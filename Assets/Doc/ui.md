# STRIKER – UI SETUP SHEET
One-minute checklist to stop pink-missing-references errors.

## 1. HUDCanvas
- Right-click Hierarchy → UI → Canvas  
- Rename **"HUDCanvas"**  
- Inspector  
  - Render Mode: **Screen Space – Overlay**  
  - Canvas Scaler → Reference Resolution **1920 × 1080**, Match **0.5**

## 2. Focus Bar
- Right-click HUDCanvas → UI → Slider → rename **"FocusSlider"**  
- RectTransform anchor **Top-Center**, Pos-Y **-20**  
- Width **300**, Height **30**  
- Fill Area → Fill → Image  
  - Color **#00FFFF** (cyan)  
- Un-tick **Interactable**  
- Bind: drag into **GritAndFocus.cs** field `public Slider focusSlider;`

## 3. Grit Pips
- Right-click HUDCanvas → UI → Horizontal Layout Group → rename **"GritLayout"**  
- Anchor **Top-Left**, Pos-X **20**, Pos-Y **-20**  
- Cell Size **40 × 40**, Spacing **10**  
- Inside Layout Group:  
  - UI → Image (×2) → names **GritPip0**, **GritPip1**  
  - Color **#FFFFFF** (white)  
- Bind array: drag both images into **GritAndFocus.cs** `public Image[] gritPips;`

## 4. Wound Icon
- Right-click HUDCanvas → UI → Image → rename **"WoundIcon"**  
- Anchor **Top-Left**, Pos-X **120**, Pos-Y **-20**, Size **40 × 40**  
- Color **#FF0000** (red)  
- Set **enabled = false** at start; enable when wound gained  
- Bind: drag into **GritAndFocus.cs** `public Image woundIcon;`

## 5. Death Text (optional)
- Right-click HUDCanvas → UI → Text → TextMeshPro (import TMP if asked) → rename **"DeathText"**  
- Anchor **Center**, Alignment **Center**  
- Font Size **24**, Color **#FFFFFF**  
- Bind: drag into **MetricsLogger.cs** `public TextMeshProUGUI deathText;`  
- Code fills: `deathText.text = $"Wave {wave} – {Time.time:F1}s";`

## 6. EventSystem
- Auto-created with first UI element; leave default settings.

## 7. Quick Bind Checklist
- [ ] FocusSlider assigned  
- [ ] GritPip array length 2, assigned  
- [ ] WoundIcon assigned  
- [ ] DeathText assigned (if used)  
- [ ] All UI anchors set (no stretch arrows)  
- [ ] Canvas **Screen Space – Overlay** (no camera needed)  

**Tick → run → no pink UI errors → ready for Triangle test.**