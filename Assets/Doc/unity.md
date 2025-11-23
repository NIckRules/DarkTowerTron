# STRIKER – UNITY OBJECT BIBLE
Copy-paste checklist for Hierarchy + Project window.  
Colours are HEX (Gamma) – tint unlit materials 2× for HDR glow.

---

## PREFABS (Assets/Prefabs/)

### 1 Player
- GameObject ➜ rename **"Player"**  
- Tag **Player**  
- Layer **Player**  
- Transform **0, 0, 0**  
- Components  
  - Rigidbody – Kinematic, useGravity OFF, constraints ALL  
  - CapsuleCollider – center (0, 0, 0), radius 0.5, height 2, **NOT trigger**  
  - MeshFilter – Capsule primitive  
  - MeshRenderer – material **Mat_Player**  
  - Scripts  
    - PlayerMovement.cs  
    - PlayerAttack.cs  
    - GritAndFocus.cs  
    - Blitz.cs  

### 2 SpearProjectile (for specials only – basic attack uses raycast)
- GameObject ➜ **"SpearProjectile"**  
- Tag **Untagged**  
- Layer **Projectile**  
- Transform **0, 0, 0**  
- Components  
  - Rigidbody – mass 1, drag 0, useGravity OFF, collisionDetection **Discrete**, constraints ALL  
  - CapsuleCollider – center (0, 0, 0), radius 0.1, height 0.5, **IS trigger**, direction Z  
  - MeshFilter – Capsule primitive  
  - MeshRenderer – material **Mat_Spear**  
  - TrailRenderer – material **Mat_Trail**, time 0.05, width curve 0.1→0, color cyan→transparent  
  - Script **SpearProjectile.cs**  
- Save as prefab – drag into **Assets/Prefabs/**

### 3 Enemy_Pebble
- GameObject ➜ **"Enemy_Pebble"**  
- Tag **Enemy**  
- Layer **Enemy**  
- Transform **0, 0, 0**  
- Components  
  - Rigidbody – Kinematic, useGravity OFF  
  - BoxCollider – center (0, 0, 0), size (1, 1, 1), **NOT trigger**  
  - MeshFilter – Cube primitive  
  - MeshRenderer – material **Mat_Enemy**  
  - Scripts  
    - EnemyStagger.cs  
    - EnemyHealth.cs  
    - PebbleAttack.cs  
- Save prefab

### 4 Enemy_Sniper
- Same as Pebble, replace attack script with **SniperAttack.cs**  
- Add **LineRenderer** child (see below)

### 5 Enemy_Gatling
- Same as Pebble, replace attack script with **GatlingAttack.cs**

### 6 Projectile
- GameObject ➜ **"Projectile"**  
- Tag **Untagged**  
- Layer **Projectile**  
- Components  
  - SphereCollider – radius 0.2, **IS trigger**  
  - Rigidbody – useGravity OFF, constraints ALL  
  - MeshFilter – Sphere primitive  
  - MeshRenderer – material **Mat_Projectile**  
  - Script **Projectile.cs**  
- Save prefab

### 7 AfterImage
- Empty GameObject ➜ **"AfterImage"**  
- Components  
  - CapsuleCollider – same size as player, **IS trigger**, Layer **AfterImage**  
  - MeshFilter – Capsule  
  - MeshRenderer – material **Mat_AfterImage**  
  - Script **AfterImage.cs**  
- Save prefab

### 8 EnergyPickup
- Sphere 0.3 scale  
- SphereCollider trigger, Layer **Pickup**  
- MeshRenderer **Mat_Pickup**  
- Script **EnergyPickup.cs**  
- Save prefab

---

## MATERIALS (Assets/Materials/) – Unlit/Color unless noted

| Name | Hex (Gamma) | HDR Intensity | Use |
|---|---|---|---|
|Mat_Player|#FFFFFF|1|Player capsule|
|Mat_Spear|#00FFFF|2|Projectile spear glow|
|Mat_Trail|#00FFFF|1.5|TrailRenderer tint|
|Mat_Enemy|#FF0000|1|Enemy cubes|
|Mat_Projectile|#FFFF00|1|Bullets|
|Mat_AfterImage|#FFFFFF|0.5|Transparent, fades alpha|
|Mat_Pickup|#00FFFF|2|Energy orb|

**Create**: Right-click &gt; Material &gt; Unlit/Color &gt; paste Hex, enable HDR checkbox, set Intensity in Color picker.

---

## LAYERS & MATRIX
ProjectSettings → Tags & Layers  
0 Default  
8 Player  
9 Enemy  
10 Projectile  
11 AfterImage  
12 Pickup  

**Collision matrix** (only checked pairs):  
- Projectile → Enemy  
- Projectile → Player  
- AfterImage → Projectile  

**Ignore**: Projectile ↔ Projectile, Enemy ↔ Player (no body-block).

---

## SCENE HIERARCHY (SampleBattle)

### Main Camera
- Transform (0, 10, 0) Rot (90, 0, 0)  
- Camera – Orthographic, Size 5, Clear Solid Color #000000  
- AudioListener (default)

### Directional Light
- Rot (50, -30, 0) Intensity 1, Color #FFFFFF

### Floor (optional visual reference)
- Quad 20×20, Y = -1, Mat_Black, Layer Default

### EventSystem
- Unity built-in

### WaveManager
- Empty GameObject  
- Script **WaveManager.cs**  
- Drag enemy prefabs into array slots

### Player (instance of prefab)
- Position (0, 0, 0)

### Enemies
- Instantiate via WaveManager at runtime (use empty child objects as spawn markers: Spawn_0, Spawn_120, Spawn_240, 4 u from origin).

---

## INPUT MANAGER AXES (Old system)
Edit → Project Settings → Input Manager  
- Horizontal (WASD) – already present  
- Vertical (WASD) – already present  
- Fire1 – Mouse0 (left click)  
- Fire2 – Mouse1 (right click) – reserved for future heavy attack  
- Jump – Space – **currently Blitz trigger**

---

## PHYSICS SETTINGS
- Fixed Timestep 0.01 (100 Hz)  
- Default Solver Iterations 6 (default)  
- Gravity (0, -9.81, 0) – unused (all kinematic)

---

## AUDIO (PLACEHOLDER)
Create **Audio** folder.  
Import 3 free clips:
- spearSpawn.wav – 0.1 s *shink*
- spearHit.wav – 0.05 s *thwip*
- overheatBoom.wav – 0.3 s bass drop  
Drag into respective script public fields.

---

## QUICK CHECKLIST (copy → tick)
- [ ] All prefabs saved in **Assets/Prefabs/**
- [ ] All materials created & assigned
- [ ] Layers created and matrix set
- [ ] WaveManager spawn markers placed
- [ ] Player prefab dragged into scene
- [ ] Physics timestep = 0.01
- [ ] Input Manager shows Fire1 / Jump
- [ ] Audio clips in Audio folder
- [ ] Console clear on play – no pink shaders, no missing scripts

**Tick all → hit Play → Triangle test ready.**