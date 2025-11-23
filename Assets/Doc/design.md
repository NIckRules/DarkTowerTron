# STRIKER – PROTOTYPE VAULT
LLM-ready dump: paste this into your next prompt to continue exactly where we left off.

## PROJECT SCOPE
- **Phase**: Combat-engine proof-of-concept (8–12 h build)
- **Goal**: Prove stagger-to-heal loop has 3 distinct fights; **NO art pass, NO meta, NO polish until Triangle cleared 3×**
- **Engine**: Unity 2022.3 LTS, Built-in or URP, Legacy Input Manager, Physics 100 Hz, Ortho camera size 5

## CORE LOOP IN ONE SENTENCE
“Instant spear-thrust staggers → stagger-kill heals Grit → spend Focus on Blitz dash/parry → overheat AoE gamble → hesitate and die.”

## MECHANICS DICTIONARY
| Term | Value | Notes |
|---|---|---|
|Grit|0–2 pips, white|Lost on hit; heal only by killing STAGGERED enemy|
|Wound|0–1 skull, red|Gained when last Grit lost; unhealable; 0 Grit + 1 Wound + hit = DEATH|
|Focus|0–100, decays ‑5/s|Gain: +20 full-Grit-heal, +30 perfect dodge, +10 stagger-kill; 100 = forced Overheat AoE|
|Blitz|50 Focus, 3 u teleport, 0.2 s invuln, leaves 1 s decoy after-image|Only defensive tool|
|Stagger|Enemy meter 0–1; +0.4 per player hit; decays ‑2/s after 0.5 s idle|Full = 1.5 s stun; next hit kills & heals Grit|
|Attack|Raycast 2 u, 0.3 s CD, instant cyan phantom 0.1 s|NO slash, NO travel time|
|Spear Projectile|Prefab reserved for specials (speed 20 u/s, pierce vars)|Basic attack uses raycast, **not** this prefab yet|

## ENEMY TRIANGLE (Waves 1–5, scripted)
|Type|Life (stagger hits)|Pattern|Telegraph|Skill Check|
|---|---|---|---|---|
|Pebble|1|1 bullet / 2 s|0.5 s scale+yellow|Prioritise|
|Sniper|3|1 fast bullet / 4 s, predicts|1 s + laser line|Parry or Blitz|
|Gatling|2|3 bullets/s × 1.5 s burst|0.3 s spin-up, locked cone|Sideways Blitz|
Wave spawns: 3-pebble → 1S+2P → 1G+1P → 1S+1G → 2S+1G

## PROJECTILE STANDARD
- **All bullets parryable** via Blitz invuln layer
- **Layers**: Projectile ignores Projectile; collides only Player
- **Speeds**: Pebble 8, Sniper 25, Gatling 10 u/s
- **Collider**: Sphere 0.2, trigger, kinematic Rigidbody

## ARENA
- 3 spawn points 4 u from center, 120°
- **No RNG**, no pickups, no walls/obstacles yet

## METRICS (console log on death)
DEATH | Wave:X | T:XX.Xs | Focus:XX | Grit:X | Wound:X | FDE:X.XX | SWR:XX %

Targets: TTFD 45–90 s, FDE > 1.5, SWR 20–40 %

## TECHNICAL CONSTANTS
- **Fixed Timestep 0.01** (100 Hz physics)
- **Spawn offset 0.3 u** in front of player (prevents self-hit)
- **Enemy cube collider**: Box 1×1×1, no scaling mismatch
- **Spear phantom**: Capsule 0.1 r, 0.5 h, 0.1 s lifetime, no physics
- **Layer Matrix**: Player, Enemy, Projectile (Projectile ↔ Projectile OFF)

## CURRENT LIMITATIONS / TODO AFTER TRIANGLE
- Art: cubes + unlit colours only
- No VFX, no screen shake, no SFX mixing
- No melee enemies, no unparryable bullets, no upgrades
- No object pooling (Instantiate/Destroy OK for <5 spears)
- No menu, no pause, no save

## VICTORY CONDITION
Beat Wave 5 three times in a row → engine deemed deep → unlock polish pass.

## FILES / SCRIPTS EXISTING
PlayerMovement.cs, PlayerAttack.cs, GritAndFocus.cs, Blitz.cs, EnemyStagger.cs, EnemyHealth.cs, Projectile.cs, SpearProjectile.cs (prefab ready), WaveManager.cs (manual spawns)

## NEXT STEP WORD COUNT
Add one new enemy or one environmental twist (wall, hole, moving platform) **only after** Triangle is trivial.  
**Do not texture a single cube until then.**