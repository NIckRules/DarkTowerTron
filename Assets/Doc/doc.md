# STRIKER – COMPLETE PROTOTYPE BLUEPRINT v0.3
LLM-ready implementation spec for Unity 2022.3 LTS. Copy-paste into `.md` file adjacent to Scripts folder.

---

## 1. FANTASY & CORE LOOP

**Fantasy**: *You are a glass cannon with a chest-mounted spear-beam. Aggression is your only defence—dancing through bullets weaponises them, staggered enemies heal you, and hesitation drains your power.*

**Loop**:  
1. **Move** (6 u/s, accel 30) → **Auto-aim beam** (2u range, 0.3s CD) snaps to nearest enemy (45° cone).  
2. **Stagger** (meter 0-1, decays -4/s) → **pushback 2u** on full, **kill = heal Grit** (+1 pip, +25 Focus).  
3. **Blitz** (40 Focus, 0.2s invuln) → **teleport 3u**, **redirect bullets** (cyan homing, +30 Focus), **leaves decoy**.  
4. **Focus** (0-100, decays -5/s, burn @ >80) → powers Blitz, overheat @ 100 (AoE stagger, drop to 1 Grit).  
5. **Grit/Wound**: 2 white pips, 1 red skull (permanent). 0 Grit + hit = death.

---

## 2. PLAYER PREFAB (Assets/Prefabs/Player.prefab)

### GameObject Hierarchy

Player (root)
├── Capsule (mesh)
├── BeamPivot (empty)
│   ├── LineRenderer (beam)
│   └── ChargeParticles (ParticleSystem)
└── SnapIndicator (WorldSpace Canvas)
└── Image (cyan triangle)


### Root Components
| Component | Settings | Scripts |
|---|---|---|
| **Tag** | `Player` | `PlayerMovement.cs` |
| **Layer** | `Player` | `PlayerAttack.cs` |
| Rigidbody | Kinematic, useGravity OFF | `GritAndFocus.cs` |
| CapsuleCollider | radius 0.5, height 2, NOT trigger | `Blitz.cs` |
| MeshRenderer | material `Mat_Player` | `PlayerShimmer.cs` (optional) |

### Inspector Field Assignments
**PlayerAttack.cs**:
- `beamPivot`: assign BeamPivot child
- `beamLine`: assign LineRenderer
- `chargeParticles`: assign ParticleSystem
- `snapIndicator`: assign SnapIndicator Canvas
- `hitConfirmClip`: assign Audio/hitConfirm.wav

**GritAndFocus.cs**:
- `focusSlider`: assign HUD/FocusSlider
- `gritPips`: assign array [GritPip0, GritPip1]
- `woundIcon`: assign HUD/WoundIcon

**Blitz.cs**:
- `blitzGhostPrefab`: assign Prefabs/BlitzGhost (transparent cyan sphere)
- `projectileLayer`: assign LayerMask (Projectile layer)

---

## 3. ENEMY PREFABS (Assets/Prefabs/)

### 3.1 Pebble
| Component | Settings |
|---|---|
| Tag | `Enemy` |
| Layer | `Enemy` |
| Rigidbody | Kinematic |
| BoxCollider | size 1×1×1, NOT trigger |
| MeshRenderer | material `Mat_Enemy` |
| Scripts | `EnemyStagger.cs`, `PebbleAttack.cs` |

**PebbleAttack.cs** Inspector:
- `fireInterval`: 2.0
- `projectilePrefab`: assign Projectile
- `telegraphDuration`: 0.35

### 3.2 Sniper
Same as Pebble, script **SniperAttack.cs**:
- `fireInterval`: 4.0
- `projectileSpeed`: 25
- `telegraphDuration`: 0.75
- `laserLine`: assign child LineRenderer (red, 0.05 width)

### 3.3 Gatling
Same as Pebble, script **GatlingAttack.cs**:
- `burstCount`: 2
- `burstGap`: 0.3
- `fireInterval`: 2.5
- `staggerDecayMod`: 0.5

### 3.4 Drifter
Same as Pebble, script **DrifterEnemy.cs**:
- `orbitSpeed`: 4
- `orbitRadius`: 4 (±1 random on spawn)
- `fireInterval`: 2.5
- `burstCount`: 2

---

## 4. PROJECTILE PREFAB (Assets/Prefabs/Projectile.prefab)

| Component | Settings |
|---|---|
| Tag | `Untagged` |
| Layer | `Projectile` |
| SphereCollider | radius 0.2, IS trigger |
| Rigidbody | useGravity OFF, constraints ALL |
| MeshRenderer | material `Mat_Projectile` |
| Script | `Projectile.cs` |

**Projectile.cs** Inspector:
- `speed`: 8 (Pebble), 25 (Sniper), 10 (Gatling)
- `redirectMaterial`: assign `Mat_ProjectileRedirected` (cyan)
- `redirectPingClip`: assign Audio/redirectPing.wav

---

## 5. UI CANVAS (HUDCanvas.prefab)

### Hierarchy

HUDCanvas
├── FocusSlider (Slider)
├── GritLayout (HorizontalLayoutGroup)
│   ├── GritPip0 (Image)
│   └── GritPip1 (Image)
├── WoundIcon (Image)
└── DeathText (TextMeshProUGUI)


### Canvas Settings
- Render Mode: **Screen Space – Overlay**
- Reference Resolution: **1920 × 1080**, Match **0.5**

