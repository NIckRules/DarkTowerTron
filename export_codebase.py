#!/usr/bin/env python
"""
Codebase Markdown Exporter
--------------------------

Drop this file into a project root, configure `code_exporter.yml`,
and run:

    python export_codebase.py

Requires:
- Python 3.10+
- PyYAML (pip install pyyaml)

Windows-only assumptions.
"""

from __future__ import annotations

import os
import re
import sys
import fnmatch
import hashlib
from pathlib import Path
from datetime import datetime
from typing import Dict, List, Iterable, Tuple

try:
    import yaml
except ImportError:
    print("ERROR: PyYAML not installed. Run: pip install pyyaml")
    sys.exit(1)

# ---------------------------------------------------------------------
# Config loading
# ---------------------------------------------------------------------

CONFIG_FILE = "code_exporter.yml"


def load_config() -> dict:
    path = Path(CONFIG_FILE)
    if not path.exists():
        print(f"ERROR: Missing {CONFIG_FILE}")
        sys.exit(1)

    with path.open("r", encoding="utf-8") as f:
        return yaml.safe_load(f)


# ---------------------------------------------------------------------
# Gitignore support (basic, deterministic)
# ---------------------------------------------------------------------

def load_gitignore(root: Path) -> List[str]:
    gi = root / ".gitignore"
    if not gi.exists():
        return []

    patterns = []
    for line in gi.read_text(encoding="utf-8", errors="ignore").splitlines():
        line = line.strip()
        if not line or line.startswith("#"):
            continue
        patterns.append(line)
    return patterns


def is_gitignored(path: Path, patterns: List[str]) -> bool:
    rel = str(path.as_posix())
    return any(fnmatch.fnmatch(rel, p) for p in patterns)


# ---------------------------------------------------------------------
# File scanning
# ---------------------------------------------------------------------

def scan_files(
    roots: List[Path],
    include_ext: set[str],
    exclude_dirs: set[str],
    exclude_files: List[str],
    gitignore: List[str],
) -> List[Path]:
    files: List[Path] = []

    for root in roots:
        if not root.exists():
            continue

        for dirpath, dirnames, filenames in os.walk(root):
            dirnames[:] = [
                d for d in dirnames
                if d not in exclude_dirs
            ]

            for name in filenames:
                p = Path(dirpath) / name

                if p.suffix not in include_ext:
                    continue

                if any(fnmatch.fnmatch(name, pat) for pat in exclude_files):
                    continue

                if gitignore and is_gitignored(p, gitignore):
                    continue

                files.append(p)

    return sorted(files, key=lambda p: str(p).lower())


# ---------------------------------------------------------------------
# Utilities
# ---------------------------------------------------------------------

def read_text_safe(path: Path) -> str:
    try:
        return path.read_text(encoding="utf-8", errors="ignore")
    except Exception:
        return ""


def estimate_tokens(text: str) -> int:
    # Conservative heuristic: ~4 chars per token
    return max(1, len(text) // 4)


def redact(text: str, patterns: List[str]) -> Tuple[str, List[str]]:
    redacted = text
    hits = []

    for pat in patterns:
        regex = re.compile(pat)
        if regex.search(redacted):
            hits.append(pat)
            redacted = regex.sub("[REDACTED]", redacted)

    return redacted, hits


def language_for(path: Path, mapping: Dict[str, str]) -> str:
    # support double suffix like .blade.php
    for ext, lang in mapping.items():
        if str(path).endswith(ext):
            return lang
    return path.suffix.lstrip(".")


# ---------------------------------------------------------------------
# Markdown rendering
# ---------------------------------------------------------------------

def render_tree(files: List[Path], root: Path) -> str:
    tree = {}
    for f in files:
        parts = f.relative_to(root).parts
        node = tree
        for part in parts:
            node = node.setdefault(part, {})

    def walk(node, prefix=""):
        lines = []
        for k in sorted(node):
            lines.append(prefix + k)
            lines.extend(walk(node[k], prefix + "  "))
        return lines

    return "\n".join(walk(tree))


# ---------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------

def main():
    cfg = load_config()

    profile_name = cfg["profile"]
    profile = cfg["profiles"][profile_name]

    root_dir = Path.cwd()

    roots = [root_dir / p for p in profile["roots"]]
    include_ext = set(profile["include_extensions"])
    exclude_dirs = set(profile.get("exclude_dirs", []))
    exclude_files = profile.get("exclude_files", [])

    languages = profile.get("languages", {})
    redact_patterns = cfg.get("security", {}).get("redact_patterns", [])

    output_cfg = cfg["output"]
    out_dir = root_dir / output_cfg["directory"]
    out_dir.mkdir(parents=True, exist_ok=True)
    out_file = out_dir / output_cfg["filename"]

    gitignore = []
    if cfg.get("git", {}).get("respect_gitignore", False):
        gitignore = load_gitignore(root_dir)

    files = scan_files(
        roots,
        include_ext,
        exclude_dirs,
        exclude_files,
        gitignore,
    )

    total_lines = 0
    total_tokens = 0
    redaction_log = []

    md: List[str] = []

    # -----------------------------------------------------------------
    # Header
    # -----------------------------------------------------------------

    md.append("# 📦 Codebase Export")
    md.append(f"- **Profile:** `{profile_name}`")
    md.append(f"- **Generated:** {datetime.now():%Y-%m-%d %H:%M}")
    md.append(f"- **Files:** {len(files)}")
    md.append("")

    # -----------------------------------------------------------------
    # Tree
    # -----------------------------------------------------------------

    if cfg["markdown"].get("include_tree", True):
        md.append("## 📁 Project Tree")
        md.append("```")
        md.append(render_tree(files, root_dir))
        md.append("```")
        md.append("")

    # -----------------------------------------------------------------
    # Files
    # -----------------------------------------------------------------

    for f in files:
        rel = f.relative_to(root_dir)
        content = read_text_safe(f)
        size_kb = f.stat().st_size / 1024
        lines = content.count("\n") + 1

        total_lines += lines

        if cfg["llm"].get("estimate_tokens", False):
            total_tokens += estimate_tokens(content)

        content, hits = redact(content, redact_patterns)
        if hits:
            redaction_log.append(str(rel))

        md.append(f"## 📄 `{rel}`")
        md.append(f"- Lines: {lines}")
        md.append(f"- Size: {size_kb:.1f} KB")
        md.append(f"- Modified: {datetime.fromtimestamp(f.stat().st_mtime):%Y-%m-%d %H:%M}")
        md.append("")

        lang = language_for(f, languages)
        md.append(f"```{lang}")
        md.append(content.rstrip())
        md.append("```")
        md.append("")

    # -----------------------------------------------------------------
    # Summary
    # -----------------------------------------------------------------

    md.insert(4, f"- **Total LOC:** {total_lines}")
    if total_tokens:
        md.insert(5, f"- **Estimated tokens:** {total_tokens}")

    # -----------------------------------------------------------------
    # Redaction log
    # -----------------------------------------------------------------

    if redaction_log:
        md.append("## 🔐 Redacted Files")
        for r in sorted(set(redaction_log)):
            md.append(f"- {r}")
        md.append("")

    out_file.write_text("\n".join(md), encoding="utf-8")
    print(f"✔ Export written to {out_file}")


if __name__ == "__main__":
    main()