### Component Assignments
- **FocusSlider**: Anchor Top-Center, width 300, height 30, non-interactable
- **GritLayout**: Anchor Top-Left, spacing 10, cell size 40×40
- **WoundIcon**: Anchor Top-Left, pos (120, -20, 0), red, disabled by default
- **DeathText**: Anchor Center, font size 24, white

---

## 6. MATERIALS (Assets/Materials/)

| Name | Shader | Color (Gamma) | HDR Intensity | Use |
|---|---|---|---|---|
| `Mat_Player` | Unlit/Color | #FFFFFF | 1 | Player capsule |
| `Mat_Beam` | Unlit/Color | #00FFFF | 2 | LineRenderer beam |
| `Mat_Enemy` | Unlit/Color | #FF0000 | 1 | Enemy cubes |
| `Mat_Projectile` | Unlit/Color | #FFFF00 | 1 | Bullets |
| `Mat_ProjectileRedirected` | Unlit/Color | #00FFFF | 2 | Redirected bullets |
| `Mat_AfterImage` | Unlit/Color (Transparent) | #FFFFFF | 0.5 | Blitz decoy (alpha fade) |
| `Mat_Well` | Standard (Transparent) | #000000 | 0.3 | Arena hazard (cylinder trigger) |

**Create**: Right-click > Material > Unlit/Color > paste Hex, enable HDR.

---

## 7. LAYERS & PHYSICS

### Layers (Edit → Project Settings → Tags & Layers)
0 Default  
8 Player  
9 Enemy  
10 Projectile  
11 AfterImage  
12 Pickup  

### Collision Matrix (only TRUE pairs)
- Projectile ↔ Enemy  
- Projectile ↔ Player  
- AfterImage ↔ Projectile  

### Physics Settings
- **Fixed Timestep**: 0.01 (100 Hz)  
- **Gravity**: (0, -9.81, 0) (unused)  
- **Solver Iterations**: 6 (default)

---

## 8. WAVE MANAGER (Assets/Scripts/WaveManager.cs)

### Inspector Fields
```csharp
public Transform[] spawnMarkers; // length 3, positions at 0°, 120°, 240°, radius 4
public GameObject[] enemyPrefabs; // assign [Pebble, Sniper, Gatling, Drifter]
public GritAndFocus playerGritAndFocus; // assign Player in scene

void StartWave(int id) {
    switch(id) {
        case 1: Spawn(0, 3); break; // 3 Pebbles
        case 2: Spawn(1, 1); Spawn(0, 2); break; // 1 Sniper + 2 Pebbles
        case 3: Spawn(2, 1); Spawn(0, 1); Spawn(3, 1); break; // Gatling + Pebble + Drifter
        case 4: Spawn(1, 1); Spawn(2, 1); Spawn(3, 1); break; // Sniper + Gatling + Drifter
        case 5: Spawn(1, 2); Spawn(2, 1); Spawn(3, 1); break; // 2 Snipers + Gatling + Drifter
        // Waves 6-10: copy pattern, add Well hazard, increase density
    }
    // Focus floor
    if (playerGritAndFocus != null) {
        playerGritAndFocus.focus = Mathf.Max(playerGritAndFocus.focus, 30);
        playerGritAndFocus.UpdateUI();
    }
}

void Spawn(int prefabIndex, int count) {
    for (int i = 0; i < count; i++) {
        Transform marker = spawnMarkers[Random.Range(0, 3)];
        Instantiate(enemyPrefabs[prefabIndex], marker.position, Quaternion.identity);
    }
}

9. METRICS LOGGER (Assets/Scripts/MetricsLogger.cs)
Console Output

Debug.Log($"DEATH | Wave:{wave} | T:{Time.timeSinceLevelLoad:F1}s | Focus:{focus:F0} | Grit:{grit} | Wound:{wound} | FDE:{fde:F2} | SWR:{swr:P0} | Cause:{deathCause}");


CSV Export (optional)

void OnApplicationQuit() {
    string path = Application.persistentDataPath + "/striker_autopsy.csv";
    File.AppendAllText(path, $"{wave},{ttfd},{fde},{swr},{deathCause},{focus},{grit},{wound},{restartTime}\n");
}

10. VALIDATION CHECKLIST (Play 3×)
Pre-Playtest (5 min)
[ ] All prefabs saved, no missing scripts (no pink)
[ ] Layers Matrix set (Projectile ↔ Projectile = OFF)
[ ] Physics Timestep = 0.01
[ ] Audio clips assigned (hitConfirm, staggerPop, redirectPing)
[ ] Materials created & HDR enabled
[ ] WaveManager spawn markers placed (3 empties, 4u radius)
[ ] Player prefab in scene, all fields assigned
In-Game (30 min)
[ ] Wave 1: Tap LMB → beam snaps to Pebble, 0.4u thrust, cyan flash, Focus +5
[ ] Wave 2: Hold Space → Blitz ghost appears, release → teleport 3u, redirect Sniper bullet → cyan homing → +30 Focus
[ ] Wave 3: Gatling staggered → pushback 2u → chase → kill → heal Grit, Fade effect on decoy
[ ] Wave 4: Drifter orbits → beam auto-aims → SnapIndicator shows target → hit/miss feedback
[ ] Wave 5: 100 Focus → overheat shockwave (white sphere scale 0→10) → drops to 1 Grit
Post-Death Metrics (5 min)
[ ] TTFD 45–90s?
[ ] FDE > 1.5?
[ ] SWR 20–40%?
[ ] DeathCause logged (OutOfFocus/StaggerDecay/PushedIntoWell/RedirectMiss)?
[ ] Restart time <5s?
All green → prototype locked → proceed to Phase 1 (10-wave Triangle).