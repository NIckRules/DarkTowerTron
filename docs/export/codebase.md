# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2025-12-24 17:22
- **Files:** 140
- **Total LOC:** 31235
- **Estimated tokens:** 219007

## 📁 Project Tree
```
Assets
  Data
    AttackPatterns
      Nova.asset
      Shotgun.asset
      Sweep.asset
    Behaviours
      Beh_Avoidance.asset
      Beh_Flee.asset
      Beh_Orbit_CCW.asset
      Beh_Orbit_CW.asset
      Beh_Seek.asset
    Enemies
      Stats_Chaser.asset
      Stats_Guardian.asset
      Stats_Sentinel.asset
      Stats_Sniper.asset
    Player
      Stats_Player_Default.asset
    Visuals
      Collections
        Collection_Enemies.asset
        Collection_Enemies_Core.asset
        Collection_Enemies_Secondary.asset
        Collection_Floors.asset
        Collection_Hazards.asset
        Collection_Player.asset
        Collection_Player_Core.asset
        Collection_Player_Seconday.asset
        Collection_Projectiles_Friendly.asset
        Collection_Projectiles_Hostile.asset
        Collection_Walls.asset
      Palettes
        PAL_Alt.asset
        PAL_Neon.asset
        PAL_Nier.asset
      Themes
        Theme_Enemy_Default.asset
        Theme_Guardian.asset
        Theme_Player_Default.asset
    Waves
      WAV_TEST_Sentinel.asset
  Prefabs
    Combat
      ENEMY_Projectile.prefab
      ENEMY_ProjectileHighCaliber.prefab
      PLAYER_Projectile.prefab
      PLAYER_Projectile_Homing.prefab
    Enemies
      ENE_Chaser_Millise.prefab
      ENE_Chaser_Mine.prefab
      ENE_Guardian.prefab
      ENE_Sentinel.prefab
      ENE_Sniper.prefab
    Environment
      Barrel.prefab
      ENV_ArenaGate.prefab
    Paths
      PatrolPath_Arena.prefab
    Player
      AFTER_IMAGE.prefab
      AFTER_IMAGE_EXPOSIVE.prefab
      BEAM_ROOT.prefab
      [PLAYER_STRIKER].prefab
    Scene
      [POST PROCESING].prefab
      [SCENE].prefab
    Systems
      MANAGERS.prefab
      [DEBUG].prefab
      [SYSTEM].prefab
    Trasversal
      Anchor.prefab
      [VOID].prefab
    UI
      PF_FloatingText.prefab
      UI_HUD.prefab
    VFX
      VFX_Explosion.prefab
      VFX_Hazard_BarrelExplosion.prefab
      VFX_Hazard_Mine.prefab
      VFX_Spawn.prefab
  Scripts
    Combat
      HazardZone.cs
      HitboxRelay.cs
      HomingMissile.cs
      Projectile.cs
    Core
      CameraRig.cs
      CircleRenderer.cs
      Data
        ActorThemeSO.cs
        AttackPatternSO.cs
        ColorPaletteSO.cs
        EnemyStatsSO.cs
        MaterialCollectionSO.cs
        PlayerStatsSO.cs
        WaveDefinitionSO.cs
      GameConstants.cs
      GameEvents.cs
      GameTime.cs
      Interfaces
        ICombatTarget.cs
        IDamageable.cs
        IPoolable.cs
        IReflectable.cs
        IWeapon.cs
      Spinner.cs
      Structs
        DamageInfo.cs
      VoidKiller.cs
    Enemy
      Agents
        EnemyAgent_Chaser.cs
        EnemyAgent_Guardian.cs
        EnemyAgent_Sentinel.cs
        EnemyAgent_Sniper.cs
      BossController.cs
      EnemyBaseAI.cs
      EnemyController.cs
      EnemyMotors.cs
      PatrolPath.cs
      States
        Chaser
          ChaserState_Chase.cs
          ChaserState_Primer.cs
        Guardian
          GuardianState_Attack.cs
          GuardianState_Move.cs
        Sentinel
          SentinelState_Combat.cs
          SentinelState_Hunt.cs
        Sniper
          SniperState_Aiming.cs
          SniperState_Firing.cs
          SniperState_Positioning.cs
          SniperState_Teleport.cs
    Environment
      ArenaGate.cs
      CameraZone.cs
      DamageableProp.cs
      WaveTrigger.cs
    Managers
      ArenaSpawner.cs
      AudioManager.cs
      DamageTextManager.cs
      DebugController.cs
      FeedbackDirector.cs
      GameFeel.cs
      GameSession.cs
      HUDManager.cs
      MusicManager.cs
      PaletteManager.cs
      PoolManager.cs
      ScoreManager.cs
      VFXManager.cs
      WaveDirector.cs
    Physics
      KinematicMover.cs
    Player
      AfterImage.cs
      PlayerAttack.cs
      PlayerController.cs
      PlayerDodge.cs
      PlayerEnergy.cs
      PlayerExecution.cs
      PlayerGun.cs
      PlayerHealth.cs
      PlayerLoadout.cs
      PlayerMovement.cs
      PlayerStats.cs
      TargetScanner.cs
      WeaponBase.cs
    UI
      CountdownUI.cs
      FloatingText.cs
      ResultScreen.cs
    Visuals
      CameraShaker.cs
      PaletteReceiver.cs
```

## 📄 `Assets\Data\AttackPatterns\Nova.asset`
- Lines: 22
- Size: 0.5 KB
- Modified: 2025-12-14 12:21

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b1e0fd8f44142d2469388ca2d00fa279, type: 3}
  m_Name: Nova
  m_EditorClassIdentifier: 
  projectileCount: 20
  spreadAngle: 360
  spinDuringFire: 0
  spinSpeed: 0
  delayBetweenShots: 0
  startDelay: 0.5
  speed: 15
```

## 📄 `Assets\Data\AttackPatterns\Shotgun.asset`
- Lines: 22
- Size: 0.5 KB
- Modified: 2025-12-14 12:44

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b1e0fd8f44142d2469388ca2d00fa279, type: 3}
  m_Name: Shotgun
  m_EditorClassIdentifier: 
  projectileCount: 5
  spreadAngle: 45
  spinDuringFire: 0
  spinSpeed: 0
  delayBetweenShots: 0
  startDelay: 0.5
  speed: 15
```

## 📄 `Assets\Data\AttackPatterns\Sweep.asset`
- Lines: 22
- Size: 0.5 KB
- Modified: 2025-12-14 12:21

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b1e0fd8f44142d2469388ca2d00fa279, type: 3}
  m_Name: Sweep
  m_EditorClassIdentifier: 
  projectileCount: 10
  spreadAngle: 60
  spinDuringFire: 0
  spinSpeed: 0
  delayBetweenShots: 0.1
  startDelay: 0.5
  speed: 15
```

## 📄 `Assets\Data\Behaviours\Beh_Avoidance.asset`
- Lines: 17
- Size: 0.4 KB
- Modified: 2025-12-11 08:03

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ae8d177c719a3c842acb623e4f890876, type: 3}
  m_Name: Beh_Avoidance
  m_EditorClassIdentifier: 
  avoidanceRadius: 2
  dangerWeight: 1
```

## 📄 `Assets\Data\Behaviours\Beh_Flee.asset`
- Lines: 16
- Size: 0.4 KB
- Modified: 2025-12-14 09:35

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 35163712aebec7645b7646b7794f86df, type: 3}
  m_Name: Beh_Flee
  m_EditorClassIdentifier: 
  fleeDistance: 10
```

## 📄 `Assets\Data\Behaviours\Beh_Orbit_CCW.asset`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-13 12:25

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5c3958e979e8ba7438bbb58ca6123f36, type: 3}
  m_Name: Beh_Orbit_CCW
  m_EditorClassIdentifier: 
  idealDistance: 7
  distanceCorrectionStrength: 0.5
  clockwise: 0
```

## 📄 `Assets\Data\Behaviours\Beh_Orbit_CW.asset`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-13 12:21

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5c3958e979e8ba7438bbb58ca6123f36, type: 3}
  m_Name: Beh_Orbit_CW
  m_EditorClassIdentifier: 
  idealDistance: 7
  distanceCorrectionStrength: 0.5
  clockwise: 1
```

## 📄 `Assets\Data\Behaviours\Beh_Seek.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2025-12-11 08:03

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 75094ea619450b6408bcf452dd613775, type: 3}
  m_Name: Beh_Seek
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Enemies\Stats_Chaser.asset`
- Lines: 31
- Size: 0.7 KB
- Modified: 2025-12-13 18:36

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 65f63d17ef75d5f45b55d0652fde43f2, type: 3}
  m_Name: Stats_Chaser
  m_EditorClassIdentifier: 
  isEssential: 0
  scoreValue: 100
  focusReward: 30
  healsGrit: 0
  gritRewardAmount: 1
  moveSpeed: 9
  rotationSpeed: 15
  acceleration: 20
  rideHeight: 0.5
  verticalSmoothTime: 0.5
  separationRadius: 1.5
  separationForce: 8
  maxStagger: 0.5
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Stats_Guardian.asset`
- Lines: 32
- Size: 0.7 KB
- Modified: 2025-12-14 12:21

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 65f63d17ef75d5f45b55d0652fde43f2, type: 3}
  m_Name: Stats_Guardian
  m_EditorClassIdentifier: 
  isEssential: 1
  scoreValue: 100
  focusReward: 30
  healsGrit: 1
  gritRewardAmount: 1
  moveSpeed: 5
  rotationSpeed: 25
  combatRotationSpeed: 3
  acceleration: 60
  rideHeight: 1
  verticalSmoothTime: 0.5
  separationRadius: 1.5
  separationForce: 8
  maxStagger: 1
  staggerDecay: 0.5
  hasFrontalShield: 1
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Stats_Sentinel.asset`
- Lines: 31
- Size: 0.7 KB
- Modified: 2025-12-14 10:31

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 65f63d17ef75d5f45b55d0652fde43f2, type: 3}
  m_Name: Stats_Sentinel
  m_EditorClassIdentifier: 
  isEssential: 0
  scoreValue: 100
  focusReward: 30
  healsGrit: 1
  gritRewardAmount: 1
  moveSpeed: 7
  rotationSpeed: 15
  acceleration: 20
  rideHeight: 1.5
  verticalSmoothTime: 0.5
  separationRadius: 2
  separationForce: 5
  maxStagger: 0.8
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Stats_Sniper.asset`
- Lines: 31
- Size: 0.7 KB
- Modified: 2025-12-14 09:19

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 65f63d17ef75d5f45b55d0652fde43f2, type: 3}
  m_Name: Stats_Sniper
  m_EditorClassIdentifier: 
  isEssential: 1
  scoreValue: 100
  focusReward: 30
  healsGrit: 1
  gritRewardAmount: 1
  moveSpeed: 4
  rotationSpeed: 10
  acceleration: 20
  rideHeight: 1
  verticalSmoothTime: 0.5
  separationRadius: 1.5
  separationForce: 8
  maxStagger: 1
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Player\Stats_Player_Default.asset`
- Lines: 27
- Size: 0.6 KB
- Modified: 2025-12-24 08:51

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5281bbdeb5c2df54fbe42cc421deb8fe, type: 3}
  m_Name: Stats_Player_Default
  m_EditorClassIdentifier: 
  moveSpeed: 12
  acceleration: 60
  maxGrit: 2
  maxFocus: 100
  dashCost: 25
  dashDistance: 8
  dashCooldown: 0.15
  damageMultiplier: 1
  fireRateMultiplier: 1
  overdriveThreshold: 80
  overdriveSpeedMult: 1.2
  overdriveDamageMult: 2
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Enemies.asset`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-23 20:34

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Enemies
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 114afe63580ae5f4b825c68319bbf8f5, type: 2}
  - {fileID: 2100000, guid: 0165aae9d439d484298ed4132223d775, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Enemies_Core.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:20

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Enemies_Core
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 06ebf18291359ee45a07edb03f44fad2, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Enemies_Secondary.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:20

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Enemies_Secondary
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 4c8e6116e29516b4498d328dbfceddbe, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Floors.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:22

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Floors
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 4d615c14b48fef541a82dd2fb5c349c6, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Hazards.asset`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-23 20:03

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Hazards
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 6786b08de9810d54ab2098e20884fa61, type: 2}
  - {fileID: 2100000, guid: f1caba4964998b147be969d1e17c1d94, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Player.asset`
- Lines: 19
- Size: 0.6 KB
- Modified: 2025-12-24 08:50

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Player
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 11f428ecb4a389e48b3415c41eee0938, type: 2}
  - {fileID: 2100000, guid: 45593d2fdaab0574093a72b11a94f887, type: 2}
  - {fileID: 2100000, guid: b24d715459c93c94c94a3da751904c4b, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Player_Core.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:20

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Player_Core
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 3cf496f97baa02943befc49a0e9e5731, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Player_Seconday.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:20

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Player_Seconday
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 570a0b9c262ed7744a6cdcac4fe6e9a6, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Projectiles_Friendly.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:50

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Projectiles_Friendly
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 3a04aa1b05131a14e9ff984a6458bdc6, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Projectiles_Hostile.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:22

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Projectiles_Hostile
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 77736e828f9e8074798c85575b33cf35, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Walls.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-24 08:22

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1d68db7d881f247a058cdf29aadd45, type: 3}
  m_Name: Collection_Walls
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 3a93bbcea6f88004ca8a2383bec8d1cb, type: 2}
```

## 📄 `Assets\Data\Visuals\Palettes\PAL_Alt.asset`
- Lines: 61
- Size: 1.5 KB
- Modified: 2025-12-24 08:50

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: dda5f9eb5b7e0544b859fff5673912ea, type: 3}
  m_Name: PAL_Alt
  m_EditorClassIdentifier: 
  playerPrimary:
    mainColor: {r: 0.4811321, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  playerSecondary:
    mainColor: {r: 1, g: 0.16509432, b: 0.16509432, a: 0}
    smoothness: 0
    metallic: 0
  playerTertiary:
    mainColor: {r: 0.9528302, g: 0.4809096, b: 0.4809096, a: 0}
    smoothness: 0
    metallic: 0
  enemyPrimary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  enemySecondary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  enemyTertiary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  projectileHostile:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  projectileFriendly:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  staggerColor: {r: 0.4811321, g: 0.44333738, b: 0.0068084607, a: 1}
  floor:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  walls:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  hazards:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  skyColor: {r: 0.89444643, g: 0.93871146, b: 0.9433962, a: 1}
```

## 📄 `Assets\Data\Visuals\Palettes\PAL_Neon.asset`
- Lines: 49
- Size: 1.2 KB
- Modified: 2025-12-23 22:46

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: dda5f9eb5b7e0544b859fff5673912ea, type: 3}
  m_Name: PAL_Neon
  m_EditorClassIdentifier: 
  playerPrimary:
    mainColor: {r: 0, g: 8, b: 8, a: 0}
    smoothness: 0
    metallic: 0
  playerSecondary:
    mainColor: {r: 0, g: 0.19450173, b: 3.5471697, a: 0}
    smoothness: 0
    metallic: 0
  enemyBody:
    mainColor: {r: 8, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  projectileHostile:
    mainColor: {r: 16, g: 10.792157, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  projectileFriendly:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  staggerColor: {r: 1, g: 1, b: 0, a: 0}
  floor:
    mainColor: {r: 0.09411765, g: 0, b: 0.19215687, a: 0}
    smoothness: 0
    metallic: 0
  walls:
    mainColor: {r: 1.3803922, g: 0, b: 4, a: 0}
    smoothness: 0
    metallic: 0
  hazards:
    mainColor: {r: 4, g: 0, b: 1.9921569, a: 0}
    smoothness: 0
    metallic: 0
  skyColor: {r: 0, g: 0, b: 0, a: 1}
```

## 📄 `Assets\Data\Visuals\Palettes\PAL_Nier.asset`
- Lines: 61
- Size: 1.6 KB
- Modified: 2025-12-24 08:50

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: dda5f9eb5b7e0544b859fff5673912ea, type: 3}
  m_Name: PAL_Nier
  m_EditorClassIdentifier: 
  playerPrimary:
    mainColor: {r: 0, g: 0.02924453, b: 0.6415094, a: 0}
    smoothness: 0
    metallic: 0
  playerSecondary:
    mainColor: {r: 0.9339623, g: 0.7973923, b: 0.7973923, a: 0}
    smoothness: 0
    metallic: 0
  playerTertiary:
    mainColor: {r: 0.8679245, g: 0.09416164, b: 0.09416164, a: 0}
    smoothness: 0
    metallic: 0
  enemyPrimary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  enemySecondary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  enemyTertiary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  projectileHostile:
    mainColor: {r: 1, g: 0.33965325, b: 0.0990566, a: 0}
    smoothness: 0
    metallic: 0
  projectileFriendly:
    mainColor: {r: 0, g: 0.12644672, b: 1, a: 0}
    smoothness: 0
    metallic: 0
  staggerColor: {r: 1, g: 0.8, b: 0, a: 1}
  floor:
    mainColor: {r: 0.8679245, g: 0.79013884, b: 0.79013884, a: 0}
    smoothness: 0.00029999999
    metallic: 0
  walls:
    mainColor: {r: 0.6886792, g: 0.63995194, b: 0.63995194, a: 0}
    smoothness: 0
    metallic: 0
  hazards:
    mainColor: {r: 1, g: 0.1462264, b: 0.1462264, a: 0}
    smoothness: 0
    metallic: 0
  skyColor: {r: 0.4009434, g: 1, b: 0.95789695, a: 1}
```

## 📄 `Assets\Data\Visuals\Themes\Theme_Enemy_Default.asset`
- Lines: 27
- Size: 0.7 KB
- Modified: 2025-12-24 08:13

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b6a2733c26ebf8c4eaf9d3bb2f81ce1c, type: 3}
  m_Name: Theme_Enemy_Default
  m_EditorClassIdentifier: 
  primary:
    mainColor: {r: 0.3584906, g: 0.34665364, b: 0.34665364, a: 0}
    smoothness: 0
    metallic: 0
  secondary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
  tertiary:
    mainColor: {r: 1, g: 0.3726415, b: 0.3726415, a: 0}
    smoothness: 0
    metallic: 0
```

## 📄 `Assets\Data\Visuals\Themes\Theme_Guardian.asset`
- Lines: 27
- Size: 0.7 KB
- Modified: 2025-12-24 08:13

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b6a2733c26ebf8c4eaf9d3bb2f81ce1c, type: 3}
  m_Name: Theme_Guardian
  m_EditorClassIdentifier: 
  primary:
    mainColor: {r: 0.9811321, g: 0.9811321, b: 0.9811321, a: 0}
    smoothness: 0
    metallic: 0
  secondary:
    mainColor: {r: 0.2924528, g: 0.2924528, b: 0.2924528, a: 0}
    smoothness: 0
    metallic: 0
  tertiary:
    mainColor: {r: 0.5, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
```

## 📄 `Assets\Data\Visuals\Themes\Theme_Player_Default.asset`
- Lines: 27
- Size: 0.7 KB
- Modified: 2025-12-24 08:13

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b6a2733c26ebf8c4eaf9d3bb2f81ce1c, type: 3}
  m_Name: Theme_Player_Default
  m_EditorClassIdentifier: 
  primary:
    mainColor: {r: 0.33259162, g: 0.31910825, b: 0.9528302, a: 0}
    smoothness: 0
    metallic: 0
  secondary:
    mainColor: {r: 0.013933237, g: 0, b: 0.509434, a: 0}
    smoothness: 0
    metallic: 0
  tertiary:
    mainColor: {r: 0.7264151, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
```

## 📄 `Assets\Data\Waves\WAV_TEST_Sentinel.asset`
- Lines: 26
- Size: 0.7 KB
- Modified: 2025-12-11 17:31

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: c00ec1be340b92143a5060df8ebbf3e9, type: 3}
  m_Name: WAV_TEST_Sentinel
  m_EditorClassIdentifier: 
  waveName: TEST Sentinel
  entries:
  - enemyPrefab: {fileID: 4608774935982201577, guid: eb8ac38007f42f44bbf0f720d35d9a83,
      type: 3}
    count: 1
    rate: 0
    spawnPointIndex: -1
  gruntPrefabs:
  - {fileID: 3473038045254472648, guid: 1513d0ac6f440b04981069a6ebcff7b7, type: 3}
  maxGrunts: 5
  gruntSpawnRate: 3
```

## 📄 `Assets\Prefabs\Combat\ENEMY_Projectile.prefab`
- Lines: 213
- Size: 5.7 KB
- Modified: 2025-12-13 15:18

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &337644372426971230
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6063498928142543216}
  - component: {fileID: 4853897871245773816}
  - component: {fileID: 7853976462343550844}
  - component: {fileID: 6894111335874687869}
  m_Layer: 0
  m_Name: Bullet
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6063498928142543216
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 0.5, y: 0.5, z: 0.5}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5410732386354289441}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &4853897871245773816
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7853976462343550844
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 419b632810dcd054091da8b034b8e1d5, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!135 &6894111335874687869
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!1 &4044515353307923508
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5410732386354289441}
  - component: {fileID: 1675961125911624443}
  - component: {fileID: 5943469654723181332}
  - component: {fileID: 4178352096548772990}
  m_Layer: 8
  m_Name: ENEMY_Projectile
  m_TagString: Projectile
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5410732386354289441
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6063498928142543216}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!135 &1675961125911624443
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!54 &5943469654723181332
Rigidbody:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 4
  m_Mass: 1
  m_Drag: 0
  m_AngularDrag: 0.05
  m_CenterOfMass: {x: 0, y: 0, z: 0}
  m_InertiaTensor: {x: 1, y: 1, z: 1}
  m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ImplicitCom: 1
  m_ImplicitTensor: 1
  m_UseGravity: 0
  m_IsKinematic: 1
  m_Interpolate: 0
  m_Constraints: 112
  m_CollisionDetection: 0
--- !u!114 &4178352096548772990
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0dd7805b9e1c7a741a660a6d1d5c316b, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  speed: 15
  lifetime: 5
  isHostile: 1
  damage: 1
  stagger: 0
  meshRenderer: {fileID: 7853976462343550844}
  friendlyMaterial: {fileID: 2100000, guid: cf01d22f2a790404ab04b7f9db4fdc89, type: 2}
  wallLayer:
    serializedVersion: 2
    m_Bits: 0
```

## 📄 `Assets\Prefabs\Combat\ENEMY_ProjectileHighCaliber.prefab`
- Lines: 213
- Size: 5.7 KB
- Modified: 2025-12-13 15:18

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &337644372426971230
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6063498928142543216}
  - component: {fileID: 4853897871245773816}
  - component: {fileID: 7853976462343550844}
  - component: {fileID: 6894111335874687869}
  m_Layer: 0
  m_Name: Bullet
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6063498928142543216
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5410732386354289441}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &4853897871245773816
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7853976462343550844
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 419b632810dcd054091da8b034b8e1d5, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!135 &6894111335874687869
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!1 &4044515353307923508
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5410732386354289441}
  - component: {fileID: 1675961125911624443}
  - component: {fileID: 5943469654723181332}
  - component: {fileID: 4178352096548772990}
  m_Layer: 0
  m_Name: ENEMY_ProjectileHighCaliber
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5410732386354289441
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1920, y: 1080, z: 0}
  m_LocalScale: {x: 1.2, y: 1.2, z: 1.2}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6063498928142543216}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!135 &1675961125911624443
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!54 &5943469654723181332
Rigidbody:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 4
  m_Mass: 1
  m_Drag: 0
  m_AngularDrag: 0.05
  m_CenterOfMass: {x: 0, y: 0, z: 0}
  m_InertiaTensor: {x: 1, y: 1, z: 1}
  m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ImplicitCom: 1
  m_ImplicitTensor: 1
  m_UseGravity: 0
  m_IsKinematic: 1
  m_Interpolate: 0
  m_Constraints: 112
  m_CollisionDetection: 0
--- !u!114 &4178352096548772990
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0dd7805b9e1c7a741a660a6d1d5c316b, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  speed: 15
  lifetime: 5
  isHostile: 1
  damage: 2
  stagger: 0
  meshRenderer: {fileID: 7853976462343550844}
  friendlyMaterial: {fileID: 2100000, guid: cf01d22f2a790404ab04b7f9db4fdc89, type: 2}
  wallLayer:
    serializedVersion: 2
    m_Bits: 0
```

## 📄 `Assets\Prefabs\Combat\PLAYER_Projectile.prefab`
- Lines: 214
- Size: 5.7 KB
- Modified: 2025-12-24 13:42

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &337644372426971230
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6063498928142543216}
  - component: {fileID: 4853897871245773816}
  - component: {fileID: 7853976462343550844}
  - component: {fileID: 6894111335874687869}
  m_Layer: 0
  m_Name: Bullet
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6063498928142543216
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 0.5, y: 0.5, z: 0.5}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5410732386354289441}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &4853897871245773816
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7853976462343550844
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: cf01d22f2a790404ab04b7f9db4fdc89, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!135 &6894111335874687869
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!1 &4044515353307923508
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5410732386354289441}
  - component: {fileID: 1675961125911624443}
  - component: {fileID: 5943469654723181332}
  - component: {fileID: 4178352096548772990}
  m_Layer: 8
  m_Name: PLAYER_Projectile
  m_TagString: Projectile
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5410732386354289441
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6063498928142543216}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!135 &1675961125911624443
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!54 &5943469654723181332
Rigidbody:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 4
  m_Mass: 1
  m_Drag: 0
  m_AngularDrag: 0.05
  m_CenterOfMass: {x: 0, y: 0, z: 0}
  m_InertiaTensor: {x: 1, y: 1, z: 1}
  m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ImplicitCom: 1
  m_ImplicitTensor: 1
  m_UseGravity: 0
  m_IsKinematic: 1
  m_Interpolate: 0
  m_Constraints: 112
  m_CollisionDetection: 0
--- !u!114 &4178352096548772990
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0dd7805b9e1c7a741a660a6d1d5c316b, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  speed: 15
  lifetime: 5
  isHostile: 0
  gracePeriod: 0.05
  wallLayer:
    serializedVersion: 2
    m_Bits: 2048
  damage: 0
  stagger: 0.4
  meshRenderer: {fileID: 7853976462343550844}
  friendlyMaterial: {fileID: 2100000, guid: cf01d22f2a790404ab04b7f9db4fdc89, type: 2}
```

## 📄 `Assets\Prefabs\Combat\PLAYER_Projectile_Homing.prefab`
- Lines: 228
- Size: 6.2 KB
- Modified: 2025-12-24 13:42

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &337644372426971230
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6063498928142543216}
  - component: {fileID: 4853897871245773816}
  - component: {fileID: 7853976462343550844}
  - component: {fileID: 6894111335874687869}
  m_Layer: 0
  m_Name: Bullet
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6063498928142543216
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 0.5, y: 0.5, z: 0.5}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5410732386354289441}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &4853897871245773816
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7853976462343550844
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: cf01d22f2a790404ab04b7f9db4fdc89, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!135 &6894111335874687869
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 337644372426971230}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!1 &4044515353307923508
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5410732386354289441}
  - component: {fileID: 1675961125911624443}
  - component: {fileID: 5943469654723181332}
  - component: {fileID: 4178352096548772990}
  - component: {fileID: -5164728706294159334}
  m_Layer: 8
  m_Name: PLAYER_Projectile_Homing
  m_TagString: Projectile
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5410732386354289441
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6063498928142543216}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!135 &1675961125911624443
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!54 &5943469654723181332
Rigidbody:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  serializedVersion: 4
  m_Mass: 1
  m_Drag: 0
  m_AngularDrag: 0.05
  m_CenterOfMass: {x: 0, y: 0, z: 0}
  m_InertiaTensor: {x: 1, y: 1, z: 1}
  m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ImplicitCom: 1
  m_ImplicitTensor: 1
  m_UseGravity: 0
  m_IsKinematic: 1
  m_Interpolate: 0
  m_Constraints: 112
  m_CollisionDetection: 0
--- !u!114 &4178352096548772990
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0dd7805b9e1c7a741a660a6d1d5c316b, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  speed: 15
  lifetime: 5
  isHostile: 0
  gracePeriod: 0.05
  wallLayer:
    serializedVersion: 2
    m_Bits: 2048
  damage: 0
  stagger: 0.4
  meshRenderer: {fileID: 7853976462343550844}
  friendlyMaterial: {fileID: 2100000, guid: cf01d22f2a790404ab04b7f9db4fdc89, type: 2}
--- !u!114 &-5164728706294159334
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4044515353307923508}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: c38d3e5802833c446bc80af29d9977b8, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  turnSpeed: 5
```

## 📄 `Assets\Prefabs\Enemies\ENE_Chaser_Millise.prefab`
- Lines: 302
- Size: 8.7 KB
- Modified: 2025-12-14 10:46

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &3473038045254472648
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5544281939338948597}
  - component: {fileID: 1484172583536950358}
  - component: {fileID: 1204369766054335695}
  - component: {fileID: 6980652786400845697}
  - component: {fileID: 5182594018108175379}
  - component: {fileID: -3218215720881523416}
  - component: {fileID: -6183628841574312417}
  - component: {fileID: -4036774685981279798}
  - component: {fileID: 211356257347300322}
  - component: {fileID: 1527507773856463301}
  - component: {fileID: 1839963594574695099}
  m_Layer: 7
  m_Name: ENE_Chaser_Millise
  m_TagString: Enemy
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5544281939338948597
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7885210537638490098}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!136 &1484172583536950358
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 0.5
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &1204369766054335695
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2b9a2817a44039e4db8de7c843c7e7a9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _obstacleMask:
    serializedVersion: 2
    m_Bits: 2113
  _skinWidth: 0.015
  _maxStepHeight: 0.3
  _maxSlopeAngle: 45
  _groundSnapDistance: 0.3
  useCulling: 1
  cullingDistance: 40
--- !u!114 &6980652786400845697
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 33be3f323b5a4e94ab00f9c5187b5563, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  stats: {fileID: 11400000, guid: d21ea9f2d8bca2c46882e91c59550a06, type: 2}
  allyLayer:
    serializedVersion: 2
    m_Bits: 0
--- !u!114 &5182594018108175379
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3a7603a9ffd76d345ba02c3982101b64, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  meshRenderer: {fileID: 2571947157768207275}
  normalColor: {r: 1, g: 0, b: 0, a: 1}
  staggerColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  flashColor: {r: 1, g: 1, b: 1, a: 1}
  staggerClip: {fileID: 8300000, guid: 8825eac8c60f4bf439a3043099071044, type: 3}
--- !u!114 &-3218215720881523416
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8e5820ecb28ebae4685623df1b96f267, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  currentTarget: {fileID: 0}
  targets: []
  obstacles: []
--- !u!114 &-6183628841574312417
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 66b8d96badc136a4bb6d9e22ace96d4a, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  behaviors: []
  detectors:
  - {fileID: -4036774685981279798}
  - {fileID: 211356257347300322}
  showGizmos: 1
--- !u!114 &-4036774685981279798
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: d558570723de654498a09f560c44cc66, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRange: 50
  targetLayer:
    serializedVersion: 2
    m_Bits: 576
  showGizmos: 1
--- !u!114 &211356257347300322
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5f13137f182b75c41899ad3069ef5741, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRadius: 2.5
  obstacleMask:
    serializedVersion: 2
    m_Bits: 2049
  showGizmos: 1
--- !u!114 &1527507773856463301
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3f8a3acdcf7b73d44964b4bbc4743a18, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!114 &1839963594574695099
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: cff4a32351cd1794cb5b457de8d5fee8, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  attackRange: 1.5
  fuseDuration: 0.5
  damage: 1
  explosionForce: 20
  chaseBehaviors:
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
--- !u!1 &3806107326065917591
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7885210537638490098}
  - component: {fileID: 8646531339429306655}
  - component: {fileID: 2571947157768207275}
  m_Layer: 7
  m_Name: Body
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7885210537638490098
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3806107326065917591}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5544281939338948597}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &8646531339429306655
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3806107326065917591}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &2571947157768207275
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3806107326065917591}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 1a0fad096e911c14fab81f73ccd6ac38, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
```

## 📄 `Assets\Prefabs\Enemies\ENE_Chaser_Mine.prefab`
- Lines: 305
- Size: 8.8 KB
- Modified: 2025-12-14 10:52

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &3473038045254472648
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5544281939338948597}
  - component: {fileID: 1484172583536950358}
  - component: {fileID: 1204369766054335695}
  - component: {fileID: 6980652786400845697}
  - component: {fileID: 5182594018108175379}
  - component: {fileID: -3218215720881523416}
  - component: {fileID: -6183628841574312417}
  - component: {fileID: -4036774685981279798}
  - component: {fileID: 211356257347300322}
  - component: {fileID: 1527507773856463301}
  - component: {fileID: 1839963594574695099}
  m_Layer: 7
  m_Name: ENE_Chaser_Mine
  m_TagString: Enemy
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5544281939338948597
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7885210537638490098}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!136 &1484172583536950358
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 0.5
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &1204369766054335695
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2b9a2817a44039e4db8de7c843c7e7a9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _obstacleMask:
    serializedVersion: 2
    m_Bits: 2113
  _skinWidth: 0.015
  _maxStepHeight: 0.3
  _maxSlopeAngle: 45
  _groundSnapDistance: 0.3
  useCulling: 1
  cullingDistance: 40
--- !u!114 &6980652786400845697
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 33be3f323b5a4e94ab00f9c5187b5563, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  stats: {fileID: 11400000, guid: d21ea9f2d8bca2c46882e91c59550a06, type: 2}
  allyLayer:
    serializedVersion: 2
    m_Bits: 0
--- !u!114 &5182594018108175379
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3a7603a9ffd76d345ba02c3982101b64, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  meshRenderer: {fileID: 2571947157768207275}
  normalColor: {r: 0.2735849, g: 0.01677644, b: 0.01677644, a: 1}
  staggerColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  flashColor: {r: 1, g: 1, b: 1, a: 1}
  staggerClip: {fileID: 8300000, guid: 8825eac8c60f4bf439a3043099071044, type: 3}
--- !u!114 &-3218215720881523416
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8e5820ecb28ebae4685623df1b96f267, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  currentTarget: {fileID: 0}
  targets: []
  obstacles: []
--- !u!114 &-6183628841574312417
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 66b8d96badc136a4bb6d9e22ace96d4a, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  behaviors: []
  detectors:
  - {fileID: -4036774685981279798}
  - {fileID: 211356257347300322}
  showGizmos: 1
--- !u!114 &-4036774685981279798
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: d558570723de654498a09f560c44cc66, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRange: 50
  targetLayer:
    serializedVersion: 2
    m_Bits: 576
  showGizmos: 1
--- !u!114 &211356257347300322
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5f13137f182b75c41899ad3069ef5741, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRadius: 2.5
  obstacleMask:
    serializedVersion: 2
    m_Bits: 2049
  showGizmos: 1
--- !u!114 &1527507773856463301
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3f8a3acdcf7b73d44964b4bbc4743a18, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!114 &1839963594574695099
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3473038045254472648}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: cff4a32351cd1794cb5b457de8d5fee8, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  mode: 1
  attackRange: 1.5
  hazardPrefab: {fileID: 2235014378595880763, guid: a82ed5a805843164685bbced2f2012dd,
    type: 3}
  fuseDuration: 0.5
  damage: 1
  explosionForce: 20
  chaseBehaviors:
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
--- !u!1 &3806107326065917591
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7885210537638490098}
  - component: {fileID: 8646531339429306655}
  - component: {fileID: 2571947157768207275}
  m_Layer: 7
  m_Name: Body
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7885210537638490098
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3806107326065917591}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5544281939338948597}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &8646531339429306655
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3806107326065917591}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &2571947157768207275
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3806107326065917591}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 1a0fad096e911c14fab81f73ccd6ac38, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
```

## 📄 `Assets\Prefabs\Enemies\ENE_Guardian.prefab`
- Lines: 485
- Size: 14.1 KB
- Modified: 2025-12-23 17:17

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &4608774935982201577
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7450200404810721663}
  - component: {fileID: 5871940570560534539}
  - component: {fileID: 737736199404034563}
  - component: {fileID: 4055007547804138338}
  - component: {fileID: 940291227875785411}
  - component: {fileID: 9104580854497166427}
  - component: {fileID: 852908296871562534}
  - component: {fileID: 3962461874279498121}
  - component: {fileID: 4368561175701528667}
  - component: {fileID: 413201274170582421}
  m_Layer: 7
  m_Name: ENE_Guardian
  m_TagString: Enemy
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7450200404810721663
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 8911227397392263500}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!136 &5871940570560534539
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 1
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &737736199404034563
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2b9a2817a44039e4db8de7c843c7e7a9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _obstacleMask:
    serializedVersion: 2
    m_Bits: 3072
  _skinWidth: 0.015
  _maxStepHeight: 0.3
  _maxSlopeAngle: 45
  _groundSnapDistance: 0.3
  useCulling: 1
  cullingDistance: 40
--- !u!114 &4055007547804138338
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 33be3f323b5a4e94ab00f9c5187b5563, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  stats: {fileID: 11400000, guid: fddb9b3ad0381d74180dc1db1d0ef7b2, type: 2}
  allyLayer:
    serializedVersion: 2
    m_Bits: 0
--- !u!114 &940291227875785411
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3a7603a9ffd76d345ba02c3982101b64, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  meshRenderer: {fileID: 7105195301462925413}
  palette: {fileID: 0}
  staggerClip: {fileID: 8300000, guid: 8825eac8c60f4bf439a3043099071044, type: 3}
--- !u!114 &9104580854497166427
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8e5820ecb28ebae4685623df1b96f267, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  currentTarget: {fileID: 0}
  targets: []
  obstacles: []
--- !u!114 &852908296871562534
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 66b8d96badc136a4bb6d9e22ace96d4a, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  behaviors: []
  detectors:
  - {fileID: 413201274170582421}
  showGizmos: 1
--- !u!114 &3962461874279498121
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3f8a3acdcf7b73d44964b4bbc4743a18, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!114 &4368561175701528667
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 6e6e2fc1fcccb184ca4f51dadb93d439, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  waypointTolerance: 1
  moveBehaviors:
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
  projectilePrefab: {fileID: 4044515353307923508, guid: 0dadc435e51ea8e4b88f2067814f308d,
    type: 3}
  firePoint: {fileID: 2727545481032966752}
  attackPatterns:
  - {fileID: 11400000, guid: ead5bf89e297b6449843b262826d546f, type: 2}
  - {fileID: 11400000, guid: 5fbf3fd672e4ba246ad5e10215cb41e3, type: 2}
  - {fileID: 11400000, guid: bc9335a264b15b7498ea8e8e23bc444c, type: 2}
--- !u!114 &413201274170582421
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4608774935982201577}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5f13137f182b75c41899ad3069ef5741, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRadius: 2
  obstacleMask:
    serializedVersion: 2
    m_Bits: 3136
  showGizmos: 1
--- !u!1 &4627178880318046138
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2727545481032966752}
  m_Layer: 0
  m_Name: FirePoint
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2727545481032966752
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4627178880318046138}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 1.5}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8911227397392263500}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &4876148051091776293
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7697157350068969163}
  - component: {fileID: 65028381949910282}
  - component: {fileID: 7105195301462925413}
  - component: {fileID: 7750972262857401665}
  - component: {fileID: 3049953027818980408}
  - component: {fileID: 549829072868250149}
  m_Layer: 7
  m_Name: Body
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7697157350068969163
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4876148051091776293}
  serializedVersion: 2
  m_LocalRotation: {x: 0.35355338, y: -0.1464466, z: 0.35355338, w: 0.8535535}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1.2, y: 1.2, z: 1.2}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8911227397392263500}
  m_LocalEulerAnglesHint: {x: 45, y: 0, z: 45}
--- !u!33 &65028381949910282
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4876148051091776293}
  m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7105195301462925413
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4876148051091776293}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: a05b6fae2bd964042b79a3bd0ffe0e9e, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!114 &7750972262857401665
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4876148051091776293}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7fb22278ab29a9249976541111df945d, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  axis: {x: 0, y: 1, z: 0}
  speed: 50
--- !u!65 &3049953027818980408
BoxCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4876148051091776293}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Size: {x: 1, y: 1, z: 1}
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &549829072868250149
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4876148051091776293}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 9016109235ae934418d90e23d17144f6, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _mainController: {fileID: 940291227875785411}
  _damageMultiplier: 1
--- !u!1 &5792554547814395914
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2887306487421600477}
  - component: {fileID: 3320879060073683073}
  - component: {fileID: 3108040752348881355}
  m_Layer: 0
  m_Name: Shield_Visual
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2887306487421600477
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5792554547814395914}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 1.2}
  m_LocalScale: {x: 2, y: 2, z: 0.1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8911227397392263500}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &3320879060073683073
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5792554547814395914}
  m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &3108040752348881355
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5792554547814395914}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 24306aa8b0e3eee4a84f9603d5d3bf1a, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &7507684932702318028
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8911227397392263500}
  m_Layer: 0
  m_Name: Guardian_Art
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8911227397392263500
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7507684932702318028}
  serializedVersion: 2
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7697157350068969163}
  - {fileID: 2887306487421600477}
  - {fileID: 2727545481032966752}
  m_Father: {fileID: 7450200404810721663}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Enemies\ENE_Sentinel.prefab`
- Lines: 377
- Size: 11.0 KB
- Modified: 2025-12-14 10:35

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &1695730014863775712
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2179372144766228157}
  - component: {fileID: 7997217901161007655}
  - component: {fileID: 3834379093864157853}
  - component: {fileID: 3591973053576949401}
  m_Layer: 0
  m_Name: Art_Drone
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2179372144766228157
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1695730014863775712}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 9018658543038586659}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &7997217901161007655
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1695730014863775712}
  m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &3834379093864157853
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1695730014863775712}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: a05b6fae2bd964042b79a3bd0ffe0e9e, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!114 &3591973053576949401
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1695730014863775712}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7fb22278ab29a9249976541111df945d, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  axis: {x: 0, y: 1, z: 0}
  speed: 75
--- !u!1 &3219024694404494821
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 9018658543038586659}
  - component: {fileID: 3933523405055568408}
  - component: {fileID: 154471003305820079}
  - component: {fileID: 2541409147942260029}
  - component: {fileID: 1212059287548495218}
  - component: {fileID: 4375997593325643076}
  - component: {fileID: 4659929432609333112}
  - component: {fileID: 500795426752070036}
  - component: {fileID: 8555312545792191347}
  - component: {fileID: 8878435702132643533}
  - component: {fileID: 2210773658854962218}
  - component: {fileID: 8762978511751056149}
  m_Layer: 7
  m_Name: ENE_Sentinel
  m_TagString: Enemy
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &9018658543038586659
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 2179372144766228157}
  - {fileID: 9189882538648999800}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!65 &3933523405055568408
BoxCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Size: {x: 1.1, y: 1.1, z: 1.1}
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &154471003305820079
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2b9a2817a44039e4db8de7c843c7e7a9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _obstacleMask:
    serializedVersion: 2
    m_Bits: 3136
  _skinWidth: 0.015
  _maxStepHeight: 0.3
  _maxSlopeAngle: 45
  _groundSnapDistance: 0.3
  useCulling: 1
  cullingDistance: 40
--- !u!114 &2541409147942260029
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 33be3f323b5a4e94ab00f9c5187b5563, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  stats: {fileID: 11400000, guid: cc0a6717566fad04484abcefff70db74, type: 2}
  allyLayer:
    serializedVersion: 2
    m_Bits: 0
--- !u!114 &1212059287548495218
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3a7603a9ffd76d345ba02c3982101b64, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  meshRenderer: {fileID: 3834379093864157853}
  normalColor: {r: 1, g: 0, b: 0, a: 1}
  staggerColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  flashColor: {r: 1, g: 1, b: 1, a: 1}
  staggerClip: {fileID: 8300000, guid: 8825eac8c60f4bf439a3043099071044, type: 3}
--- !u!136 &4375997593325643076
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 1
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &4659929432609333112
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8e5820ecb28ebae4685623df1b96f267, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  currentTarget: {fileID: 0}
  targets: []
  obstacles: []
--- !u!114 &500795426752070036
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 66b8d96badc136a4bb6d9e22ace96d4a, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  behaviors: []
  detectors:
  - {fileID: 8555312545792191347}
  - {fileID: 8878435702132643533}
  showGizmos: 1
--- !u!114 &8555312545792191347
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5f13137f182b75c41899ad3069ef5741, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRadius: 2
  obstacleMask:
    serializedVersion: 2
    m_Bits: 2048
  showGizmos: 1
--- !u!114 &8878435702132643533
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: d558570723de654498a09f560c44cc66, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRange: 20
  targetLayer:
    serializedVersion: 2
    m_Bits: 64
  showGizmos: 1
--- !u!114 &2210773658854962218
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3f8a3acdcf7b73d44964b4bbc4743a18, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!114 &8762978511751056149
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3219024694404494821}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 32c072d07b415a547a35d45248fa6889, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  combatRange: 10
  huntRange: 15
  projectilePrefab: {fileID: 4044515353307923508, guid: 0dadc435e51ea8e4b88f2067814f308d,
    type: 3}
  firePoint: {fileID: 9189882538648999800}
  fireRate: 2
  huntBehaviors:
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
  combatBehaviors:
  - {fileID: 11400000, guid: 8f5bf4ca0e1bfe849aa8ef34c8cb0487, type: 2}
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
--- !u!1 &4710311676832444623
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 9189882538648999800}
  m_Layer: 0
  m_Name: FirePoint
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &9189882538648999800
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4710311676832444623}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0.5}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 9018658543038586659}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Enemies\ENE_Sniper.prefab`
- Lines: 504
- Size: 14.0 KB
- Modified: 2025-12-14 09:46

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &1079419801353842693
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2759737293173135912}
  m_Layer: 7
  m_Name: FirePoint
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2759737293173135912
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1079419801353842693}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 0.6}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 1264731330307126123}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &1165864707190064670
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8270756766291677151}
  - component: {fileID: 1834507789814928475}
  m_Layer: 7
  m_Name: LaserSight
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8270756766291677151
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1165864707190064670}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0.88, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 1264731330307126123}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!120 &1834507789814928475
LineRenderer:
  serializedVersion: 2
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1165864707190064670}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 0
  m_LightProbeUsage: 0
  m_ReflectionProbeUsage: 0
  m_RayTracingMode: 0
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 10306, guid: 0000000000000000f000000000000000, type: 0}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 10
  m_Positions:
  - {x: 0, y: 0, z: 0}
  - {x: 0, y: 0, z: 1}
  m_Parameters:
    serializedVersion: 3
    widthMultiplier: 0.05
    widthCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 1
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    colorGradient:
      serializedVersion: 2
      key0: {r: 1, g: 0, b: 0, a: 1}
      key1: {r: 1, g: 1, b: 1, a: 1}
      key2: {r: 0, g: 0, b: 0, a: 0}
      key3: {r: 0, g: 0, b: 0, a: 0}
      key4: {r: 0, g: 0, b: 0, a: 0}
      key5: {r: 0, g: 0, b: 0, a: 0}
      key6: {r: 0, g: 0, b: 0, a: 0}
      key7: {r: 0, g: 0, b: 0, a: 0}
      ctime0: 0
      ctime1: 65535
      ctime2: 0
      ctime3: 0
      ctime4: 0
      ctime5: 0
      ctime6: 0
      ctime7: 0
      atime0: 0
      atime1: 65535
      atime2: 0
      atime3: 0
      atime4: 0
      atime5: 0
      atime6: 0
      atime7: 0
      m_Mode: 0
      m_ColorSpace: 0
      m_NumColorKeys: 2
      m_NumAlphaKeys: 2
    numCornerVertices: 0
    numCapVertices: 0
    alignment: 1
    textureMode: 0
    textureScale: {x: 1, y: 1}
    shadowBias: 0.5
    generateLightingData: 0
  m_MaskInteraction: 0
  m_UseWorldSpace: 1
  m_Loop: 0
  m_ApplyActiveColorSpace: 1
--- !u!1 &3417519085629990497
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 44986943622575940}
  - component: {fileID: 5634795843501491134}
  - component: {fileID: 7474795804471265738}
  m_Layer: 7
  m_Name: Art_Monolith
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &44986943622575940
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3417519085629990497}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 0}
  m_LocalScale: {x: 0.8, y: 2, z: 0.8}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 1264731330307126123}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &5634795843501491134
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3417519085629990497}
  m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7474795804471265738
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3417519085629990497}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 0c0ca2cb379c62e49a17c89b6424d2fc, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &7120120158045443931
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1264731330307126123}
  - component: {fileID: 3490169640415794386}
  - component: {fileID: 3382452682107913301}
  - component: {fileID: 6244579565960682116}
  - component: {fileID: 8980908113649931954}
  - component: {fileID: 9153395688772525237}
  - component: {fileID: 1367402872897528640}
  - component: {fileID: 1958590894381872731}
  - component: {fileID: 9135721049295207118}
  - component: {fileID: 7709689282572705384}
  - component: {fileID: 8897705625923450698}
  - component: {fileID: 7560011476583194237}
  m_Layer: 7
  m_Name: ENE_Sniper
  m_TagString: Enemy
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &1264731330307126123
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 44986943622575940}
  - {fileID: 2759737293173135912}
  - {fileID: 8270756766291677151}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &3490169640415794386
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2b9a2817a44039e4db8de7c843c7e7a9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _obstacleMask:
    serializedVersion: 2
    m_Bits: 0
  _skinWidth: 0.015
  _maxStepHeight: 0.3
  _maxSlopeAngle: 45
  _groundSnapDistance: 0.3
  useCulling: 1
  cullingDistance: 40
--- !u!114 &3382452682107913301
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 33be3f323b5a4e94ab00f9c5187b5563, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  stats: {fileID: 11400000, guid: 52b7700e8a006764984953829e0b067f, type: 2}
  allyLayer:
    serializedVersion: 2
    m_Bits: 0
--- !u!114 &6244579565960682116
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3a7603a9ffd76d345ba02c3982101b64, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  meshRenderer: {fileID: 7474795804471265738}
  normalColor: {r: 1, g: 0, b: 0, a: 1}
  staggerColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  flashColor: {r: 1, g: 1, b: 1, a: 1}
  staggerClip: {fileID: 8300000, guid: 8825eac8c60f4bf439a3043099071044, type: 3}
--- !u!65 &8980908113649931954
BoxCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Size: {x: 1, y: 2, z: 1}
  m_Center: {x: 0, y: 1, z: 0}
--- !u!136 &9153395688772525237
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 1
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &1367402872897528640
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8e5820ecb28ebae4685623df1b96f267, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  currentTarget: {fileID: 0}
  targets: []
  obstacles: []
--- !u!114 &1958590894381872731
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 66b8d96badc136a4bb6d9e22ace96d4a, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  behaviors:
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
  detectors:
  - {fileID: 9135721049295207118}
  - {fileID: 7709689282572705384}
  showGizmos: 1
--- !u!114 &9135721049295207118
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: d558570723de654498a09f560c44cc66, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRange: 20
  targetLayer:
    serializedVersion: 2
    m_Bits: 64
  showGizmos: 0
--- !u!114 &7709689282572705384
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5f13137f182b75c41899ad3069ef5741, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  detectionRadius: 2
  obstacleMask:
    serializedVersion: 2
    m_Bits: 2049
  showGizmos: 1
--- !u!114 &8897705625923450698
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3f8a3acdcf7b73d44964b4bbc4743a18, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!114 &7560011476583194237
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7120120158045443931}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 24d8ae1b770c0164cb5b921166a86880, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  panicDistance: 6
  attackRange: 18
  teleportDistance: 12
  teleportCooldown: 5
  wallLayer:
    serializedVersion: 2
    m_Bits: 2048
  projectilePrefab: {fileID: 4044515353307923508, guid: 4af09f738c9220641892c2820a0e78c0,
    type: 3}
  firePoint: {fileID: 2759737293173135912}
  laserSight: {fileID: 1834507789814928475}
  fireRate: 3
  aimDuration: 1.5
  positioningBehaviors:
  - {fileID: 11400000, guid: a9aa5036245d66e408d847a7f9f7750e, type: 2}
  - {fileID: 11400000, guid: b1e853f3913cd434ca7f324824d176f1, type: 2}
```

## 📄 `Assets\Prefabs\Environment\Barrel.prefab`
- Lines: 137
- Size: 3.8 KB
- Modified: 2025-12-23 17:44

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &4944833170603572708
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8225284516125474972}
  - component: {fileID: 1771352897995823416}
  - component: {fileID: 2461008291067431992}
  - component: {fileID: 4762684029309144326}
  - component: {fileID: 597494721512262453}
  m_Layer: 7
  m_Name: Barrel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8225284516125474972
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4944833170603572708}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 23, y: 24.190643, z: -30.69}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &1771352897995823416
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4944833170603572708}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &2461008291067431992
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4944833170603572708}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 1a0fad096e911c14fab81f73ccd6ac38, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!136 &4762684029309144326
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4944833170603572708}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5000001
  m_Height: 2
  m_Direction: 1
  m_Center: {x: 0.000000059604645, y: 0, z: -0.00000008940697}
--- !u!114 &597494721512262453
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4944833170603572708}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 1ceae2df6c08c934bbced6c18fe38dc9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  health: 10
  isImmortal: 0
  maxStagger: 1
  staggerDecay: 1
  staggerDuration: 2
  refillFocus: 0
  healGrit: 0
  spawnOnDeath: {fileID: 2235014378595880763, guid: e7933c66a251e694c92cba8c27bf5ca3,
    type: 3}
  destroyOnDeath: 1
  meshRenderer: {fileID: 0}
  normalColor: {r: 0, g: 1, b: 1, a: 1}
  staggerColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  flashColor: {r: 1, g: 1, b: 1, a: 1}
```

## 📄 `Assets\Prefabs\Environment\ENV_ArenaGate.prefab`
- Lines: 161
- Size: 4.5 KB
- Modified: 2025-12-24 14:28

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &2639803005038198251
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1405579661138916912}
  - component: {fileID: 185020219062933364}
  - component: {fileID: 3379438675682610440}
  - component: {fileID: 344904128072713952}
  m_Layer: 0
  m_Name: Visual
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &1405579661138916912
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2639803005038198251}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 4, y: 5, z: 0.5}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 898284109098665641}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &185020219062933364
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2639803005038198251}
  m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &3379438675682610440
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2639803005038198251}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: f1caba4964998b147be969d1e17c1d94, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!65 &344904128072713952
BoxCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2639803005038198251}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Size: {x: 1, y: 1, z: 1}
  m_Center: {x: 0, y: 0, z: 0}
--- !u!1 &3341947250383591486
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 898284109098665641}
  - component: {fileID: 7433057375573411455}
  m_Layer: 0
  m_Name: ENV_ArenaGate
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &898284109098665641
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3341947250383591486}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 1405579661138916912}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &7433057375573411455
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3341947250383591486}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8b065f9919f65e749895866ea7158886, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  animDuration: 1
  openHeight: -3
  closedHeight: 0
  gateVisuals: {fileID: 1405579661138916912}
  gateCollider: {fileID: 344904128072713952}
  gateRenderer: {fileID: 3379438675682610440}
  lockedColor: {r: 1, g: 0, b: 0, a: 1}
  openColor: {r: 0, g: 1, b: 0, a: 1}
```

## 📄 `Assets\Prefabs\Paths\PatrolPath_Arena.prefab`
- Lines: 214
- Size: 6.0 KB
- Modified: 2025-12-14 11:30

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &1532766303905992734
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4940649633019682208}
  m_Layer: 0
  m_Name: Waypoint_1
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4940649633019682208
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1532766303905992734}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 33.56}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4283960884560483590}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &1987773707480505235
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4283960884560483590}
  - component: {fileID: 1705153522622598525}
  m_Layer: 0
  m_Name: PatrolPath_Arena
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4283960884560483590
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1987773707480505235}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4940649633019682208}
  - {fileID: 8508425039866403905}
  - {fileID: 5031493486268927173}
  - {fileID: 6434766414973384830}
  - {fileID: 7533703178146814855}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &1705153522622598525
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1987773707480505235}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7c1ec2e69e5f990438848cd10194aaf6, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  waypoints:
  - {fileID: 4940649633019682208}
  - {fileID: 8508425039866403905}
  - {fileID: 5031493486268927173}
  - {fileID: 6434766414973384830}
  - {fileID: 7533703178146814855}
  loop: 1
--- !u!1 &2404956690542181068
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8508425039866403905}
  m_Layer: 0
  m_Name: Waypoint_2
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8508425039866403905
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2404956690542181068}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 29.18, y: 0, z: 16}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4283960884560483590}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &2521445798371300945
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5031493486268927173}
  m_Layer: 0
  m_Name: Waypoint_3
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5031493486268927173
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2521445798371300945}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 36.29, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4283960884560483590}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &4592644933888029572
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6434766414973384830}
  m_Layer: 0
  m_Name: Waypoint_4
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6434766414973384830
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4592644933888029572}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: -29.41}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4283960884560483590}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &8370761085190410057
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7533703178146814855}
  m_Layer: 0
  m_Name: Waypoint_5
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7533703178146814855
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8370761085190410057}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: -38.7, y: 0, z: 7.7}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4283960884560483590}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Player\[PLAYER_STRIKER].prefab`
- Lines: 1082
- Size: 31.2 KB
- Modified: 2025-12-24 15:22

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &934178964674360071
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5938182085543417046}
  - component: {fileID: 4811700125883332067}
  - component: {fileID: 2005258309971441343}
  - component: {fileID: 7724402299172212888}
  m_Layer: 6
  m_Name: Reticle_3D
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!4 &5938182085543417046
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 934178964674360071}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7576279871074212748}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!120 &4811700125883332067
LineRenderer:
  serializedVersion: 2
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 934178964674360071}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 0
  m_LightProbeUsage: 0
  m_ReflectionProbeUsage: 0
  m_RayTracingMode: 0
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 10306, guid: 0000000000000000f000000000000000, type: 0}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_Positions:
  - {x: 1.5, y: 0, z: 0}
  - {x: 1.488172, y: 0, z: 0.18799983}
  - {x: 1.4528748, y: 0, z: 0.3730348}
  - {x: 1.3946648, y: 0, z: 0.5521868}
  - {x: 1.31446, y: 0, z: 0.7226305}
  - {x: 1.2135255, y: 0, z: 0.88167787}
  - {x: 1.093453, y: 0, z: 1.0268207}
  - {x: 0.9561361, y: 0, z: 1.1557698}
  - {x: 0.80374026, y: 0, z: 1.2664918}
  - {x: 0.63866895, y: 0, z: 1.3572406}
  - {x: 0.4635256, y: 0, z: 1.4265847}
  - {x: 0.28107202, y: 0, z: 1.4734309}
  - {x: 0.094185926, y: 0, z: 1.49704}
  - {x: -0.0941857, y: 0, z: 1.49704}
  - {x: -0.28107178, y: 0, z: 1.4734309}
  - {x: -0.4635254, y: 0, z: 1.4265848}
  - {x: -0.6386688, y: 0, z: 1.3572407}
  - {x: -0.80374014, y: 0, z: 1.266492}
  - {x: -0.956136, y: 0, z: 1.1557698}
  - {x: -1.0934529, y: 0, z: 1.0268207}
  - {x: -1.2135253, y: 0, z: 0.88167804}
  - {x: -1.31446, y: 0, z: 0.7226306}
  - {x: -1.3946648, y: 0, z: 0.5521869}
  - {x: -1.4528748, y: 0, z: 0.37303486}
  - {x: -1.488172, y: 0, z: 0.18800014}
  - {x: -1.5, y: 0, z: 0.00000022649371}
  - {x: -1.488172, y: 0, z: -0.1879997}
  - {x: -1.4528748, y: 0, z: -0.37303478}
  - {x: -1.3946648, y: 0, z: -0.5521865}
  - {x: -1.3144602, y: 0, z: -0.72263026}
  - {x: -1.2135255, y: 0, z: -0.8816777}
  - {x: -1.093453, y: 0, z: -1.0268207}
  - {x: -0.9561362, y: 0, z: -1.1557696}
  - {x: -0.8037405, y: 0, z: -1.2664917}
  - {x: -0.63866913, y: 0, z: -1.3572404}
  - {x: -0.46352565, y: 0, z: -1.4265847}
  - {x: -0.28107205, y: 0, z: -1.4734309}
  - {x: -0.0941858, y: 0, z: -1.49704}
  - {x: 0.09418584, y: 0, z: -1.49704}
  - {x: 0.28107142, y: 0, z: -1.473431}
  - {x: 0.463525, y: 0, z: -1.426585}
  - {x: 0.63866854, y: 0, z: -1.3572408}
  - {x: 0.8037399, y: 0, z: -1.2664921}
  - {x: 0.9561358, y: 0, z: -1.1557701}
  - {x: 1.0934528, y: 0, z: -1.0268208}
  - {x: 1.2135254, y: 0, z: -0.881678}
  - {x: 1.31446, y: 0, z: -0.72263056}
  - {x: 1.3946648, y: 0, z: -0.55218685}
  - {x: 1.4528745, y: 0, z: -0.37303543}
  - {x: 1.488172, y: 0, z: -0.18800037}
  - {x: 1.5, y: 0, z: -0.00000045298742}
  m_Parameters:
    serializedVersion: 3
    widthMultiplier: 1
    widthCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.2
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1
        value: 0.2
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    colorGradient:
      serializedVersion: 2
      key0: {r: 0.114542544, g: 0.1347088, b: 0.735849, a: 0.78431374}
      key1: {r: 0.03404235, g: 0.349339, b: 0.8018868, a: 1}
      key2: {r: 0, g: 0, b: 0, a: 0}
      key3: {r: 0, g: 0, b: 0, a: 0}
      key4: {r: 0, g: 0, b: 0, a: 0}
      key5: {r: 0, g: 0, b: 0, a: 0}
      key6: {r: 0, g: 0, b: 0, a: 0}
      key7: {r: 0, g: 0, b: 0, a: 0}
      ctime0: 0
      ctime1: 65535
      ctime2: 0
      ctime3: 0
      ctime4: 0
      ctime5: 0
      ctime6: 0
      ctime7: 0
      atime0: 0
      atime1: 65535
      atime2: 0
      atime3: 0
      atime4: 0
      atime5: 0
      atime6: 0
      atime7: 0
      m_Mode: 1
      m_ColorSpace: 0
      m_NumColorKeys: 2
      m_NumAlphaKeys: 2
    numCornerVertices: 0
    numCapVertices: 0
    alignment: 1
    textureMode: 0
    textureScale: {x: 1, y: 1}
    shadowBias: 0.5
    generateLightingData: 0
  m_MaskInteraction: 0
  m_UseWorldSpace: 0
  m_Loop: 1
  m_ApplyActiveColorSpace: 1
--- !u!114 &2005258309971441343
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 934178964674360071}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ad2f189fc1734ff49ad7b9744ed227f5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  segments: 50
  radius: 1.5
  lineWidth: 0.2
--- !u!114 &7724402299172212888
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 934178964674360071}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 7fb22278ab29a9249976541111df945d, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  axis: {x: 0, y: 1, z: 0}
  speed: 100
--- !u!1 &1617517802429839644
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8608103599068932834}
  m_Layer: 6
  m_Name: FirePoint
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8608103599068932834
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1617517802429839644}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1.384, z: 0.447}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7576279871074212748}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &2800933339060134204
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7600515752588601197}
  - component: {fileID: 1662632101848578889}
  - component: {fileID: 6070481044973411645}
  m_Layer: 6
  m_Name: Core
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7600515752588601197
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2800933339060134204}
  serializedVersion: 2
  m_LocalRotation: {x: 0.7071068, y: 0, z: 0, w: 0.7071068}
  m_LocalPosition: {x: 0, y: 1.418, z: 0.282}
  m_LocalScale: {x: 0.4, y: 0.1, z: 0.4}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7576279871074212748}
  m_LocalEulerAnglesHint: {x: 90, y: 0, z: 0}
--- !u!33 &1662632101848578889
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2800933339060134204}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &6070481044973411645
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2800933339060134204}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 3cf496f97baa02943befc49a0e9e5731, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &4708903253865202310
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 392873374073357921}
  - component: {fileID: 404550043653125912}
  - component: {fileID: 1628793600088000154}
  m_Layer: 6
  m_Name: Visor
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &392873374073357921
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4708903253865202310}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 0.1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4632399184935556604}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &404550043653125912
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4708903253865202310}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &1628793600088000154
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4708903253865202310}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 570a0b9c262ed7744a6cdcac4fe6e9a6, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &6707888363146532995
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8058484832477479520}
  - component: {fileID: 1145431250015528344}
  - component: {fileID: 8626066530795315162}
  m_Layer: 6
  m_Name: Cylinder
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8058484832477479520
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6707888363146532995}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0.1, z: 0}
  m_LocalScale: {x: 1, y: 0.1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 192944804307636621}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &1145431250015528344
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6707888363146532995}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &8626066530795315162
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6707888363146532995}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: cc19ea74c476bab4daeeff447d45cbc9, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &7112460915844066059
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8308375988866213649}
  - component: {fileID: 8286395324277569923}
  - component: {fileID: 8497757297922539902}
  m_Layer: 6
  m_Name: Tube
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8308375988866213649
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7112460915844066059}
  serializedVersion: 2
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0.3, z: 0}
  m_LocalScale: {x: 0.5, y: 0.2, z: 0.5}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4632399184935556604}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &8286395324277569923
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7112460915844066059}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &8497757297922539902
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7112460915844066059}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 570a0b9c262ed7744a6cdcac4fe6e9a6, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &7426592532524690677
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7056910256623673570}
  - component: {fileID: 2511595308338736714}
  - component: {fileID: 2708127184922713459}
  m_Layer: 6
  m_Name: Body
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7056910256623673570
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7426592532524690677}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 0}
  m_LocalScale: {x: 0.7, y: 1, z: 0.7}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7576279871074212748}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &2511595308338736714
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7426592532524690677}
  m_Mesh: {fileID: 10208, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &2708127184922713459
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7426592532524690677}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 11f428ecb4a389e48b3415c41eee0938, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!1 &7678380716543962105
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 192944804307636621}
  m_Layer: 6
  m_Name: Blitz_Indicator
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!4 &192944804307636621
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7678380716543962105}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 8058484832477479520}
  m_Father: {fileID: 7576279871074212748}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &8164355637247924031
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7576279871074212748}
  - component: {fileID: 9183884152685474308}
  - component: {fileID: 5230015545283728264}
  - component: {fileID: 6365553688910257222}
  - component: {fileID: 8588073913637015239}
  - component: {fileID: 6949509784031142000}
  - component: {fileID: 7548255836402914066}
  - component: {fileID: 3146043007839357323}
  - component: {fileID: 1722693863214666388}
  - component: {fileID: 441507639296113179}
  - component: {fileID: 3406123499475282924}
  - component: {fileID: 5466856792935116601}
  - component: {fileID: 8853776279611051482}
  - component: {fileID: -4286876796308643671}
  - component: {fileID: 5645868823290248984}
  - component: {fileID: 6849140618581266389}
  m_Layer: 6
  m_Name: '[PLAYER_STRIKER]'
  m_TagString: Player
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7576279871074212748
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0.1, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7056910256623673570}
  - {fileID: 4632399184935556604}
  - {fileID: 7600515752588601197}
  - {fileID: 8608103599068932834}
  - {fileID: 192944804307636621}
  - {fileID: 5938182085543417046}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!136 &9183884152685474308
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 2
  m_Direction: 1
  m_Center: {x: 0, y: 1, z: 0}
--- !u!54 &5230015545283728264
Rigidbody:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  serializedVersion: 4
  m_Mass: 1
  m_Drag: 0
  m_AngularDrag: 0.05
  m_CenterOfMass: {x: 0, y: 0, z: 0}
  m_InertiaTensor: {x: 1, y: 1, z: 1}
  m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ImplicitCom: 1
  m_ImplicitTensor: 1
  m_UseGravity: 0
  m_IsKinematic: 1
  m_Interpolate: 0
  m_Constraints: 4
  m_CollisionDetection: 0
--- !u!114 &6365553688910257222
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2b9a2817a44039e4db8de7c843c7e7a9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _obstacleMask:
    serializedVersion: 2
    m_Bits: 3201
  _skinWidth: 0.015
  _maxStepHeight: 0.3
  _maxSlopeAngle: 45
  _groundSnapDistance: 0.3
  useCulling: 1
  cullingDistance: 40
--- !u!114 &8588073913637015239
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: cf2267156712e0248a224233bd101a1e, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  deceleration: 40
  rotationSpeed: 25
  wallBuffer: 0.7
  repulsionForce: 120
  wallLayer:
    serializedVersion: 2
    m_Bits: 2048
  gravity: 20
  safeGroundTimer: 0.5
--- !u!114 &6949509784031142000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 9e5f440b2737114418b3ca265853fa24, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!114 &7548255836402914066
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8274311e1aea4644e8a6cd7bdb8828e9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  maxGrit: 2
  startWithHull: 1
--- !u!114 &3146043007839357323
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 9d87efa653f246b45be35b53052d787b, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  maxFocus: 100
  decayRate: 3
  defaultFocusOnKill: 30
--- !u!114 &1722693863214666388
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 20549bf1521c4194fb2c644db7c18579, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  scanRange: 35
  scanRadius: 3
  enemyLayer:
    serializedVersion: 2
    m_Bits: 128
  reticlePrefab: {fileID: 5938182085543417046}
  reticleOffset: {x: 0, y: 0.1, z: 0}
  lockedColor: {r: 0, g: 1, b: 1, a: 1}
  executionColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
--- !u!114 &441507639296113179
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 07184ec7d777ba2459feab10aeb6bf89, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  firePoint: {fileID: 8608103599068932834}
  baseFireRate: 0.2
  fireClip: {fileID: 8300000, guid: f16c082ad078e8943990c633ba1ea8b4, type: 3}
  volume: 0.8
  inputBufferTime: 0.2
  bulletSpeed: 45
--- !u!114 &3406123499475282924
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5b7430c062d1d144b9292b4648b893b4, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  firePoint: {fileID: 8608103599068932834}
  baseFireRate: 0.2
  fireClip: {fileID: 8300000, guid: 550cd03e285900e40b4fc9ce12aa32cb, type: 3}
  volume: 0.8
  inputBufferTime: 0.2
  range: 7
  beamRadius: 0.5
  selfRecoil: 15
  hitLayers:
    serializedVersion: 2
    m_Bits: 2177
  beamVisualPrefab: {fileID: 787095901406166969, guid: ca3c409d6d1f9224eb80fcb2594a72ea,
    type: 3}
--- !u!114 &5466856792935116601
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 5a613d45a4de2b84e9b8c6e96f0e8b7c, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  focusCost: 22
  dashDistance: 8
  dashDuration: 0.15
  projectileLayer:
    serializedVersion: 2
    m_Bits: 256
  dashClip: {fileID: 8300000, guid: 11a67d7cfc51a7a47aa5638e3bfd7826, type: 3}
  indicatorRef: {fileID: 192944804307636621}
  indicatorRenderer: {fileID: 4811700125883332067}
  readyMat: {fileID: 2100000, guid: 24306aa8b0e3eee4a84f9603d5d3bf1a, type: 2}
  notReadyMat: {fileID: 2100000, guid: cc19ea74c476bab4daeeff447d45cbc9, type: 2}
  wallLayer:
    serializedVersion: 2
    m_Bits: 2048
--- !u!114 &8853776279611051482
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: be01441c03af92543876bc1721da12c0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  killRewardFocus: 50
  executeClip: {fileID: 8300000, guid: 3a8204bbfd76b4c44a30dbced9b6a021, type: 3}
--- !u!114 &-4286876796308643671
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: d3dabcba8c5ea184c98fdb8df9f5484c, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  actorType: 0
  themeOverride: {fileID: 0}
  primaryRenderers:
  - {fileID: 2708127184922713459}
  secondaryRenderers:
  - {fileID: 8497757297922539902}
  - {fileID: 1628793600088000154}
  tertiaryRenderers:
  - {fileID: 6070481044973411645}
--- !u!114 &5645868823290248984
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 6343646a9f89d5e42b6ddc41b23a5f63, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  baseStats: {fileID: 11400000, guid: 9baa1bba4b0c9814282f5c7ee9f8e67a, type: 2}
--- !u!114 &6849140618581266389
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8164355637247924031}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: d9df14f1b6c62074f8c30a847e0e1eb8, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  defaultProjectile: {fileID: 4044515353307923508, guid: c7dcc8ab25afa6847a78b815b8462362,
    type: 3}
  defaultDecoy: {fileID: 2788212711757725431, guid: 44f32e0a429fb8148884f01ad36c7703,
    type: 3}
  currentProjectile: {fileID: 4044515353307923508, guid: c7dcc8ab25afa6847a78b815b8462362,
    type: 3}
  currentDecoy: {fileID: 2788212711757725431, guid: 44f32e0a429fb8148884f01ad36c7703,
    type: 3}
--- !u!1 &8799886156076035042
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4632399184935556604}
  m_Layer: 6
  m_Name: Hat
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4632399184935556604
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8799886156076035042}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 2, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 8308375988866213649}
  - {fileID: 392873374073357921}
  m_Father: {fileID: 7576279871074212748}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Player\AFTER_IMAGE.prefab`
- Lines: 156
- Size: 4.3 KB
- Modified: 2025-12-24 13:38

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &2788212711757725431
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 723082918043367499}
  - component: {fileID: 1369080987920047305}
  m_Layer: 9
  m_Name: AFTER_IMAGE
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &723082918043367499
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2788212711757725431}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4459037203395882135}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &1369080987920047305
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2788212711757725431}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 90b7a29529e113e48adfa8c4170a0508, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  lifetime: 1
--- !u!1 &7796294636433837959
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4459037203395882135}
  - component: {fileID: 6368881491019199300}
  - component: {fileID: 6370030462567589499}
  - component: {fileID: 9156137676136654401}
  m_Layer: 9
  m_Name: Body
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4459037203395882135
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1.09, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 723082918043367499}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &6368881491019199300
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  m_Mesh: {fileID: 10208, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &6370030462567589499
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: cc19ea74c476bab4daeeff447d45cbc9, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!136 &9156137676136654401
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 2
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Player\AFTER_IMAGE_EXPOSIVE.prefab`
- Lines: 177
- Size: 4.9 KB
- Modified: 2025-12-24 13:44

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &2788212711757725431
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 723082918043367499}
  - component: {fileID: 1369080987920047305}
  - component: {fileID: -1068563760271009996}
  m_Layer: 9
  m_Name: AFTER_IMAGE_EXPOSIVE
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &723082918043367499
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2788212711757725431}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4459037203395882135}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &1369080987920047305
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2788212711757725431}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 90b7a29529e113e48adfa8c4170a0508, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  lifetime: 1
--- !u!114 &-1068563760271009996
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2788212711757725431}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 07fbf082506fc3b4eab408a5f32d4478, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  duration: 3
  damage: 1
  knockbackForce: 15
  targetLayer:
    serializedVersion: 2
    m_Bits: 0
  visualRing: {fileID: 7551186951016571749, guid: e7933c66a251e694c92cba8c27bf5ca3,
    type: 3}
--- !u!1 &7796294636433837959
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4459037203395882135}
  - component: {fileID: 6368881491019199300}
  - component: {fileID: 6370030462567589499}
  - component: {fileID: 9156137676136654401}
  m_Layer: 9
  m_Name: Body
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4459037203395882135
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1.09, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 723082918043367499}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &6368881491019199300
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  m_Mesh: {fileID: 10208, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &6370030462567589499
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: cc19ea74c476bab4daeeff447d45cbc9, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!136 &9156137676136654401
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7796294636433837959}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Height: 2
  m_Direction: 1
  m_Center: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Player\BEAM_ROOT.prefab`
- Lines: 118
- Size: 3.4 KB
- Modified: 2025-12-24 13:38

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &787095901406166969
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7895602571878091356}
  m_Layer: 0
  m_Name: BEAM_ROOT
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7895602571878091356
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 787095901406166969}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 5442562417078519848}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &3489193378672524391
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5442562417078519848}
  - component: {fileID: 7039372289348329240}
  - component: {fileID: 8775854936899163272}
  m_Layer: 0
  m_Name: BeamPhantom
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5442562417078519848
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3489193378672524391}
  serializedVersion: 2
  m_LocalRotation: {x: 0.7071068, y: 0, z: 0, w: 0.7071068}
  m_LocalPosition: {x: 0, y: 0, z: 0.5}
  m_LocalScale: {x: 1, y: 0.5, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7895602571878091356}
  m_LocalEulerAnglesHint: {x: 90, y: 0, z: 0}
--- !u!33 &7039372289348329240
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3489193378672524391}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &8775854936899163272
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3489193378672524391}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 24306aa8b0e3eee4a84f9603d5d3bf1a, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
```

## 📄 `Assets\Prefabs\Scene\[POST PROCESING].prefab`
- Lines: 52
- Size: 1.4 KB
- Modified: 2025-12-11 17:30

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &6219090421559542051
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6949824205231625066}
  - component: {fileID: 6880798508900867420}
  m_Layer: 0
  m_Name: '[POST PROCESING]'
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6949824205231625066
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6219090421559542051}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &6880798508900867420
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6219090421559542051}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 172515602e62fb746b5d573b38a5fe58, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_IsGlobal: 1
  priority: 0
  blendDistance: 0
  weight: 1
  sharedProfile: {fileID: 11400000, guid: edd0ddc95a0e2364fabcbf70754eb30e, type: 2}
```

## 📄 `Assets\Prefabs\Scene\[SCENE].prefab`
- Lines: 308
- Size: 8.0 KB
- Modified: 2025-12-24 14:13

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &3033808995432721078
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2109871604053938133}
  - component: {fileID: 7006024474988336104}
  - component: {fileID: 6058396573655215589}
  - component: {fileID: 8291338698807381252}
  - component: {fileID: 3998046780375777234}
  m_Layer: 0
  m_Name: Main Camera
  m_TagString: MainCamera
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2109871604053938133
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3033808995432721078}
  serializedVersion: 2
  m_LocalRotation: {x: -0.11827603, y: 0.8034104, z: -0.17024218, w: -0.55817574}
  m_LocalPosition: {x: 0.18168372, y: 0.113635555, z: -10.50535}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 2461092328778261139}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!20 &7006024474988336104
Camera:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3033808995432721078}
  m_Enabled: 1
  serializedVersion: 2
  m_ClearFlags: 1
  m_BackGroundColor: {r: 0, g: 0, b: 0, a: 1}
  m_projectionMatrixMode: 1
  m_GateFitMode: 2
  m_FOVAxisMode: 0
  m_Iso: 200
  m_ShutterSpeed: 0.005
  m_Aperture: 16
  m_FocusDistance: 10
  m_FocalLength: 50
  m_BladeCount: 5
  m_Curvature: {x: 2, y: 11}
  m_BarrelClipping: 0.25
  m_Anamorphism: 0
  m_SensorSize: {x: 36, y: 24}
  m_LensShift: {x: 0, y: 0}
  m_NormalizedViewPortRect:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  near clip plane: 0.3
  far clip plane: 1000
  field of view: 60.000004
  orthographic: 0
  orthographic size: 5
  m_Depth: -1
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingPath: -1
  m_TargetTexture: {fileID: 0}
  m_TargetDisplay: 0
  m_TargetEye: 3
  m_HDR: 1
  m_AllowMSAA: 1
  m_AllowDynamicResolution: 0
  m_ForceIntoRT: 0
  m_OcclusionCulling: 1
  m_StereoConvergence: 10
  m_StereoSeparation: 0.022
--- !u!81 &6058396573655215589
AudioListener:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3033808995432721078}
  m_Enabled: 1
--- !u!114 &8291338698807381252
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3033808995432721078}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: a79441f348de89743a2939f4d699eac1, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_RenderShadows: 1
  m_RequiresDepthTextureOption: 2
  m_RequiresOpaqueTextureOption: 2
  m_CameraType: 0
  m_Cameras: []
  m_RendererIndex: -1
  m_VolumeLayerMask:
    serializedVersion: 2
    m_Bits: 1
  m_VolumeTrigger: {fileID: 0}
  m_VolumeFrameworkUpdateModeOption: 2
  m_RenderPostProcessing: 1
  m_Antialiasing: 0
  m_AntialiasingQuality: 2
  m_StopNaN: 0
  m_Dithering: 0
  m_ClearDepth: 1
  m_AllowXRRendering: 1
  m_AllowHDROutput: 1
  m_UseScreenCoordOverride: 0
  m_ScreenSizeOverride: {x: 0, y: 0, z: 0, w: 0}
  m_ScreenCoordScaleBias: {x: 0, y: 0, z: 0, w: 0}
  m_RequiresDepthTexture: 0
  m_RequiresColorTexture: 0
  m_Version: 2
  m_TaaSettings:
    m_Quality: 3
    m_FrameInfluence: 0.1
    m_JitterScale: 1
    m_MipBias: 0
    m_VarianceClampScale: 0.9
    m_ContrastAdaptiveSharpening: 0
--- !u!114 &3998046780375777234
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3033808995432721078}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: a56996cf69156b449bc8f7307627a681, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  target: {fileID: 0}
  pitch: 45
  distance: 25
  smoothTime: 0.1
--- !u!1 &4154563175726299682
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2337854088277276871}
  - component: {fileID: 2494496193207943625}
  - component: {fileID: 7794058528956593069}
  m_Layer: 0
  m_Name: Directional Light
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2337854088277276871
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4154563175726299682}
  serializedVersion: 2
  m_LocalRotation: {x: 0.40821788, y: -0.23456968, z: 0.10938163, w: 0.8754261}
  m_LocalPosition: {x: 0.18168372, y: 3.0136356, z: -0.50535035}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 2461092328778261139}
  m_LocalEulerAnglesHint: {x: 50, y: -30, z: 0}
--- !u!108 &2494496193207943625
Light:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4154563175726299682}
  m_Enabled: 1
  serializedVersion: 10
  m_Type: 1
  m_Shape: 0
  m_Color: {r: 1, g: 0.95686275, b: 0.8392157, a: 1}
  m_Intensity: 1
  m_Range: 10
  m_SpotAngle: 30
  m_InnerSpotAngle: 21.80208
  m_CookieSize: 10
  m_Shadows:
    m_Type: 2
    m_Resolution: -1
    m_CustomResolution: -1
    m_Strength: 1
    m_Bias: 0.05
    m_NormalBias: 0.4
    m_NearPlane: 0.2
    m_CullingMatrixOverride:
      e00: 1
      e01: 0
      e02: 0
      e03: 0
      e10: 0
      e11: 1
      e12: 0
      e13: 0
      e20: 0
      e21: 0
      e22: 1
      e23: 0
      e30: 0
      e31: 0
      e32: 0
      e33: 1
    m_UseCullingMatrixOverride: 0
  m_Cookie: {fileID: 0}
  m_DrawHalo: 0
  m_Flare: {fileID: 0}
  m_RenderMode: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingLayerMask: 1
  m_Lightmapping: 4
  m_LightShadowCasterMode: 0
  m_AreaSize: {x: 1, y: 1}
  m_BounceIntensity: 1
  m_ColorTemperature: 6570
  m_UseColorTemperature: 0
  m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
  m_UseBoundingSphereOverride: 0
  m_UseViewFrustumForShadowCasterCull: 1
  m_ShadowRadius: 0
  m_ShadowAngle: 0
--- !u!114 &7794058528956593069
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4154563175726299682}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 474bcb49853aa07438625e644c072ee6, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Version: 3
  m_UsePipelineSettings: 1
  m_AdditionalLightsShadowResolutionTier: 2
  m_LightLayerMask: 1
  m_RenderingLayers: 1
  m_CustomShadowLayers: 0
  m_ShadowLayerMask: 1
  m_ShadowRenderingLayers: 1
  m_LightCookieSize: {x: 1, y: 1}
  m_LightCookieOffset: {x: 0, y: 0}
  m_SoftShadowQuality: 0
--- !u!1 &4449467226045155078
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2461092328778261139}
  m_Layer: 0
  m_Name: '[SCENE]'
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2461092328778261139
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4449467226045155078}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 2337854088277276871}
  - {fileID: 2109871604053938133}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Prefabs\Systems\[DEBUG].prefab`
- Lines: 50
- Size: 1.4 KB
- Modified: 2025-12-13 10:21

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &6730024780086289146
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 993538837623503203}
  - component: {fileID: 8954004539990992816}
  m_Layer: 0
  m_Name: '[DEBUG]'
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &993538837623503203
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6730024780086289146}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 939.7043, y: 1051.4177, z: -18.75924}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &8954004539990992816
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6730024780086289146}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: b26d2313a71880945b5538a72e8f428d, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  godMode: 0
  infiniteFocus: 0
  enemiesToSpawn: []
```

## 📄 `Assets\Prefabs\Systems\[SYSTEM].prefab`
- Lines: 695
- Size: 23.6 KB
- Modified: 2025-12-24 13:40

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &3293673758500166157
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7814700572193736764}
  - component: {fileID: 2973498148887963160}
  - component: {fileID: 2242135720706172664}
  m_Layer: 0
  m_Name: EventSystem
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7814700572193736764
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3293673758500166157}
  serializedVersion: 2
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4583971373037434231}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &2973498148887963160
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3293673758500166157}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 76c392e42b5098c458856cdf6ecaaaa1, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_FirstSelected: {fileID: 0}
  m_sendNavigationEvents: 1
  m_DragThreshold: 10
--- !u!114 &2242135720706172664
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3293673758500166157}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4f231c4fb786f3946a6b90b886c48677, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_SendPointerHoverToParent: 1
  m_HorizontalAxis: Horizontal
  m_VerticalAxis: Vertical
  m_SubmitButton: Submit
  m_CancelButton: Cancel
  m_InputActionsPerSecond: 10
  m_RepeatDelay: 0.5
  m_ForceModuleActive: 0
--- !u!1 &3462713615548775571
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4583971373037434231}
  m_Layer: 0
  m_Name: '[SYSTEM]'
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4583971373037434231
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3462713615548775571}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7641673414799766046}
  - {fileID: 1136409820151048644}
  - {fileID: 7814700572193736764}
  - {fileID: 8446783470516128647}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &7495381767313450556
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8446783470516128647}
  - component: {fileID: 8185893364261987117}
  m_Layer: 0
  m_Name: Audio Source
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8446783470516128647
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7495381767313450556}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4583971373037434231}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!82 &8185893364261987117
AudioSource:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7495381767313450556}
  m_Enabled: 1
  serializedVersion: 4
  OutputAudioMixerGroup: {fileID: 0}
  m_audioClip: {fileID: 0}
  m_PlayOnAwake: 0
  m_Volume: 1
  m_Pitch: 1
  Loop: 0
  Mute: 0
  Spatialize: 0
  SpatializePostEffects: 0
  Priority: 128
  DopplerLevel: 1
  MinDistance: 1
  MaxDistance: 500
  Pan2D: 0
  rolloffMode: 0
  BypassEffects: 0
  BypassListenerEffects: 0
  BypassReverbZones: 0
  rolloffCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    - serializedVersion: 3
      time: 1
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  panLevelCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  spreadCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  reverbZoneMixCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
--- !u!1001 &1460922002459456956
PrefabInstance:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Modification:
    serializedVersion: 3
    m_TransformParent: {fileID: 4583971373037434231}
    m_Modifications:
    - target: {fileID: 116000915692159342, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 267414015062073244, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 267414015062073244, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 267414015062073244, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 267414015062073244, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 714350303644832287, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 714350303644832287, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 714350303644832287, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 714350303644832287, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 1721542208996667898, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 1721542208996667898, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 1721542208996667898, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 1721542208996667898, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 1846926581866888574, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 1902584077792702905, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 2878496905638879129, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_Name
      value: UI_HUD
      objectReference: {fileID: 0}
    - target: {fileID: 3394127235468340535, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 3526816204144016603, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 4181762744011268293, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 4181762744011268293, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 4181762744011268293, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 4181762744011268293, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 5206918507631830745, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 5220295483703296410, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 5220295483703296410, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 5220295483703296410, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 5220295483703296410, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 5499693873365596550, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 5656959328185902210, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 6271382998069292833, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 6601267033874888592, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 6725254738931999090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8219719943515876693, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_OnClick.m_PersistentCalls.m_Calls.Array.data[0].m_Target
      value: 
      objectReference: {fileID: 1511099843283945826}
    - target: {fileID: 8745827455391631090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8745827455391631090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8745827455391631090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8745827455391631090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_Pivot.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_Pivot.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMax.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchorMin.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_SizeDelta.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_SizeDelta.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalPosition.z
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalRotation.w
      value: 1
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalRotation.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalRotation.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalRotation.z
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_AnchoredPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.z
      value: 0
      objectReference: {fileID: 0}
    m_RemovedComponents: []
    m_RemovedGameObjects: []
    m_AddedGameObjects: []
    m_AddedComponents: []
  m_SourcePrefab: {fileID: 100100000, guid: dcff4a96bbce5774082018915d117428, type: 3}
--- !u!1 &666718699631651886 stripped
GameObject:
  m_CorrespondingSourceObject: {fileID: 2091523788175989138, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!1 &1966958504536888142 stripped
GameObject:
  m_CorrespondingSourceObject: {fileID: 1083738603315472114, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!1 &7266331233028832601 stripped
GameObject:
  m_CorrespondingSourceObject: {fileID: 8111278782685874405, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!224 &7641673414799766046 stripped
RectTransform:
  m_CorrespondingSourceObject: {fileID: 9100246156042717090, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!1 &7642672650237261223 stripped
GameObject:
  m_CorrespondingSourceObject: {fileID: 9103470956526551067, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!1 &8325508708358241531 stripped
GameObject:
  m_CorrespondingSourceObject: {fileID: 7479382619679410503, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!1 &8436434638302926423 stripped
GameObject:
  m_CorrespondingSourceObject: {fileID: 7012667882563511275, guid: dcff4a96bbce5774082018915d117428,
    type: 3}
  m_PrefabInstance: {fileID: 1460922002459456956}
  m_PrefabAsset: {fileID: 0}
--- !u!1001 &8472252229947353746
PrefabInstance:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Modification:
    serializedVersion: 3
    m_TransformParent: {fileID: 4583971373037434231}
    m_Modifications:
    - target: {fileID: 1948609913512096065, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: _sfxSource
      value: 
      objectReference: {fileID: 8185893364261987117}
    - target: {fileID: 6693331190896711149, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_Name
      value: MANAGERS
      objectReference: {fileID: 0}
    - target: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: hudPanel
      value: 
      objectReference: {fileID: 666718699631651886}
    - target: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: pausePanel
      value: 
      objectReference: {fileID: 1966958504536888142}
    - target: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: startPanel
      value: 
      objectReference: {fileID: 7642672650237261223}
    - target: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: victoryPanel
      value: 
      objectReference: {fileID: 8325508708358241531}
    - target: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: gameOverPanel
      value: 
      objectReference: {fileID: 7266331233028832601}
    - target: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: tutorialPanel
      value: 
      objectReference: {fileID: 8436434638302926423}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalPosition.z
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalRotation.w
      value: 1
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalRotation.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalRotation.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalRotation.z
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.z
      value: 0
      objectReference: {fileID: 0}
    m_RemovedComponents: []
    m_RemovedGameObjects: []
    m_AddedGameObjects: []
    m_AddedComponents: []
  m_SourcePrefab: {fileID: 100100000, guid: 60c54aa9d09a64049a454c04ae79ad0d, type: 3}
--- !u!4 &1136409820151048644 stripped
Transform:
  m_CorrespondingSourceObject: {fileID: 8815279732122420054, guid: 60c54aa9d09a64049a454c04ae79ad0d,
    type: 3}
  m_PrefabInstance: {fileID: 8472252229947353746}
  m_PrefabAsset: {fileID: 0}
--- !u!114 &1511099843283945826 stripped
MonoBehaviour:
  m_CorrespondingSourceObject: {fileID: 7019983508723688432, guid: 60c54aa9d09a64049a454c04ae79ad0d,
    type: 3}
  m_PrefabInstance: {fileID: 8472252229947353746}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ea17dbf14b3da0f40b82371170ad3a9a, type: 3}
  m_Name: 
  m_EditorClassIdentifier:
```

## 📄 `Assets\Prefabs\Systems\MANAGERS.prefab`
- Lines: 857
- Size: 24.6 KB
- Modified: 2025-12-24 13:40

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &1368518852975210849
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6275914763428035753}
  - component: {fileID: 7019983508723688432}
  m_Layer: 0
  m_Name: GameSession
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6275914763428035753
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1368518852975210849}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &7019983508723688432
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1368518852975210849}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ea17dbf14b3da0f40b82371170ad3a9a, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  startPanel: {fileID: 0}
  tutorialPanel: {fileID: 0}
  hudPanel: {fileID: 0}
  gameOverPanel: {fileID: 0}
  victoryPanel: {fileID: 0}
  pausePanel: {fileID: 0}
  player: {fileID: 0}
  waveDirector: {fileID: 6844326632181159856}
--- !u!1 &3147607201140058673
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6691971610368475002}
  - component: {fileID: 8671062581810638425}
  - component: {fileID: 6844326632181159856}
  m_Layer: 0
  m_Name: WaveDirector
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6691971610368475002
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3147607201140058673}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 2448040589408023680}
  - {fileID: 7300687072882752754}
  - {fileID: 7994858786360697273}
  - {fileID: 7722525328346775040}
  - {fileID: 6742737530136546114}
  - {fileID: 1552766521367050216}
  - {fileID: 7933371094580013803}
  - {fileID: 3691519767671120281}
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &8671062581810638425
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3147607201140058673}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 683f2d9031bdaae4a8b5fb5f97a1c008, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  spawnPoints:
  - {fileID: 2448040589408023680}
  - {fileID: 7300687072882752754}
  - {fileID: 7994858786360697273}
  - {fileID: 7722525328346775040}
  - {fileID: 6742737530136546114}
  - {fileID: 1552766521367050216}
  - {fileID: 7933371094580013803}
  - {fileID: 3691519767671120281}
--- !u!114 &6844326632181159856
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3147607201140058673}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 40d19321d9712204293a987e3bb6c75e, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  waves:
  - {fileID: 11400000, guid: e4778bb864952b24cb2386e86432943c, type: 2}
  timeBetweenWaves: 3
--- !u!1 &3209927422991959027
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7300687072882752754}
  m_Layer: 0
  m_Name: NE
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7300687072882752754
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3209927422991959027}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: -25, y: 0.1, z: -25}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &3247163194831475538
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1320040776942931974}
  - component: {fileID: 7811597817190014660}
  m_Layer: 0
  m_Name: DamageTextManager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &1320040776942931974
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3247163194831475538}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &7811597817190014660
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3247163194831475538}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 032c3d8b1873835498fcc07b16c6fbfc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  textPrefab: {fileID: 3066595854704698543, guid: cd900abcfe87a174fab2d4512b65af2e,
    type: 3}
  offset: {x: 0, y: 2, z: 0}
  normalColor: {r: 1, g: 1, b: 1, a: 1}
  critColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  infoColor: {r: 0, g: 1, b: 1, a: 1}
--- !u!1 &3735631273208757610
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6742737530136546114}
  m_Layer: 0
  m_Name: S
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6742737530136546114
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3735631273208757610}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 25, y: 0.1, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &4184477018557271755
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5502514684090582437}
  - component: {fileID: 5286161135525202230}
  - component: {fileID: 8129776116882828951}
  m_Layer: 0
  m_Name: MusicManager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5502514684090582437
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4184477018557271755}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!82 &5286161135525202230
AudioSource:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4184477018557271755}
  m_Enabled: 1
  serializedVersion: 4
  OutputAudioMixerGroup: {fileID: 0}
  m_audioClip: {fileID: 8300000, guid: 25a78b93eb068a246b3e8e140aa96117, type: 3}
  m_PlayOnAwake: 1
  m_Volume: 1
  m_Pitch: 1
  Loop: 0
  Mute: 0
  Spatialize: 0
  SpatializePostEffects: 0
  Priority: 128
  DopplerLevel: 1
  MinDistance: 1
  MaxDistance: 500
  Pan2D: 0
  rolloffMode: 0
  BypassEffects: 0
  BypassListenerEffects: 0
  BypassReverbZones: 0
  rolloffCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    - serializedVersion: 3
      time: 1
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  panLevelCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  spreadCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  reverbZoneMixCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
--- !u!114 &8129776116882828951
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4184477018557271755}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4bf97d9429aec5a41a949b95cec52d49, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &4259792206303997456
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7994858786360697273}
  m_Layer: 0
  m_Name: E
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7994858786360697273
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4259792206303997456}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0.1, z: -25}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &4402944559388241927
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 671075306463093611}
  - component: {fileID: 1948609913512096065}
  m_Layer: 0
  m_Name: GameFeel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &671075306463093611
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4402944559388241927}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &1948609913512096065
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4402944559388241927}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ba0acfeec110aaa449205b4168d37281, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _sfxSource: {fileID: 0}
  _hitClip: {fileID: 8300000, guid: 40af9ab99400ae24d8a270be00a9267e, type: 3}
  _killClip: {fileID: 0}
  _playerHurtClip: {fileID: 8300000, guid: 5516b1d7366c26c47b482e7a14faf4c8, type: 3}
--- !u!1 &5088736669457896570
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 3691519767671120281}
  m_Layer: 0
  m_Name: NW
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &3691519767671120281
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5088736669457896570}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: -25, y: 0.1, z: 25}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &5323578971059811479
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1552766521367050216}
  m_Layer: 0
  m_Name: SW
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &1552766521367050216
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5323578971059811479}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 25, y: 0.1, z: 25}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &5849031987215573619
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7933371094580013803}
  m_Layer: 0
  m_Name: W
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7933371094580013803
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5849031987215573619}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0.1, z: 25}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &6352595394874491385
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5931125696805164646}
  - component: {fileID: 8495275787790726486}
  m_Layer: 0
  m_Name: ScoreManager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5931125696805164646
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6352595394874491385}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &8495275787790726486
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6352595394874491385}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: e2a12d9494428cb4c917d37f3c7c31e5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  baseScorePerKill: 100
  gloryKillBonus: 500
  currentMultiplier: 1
  maxMultiplier: 5
--- !u!1 &6693331190896711149
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8815279732122420054}
  m_Layer: 0
  m_Name: MANAGERS
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &8815279732122420054
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6693331190896711149}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 671075306463093611}
  - {fileID: 6275914763428035753}
  - {fileID: 6691971610368475002}
  - {fileID: 5502514684090582437}
  - {fileID: 2657369426726074030}
  - {fileID: 5931125696805164646}
  - {fileID: 1320040776942931974}
  - {fileID: 257073566971201233}
  - {fileID: 6317280149986970042}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &6770770805823434177
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6317280149986970042}
  - component: {fileID: 1525320784070361757}
  m_Layer: 0
  m_Name: PaletteManager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6317280149986970042
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6770770805823434177}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &1525320784070361757
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6770770805823434177}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0f4c1f22d2c2edf429a4df06c4e619d3, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  activePalette: {fileID: 11400000, guid: 253c73382724c81448699d784b933b68, type: 2}
  playerPrimaryCols: {fileID: 11400000, guid: 4a48fecfa6f40d546a691de1b3a319e8, type: 2}
  playerSecondaryCols: {fileID: 11400000, guid: 42b58d063cd4d28498b6832812f62242,
    type: 2}
  playerTertiaryCols: {fileID: 11400000, guid: 316488ef898c4da408965571ac1534e7, type: 2}
  enemyPrimaryCols: {fileID: 11400000, guid: a5ab19fb2b2b2d74497a9c5d67f872d5, type: 2}
  enemySecondaryCols: {fileID: 11400000, guid: 6aeec2b6cfc6b5b45b4f4aea63ea700a, type: 2}
  enemyTertiaryCols: {fileID: 11400000, guid: 395003987dc20114f91713ff6dd2225a, type: 2}
  floorCols: {fileID: 11400000, guid: e64a29004f9ed6d4994b85261337aacb, type: 2}
  wallCols: {fileID: 11400000, guid: 8342502258de9bb48b87f0298e3e2ff2, type: 2}
  hazardCols: {fileID: 11400000, guid: d6e557455fd9a074cbc5863e7c3da0fd, type: 2}
  projectileHostileCols: {fileID: 0}
  projectileFriendlyCols: {fileID: 0}
  refreshNow: 0
--- !u!1 &6874656309509601956
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7722525328346775040}
  m_Layer: 0
  m_Name: SE
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7722525328346775040
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6874656309509601956}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 25, y: 0.1, z: -25}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &7559586042655111151
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2657369426726074030}
  - component: {fileID: 5971834303583996767}
  m_Layer: 0
  m_Name: PoolManager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2657369426726074030
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7559586042655111151}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &5971834303583996767
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7559586042655111151}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 6efb7a95540a1014eb4cb411c880f8ab, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &8788039172466881072
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2448040589408023680}
  m_Layer: 0
  m_Name: N
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2448040589408023680
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8788039172466881072}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: -25, y: 0.1, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6691971610368475002}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &9077905985579951948
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 257073566971201233}
  - component: {fileID: 5385714611965903728}
  m_Layer: 0
  m_Name: VFXManager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &257073566971201233
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9077905985579951948}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8815279732122420054}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &5385714611965903728
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9077905985579951948}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: bd60cc8ae935a1b4caaa8aed0fb4d5da, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  explosionPrefab: {fileID: 648059833510886341, guid: 68f25ab6f4dbf344187bc8a7231afda4,
    type: 3}
  spawnPrefab: {fileID: 823617336625923824, guid: e803ad9022950d94a8887bcbf94af167,
    type: 3}
```

## 📄 `Assets\Prefabs\Trasversal\[VOID].prefab`
- Lines: 153
- Size: 4.2 KB
- Modified: 2025-12-19 07:48

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &2956211211395336478
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6310636785882530999}
  - component: {fileID: 2630924700769678948}
  - component: {fileID: 3811133233679157356}
  m_Layer: 0
  m_Name: '[VOID]'
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6310636785882530999
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2956211211395336478}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: -25, z: 0}
  m_LocalScale: {x: 20, y: 5, z: 20}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6330797266930909869}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!65 &2630924700769678948
BoxCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2956211211395336478}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Size: {x: 7, y: 1, z: 7}
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &3811133233679157356
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2956211211395336478}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: cc7f7ce365b7e1845adb79da536367ab, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &7669706235691237459
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6330797266930909869}
  - component: {fileID: 7556818841533536482}
  - component: {fileID: 5967584312878974349}
  m_Layer: 0
  m_Name: Visual_Hazard
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6330797266930909869
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7669706235691237459}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6310636785882530999}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &7556818841533536482
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7669706235691237459}
  m_Mesh: {fileID: 10209, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &5967584312878974349
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7669706235691237459}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 31321ba15b8f8eb4c954353edc038b1d, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
```

## 📄 `Assets\Prefabs\Trasversal\Anchor.prefab`
- Lines: 132
- Size: 3.6 KB
- Modified: 2025-12-19 07:39

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &6042327649744245293
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2195855926670066499}
  - component: {fileID: 4720043074774516620}
  - component: {fileID: 8876131734462160885}
  - component: {fileID: 2506214670472289537}
  - component: {fileID: 6137953672136972031}
  m_Layer: 7
  m_Name: Anchor
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2195855926670066499
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6042327649744245293}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &4720043074774516620
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6042327649744245293}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &8876131734462160885
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6042327649744245293}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 963055f58ce378b47ba813ef87c37448, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!135 &2506214670472289537
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6042327649744245293}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &6137953672136972031
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6042327649744245293}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 1ceae2df6c08c934bbced6c18fe38dc9, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  health: 10
  isImmortal: 1
  maxStagger: 0.1
  staggerDecay: 1
  staggerDuration: 3
  refillFocus: 1
  healGrit: 0
  meshRenderer: {fileID: 0}
  normalColor: {r: 0, g: 1, b: 1, a: 1}
  staggerColor: {r: 1, g: 0.92156863, b: 0.015686275, a: 1}
  flashColor: {r: 1, g: 1, b: 1, a: 1}
```

## 📄 `Assets\Prefabs\UI\PF_FloatingText.prefab`
- Lines: 224
- Size: 6.4 KB
- Modified: 2025-12-11 07:51

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &3066595854704698543
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2724029378831916949}
  - component: {fileID: 4915023236430385442}
  m_Layer: 0
  m_Name: PF_FloatingText
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2724029378831916949
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3066595854704698543}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 19.403263, y: 0.6554531, z: 13.005305}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 342485356384100710}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &4915023236430385442
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3066595854704698543}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 6571c3aba2252f0419f005a3bbf73346, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  textMesh: {fileID: 2011547563755599568}
  floatDistance: 2
  duration: 0.8
  motionEase: 9
--- !u!1 &9128482357710464929
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 342485356384100710}
  - component: {fileID: 8194810121028410458}
  - component: {fileID: 2011547563755599568}
  m_Layer: 2
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &342485356384100710
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9128482357710464929}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 2724029378831916949}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 20, y: 5}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!23 &8194810121028410458
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9128482357710464929}
  m_Enabled: 1
  m_CastShadows: 0
  m_ReceiveShadows: 0
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!114 &2011547563755599568
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9128482357710464929}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 9541d86e2fd84c1d9990edf0852d74ab, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: Sample text
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 6
  m_fontSizeBase: 6
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 0
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 0
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  _SortingLayer: 0
  _SortingLayerID: 0
  _SortingOrder: 0
  m_hasFontAssetChanged: 0
  m_renderer: {fileID: 8194810121028410458}
  m_maskType: 0
```

## 📄 `Assets\Prefabs\UI\UI_HUD.prefab`
- Lines: 6867
- Size: 197.6 KB
- Modified: 2025-12-14 08:22

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &143172990346197262
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 308419519671609423}
  - component: {fileID: 4293227513746982935}
  - component: {fileID: 4721229484255753171}
  - component: {fileID: 3394127235468340535}
  - component: {fileID: 1221364554333909950}
  m_Layer: 5
  m_Name: ResumeButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &308419519671609423
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 143172990346197262}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 8113142717665356081}
  m_Father: {fileID: 7215703031330175144}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -83.33333}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &4293227513746982935
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 143172990346197262}
  m_CullTransparentMesh: 1
--- !u!114 &4721229484255753171
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 143172990346197262}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &3394127235468340535
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 143172990346197262}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 4721229484255753171}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: TogglePause
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!114 &1221364554333909950
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 143172990346197262}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 306cc8c2b49d7114eaa3623786fc2126, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_IgnoreLayout: 0
  m_MinWidth: -1
  m_MinHeight: -1
  m_PreferredWidth: -1
  m_PreferredHeight: 65
  m_FlexibleWidth: -1
  m_FlexibleHeight: -1
  m_LayoutPriority: 1
--- !u!1 &286126770276253398
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2136450115634583766}
  - component: {fileID: 5895776217789415062}
  - component: {fileID: 1473828227356180873}
  m_Layer: 5
  m_Name: Value_Score
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &2136450115634583766
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 286126770276253398}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4673176090307018577}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 300, y: -350}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5895776217789415062
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 286126770276253398}
  m_CullTransparentMesh: 1
--- !u!114 &1473828227356180873
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 286126770276253398}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 000.000
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4285267964
  m_fontColor: {r: 0.98678637, g: 1, b: 0.4198113, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &380025226013883302
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4063324330081979967}
  - component: {fileID: 639244134285980254}
  - component: {fileID: 171772619049025155}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4063324330081979967
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 380025226013883302}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6145309485915468302}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 500, y: 64}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &639244134285980254
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 380025226013883302}
  m_CullTransparentMesh: 1
--- !u!114 &171772619049025155
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 380025226013883302}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'EXIT SIMULATION

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &447752907211986475
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4621406102330463814}
  - component: {fileID: 5710106401436973961}
  - component: {fileID: 830741963229645557}
  - component: {fileID: 2866883596114137020}
  m_Layer: 5
  m_Name: ButtonContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4621406102330463814
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 447752907211986475}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6188309420248731905}
  - {fileID: 1377503145063931568}
  - {fileID: 6145309485915468302}
  m_Father: {fileID: 2772274479977780061}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 1920, y: 500}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5710106401436973961
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 447752907211986475}
  m_CullTransparentMesh: 1
--- !u!114 &830741963229645557
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 447752907211986475}
  m_Enabled: 0
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 0.392}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &2866883596114137020
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 447752907211986475}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 59f8146938fff824cb5fd77236b75775, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Padding:
    m_Left: 0
    m_Right: 0
    m_Top: 0
    m_Bottom: 0
  m_ChildAlignment: 4
  m_Spacing: 0
  m_ChildForceExpandWidth: 1
  m_ChildForceExpandHeight: 1
  m_ChildControlWidth: 0
  m_ChildControlHeight: 0
  m_ChildScaleWidth: 0
  m_ChildScaleHeight: 0
  m_ReverseArrangement: 0
--- !u!1 &794312740175006923
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 3128880439868124835}
  - component: {fileID: 576358403851334661}
  - component: {fileID: 8628415233252360989}
  - component: {fileID: 1902584077792702905}
  m_Layer: 5
  m_Name: ExitButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &3128880439868124835
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 794312740175006923}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 731256735620084907}
  m_Father: {fileID: 7215703031330175144}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -416.66663}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &576358403851334661
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 794312740175006923}
  m_CullTransparentMesh: 1
--- !u!114 &8628415233252360989
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 794312740175006923}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &1902584077792702905
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 794312740175006923}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 8628415233252360989}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: QuitGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &855704869751846257
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1272697595678758692}
  - component: {fileID: 8320655732627130337}
  - component: {fileID: 2027129022962530755}
  m_Layer: 5
  m_Name: Label_Score
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1272697595678758692
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 855704869751846257}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4673176090307018577}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: -250, y: -350}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &8320655732627130337
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 855704869751846257}
  m_CullTransparentMesh: 1
--- !u!114 &2027129022962530755
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 855704869751846257}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'FINAL SCORE:'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 4
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &939373153805484079
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2980065583416820200}
  - component: {fileID: 3878180351411057817}
  - component: {fileID: 540965663960617009}
  - component: {fileID: 116000915692159342}
  m_Layer: 5
  m_Name: Btn_Exit
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &2980065583416820200
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 939373153805484079}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4715614023149022726}
  m_Father: {fileID: 6275334821920857403}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -262.5}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &3878180351411057817
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 939373153805484079}
  m_CullTransparentMesh: 1
--- !u!114 &540965663960617009
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 939373153805484079}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &116000915692159342
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 939373153805484079}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 540965663960617009}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: QuitGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &1083738603315472114
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4449692518664434050}
  - component: {fileID: 7508236094750697983}
  - component: {fileID: 227204120828428217}
  m_Layer: 5
  m_Name: PausePanel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!224 &4449692518664434050
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1083738603315472114}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7215703031330175144}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &7508236094750697983
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1083738603315472114}
  m_CullTransparentMesh: 1
--- !u!114 &227204120828428217
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1083738603315472114}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 0.78431374}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &1305884057319415933
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6741502265826391643}
  - component: {fileID: 5654108022229182462}
  - component: {fileID: 3092976856187267895}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6741502265826391643
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1305884057319415933}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6468138990412374915}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5654108022229182462
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1305884057319415933}
  m_CullTransparentMesh: 1
--- !u!114 &3092976856187267895
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1305884057319415933}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'REBOOT

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &1656931790545923239
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7249388929309597070}
  - component: {fileID: 8685971108149982942}
  - component: {fileID: 8814143133066075484}
  m_Layer: 5
  m_Name: Value_Time
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &7249388929309597070
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1656931790545923239}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4673176090307018577}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 300, y: -300}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &8685971108149982942
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1656931790545923239}
  m_CullTransparentMesh: 1
--- !u!114 &8814143133066075484
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1656931790545923239}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 00:00
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4285267964
  m_fontColor: {r: 0.98678637, g: 1, b: 0.4198113, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &1697804422465653133
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4594955223132608138}
  - component: {fileID: 6351216192688052957}
  - component: {fileID: 2532111939171961731}
  m_Layer: 5
  m_Name: Label_Rank
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4594955223132608138
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1697804422465653133}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4673176090307018577}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: -250, y: -400}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6351216192688052957
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1697804422465653133}
  m_CullTransparentMesh: 1
--- !u!114 &2532111939171961731
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1697804422465653133}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'RANK:'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 4
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &1782089042543945440
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6275334821920857403}
  - component: {fileID: 7034664339765140687}
  - component: {fileID: 7018060505646052613}
  - component: {fileID: 4842170119546461075}
  m_Layer: 5
  m_Name: ButtonContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6275334821920857403
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1782089042543945440}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6468138990412374915}
  - {fileID: 2980065583416820200}
  m_Father: {fileID: 357821462121774746}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 1920, y: 350}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &7034664339765140687
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1782089042543945440}
  m_CullTransparentMesh: 1
--- !u!114 &7018060505646052613
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1782089042543945440}
  m_Enabled: 0
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.99215686, g: 0.043137256, b: 0.043137256, a: 0.78431374}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &4842170119546461075
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1782089042543945440}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 59f8146938fff824cb5fd77236b75775, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Padding:
    m_Left: 0
    m_Right: 0
    m_Top: 0
    m_Bottom: 0
  m_ChildAlignment: 4
  m_Spacing: 0
  m_ChildForceExpandWidth: 1
  m_ChildForceExpandHeight: 1
  m_ChildControlWidth: 0
  m_ChildControlHeight: 0
  m_ChildScaleWidth: 0
  m_ChildScaleHeight: 0
  m_ReverseArrangement: 0
--- !u!1 &1984939127924955271
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 306406388369157420}
  - component: {fileID: 4851065545286415723}
  - component: {fileID: 5251085895114163897}
  m_Layer: 5
  m_Name: Tutorial_Text
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &306406388369157420
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1984939127924955271}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5992629754528979461}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 15, y: -15}
  m_SizeDelta: {x: 950, y: 650}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &4851065545286415723
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1984939127924955271}
  m_CullTransparentMesh: 1
--- !u!114 &5251085895114163897
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1984939127924955271}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: '<color=yellow>WASD / L-STICK</color> :: LOCOMOTION

    <color=yellow>L-CLICK
    / RT</color>   :: PRIMARY FIRE (BUILD STAGGER)

    <color=yellow>SPACE / RB</color>    
    :: KINETIC DASH (COSTS FOCUS)

    <color=yellow>E KEY / LB</color>     :: EXECUTE
    STAGGERED TARGET (REFILLS FOCUS)



    // TIP //

    AGGRESSION IS FUEL.

    STAGGER
    ENEMIES TO OPEN EXECUTION WINDOWS.'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 17.611084}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &2091523788175989138
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5579059785840851497}
  m_Layer: 5
  m_Name: HUD_Group
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &5579059785840851497
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2091523788175989138}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 8830797574682811436}
  - {fileID: 1266481494037411217}
  - {fileID: 4973795791505662065}
  - {fileID: 5553600547898064283}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 1}
--- !u!1 &2359946657455363315
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 3738802299605300385}
  - component: {fileID: 5824122627947636934}
  - component: {fileID: 1379724484742638253}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &3738802299605300385
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2359946657455363315}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 2905910993038880999}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5824122627947636934
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2359946657455363315}
  m_CullTransparentMesh: 1
--- !u!114 &1379724484742638253
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2359946657455363315}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: RESTART
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &2422680922202056092
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6188309420248731905}
  - component: {fileID: 33919701806584721}
  - component: {fileID: 8493357951812814240}
  - component: {fileID: 6601267033874888592}
  - component: {fileID: 7637762612155453281}
  m_Layer: 5
  m_Name: StartButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6188309420248731905
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2422680922202056092}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 769720090105793255}
  m_Father: {fileID: 4621406102330463814}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -83.33333}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &33919701806584721
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2422680922202056092}
  m_CullTransparentMesh: 1
--- !u!114 &8493357951812814240
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2422680922202056092}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &6601267033874888592
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2422680922202056092}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 8493357951812814240}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: BeginGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!114 &7637762612155453281
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2422680922202056092}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 306cc8c2b49d7114eaa3623786fc2126, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_IgnoreLayout: 0
  m_MinWidth: -1
  m_MinHeight: -1
  m_PreferredWidth: -1
  m_PreferredHeight: 65
  m_FlexibleWidth: -1
  m_FlexibleHeight: -1
  m_LayoutPriority: 1
--- !u!1 &2448759117621286344
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6145309485915468302}
  - component: {fileID: 7700758047555696365}
  - component: {fileID: 6684971141968286222}
  - component: {fileID: 5499693873365596550}
  m_Layer: 5
  m_Name: Btn_Exit
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6145309485915468302
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2448759117621286344}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4063324330081979967}
  m_Father: {fileID: 4621406102330463814}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -416.66663}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &7700758047555696365
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2448759117621286344}
  m_CullTransparentMesh: 1
--- !u!114 &6684971141968286222
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2448759117621286344}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &5499693873365596550
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2448759117621286344}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 6684971141968286222}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: QuitGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &2769672630800186857
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6725254738931999090}
  - component: {fileID: 7622947696633451874}
  - component: {fileID: 7930549607438389526}
  m_Layer: 5
  m_Name: Fill
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6725254738931999090
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2769672630800186857}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 1078007717861629156}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 10, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &7622947696633451874
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2769672630800186857}
  m_CullTransparentMesh: 1
--- !u!114 &7930549607438389526
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2769672630800186857}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.087931626, g: 0.9811321, b: 0.96399045, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &2878496905638879129
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 9100246156042717090}
  - component: {fileID: 8369228677265454436}
  - component: {fileID: 5882383119049004427}
  - component: {fileID: 2827169724145638713}
  m_Layer: 5
  m_Name: UI_HUD
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &9100246156042717090
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2878496905638879129}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 0, y: 0, z: 0}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 5717701635820235937}
  - {fileID: 2772274479977780061}
  - {fileID: 4449692518664434050}
  - {fileID: 357821462121774746}
  - {fileID: 8853477456087505937}
  - {fileID: 5992629754528979461}
  - {fileID: 5579059785840851497}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0, y: 0}
--- !u!223 &8369228677265454436
Canvas:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2878496905638879129}
  m_Enabled: 1
  serializedVersion: 3
  m_RenderMode: 0
  m_Camera: {fileID: 0}
  m_PlaneDistance: 100
  m_PixelPerfect: 0
  m_ReceivesEvents: 1
  m_OverrideSorting: 0
  m_OverridePixelPerfect: 0
  m_SortingBucketNormalizedSize: 0
  m_VertexColorAlwaysGammaSpace: 0
  m_AdditionalShaderChannelsFlag: 25
  m_UpdateRectTransformForStandalone: 0
  m_SortingLayerID: 0
  m_SortingOrder: 0
  m_TargetDisplay: 0
--- !u!114 &5882383119049004427
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2878496905638879129}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0cd44c1031e13a943bb63640046fad76, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_UiScaleMode: 1
  m_ReferencePixelsPerUnit: 100
  m_ScaleFactor: 1
  m_ReferenceResolution: {x: 1920, y: 1980}
  m_ScreenMatchMode: 0
  m_MatchWidthOrHeight: 0.5
  m_PhysicalUnit: 3
  m_FallbackScreenDPI: 96
  m_DefaultSpriteDPI: 96
  m_DynamicPixelsPerUnit: 1
  m_PresetInfoIsWorld: 0
--- !u!114 &2827169724145638713
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2878496905638879129}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: dc42784cf147c0c48a680349fa168899, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_IgnoreReversedGraphics: 1
  m_BlockingObjects: 0
  m_BlockingMask:
    serializedVersion: 2
    m_Bits: 4294967295
--- !u!1 &3301578897406102130
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7318578176455424969}
  - component: {fileID: 5593233688280792947}
  - component: {fileID: 4912566189463412379}
  - component: {fileID: 5656959328185902210}
  - component: {fileID: 4230208116798315290}
  m_Layer: 5
  m_Name: RestartButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &7318578176455424969
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3301578897406102130}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 3161500253399534495}
  m_Father: {fileID: 4735050686387023062}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -62.5}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5593233688280792947
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3301578897406102130}
  m_CullTransparentMesh: 1
--- !u!114 &4912566189463412379
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3301578897406102130}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &5656959328185902210
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3301578897406102130}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 4912566189463412379}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: RestartGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!114 &4230208116798315290
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3301578897406102130}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 306cc8c2b49d7114eaa3623786fc2126, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_IgnoreLayout: 0
  m_MinWidth: -1
  m_MinHeight: -1
  m_PreferredWidth: -1
  m_PreferredHeight: 65
  m_FlexibleWidth: -1
  m_FlexibleHeight: -1
  m_LayoutPriority: 1
--- !u!1 &3302696979535306383
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4775706684721051821}
  - component: {fileID: 6320906014375114198}
  - component: {fileID: 2494302043925613599}
  - component: {fileID: 6271382998069292833}
  m_Layer: 5
  m_Name: Btn_Exit
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4775706684721051821
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3302696979535306383}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 1005602206469311511}
  m_Father: {fileID: 4735050686387023062}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -187.5}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6320906014375114198
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3302696979535306383}
  m_CullTransparentMesh: 1
--- !u!114 &2494302043925613599
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3302696979535306383}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &6271382998069292833
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3302696979535306383}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 2494302043925613599}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: QuitGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &3358508044326171288
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2905910993038880999}
  - component: {fileID: 34627404037504794}
  - component: {fileID: 7768902606471005976}
  - component: {fileID: 1846926581866888574}
  m_Layer: 5
  m_Name: RestartButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &2905910993038880999
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3358508044326171288}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 3738802299605300385}
  m_Father: {fileID: 7215703031330175144}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -249.99998}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &34627404037504794
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3358508044326171288}
  m_CullTransparentMesh: 1
--- !u!114 &7768902606471005976
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3358508044326171288}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &1846926581866888574
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3358508044326171288}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 7768902606471005976}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: RestartGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &3445356057079609888
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 770043533993339775}
  - component: {fileID: 2067569536690056457}
  - component: {fileID: 7574580421335220546}
  m_Layer: 5
  m_Name: Text_Title
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &770043533993339775
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3445356057079609888}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 357821462121774746}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 0, y: -250}
  m_SizeDelta: {x: 750, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &2067569536690056457
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3445356057079609888}
  m_CullTransparentMesh: 1
--- !u!114 &7574580421335220546
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3445356057079609888}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: SYSTEM FAILURE
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 75
  m_fontSizeBase: 75
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &3577896108135813833
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5220295483703296410}
  - component: {fileID: 1770985991995189166}
  - component: {fileID: 3091016849707128618}
  m_Layer: 5
  m_Name: Text_Score
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &5220295483703296410
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3577896108135813833}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5553600547898064283}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 300, y: 60}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &1770985991995189166
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3577896108135813833}
  m_CullTransparentMesh: 1
--- !u!114 &3091016849707128618
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3577896108135813833}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 0
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4282335039
  m_fontColor: {r: 0.24528301, g: 0.24528301, b: 0.24528301, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 60
  m_fontSizeBase: 60
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &3614710227554066521
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4708545115416955086}
  - component: {fileID: 2253110411760995373}
  - component: {fileID: 9072020889798474154}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4708545115416955086
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3614710227554066521}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 1377503145063931568}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &2253110411760995373
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3614710227554066521}
  m_CullTransparentMesh: 1
--- !u!114 &9072020889798474154
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3614710227554066521}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'HOW TO PLAY

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &3717739823171339186
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4973795791505662065}
  - component: {fileID: 5966558725732765049}
  - component: {fileID: 6871615302588454282}
  m_Layer: 5
  m_Name: GritContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4973795791505662065
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3717739823171339186}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4181762744011268293}
  - {fileID: 1721542208996667898}
  - {fileID: 714350303644832287}
  m_Father: {fileID: 5579059785840851497}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 150, y: -100}
  m_SizeDelta: {x: 200, y: 1080}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5966558725732765049
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3717739823171339186}
  m_CullTransparentMesh: 1
--- !u!114 &6871615302588454282
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3717739823171339186}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 30649d3a9faa99c48a7b1166b86bf2a0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Padding:
    m_Left: 0
    m_Right: 0
    m_Top: 0
    m_Bottom: 0
  m_ChildAlignment: 4
  m_Spacing: 5
  m_ChildForceExpandWidth: 1
  m_ChildForceExpandHeight: 1
  m_ChildControlWidth: 0
  m_ChildControlHeight: 0
  m_ChildScaleWidth: 0
  m_ChildScaleHeight: 0
  m_ReverseArrangement: 0
--- !u!1 &3752786560504383486
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4673176090307018577}
  m_Layer: 5
  m_Name: StatsContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4673176090307018577
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3752786560504383486}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 1272697595678758692}
  - {fileID: 2136450115634583766}
  - {fileID: 7249388929309597070}
  - {fileID: 7124175928308969463}
  - {fileID: 1327972982294030153}
  - {fileID: 4594955223132608138}
  m_Father: {fileID: 8853477456087505937}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 0, y: -50}
  m_SizeDelta: {x: 100, y: 100}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!1 &3966172095664506390
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8745827455391631090}
  - component: {fileID: 4868421760891598097}
  - component: {fileID: 3521746167150303818}
  m_Layer: 5
  m_Name: Text_Multipliyer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &8745827455391631090
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3966172095664506390}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5553600547898064283}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 300, y: 60}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &4868421760891598097
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3966172095664506390}
  m_CullTransparentMesh: 1
--- !u!114 &3521746167150303818
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 3966172095664506390}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 0
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4282335039
  m_fontColor: {r: 0.24528301, g: 0.24528301, b: 0.24528301, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 60
  m_fontSizeBase: 60
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &4010531743183429921
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6035359685227545228}
  - component: {fileID: 6675033302787532543}
  - component: {fileID: 633657714906244717}
  m_Layer: 5
  m_Name: Text_Countdown
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6035359685227545228
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4010531743183429921}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5717701635820235937}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: -100}
  m_SizeDelta: {x: 750, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6675033302787532543
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4010531743183429921}
  m_CullTransparentMesh: 1
--- !u!114 &633657714906244717
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4010531743183429921}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 3
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4280032497
  m_fontColor: {r: 0.9433962, g: 0.11124954, b: 0.11124954, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 150
  m_fontSizeBase: 150
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &4014953299153213275
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8113142717665356081}
  - component: {fileID: 1365420202899102901}
  - component: {fileID: 7471291093399176192}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &8113142717665356081
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4014953299153213275}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 308419519671609423}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &1365420202899102901
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4014953299153213275}
  m_CullTransparentMesh: 1
--- !u!114 &7471291093399176192
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4014953299153213275}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'RESUME

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &4622929055684298775
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 769720090105793255}
  - component: {fileID: 6290212069515484879}
  - component: {fileID: 607541999711020847}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &769720090105793255
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4622929055684298775}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 6188309420248731905}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6290212069515484879
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4622929055684298775}
  m_CullTransparentMesh: 1
--- !u!114 &607541999711020847
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4622929055684298775}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'INIZIALIZE

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &4742413701259148626
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8830797574682811436}
  - component: {fileID: 1201445226315778228}
  m_Layer: 5
  m_Name: HUD_Logic
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &8830797574682811436
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4742413701259148626}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5579059785840851497}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!114 &1201445226315778228
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4742413701259148626}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 21adf0054dcd0004299c15a70482c9bb, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  focusSlider: {fileID: 2996418842784881643}
  focusFillImage: {fileID: 7930549607438389526}
  normalFocusColor: {r: 0, g: 1, b: 1, a: 1}
  overheatFocusColor: {r: 1, g: 0, b: 0, a: 1}
  gritPips:
  - {fileID: 5039610156567572659}
  - {fileID: 5971414507758737080}
  activePipColor: {r: 1, g: 1, b: 1, a: 1}
  inactivePipColor: {r: 0.7075472, g: 0.7075472, b: 0.7075472, a: 0.2}
  hullIcon: {fileID: 3593251430110007768}
  hullActiveColor: {r: 0, g: 1, b: 1, a: 1}
  hullBrokenColor: {r: 1, g: 0, b: 0, a: 0.3}
  waveText: {fileID: 0}
  scoreText: {fileID: 3091016849707128618}
  multiplierText: {fileID: 3521746167150303818}
  timerText: {fileID: 6141133899994567541}
--- !u!1 &4961448130302107982
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7074924799353168232}
  - component: {fileID: 6842697942112591304}
  - component: {fileID: 3696503811696863374}
  - component: {fileID: 5206918507631830745}
  m_Layer: 5
  m_Name: ReturnButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &7074924799353168232
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4961448130302107982}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 5}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 1634997278929890482}
  m_Father: {fileID: 5992629754528979461}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0}
  m_AnchorMax: {x: 0.5, y: 0}
  m_AnchoredPosition: {x: 0, y: 150}
  m_SizeDelta: {x: 260, y: 60}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6842697942112591304
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4961448130302107982}
  m_CullTransparentMesh: 1
--- !u!114 &3696503811696863374
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4961448130302107982}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &5206918507631830745
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4961448130302107982}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 3696503811696863374}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: BackToMenu
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &5002720277259120514
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 3161500253399534495}
  - component: {fileID: 6725049156280700555}
  - component: {fileID: 7311257640200291419}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &3161500253399534495
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5002720277259120514}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7318578176455424969}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6725049156280700555
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5002720277259120514}
  m_CullTransparentMesh: 1
--- !u!114 &7311257640200291419
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5002720277259120514}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'NEW SIMULATION

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &5039610156567572659
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1721542208996667898}
  - component: {fileID: 8489409063572400444}
  - component: {fileID: 2192172772243280158}
  m_Layer: 5
  m_Name: Pip_1
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1721542208996667898
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5039610156567572659}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4973795791505662065}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 50, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &8489409063572400444
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5039610156567572659}
  m_CullTransparentMesh: 1
--- !u!114 &2192172772243280158
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5039610156567572659}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 0}
  m_Type: 0
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &5563965678619931982
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4715614023149022726}
  - component: {fileID: 6298892476251308540}
  - component: {fileID: 6757536219278328140}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4715614023149022726
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5563965678619931982}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 2980065583416820200}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 500, y: 64}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6298892476251308540
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5563965678619931982}
  m_CullTransparentMesh: 1
--- !u!114 &6757536219278328140
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5563965678619931982}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'EXIT SIMULATION

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &5593122351266009793
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6468138990412374915}
  - component: {fileID: 4807737007562670998}
  - component: {fileID: 2860661511176592253}
  - component: {fileID: 8219719943515876693}
  - component: {fileID: 4466518251625933777}
  m_Layer: 5
  m_Name: RestartButton
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6468138990412374915
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5593122351266009793}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6741502265826391643}
  m_Father: {fileID: 6275334821920857403}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -87.5}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &4807737007562670998
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5593122351266009793}
  m_CullTransparentMesh: 1
--- !u!114 &2860661511176592253
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5593122351266009793}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &8219719943515876693
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5593122351266009793}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 2860661511176592253}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: RestartGame
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!114 &4466518251625933777
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5593122351266009793}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 306cc8c2b49d7114eaa3623786fc2126, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_IgnoreLayout: 0
  m_MinWidth: -1
  m_MinHeight: -1
  m_PreferredWidth: -1
  m_PreferredHeight: 65
  m_FlexibleWidth: -1
  m_FlexibleHeight: -1
  m_LayoutPriority: 1
--- !u!1 &5971414507758737080
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 714350303644832287}
  - component: {fileID: 8206158053423779290}
  - component: {fileID: 7821774073840358205}
  m_Layer: 5
  m_Name: Pip_2
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &714350303644832287
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5971414507758737080}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4973795791505662065}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 50, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &8206158053423779290
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5971414507758737080}
  m_CullTransparentMesh: 1
--- !u!114 &7821774073840358205
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5971414507758737080}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 0}
  m_Type: 0
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &6139726102376973083
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7215703031330175144}
  - component: {fileID: 6558605503500687771}
  - component: {fileID: 4337748724675174306}
  - component: {fileID: 8535084903404496676}
  m_Layer: 5
  m_Name: ButtonContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &7215703031330175144
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6139726102376973083}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 308419519671609423}
  - {fileID: 2905910993038880999}
  - {fileID: 3128880439868124835}
  m_Father: {fileID: 4449692518664434050}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 1920, y: 500}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &6558605503500687771
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6139726102376973083}
  m_CullTransparentMesh: 1
--- !u!114 &4337748724675174306
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6139726102376973083}
  m_Enabled: 0
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 0.392}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &8535084903404496676
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6139726102376973083}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 59f8146938fff824cb5fd77236b75775, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Padding:
    m_Left: 0
    m_Right: 0
    m_Top: 0
    m_Bottom: 0
  m_ChildAlignment: 4
  m_Spacing: 0
  m_ChildForceExpandWidth: 1
  m_ChildForceExpandHeight: 1
  m_ChildControlWidth: 0
  m_ChildControlHeight: 0
  m_ChildScaleWidth: 0
  m_ChildScaleHeight: 0
  m_ReverseArrangement: 0
--- !u!1 &6407533725428197721
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 267414015062073244}
  - component: {fileID: 2197917488271300584}
  - component: {fileID: 6141133899994567541}
  m_Layer: 5
  m_Name: Text_Timer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &267414015062073244
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6407533725428197721}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5553600547898064283}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 300, y: 60}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &2197917488271300584
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6407533725428197721}
  m_CullTransparentMesh: 1
--- !u!114 &6141133899994567541
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6407533725428197721}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 0
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4282335039
  m_fontColor: {r: 0.24528301, g: 0.24528301, b: 0.24528301, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 60
  m_fontSizeBase: 60
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &6540804886874774306
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1634997278929890482}
  - component: {fileID: 4419978528322512769}
  - component: {fileID: 2606217852238001680}
  m_Layer: 5
  m_Name: Text_Return
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1634997278929890482
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6540804886874774306}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7074924799353168232}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &4419978528322512769
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6540804886874774306}
  m_CullTransparentMesh: 1
--- !u!114 &2606217852238001680
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6540804886874774306}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'RETURN

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &6574467364115598284
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7124175928308969463}
  - component: {fileID: 5678481314642963674}
  - component: {fileID: 9049357053158017366}
  m_Layer: 5
  m_Name: Label_Time
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &7124175928308969463
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6574467364115598284}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4673176090307018577}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: -250, y: -300}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5678481314642963674
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6574467364115598284}
  m_CullTransparentMesh: 1
--- !u!114 &9049357053158017366
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6574467364115598284}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'TIME:'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 4
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &6662530465528975535
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5553600547898064283}
  - component: {fileID: 8458559505704225318}
  m_Layer: 5
  m_Name: ScoreContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &5553600547898064283
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6662530465528975535}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 5220295483703296410}
  - {fileID: 8745827455391631090}
  - {fileID: 267414015062073244}
  m_Father: {fileID: 5579059785840851497}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 1, y: 1}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: -50, y: -100}
  m_SizeDelta: {x: 100, y: 100}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!114 &8458559505704225318
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6662530465528975535}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 59f8146938fff824cb5fd77236b75775, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Padding:
    m_Left: 0
    m_Right: 0
    m_Top: 0
    m_Bottom: 0
  m_ChildAlignment: 5
  m_Spacing: 0
  m_ChildForceExpandWidth: 1
  m_ChildForceExpandHeight: 1
  m_ChildControlWidth: 0
  m_ChildControlHeight: 0
  m_ChildScaleWidth: 0
  m_ChildScaleHeight: 0
  m_ReverseArrangement: 0
--- !u!1 &6682878239681197289
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1005602206469311511}
  - component: {fileID: 5429077590711960445}
  - component: {fileID: 6142867805569180210}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1005602206469311511
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6682878239681197289}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4775706684721051821}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 500, y: 64}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5429077590711960445
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6682878239681197289}
  m_CullTransparentMesh: 1
--- !u!114 &6142867805569180210
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6682878239681197289}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'EXIT SIMULATION

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &6777211595231053456
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1377503145063931568}
  - component: {fileID: 5452391761019114375}
  - component: {fileID: 5635993946567701189}
  - component: {fileID: 3526816204144016603}
  m_Layer: 5
  m_Name: Btn_Tutorial
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1377503145063931568
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6777211595231053456}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4708545115416955086}
  m_Father: {fileID: 4621406102330463814}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 1}
  m_AnchorMax: {x: 0, y: 1}
  m_AnchoredPosition: {x: 960, y: -249.99998}
  m_SizeDelta: {x: 500, y: 65}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &5452391761019114375
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6777211595231053456}
  m_CullTransparentMesh: 1
--- !u!114 &5635993946567701189
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6777211595231053456}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &3526816204144016603
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 6777211595231053456}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: 5635993946567701189}
  m_OnClick:
    m_PersistentCalls:
      m_Calls:
      - m_Target: {fileID: 0}
        m_TargetAssemblyTypeName: DarkTowerTron.Managers.GameSession, Assembly-CSharp
        m_MethodName: OpenTutorial
        m_Mode: 1
        m_Arguments:
          m_ObjectArgument: {fileID: 0}
          m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
          m_IntArgument: 0
          m_FloatArgument: 0
          m_StringArgument: 
          m_BoolArgument: 0
        m_CallState: 2
--- !u!1 &7012667882563511275
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5992629754528979461}
  - component: {fileID: 352714111140808926}
  - component: {fileID: 2186483720015554089}
  m_Layer: 5
  m_Name: TutorialPanel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!224 &5992629754528979461
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7012667882563511275}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7074924799353168232}
  - {fileID: 1093791948572703840}
  - {fileID: 306406388369157420}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &352714111140808926
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7012667882563511275}
  m_CullTransparentMesh: 1
--- !u!114 &2186483720015554089
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7012667882563511275}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0, g: 0, b: 0, a: 0.9411765}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &7065851367010980082
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4735050686387023062}
  - component: {fileID: 468315035632938553}
  - component: {fileID: 5115876343839804407}
  - component: {fileID: 2149389061025176540}
  m_Layer: 5
  m_Name: ButtonContainer
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4735050686387023062
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7065851367010980082}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7318578176455424969}
  - {fileID: 4775706684721051821}
  m_Father: {fileID: 8853477456087505937}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: -100}
  m_SizeDelta: {x: 1920, y: 250}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &468315035632938553
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7065851367010980082}
  m_CullTransparentMesh: 1
--- !u!114 &5115876343839804407
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7065851367010980082}
  m_Enabled: 0
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.99215686, g: 0.043137256, b: 0.043137256, a: 0.78431374}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &2149389061025176540
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7065851367010980082}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 59f8146938fff824cb5fd77236b75775, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Padding:
    m_Left: 0
    m_Right: 0
    m_Top: 0
    m_Bottom: 0
  m_ChildAlignment: 4
  m_Spacing: 0
  m_ChildForceExpandWidth: 1
  m_ChildForceExpandHeight: 1
  m_ChildControlWidth: 0
  m_ChildControlHeight: 0
  m_ChildScaleWidth: 0
  m_ChildScaleHeight: 0
  m_ReverseArrangement: 0
--- !u!1 &7121023280442368374
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6236503024863068378}
  - component: {fileID: 34345240842339767}
  - component: {fileID: 2479620650496796944}
  m_Layer: 5
  m_Name: Text_Title
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &6236503024863068378
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7121023280442368374}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 8853477456087505937}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 0, y: -150}
  m_SizeDelta: {x: 1000, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &34345240842339767
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7121023280442368374}
  m_CullTransparentMesh: 1
--- !u!114 &2479620650496796944
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7121023280442368374}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'SIMULATION COMPLETE

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 75
  m_fontSizeBase: 75
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &7318715347358405930
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1594147492916372923}
  - component: {fileID: 3288452247472078129}
  - component: {fileID: 1521890422249070572}
  m_Layer: 5
  m_Name: Text_WaveTitle
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1594147492916372923
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7318715347358405930}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5717701635820235937}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 50}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &3288452247472078129
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7318715347358405930}
  m_CullTransparentMesh: 1
--- !u!114 &1521890422249070572
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7318715347358405930}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: WAVE 1
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4293984000
  m_fontColor: {r: 0, g: 1, b: 0.9395871, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 80
  m_fontSizeBase: 80
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &7479382619679410503
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 8853477456087505937}
  - component: {fileID: 3638171459817157148}
  - component: {fileID: 4216531826355753601}
  - component: {fileID: 7541861393722231731}
  m_Layer: 5
  m_Name: VictoryPanel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!224 &8853477456087505937
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7479382619679410503}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4735050686387023062}
  - {fileID: 6236503024863068378}
  - {fileID: 4673176090307018577}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &3638171459817157148
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7479382619679410503}
  m_CullTransparentMesh: 1
--- !u!114 &4216531826355753601
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7479382619679410503}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.6367924, g: 1, b: 0.8199406, a: 0.78431374}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!114 &7541861393722231731
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7479382619679410503}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: e7e983e1506275444953680431bc95a0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  scoreText: {fileID: 1473828227356180873}
  timeText: {fileID: 8814143133066075484}
  rankText: {fileID: 8345996789476983119}
  rankS_Threshold: 50000
  rankA_Threshold: 25000
  rankB_Threshold: 10000
--- !u!1 &7606772395903952469
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1266481494037411217}
  - component: {fileID: 2996418842784881643}
  m_Layer: 5
  m_Name: FocusSlider
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1266481494037411217
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7606772395903952469}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 3056237619404857284}
  - {fileID: 1078007717861629156}
  m_Father: {fileID: 5579059785840851497}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 0, y: -120}
  m_SizeDelta: {x: 600, y: 70}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!114 &2996418842784881643
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7606772395903952469}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 67db9e8f0e2ae9c40bc1e2b64352a6b4, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
    m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
    m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
    m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 0
  m_TargetGraphic: {fileID: 0}
  m_FillRect: {fileID: 6725254738931999090}
  m_HandleRect: {fileID: 0}
  m_Direction: 0
  m_MinValue: 0
  m_MaxValue: 1
  m_WholeNumbers: 0
  m_Value: 0
  m_OnValueChanged:
    m_PersistentCalls:
      m_Calls: []
--- !u!1 &7669676435098484103
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5717701635820235937}
  - component: {fileID: 3519676716403322816}
  m_Layer: 5
  m_Name: WaveAnnouncement
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &5717701635820235937
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7669676435098484103}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 1594147492916372923}
  - {fileID: 6035359685227545228}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 100, y: 100}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!114 &3519676716403322816
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7669676435098484103}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 516b729582f9e2241b1d5c079b485861, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  waveTitleText: {fileID: 1521890422249070572}
  countdownText: {fileID: 633657714906244717}
--- !u!1 &7760171909690953536
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4181762744011268293}
  - component: {fileID: 462630052477532443}
  - component: {fileID: 3593251430110007768}
  m_Layer: 5
  m_Name: Hull_Icon
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &4181762744011268293
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7760171909690953536}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4973795791505662065}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 0, y: 0}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 50, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &462630052477532443
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7760171909690953536}
  m_CullTransparentMesh: 1
--- !u!114 &3593251430110007768
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7760171909690953536}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.07058824, g: 0.26795727, b: 0.99215686, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 0}
  m_Type: 0
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &7783973557150069832
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1078007717861629156}
  m_Layer: 5
  m_Name: Fill Area
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1078007717861629156
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7783973557150069832}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6725254738931999090}
  m_Father: {fileID: 1266481494037411217}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0.25}
  m_AnchorMax: {x: 1, y: 0.75}
  m_AnchoredPosition: {x: -5, y: 0}
  m_SizeDelta: {x: -20, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!1 &7869767329347124271
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 731256735620084907}
  - component: {fileID: 2523832663553386155}
  - component: {fileID: 4239911145692432235}
  m_Layer: 5
  m_Name: Text (TMP)
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &731256735620084907
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7869767329347124271}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 3128880439868124835}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 0.5}
  m_AnchorMax: {x: 0.5, y: 0.5}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 500, y: 64}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &2523832663553386155
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7869767329347124271}
  m_CullTransparentMesh: 1
--- !u!114 &4239911145692432235
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 7869767329347124271}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'EXIT SIMULATION

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4281479730
  m_fontColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 0
  m_fontSizeMax: 0
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 0
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &8111278782685874405
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 357821462121774746}
  - component: {fileID: 423907477506872942}
  - component: {fileID: 4676486494653751701}
  m_Layer: 5
  m_Name: GameOverPanel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!224 &357821462121774746
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8111278782685874405}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 6275334821920857403}
  - {fileID: 770043533993339775}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &423907477506872942
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8111278782685874405}
  m_CullTransparentMesh: 1
--- !u!114 &4676486494653751701
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8111278782685874405}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.990566, g: 0.042052314, b: 0.042052314, a: 0.78431374}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &8150306347443751610
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1327972982294030153}
  - component: {fileID: 865232258203114376}
  - component: {fileID: 8345996789476983119}
  m_Layer: 5
  m_Name: Text_Rank
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1327972982294030153
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8150306347443751610}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 4673176090307018577}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 300, y: -400}
  m_SizeDelta: {x: 500, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &865232258203114376
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8150306347443751610}
  m_CullTransparentMesh: 1
--- !u!114 &8345996789476983119
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8150306347443751610}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: N
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 45
  m_fontSizeBase: 45
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 1
  m_VerticalAlignment: 256
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
--- !u!1 &8310834652806003934
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 3056237619404857284}
  - component: {fileID: 9069715949710458430}
  - component: {fileID: 1943356592546508527}
  m_Layer: 5
  m_Name: Background
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &3056237619404857284
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8310834652806003934}
  m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 1266481494037411217}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0.25}
  m_AnchorMax: {x: 1, y: 0.75}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &9069715949710458430
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8310834652806003934}
  m_CullTransparentMesh: 1
--- !u!114 &1943356592546508527
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8310834652806003934}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 0.3490566, g: 0.33753115, b: 0.33753115, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &9103470956526551067
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2772274479977780061}
  - component: {fileID: 7745183731096659184}
  - component: {fileID: 1248215460161505560}
  m_Layer: 5
  m_Name: StartPanel
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 0
--- !u!224 &2772274479977780061
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9103470956526551067}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 4621406102330463814}
  m_Father: {fileID: 9100246156042717090}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0, y: 0}
  m_AnchorMax: {x: 1, y: 1}
  m_AnchoredPosition: {x: 0, y: 0}
  m_SizeDelta: {x: 0, y: 0}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &7745183731096659184
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9103470956526551067}
  m_CullTransparentMesh: 1
--- !u!114 &1248215460161505560
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9103470956526551067}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 0.78431374}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
  m_Type: 1
  m_PreserveAspect: 0
  m_FillCenter: 1
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: 1
--- !u!1 &9221497028777803119
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1093791948572703840}
  - component: {fileID: 4991372848904946980}
  - component: {fileID: 6361042891923926869}
  m_Layer: 5
  m_Name: Title
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!224 &1093791948572703840
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9221497028777803119}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 5992629754528979461}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
  m_AnchorMin: {x: 0.5, y: 1}
  m_AnchorMax: {x: 0.5, y: 1}
  m_AnchoredPosition: {x: 0, y: -200}
  m_SizeDelta: {x: 750, y: 50}
  m_Pivot: {x: 0.5, y: 0.5}
--- !u!222 &4991372848904946980
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9221497028777803119}
  m_CullTransparentMesh: 1
--- !u!114 &6361042891923926869
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 9221497028777803119}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: 1
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: 'OPERATIONAL MANUAL

'
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: d3a72a3ae62b54442b3e0df6be9d3cb8, type: 2}
  m_sharedMaterial: {fileID: 5902854279487297354, guid: d3a72a3ae62b54442b3e0df6be9d3cb8,
    type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: 4294967295
  m_fontColor: {r: 1, g: 1, b: 1, a: 1}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: 55
  m_fontSizeBase: 55
  m_fontWeight: 400
  m_enableAutoSizing: 0
  m_fontSizeMin: 18
  m_fontSizeMax: 72
  m_fontStyle: 1
  m_HorizontalAlignment: 2
  m_VerticalAlignment: 512
  m_textAlignment: 65535
  m_characterSpacing: 0
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_enableWordWrapping: 1
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: 0, y: 0, z: 0, w: 0}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
```

## 📄 `Assets\Prefabs\VFX\VFX_Explosion.prefab`
- Lines: 4891
- Size: 120.4 KB
- Modified: 2025-12-11 07:51

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &648059833510886341
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1764288382972114564}
  - component: {fileID: 3897047760621542942}
  - component: {fileID: 902691461318591643}
  m_Layer: 0
  m_Name: VFX_Explosion
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &1764288382972114564
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 648059833510886341}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!198 &3897047760621542942
ParticleSystem:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 648059833510886341}
  serializedVersion: 8
  lengthInSec: 1
  simulationSpeed: 1
  stopAction: 1
  cullingMode: 0
  ringBufferMode: 0
  ringBufferLoopRange: {x: 0, y: 1}
  emitterVelocityMode: 1
  looping: 0
  prewarm: 0
  playOnAwake: 1
  useUnscaledTime: 1
  autoRandomSeed: 1
  startDelay:
    serializedVersion: 2
    minMaxState: 0
    scalar: 0
    minScalar: 0
    maxCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    minCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
  moveWithTransform: 0
  moveWithCustomTransform: {fileID: 0}
  scalingMode: 1
  randomSeed: 0
  InitialModule:
    serializedVersion: 3
    enabled: 1
    startLifetime:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.5
      minScalar: 5
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startSpeed:
      serializedVersion: 2
      minMaxState: 0
      scalar: 10
      minScalar: 5
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startColor:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 0.3679245, g: 0, b: 0.04564547, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    startSize:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.5
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startSizeY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startSizeZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startRotationX:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startRotationY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startRotation:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    randomizeRotationDirection: 0
    gravitySource: 0
    maxNumParticles: 1000
    customEmitterVelocity: {x: 0, y: 0, z: 0}
    size3D: 0
    rotation3D: 0
    gravityModifier:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  ShapeModule:
    serializedVersion: 6
    enabled: 1
    type: 0
    angle: 25
    length: 5
    boxThickness: {x: 0, y: 0, z: 0}
    radiusThickness: 1
    donutRadius: 0.2
    m_Position: {x: 0, y: 0, z: 0}
    m_Rotation: {x: 0, y: 0, z: 0}
    m_Scale: {x: 1, y: 1, z: 1}
    placementMode: 0
    m_MeshMaterialIndex: 0
    m_MeshNormalOffset: 0
    m_MeshSpawn:
      mode: 0
      spread: 0
      speed:
        serializedVersion: 2
        minMaxState: 0
        scalar: 1
        minScalar: 1
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
    m_Mesh: {fileID: 0}
    m_MeshRenderer: {fileID: 0}
    m_SkinnedMeshRenderer: {fileID: 0}
    m_Sprite: {fileID: 0}
    m_SpriteRenderer: {fileID: 0}
    m_UseMeshMaterialIndex: 0
    m_UseMeshColors: 1
    alignToDirection: 0
    m_Texture: {fileID: 0}
    m_TextureClipChannel: 3
    m_TextureClipThreshold: 0
    m_TextureUVChannel: 0
    m_TextureColorAffectsParticles: 1
    m_TextureAlphaAffectsParticles: 1
    m_TextureBilinearFiltering: 0
    randomDirectionAmount: 0
    sphericalDirectionAmount: 0
    randomPositionAmount: 0
    radius:
      value: 0.5
      mode: 0
      spread: 0
      speed:
        serializedVersion: 2
        minMaxState: 0
        scalar: 1
        minScalar: 1
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
    arc:
      value: 360
      mode: 0
      spread: 0
      speed:
        serializedVersion: 2
        minMaxState: 0
        scalar: 1
        minScalar: 1
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
  EmissionModule:
    enabled: 1
    serializedVersion: 4
    rateOverTime:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 10
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    rateOverDistance:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_BurstCount: 1
    m_Bursts:
    - serializedVersion: 2
      time: 0
      countCurve:
        serializedVersion: 2
        minMaxState: 3
        scalar: 50
        minScalar: 30
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
      cycleCount: 1
      repeatInterval: 0.01
      probability: 1
  SizeModule:
    enabled: 1
    curve:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
  RotationModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    curve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.7853982
      minScalar: 0.7853982
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
  ColorModule:
    enabled: 1
    gradient:
      serializedVersion: 2
      minMaxState: 1
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 0.55168885, b: 0.2216981, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 1, g: 1, b: 1, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 65535
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: 0
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
  UVModule:
    serializedVersion: 2
    enabled: 0
    mode: 0
    timeMode: 0
    fps: 30
    frameOverTime:
      serializedVersion: 2
      minMaxState: 1
      scalar: 0.9999
      minScalar: 0.9999
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startFrame:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    speedRange: {x: 0, y: 1}
    tilesX: 1
    tilesY: 1
    animationType: 0
    rowIndex: 0
    cycles: 1
    uvChannelMask: -1
    rowMode: 1
    sprites:
    - sprite: {fileID: 0}
    flipU: 0
    flipV: 0
  VelocityModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalX:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalOffsetX:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalOffsetY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalOffsetZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    radial:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    speedModifier:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    inWorldSpace: 0
  InheritVelocityModule:
    enabled: 0
    m_Mode: 0
    m_Curve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  LifetimeByEmitterSpeedModule:
    enabled: 0
    m_Curve:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: -0.8
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0.2
          inSlope: -0.8
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_Range: {x: 0, y: 1}
  ForceModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    inWorldSpace: 0
    randomizePerFrame: 0
  ExternalForcesModule:
    serializedVersion: 2
    enabled: 0
    multiplierCurve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    influenceFilter: 0
    influenceMask:
      serializedVersion: 2
      m_Bits: 4294967295
    influenceList: []
  ClampVelocityModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    magnitude:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxis: 0
    inWorldSpace: 0
    multiplyDragByParticleSize: 1
    multiplyDragByParticleVelocity: 1
    dampen: 0
    drag:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  NoiseModule:
    enabled: 0
    strength:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    strengthY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    strengthZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
    frequency: 0.5
    damping: 1
    octaves: 1
    octaveMultiplier: 0.5
    octaveScale: 2
    quality: 1
    scrollSpeed:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remap:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: -1
          inSlope: 0
          outSlope: 2
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 2
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remapY:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: -1
          inSlope: 0
          outSlope: 2
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 2
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remapZ:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: -1
          inSlope: 0
          outSlope: 2
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 2
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remapEnabled: 0
    positionAmount:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    rotationAmount:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    sizeAmount:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  SizeBySpeedModule:
    enabled: 0
    curve:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    range: {x: 0, y: 1}
    separateAxes: 0
  RotationBySpeedModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    curve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.7853982
      minScalar: 0.7853982
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
    range: {x: 0, y: 1}
  ColorBySpeedModule:
    enabled: 0
    gradient:
      serializedVersion: 2
      minMaxState: 1
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    range: {x: 0, y: 1}
  CollisionModule:
    enabled: 0
    serializedVersion: 4
    type: 0
    collisionMode: 0
    colliderForce: 0
    multiplyColliderForceByParticleSize: 0
    multiplyColliderForceByParticleSpeed: 0
    multiplyColliderForceByCollisionAngle: 1
    m_Planes: []
    m_Dampen:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_Bounce:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_EnergyLossOnCollision:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    minKillSpeed: 0
    maxKillSpeed: 10000
    radiusScale: 1
    collidesWith:
      serializedVersion: 2
      m_Bits: 4294967295
    maxCollisionShapes: 256
    quality: 0
    voxelSize: 0.5
    collisionMessages: 0
    collidesWithDynamic: 1
    interiorCollisions: 0
  TriggerModule:
    enabled: 0
    serializedVersion: 2
    inside: 1
    outside: 0
    enter: 0
    exit: 0
    colliderQueryMode: 0
    radiusScale: 1
    primitives: []
  SubModule:
    serializedVersion: 2
    enabled: 0
    subEmitters:
    - serializedVersion: 3
      emitter: {fileID: 0}
      type: 0
      properties: 0
      emitProbability: 1
  LightsModule:
    enabled: 0
    ratio: 0
    light: {fileID: 0}
    randomDistribution: 1
    color: 1
    range: 1
    intensity: 1
    rangeCurve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    intensityCurve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    maxLights: 20
  TrailModule:
    enabled: 0
    mode: 0
    ratio: 1
    lifetime:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    minVertexDistance: 0.2
    textureMode: 0
    textureScale: {x: 1, y: 1}
    ribbonCount: 1
    shadowBias: 0.5
    worldSpace: 0
    dieWithParticles: 1
    sizeAffectsWidth: 1
    sizeAffectsLifetime: 0
    inheritParticleColor: 1
    generateLightingData: 0
    splitSubEmitterRibbons: 0
    attachRibbonsToTransform: 0
    colorOverLifetime:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    widthOverTrail:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    colorOverTrail:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
  CustomDataModule:
    enabled: 0
    mode0: 0
    vectorComponentCount0: 4
    color0:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    colorLabel0: Color
    vector0_0:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_0: X
    vector0_1:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_1: Y
    vector0_2:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_2: Z
    vector0_3:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_3: W
    mode1: 0
    vectorComponentCount1: 4
    color1:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    colorLabel1: Color
    vector1_0:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_0: X
    vector1_1:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_1: Y
    vector1_2:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_2: Z
    vector1_3:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_3: W
--- !u!199 &902691461318591643
ParticleSystemRenderer:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 648059833510886341}
  m_Enabled: 1
  m_CastShadows: 0
  m_ReceiveShadows: 0
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 0
  m_ReflectionProbeUsage: 0
  m_RayTracingMode: 0
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 9d2df71a4acd97d4486233056adb0b21, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_RenderMode: 0
  m_MeshDistribution: 0
  m_SortMode: 0
  m_MinParticleSize: 0
  m_MaxParticleSize: 0.5
  m_CameraVelocityScale: 0
  m_VelocityScale: 0
  m_LengthScale: 2
  m_SortingFudge: 0
  m_NormalDirection: 1
  m_ShadowBias: 0
  m_RenderAlignment: 0
  m_Pivot: {x: 0, y: 0, z: 0}
  m_Flip: {x: 0, y: 0, z: 0}
  m_EnableGPUInstancing: 1
  m_ApplyActiveColorSpace: 1
  m_AllowRoll: 1
  m_FreeformStretching: 0
  m_RotateWithStretchDirection: 1
  m_UseCustomVertexStreams: 0
  m_VertexStreams: 00010304
  m_UseCustomTrailVertexStreams: 0
  m_TrailVertexStreams: 00010304
  m_Mesh: {fileID: 0}
  m_Mesh1: {fileID: 0}
  m_Mesh2: {fileID: 0}
  m_Mesh3: {fileID: 0}
  m_MeshWeighting: 1
  m_MeshWeighting1: 1
  m_MeshWeighting2: 1
  m_MeshWeighting3: 1
  m_MaskInteraction: 0
```

## 📄 `Assets\Prefabs\VFX\VFX_Hazard_BarrelExplosion.prefab`
- Lines: 184
- Size: 5.0 KB
- Modified: 2025-12-23 17:35

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &2235014378595880763
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7551186951016571749}
  - component: {fileID: 1890442678140438322}
  - component: {fileID: 4292772575748379317}
  m_Layer: 0
  m_Name: VFX_Hazard_BarrelExplosion
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7551186951016571749
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2235014378595880763}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 24.2}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7355545379249672960}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!135 &1890442678140438322
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2235014378595880763}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 2
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &4292772575748379317
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2235014378595880763}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 07fbf082506fc3b4eab408a5f32d4478, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  duration: 0.5
  damage: 50
  knockbackForce: 30
  targetLayer:
    serializedVersion: 2
    m_Bits: 128
  visualRing: {fileID: 7355545379249672960}
--- !u!1 &2620552064002290841
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7355545379249672960}
  - component: {fileID: 5145983743083606459}
  - component: {fileID: 7282743046085621447}
  - component: {fileID: 7654509768472301505}
  m_Layer: 0
  m_Name: VisualHazard
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7355545379249672960
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 4, y: 0.1, z: 4}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7551186951016571749}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &5145983743083606459
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7282743046085621447
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: b6c350333b0c4cc4daa5ac72a64d829a, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!136 &7654509768472301505
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5000001
  m_Height: 2
  m_Direction: 1
  m_Center: {x: 0.000000059604645, y: 0, z: -0.00000008940697}
```

## 📄 `Assets\Prefabs\VFX\VFX_Hazard_Mine.prefab`
- Lines: 184
- Size: 5.0 KB
- Modified: 2025-12-14 10:52

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &2235014378595880763
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7551186951016571749}
  - component: {fileID: 1890442678140438322}
  - component: {fileID: 4292772575748379317}
  m_Layer: 0
  m_Name: VFX_Hazard_Mine
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7551186951016571749
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2235014378595880763}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 1, z: 24.2}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 7355545379249672960}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!135 &1890442678140438322
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2235014378595880763}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 1
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 3
  m_Radius: 2
  m_Center: {x: 0, y: 0, z: 0}
--- !u!114 &4292772575748379317
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2235014378595880763}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 07fbf082506fc3b4eab408a5f32d4478, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  duration: 3
  damage: 1
  knockbackForce: 20
  targetLayer:
    serializedVersion: 2
    m_Bits: 64
  visualRing: {fileID: 7355545379249672960}
--- !u!1 &2620552064002290841
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7355545379249672960}
  - component: {fileID: 5145983743083606459}
  - component: {fileID: 7282743046085621447}
  - component: {fileID: 7654509768472301505}
  m_Layer: 0
  m_Name: VisualHazard
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7355545379249672960
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 4, y: 0.1, z: 4}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7551186951016571749}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &5145983743083606459
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  m_Mesh: {fileID: 10206, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &7282743046085621447
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: b6c350333b0c4cc4daa5ac72a64d829a, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!136 &7654509768472301505
CapsuleCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2620552064002290841}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5000001
  m_Height: 2
  m_Direction: 1
  m_Center: {x: 0.000000059604645, y: 0, z: -0.00000008940697}
```

## 📄 `Assets\Prefabs\VFX\VFX_Spawn.prefab`
- Lines: 4891
- Size: 120.3 KB
- Modified: 2025-12-11 07:51

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &823617336625923824
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6483209804812477866}
  - component: {fileID: 4009414740218911732}
  - component: {fileID: 4429242102417778184}
  m_Layer: 0
  m_Name: VFX_Spawn
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6483209804812477866
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 823617336625923824}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!198 &4009414740218911732
ParticleSystem:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 823617336625923824}
  serializedVersion: 8
  lengthInSec: 1
  simulationSpeed: 1
  stopAction: 1
  cullingMode: 0
  ringBufferMode: 0
  ringBufferLoopRange: {x: 0, y: 1}
  emitterVelocityMode: 1
  looping: 0
  prewarm: 0
  playOnAwake: 1
  useUnscaledTime: 0
  autoRandomSeed: 1
  startDelay:
    serializedVersion: 2
    minMaxState: 0
    scalar: 0
    minScalar: 0
    maxCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    minCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 1
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
  moveWithTransform: 0
  moveWithCustomTransform: {fileID: 0}
  scalingMode: 1
  randomSeed: 0
  InitialModule:
    serializedVersion: 3
    enabled: 1
    startLifetime:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.5
      minScalar: 5
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startSpeed:
      serializedVersion: 2
      minMaxState: 0
      scalar: 5
      minScalar: 5
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startColor:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    startSize:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.2
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startSizeY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startSizeZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startRotationX:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startRotationY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startRotation:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    randomizeRotationDirection: 0
    gravitySource: 0
    maxNumParticles: 1000
    customEmitterVelocity: {x: 0, y: 0, z: 0}
    size3D: 0
    rotation3D: 0
    gravityModifier:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  ShapeModule:
    serializedVersion: 6
    enabled: 1
    type: 10
    angle: 25
    length: 5
    boxThickness: {x: 0, y: 0, z: 0}
    radiusThickness: 1
    donutRadius: 0.2
    m_Position: {x: 0, y: 0, z: 0}
    m_Rotation: {x: -90, y: 0, z: 0}
    m_Scale: {x: 1, y: 1, z: 1}
    placementMode: 0
    m_MeshMaterialIndex: 0
    m_MeshNormalOffset: 0
    m_MeshSpawn:
      mode: 0
      spread: 0
      speed:
        serializedVersion: 2
        minMaxState: 0
        scalar: 1
        minScalar: 1
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
    m_Mesh: {fileID: 0}
    m_MeshRenderer: {fileID: 0}
    m_SkinnedMeshRenderer: {fileID: 0}
    m_Sprite: {fileID: 0}
    m_SpriteRenderer: {fileID: 0}
    m_UseMeshMaterialIndex: 0
    m_UseMeshColors: 1
    alignToDirection: 0
    m_Texture: {fileID: 0}
    m_TextureClipChannel: 3
    m_TextureClipThreshold: 0
    m_TextureUVChannel: 0
    m_TextureColorAffectsParticles: 1
    m_TextureAlphaAffectsParticles: 1
    m_TextureBilinearFiltering: 0
    randomDirectionAmount: 0
    sphericalDirectionAmount: 0
    randomPositionAmount: 0
    radius:
      value: 1
      mode: 0
      spread: 0
      speed:
        serializedVersion: 2
        minMaxState: 0
        scalar: 1
        minScalar: 1
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
    arc:
      value: 360
      mode: 0
      spread: 0
      speed:
        serializedVersion: 2
        minMaxState: 0
        scalar: 1
        minScalar: 1
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0.33333334
            outWeight: 0.33333334
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
  EmissionModule:
    enabled: 1
    serializedVersion: 4
    rateOverTime:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 10
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    rateOverDistance:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_BurstCount: 1
    m_Bursts:
    - serializedVersion: 2
      time: 0
      countCurve:
        serializedVersion: 2
        minMaxState: 0
        scalar: 20
        minScalar: 30
        maxCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
        minCurve:
          serializedVersion: 2
          m_Curve:
          - serializedVersion: 3
            time: 0
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          - serializedVersion: 3
            time: 1
            value: 1
            inSlope: 0
            outSlope: 0
            tangentMode: 0
            weightedMode: 0
            inWeight: 0
            outWeight: 0
          m_PreInfinity: 2
          m_PostInfinity: 2
          m_RotationOrder: 4
      cycleCount: 1
      repeatInterval: 0.01
      probability: 1
  SizeModule:
    enabled: 0
    curve:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
  RotationModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    curve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.7853982
      minScalar: 0.7853982
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
  ColorModule:
    enabled: 1
    gradient:
      serializedVersion: 2
      minMaxState: 1
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 0.657492, g: 0.9339623, b: 0.59474015, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 0}
        key2: {r: 1, g: 1, b: 1, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 65535
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: 0
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
  UVModule:
    serializedVersion: 2
    enabled: 0
    mode: 0
    timeMode: 0
    fps: 30
    frameOverTime:
      serializedVersion: 2
      minMaxState: 1
      scalar: 0.9999
      minScalar: 0.9999
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    startFrame:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    speedRange: {x: 0, y: 1}
    tilesX: 1
    tilesY: 1
    animationType: 0
    rowIndex: 0
    cycles: 1
    uvChannelMask: -1
    rowMode: 1
    sprites:
    - sprite: {fileID: 0}
    flipU: 0
    flipV: 0
  VelocityModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalX:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalOffsetX:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalOffsetY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    orbitalOffsetZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    radial:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    speedModifier:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    inWorldSpace: 0
  InheritVelocityModule:
    enabled: 0
    m_Mode: 0
    m_Curve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  LifetimeByEmitterSpeedModule:
    enabled: 0
    m_Curve:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: -0.8
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0.2
          inSlope: -0.8
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_Range: {x: 0, y: 1}
  ForceModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    inWorldSpace: 0
    randomizePerFrame: 0
  ExternalForcesModule:
    serializedVersion: 2
    enabled: 0
    multiplierCurve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    influenceFilter: 0
    influenceMask:
      serializedVersion: 2
      m_Bits: 4294967295
    influenceList: []
  ClampVelocityModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    magnitude:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxis: 0
    inWorldSpace: 0
    multiplyDragByParticleSize: 1
    multiplyDragByParticleVelocity: 1
    dampen: 0
    drag:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  NoiseModule:
    enabled: 0
    strength:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    strengthY:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    strengthZ:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
    frequency: 0.5
    damping: 1
    octaves: 1
    octaveMultiplier: 0.5
    octaveScale: 2
    quality: 1
    scrollSpeed:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remap:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: -1
          inSlope: 0
          outSlope: 2
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 2
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remapY:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: -1
          inSlope: 0
          outSlope: 2
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 2
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remapZ:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: -1
          inSlope: 0
          outSlope: 2
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 2
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    remapEnabled: 0
    positionAmount:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    rotationAmount:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    sizeAmount:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
  SizeBySpeedModule:
    enabled: 0
    curve:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    z:
      serializedVersion: 2
      minMaxState: 1
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 1
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 1
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    range: {x: 0, y: 1}
    separateAxes: 0
  RotationBySpeedModule:
    enabled: 0
    x:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    y:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    curve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0.7853982
      minScalar: 0.7853982
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    separateAxes: 0
    range: {x: 0, y: 1}
  ColorBySpeedModule:
    enabled: 0
    gradient:
      serializedVersion: 2
      minMaxState: 1
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    range: {x: 0, y: 1}
  CollisionModule:
    enabled: 0
    serializedVersion: 4
    type: 0
    collisionMode: 0
    colliderForce: 0
    multiplyColliderForceByParticleSize: 0
    multiplyColliderForceByParticleSpeed: 0
    multiplyColliderForceByCollisionAngle: 1
    m_Planes: []
    m_Dampen:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_Bounce:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    m_EnergyLossOnCollision:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    minKillSpeed: 0
    maxKillSpeed: 10000
    radiusScale: 1
    collidesWith:
      serializedVersion: 2
      m_Bits: 4294967295
    maxCollisionShapes: 256
    quality: 0
    voxelSize: 0.5
    collisionMessages: 0
    collidesWithDynamic: 1
    interiorCollisions: 0
  TriggerModule:
    enabled: 0
    serializedVersion: 2
    inside: 1
    outside: 0
    enter: 0
    exit: 0
    colliderQueryMode: 0
    radiusScale: 1
    primitives: []
  SubModule:
    serializedVersion: 2
    enabled: 0
    subEmitters:
    - serializedVersion: 3
      emitter: {fileID: 0}
      type: 0
      properties: 0
      emitProbability: 1
  LightsModule:
    enabled: 0
    ratio: 0
    light: {fileID: 0}
    randomDistribution: 1
    color: 1
    range: 1
    intensity: 1
    rangeCurve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    intensityCurve:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    maxLights: 20
  TrailModule:
    enabled: 0
    mode: 0
    ratio: 1
    lifetime:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    minVertexDistance: 0.2
    textureMode: 0
    textureScale: {x: 1, y: 1}
    ribbonCount: 1
    shadowBias: 0.5
    worldSpace: 0
    dieWithParticles: 1
    sizeAffectsWidth: 1
    sizeAffectsLifetime: 0
    inheritParticleColor: 1
    generateLightingData: 0
    splitSubEmitterRibbons: 0
    attachRibbonsToTransform: 0
    colorOverLifetime:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    widthOverTrail:
      serializedVersion: 2
      minMaxState: 0
      scalar: 1
      minScalar: 1
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 1
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    colorOverTrail:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
  CustomDataModule:
    enabled: 0
    mode0: 0
    vectorComponentCount0: 4
    color0:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    colorLabel0: Color
    vector0_0:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_0: X
    vector0_1:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_1: Y
    vector0_2:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_2: Z
    vector0_3:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel0_3: W
    mode1: 0
    vectorComponentCount1: 4
    color1:
      serializedVersion: 2
      minMaxState: 0
      minColor: {r: 1, g: 1, b: 1, a: 1}
      maxColor: {r: 1, g: 1, b: 1, a: 1}
      maxGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
      minGradient:
        serializedVersion: 2
        key0: {r: 1, g: 1, b: 1, a: 1}
        key1: {r: 1, g: 1, b: 1, a: 1}
        key2: {r: 0, g: 0, b: 0, a: 0}
        key3: {r: 0, g: 0, b: 0, a: 0}
        key4: {r: 0, g: 0, b: 0, a: 0}
        key5: {r: 0, g: 0, b: 0, a: 0}
        key6: {r: 0, g: 0, b: 0, a: 0}
        key7: {r: 0, g: 0, b: 0, a: 0}
        ctime0: 0
        ctime1: 65535
        ctime2: 0
        ctime3: 0
        ctime4: 0
        ctime5: 0
        ctime6: 0
        ctime7: 0
        atime0: 0
        atime1: 65535
        atime2: 0
        atime3: 0
        atime4: 0
        atime5: 0
        atime6: 0
        atime7: 0
        m_Mode: 0
        m_ColorSpace: -1
        m_NumColorKeys: 2
        m_NumAlphaKeys: 2
    colorLabel1: Color
    vector1_0:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_0: X
    vector1_1:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_1: Y
    vector1_2:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_2: Z
    vector1_3:
      serializedVersion: 2
      minMaxState: 0
      scalar: 0
      minScalar: 0
      maxCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
      minCurve:
        serializedVersion: 2
        m_Curve:
        - serializedVersion: 3
          time: 0
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        - serializedVersion: 3
          time: 1
          value: 0
          inSlope: 0
          outSlope: 0
          tangentMode: 0
          weightedMode: 0
          inWeight: 0.33333334
          outWeight: 0.33333334
        m_PreInfinity: 2
        m_PostInfinity: 2
        m_RotationOrder: 4
    vectorLabel1_3: W
--- !u!199 &4429242102417778184
ParticleSystemRenderer:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 823617336625923824}
  m_Enabled: 1
  m_CastShadows: 0
  m_ReceiveShadows: 0
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 0
  m_ReflectionProbeUsage: 0
  m_RayTracingMode: 0
  m_RayTraceProcedural: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 0}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_RenderMode: 0
  m_MeshDistribution: 0
  m_SortMode: 0
  m_MinParticleSize: 0
  m_MaxParticleSize: 0.5
  m_CameraVelocityScale: 0
  m_VelocityScale: 0
  m_LengthScale: 2
  m_SortingFudge: 0
  m_NormalDirection: 1
  m_ShadowBias: 0
  m_RenderAlignment: 0
  m_Pivot: {x: 0, y: 0, z: 0}
  m_Flip: {x: 0, y: 0, z: 0}
  m_EnableGPUInstancing: 1
  m_ApplyActiveColorSpace: 1
  m_AllowRoll: 1
  m_FreeformStretching: 0
  m_RotateWithStretchDirection: 1
  m_UseCustomVertexStreams: 0
  m_VertexStreams: 00010304
  m_UseCustomTrailVertexStreams: 0
  m_TrailVertexStreams: 00010304
  m_Mesh: {fileID: 0}
  m_Mesh1: {fileID: 0}
  m_Mesh2: {fileID: 0}
  m_Mesh3: {fileID: 0}
  m_MeshWeighting: 1
  m_MeshWeighting1: 1
  m_MeshWeighting2: 1
  m_MeshWeighting3: 1
  m_MaskInteraction: 0
```

## 📄 `Assets\Scripts\Combat\HazardZone.cs`
- Lines: 60
- Size: 1.9 KB
- Modified: 2025-12-14 10:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class HazardZone : MonoBehaviour
    {
        [Header("Settings")]
        public float duration = 3.0f;
        public float damage = 1f;
        public float knockbackForce = 15f;
        public LayerMask targetLayer; // Player

        [Header("Visuals")]
        public Transform visualRing; // Assign a cylinder/sprite

        private void Start()
        {
            // 1. Expand Visuals (Juice)
            transform.localScale = Vector3.zero;
            transform.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);

            // 2. Schedule Destruction
            // Fade out before destroying
            DOVirtual.DelayedCall(duration - 0.5f, FadeOut);
            Destroy(gameObject, duration);
        }

        private void FadeOut()
        {
            transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check Layer
            if (((1 << other.gameObject.layer) & targetLayer) != 0)
            {
                IDamageable target = other.GetComponentInParent<IDamageable>();
                if (target != null)
                {
                    // Calculate push direction (Away from center of zone)
                    Vector3 dir = (other.transform.position - transform.position).normalized;
                    dir.y = 0;

                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = dir,
                        pushForce = knockbackForce,
                        source = gameObject
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HitboxRelay.cs`
- Lines: 42
- Size: 1.2 KB
- Modified: 2025-12-23 17:09

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Enemy; // Access EnemyController

namespace DarkTowerTron.Combat
{
    /// <summary>
    /// Place this on Child Colliders (e.g. Head, Weakpoint).
    /// It forwards damage to the Main Controller on the Root.
    /// </summary>
    public class HitboxRelay : MonoBehaviour, IDamageable
    {
        [Header("Link")]
        [SerializeField] private EnemyController _mainController;

        [Header("Settings")]
        [SerializeField] private float _damageMultiplier = 1.0f; // 2.0 = Critical Spot

        private void Awake()
        {
            // Auto-link if empty
            if (_mainController == null)
                _mainController = GetComponentInParent<EnemyController>();
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_mainController == null) return false;

            // Apply Multiplier (e.g. Headshot)
            info.damageAmount *= _damageMultiplier;

            // Forward the hit
            return _mainController.TakeDamage(info);
        }

        public void Kill(bool instant)
        {
            if (_mainController) _mainController.Kill(instant);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HomingMissile.cs`
- Lines: 49
- Size: 1.7 KB
- Modified: 2025-12-24 13:13

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player; // To access TargetScanner

namespace DarkTowerTron.Combat
{
    public class HomingMissile : MonoBehaviour
    {
        public float turnSpeed = 5f;

        private Transform _target;
        private Projectile _projectile;

        private void OnEnable()
        {
            _projectile = GetComponent<Projectile>();

            // Find Target from Player's Scanner
            var player = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (player)
            {
                var scanner = player.GetComponent<TargetScanner>();
                if (scanner && scanner.CurrentTarget != null)
                {
                    // Target the collider center or transform
                    _target = scanner.CurrentTarget.transform;
                }
            }
        }

        private void Update()
        {
            if (_target == null || _projectile == null) return;

            Vector3 dirToTarget = (_target.position - transform.position).normalized;

            // Smoothly rotate towards target
            // The Projectile script moves 'Forward', so this curves the flight path
            Vector3 newDir = Vector3.RotateTowards(transform.forward, dirToTarget, turnSpeed * Time.deltaTime, 0.0f);

            transform.rotation = Quaternion.LookRotation(newDir);

            // Update the Projectile's internal direction vector so it doesn't fight us
            // (Only needed if Projectile uses a cached vector instead of transform.forward)
            // Our Projectile.cs uses a cached `_direction`. We need to update it.
            _projectile.Initialize(newDir);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Projectile.cs`
- Lines: 129
- Size: 4.1 KB
- Modified: 2025-12-14 12:42

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Ballistics")]
        public float speed = 15f;
        public float lifetime = 5f;
        public bool isHostile = true;
        
        [Header("Safety")]
        public float gracePeriod = 0.05f; // Ignore hits for first 0.05s
        public LayerMask wallLayer;

        [Header("Damage Stats")]
        public float damage = 10f;
        public float stagger = 0f;

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial;

        private Material _originalMaterial;
        private Vector3 _direction;
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private float _lifeTimer;
        private float _graceTimer;

        private void Awake()
        {
            if (meshRenderer) _originalMaterial = meshRenderer.sharedMaterial;
            if (wallLayer == 0) wallLayer = LayerMask.GetMask(GameConstants.LAYER_WALL, "Default");
        }

        public void OnSpawn()
        {
            _lifeTimer = lifetime;
        }

        public void OnDespawn()
        {
            CancelInvoke();
            _isInitialized = false;
        }

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;
            _graceTimer = gracePeriod; // RESET TIMER
            _isRedirected = false; 
            
            if (meshRenderer && _originalMaterial) meshRenderer.material = _originalMaterial;
        }

        public void ResetHostility(bool startHostile) { isHostile = startHostile; }

        private void Update()
        {
            if (!_isInitialized) return;
            
            // Countdown Grace Period
            if (_graceTimer > 0) _graceTimer -= Time.deltaTime;

            transform.Translate(_direction * speed * Time.deltaTime, Space.World);

            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0) Despawn();
        }

        private void OnTriggerEnter(Collider other)
        {
            // SAFETY CHECK: If grace period active, ignore everything
            if (_graceTimer > 0) return;

            if (other.isTrigger) return;

            // Wall Check
            if ((wallLayer.value & (1 << other.gameObject.layer)) > 0)
            {
                Despawn();
                return;
            }

            IDamageable target = other.GetComponentInParent<IDamageable>();
            if (target != null)
            {
                if (isHostile && other.CompareTag(GameConstants.TAG_ENEMY)) return;
                if (!isHostile && other.CompareTag(GameConstants.TAG_PLAYER)) return;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = this.damage,
                    staggerAmount = this.stagger,
                    pushDirection = _direction,
                    pushForce = 5f,
                    source = gameObject,
                    isRedirected = this._isRedirected 
                };

                if (target.TakeDamage(info)) Despawn();
            }
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            isHostile = false; 
            _isRedirected = true;
            _direction = newDirection.normalized;
            speed *= 1.5f; 
            if (meshRenderer && friendlyMaterial) meshRenderer.material = friendlyMaterial;
            else if (meshRenderer) meshRenderer.material.color = Color.cyan;
            _lifeTimer = 3.0f; 
        }

        private void Despawn()
        {
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\CameraRig.cs`
- Lines: 83
- Size: 2.8 KB
- Modified: 2025-12-24 17:20

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public class CameraRig : MonoBehaviour
    {
        [Header("Target")]
        public Transform target;

        [Header("Default Settings")]
        public float defaultPitch = 45f;
        public float defaultDistance = 25f;
        public float smoothTime = 0.1f;

        // Internal State
        private float _targetPitch;
        private float _targetDistance;

        // Locking State
        private bool _lockX = false;
        private bool _lockZ = false;
        private Vector3 _lockPosition = Vector3.zero;

        private Vector3 _currentVelocity;

        private void Start()
        {
            ResetToDefault();
        }

        public void ResetToDefault()
        {
            _targetPitch = defaultPitch;
            _targetDistance = defaultDistance;
            _lockX = false;
            _lockZ = false;
        }

        // Called by CameraZone
        public void OverrideCamera(float newPitch, float newDist, bool lockX, bool lockZ, Vector3 lockPos)
        {
            // If -1, keep current/default. Otherwise update.
            if (newPitch > 0) _targetPitch = newPitch;
            if (newDist > 0) _targetDistance = newDist;

            _lockX = lockX;
            _lockZ = lockZ;
            _lockPosition = lockPos;
        }

        private void LateUpdate()
        {
            if (target == null) return;

            // 1. Determine Target Base Position
            Vector3 followPos = target.position;

            // 2. Apply Locks (The Side-Scroller Logic)
            if (_lockX) followPos.x = _lockPosition.x; // Lock horizontal
            if (_lockZ) followPos.z = _lockPosition.z; // Lock depth

            // 3. Smoothly Interpolate Settings
            float currentPitch = transform.eulerAngles.x;
            float usedPitch = Mathf.LerpAngle(currentPitch, _targetPitch, Time.deltaTime * 2f);

            // Simple Lerp for distance is usually enough, or use SmoothDamp if you want fancy zoom
            float currentDist = (transform.position - followPos).magnitude; // Approx
            float usedDist = Mathf.Lerp(currentDist, _targetDistance, Time.deltaTime * 2f);

            // 4. Calculate Offset Math
            float rad = usedPitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * _targetDistance; // Use target dist directly for stability
            float zOffset = -(Mathf.Cos(rad) * _targetDistance);

            // 5. Final Position
            Vector3 targetPos = followPos + new Vector3(0, yOffset, zOffset);

            // 6. Execute Move
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _currentVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(usedPitch, 0, 0);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\CircleRenderer.cs`
- Lines: 51
- Size: 1.4 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    [RequireComponent(typeof(LineRenderer))]
    public class CircleRenderer : MonoBehaviour
    {
        [Header("Settings")]
        public int segments = 50; // Smoothness
        public float radius = 1.0f;
        public float lineWidth = 0.1f;

        private LineRenderer _line;

        void Awake()
        {
            _line = GetComponent<LineRenderer>();
            DrawCircle();
        }

        // Draw immediately in Editor so you can see it
        void OnValidate()
        {
            _line = GetComponent<LineRenderer>();
            DrawCircle();
        }

        public void DrawCircle()
        {
            if (_line == null) return;

            _line.useWorldSpace = false; // Move with the parent
            _line.startWidth = lineWidth;
            _line.endWidth = lineWidth;
            _line.positionCount = segments + 1; // +1 to close the loop

            float angleStep = 360f / segments;

            for (int i = 0; i < segments + 1; i++)
            {
                float angle = i * angleStep * Mathf.Deg2Rad;

                // Draw on X/Z plane (Flat on ground)
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;

                _line.SetPosition(i, new Vector3(x, 0, z));
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\ActorThemeSO.cs`
- Lines: 13
- Size: 0.5 KB
- Modified: 2025-12-24 07:55

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/Actor Theme")]
    public class ActorThemeSO : ScriptableObject
    {
        [Header("3-Tone Palette")]
        public SurfaceDefinition primary;   // Main Body (e.g. Armor)
        public SurfaceDefinition secondary; // Details (e.g. Joints/Frame)
        public SurfaceDefinition tertiary;  // Accents (e.g. Eyes/Core - High Emission)
    }
}
```

## 📄 `Assets\Scripts\Core\Data\AttackPatternSO.cs`
- Lines: 23
- Size: 0.8 KB
- Modified: 2025-12-14 11:08

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Combat/Attack Pattern")]
    public class AttackPatternSO : ScriptableObject
    {
        [Header("Pattern Shape")]
        public int projectileCount = 1;
        [Range(0, 360)] public float spreadAngle = 0f; // 0 = Stream, 360 = Nova
        public bool spinDuringFire = false;
        public float spinSpeed = 0f;

        [Header("Timing")]
        public float delayBetweenShots = 0.1f; // Machine gun vs Shotgun
        public float startDelay = 0.5f; // Windup time

        [Header("Projectile Override")]
        public float speed = 15f;
        // Optional: Custom prefab for this specific attack? 
        // For now, we use the Agent's default prefab to keep it simple.
    }
}
```

## 📄 `Assets\Scripts\Core\Data\ColorPaletteSO.cs`
- Lines: 43
- Size: 1.6 KB
- Modified: 2025-12-24 08:09

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public struct SurfaceDefinition
    {
        [ColorUsage(true, true)] public Color mainColor;
        [Range(0f, 1f)] public float smoothness;
        [Range(0f, 1f)] public float metallic;
    }

    [CreateAssetMenu(fileName = "NewPalette", menuName = "DarkTowerTron/Visuals/Color Palette")]
    public class ColorPaletteSO : ScriptableObject
    {
        [Header("Player Theme")]
        public SurfaceDefinition playerPrimary;   // Body
        public SurfaceDefinition playerSecondary; // Visor / Details
        public SurfaceDefinition playerTertiary;  // Lights / Engine

        [Header("Enemy Theme")]
        public SurfaceDefinition enemyPrimary;    // Body (Red)
        public SurfaceDefinition enemySecondary;  // Joints (Grey/Dark)
        public SurfaceDefinition enemyTertiary;   // Eyes / Cores (Bright)

        // Keep legacy references for PaletteReceiver defaults
        // We can construct ActorThemeSO at runtime or just reference these values directly
        // For simplicity, PaletteManager will read these specific fields.

        [Header("Combat")]
        public SurfaceDefinition projectileHostile;
        public SurfaceDefinition projectileFriendly;
        [ColorUsage(true, true)] public Color staggerColor = Color.yellow;

        [Header("Environment")]
        public SurfaceDefinition floor;
        public SurfaceDefinition walls;
        public SurfaceDefinition hazards;

        [Header("Global")]
        public Color skyColor = Color.black;
    }
}
```

## 📄 `Assets\Scripts\Core\Data\EnemyStatsSO.cs`
- Lines: 62
- Size: 2.2 KB
- Modified: 2025-12-14 12:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewEnemyStats", menuName = "DarkTowerTron/Enemy Stats")]
    public class EnemyStatsSO : ScriptableObject
    {
        [Header("Wave Logic")]
        public bool isEssential = true;

        [Header("Rewards")]
        public int scoreValue = 100;
        public float focusReward = 30f;
        public bool healsGrit = true;
        [Min(1)] public int gritRewardAmount = 1;

        [Header("Movement")]
        public float moveSpeed = 8f;
        public float rotationSpeed = 10f; // Fast, for navigation
        public float combatRotationSpeed = 3f; // Slow, for aiming at player
        public float acceleration = 20f;

        [Header("Flight (Set 0 for Ground)")]
        public float rideHeight = 0f;
        public float verticalSmoothTime = 0.5f;

        [Header("Separation (Flocking)")]
        public float separationRadius = 1.5f;
        public float separationForce = 8f;

        [Header("Combat & Stagger")]
        public float maxStagger = 1.0f;
        public float staggerDecay = 0.5f;

        [Header("Defenses")]
        public bool hasFrontalShield = false;
        [Range(0f, 1f)] public float shieldAngle = 0.5f;

        // --- NEW: VALIDATION LOGIC ---
        // This runs automatically whenever you change a value in the Inspector
        private void OnValidate()
        {
            // Prevent negative movement
            moveSpeed = Mathf.Max(0f, moveSpeed);
            rotationSpeed = Mathf.Max(0f, rotationSpeed);
            combatRotationSpeed = Mathf.Max(0.1f, combatRotationSpeed);
            acceleration = Mathf.Max(0.1f, acceleration); // 0 accel = infinite stuck

            // Prevent negative rewards
            scoreValue = Mathf.Max(0, scoreValue);
            focusReward = Mathf.Max(0f, focusReward);
            gritRewardAmount = Mathf.Max(1, gritRewardAmount);

            // Prevent divide-by-zero or weird logic in Stagger
            maxStagger = Mathf.Max(0.1f, maxStagger);
            staggerDecay = Mathf.Max(0.1f, staggerDecay);

            // Flocking safety
            separationRadius = Mathf.Max(0.1f, separationRadius);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\MaterialCollectionSO.cs`
- Lines: 12
- Size: 0.4 KB
- Modified: 2025-12-23 19:42

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/Material Collection")]
    public class MaterialCollectionSO : ScriptableObject
    {
        [Tooltip("All materials in this list will share the same color palette.")]
        public List<Material> materials;
    }
}
```

## 📄 `Assets\Scripts\Core\Data\PlayerStatsSO.cs`
- Lines: 30
- Size: 0.9 KB
- Modified: 2025-12-24 08:43

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "PlayerStats_Default", menuName = "DarkTowerTron/Player/Base Stats")]
    public class PlayerStatsSO : ScriptableObject
    {
        [Header("Movement")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;

        [Header("Resources")]
        public int maxGrit = 2;
        public float maxFocus = 100f;

        [Header("Abilities")]
        public float dashCost = 25f;
        public float dashDistance = 8f;
        public float dashCooldown = 0.15f; // Duration

        [Header("Combat Globals")]
        public float damageMultiplier = 1.0f;
        public float fireRateMultiplier = 1.0f;

        [Header("Overdrive")]
        public float overdriveThreshold = 80f; // Focus needed
        public float overdriveSpeedMult = 1.2f;
        public float overdriveDamageMult = 2.0f;
    }
}
```

## 📄 `Assets\Scripts\Core\Data\WaveDefinitionSO.cs`
- Lines: 30
- Size: 0.8 KB
- Modified: 2025-12-11 13:58

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public class WaveEntry
    {
        public GameObject enemyPrefab;
        public int count = 1;
        public float rate = 1.0f;
        [Tooltip("-1 for Random, 0+ for specific index")]
        public int spawnPointIndex = -1;
    }

    [CreateAssetMenu(fileName = "NewWave", menuName = "DarkTowerTron/Wave Definition")]
    public class WaveDefinitionSO : ScriptableObject
    {
        [Header("Wave Info")]
        public string waveName = "Wave 1";

        [Header("Main Force (Essential)")]
        public List<WaveEntry> entries;

        [Header("Grunt Support (Fodder)")]
        public GameObject[] gruntPrefabs;
        public int maxGrunts = 0;
        public float gruntSpawnRate = 5f;
    }
}
```

## 📄 `Assets\Scripts\Core\GameConstants.cs`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-11 07:51

```csharp
namespace DarkTowerTron.Core
{
    public static class GameConstants
    {
        // Layers
        public const string LAYER_PLAYER = "Player";
        public const string LAYER_ENEMY = "Enemy";
        public const string LAYER_PROJECTILE = "Projectile";
        public const string LAYER_AFTERIMAGE = "AfterImage";
        public const string LAYER_GROUND = "Ground";
        public const string LAYER_WALL = "Wall";

        // Tags
        public const string TAG_PLAYER = "Player";
        public const string TAG_ENEMY = "Enemy";
    }
}
```

## 📄 `Assets\Scripts\Core\GameEvents.cs`
- Lines: 73
- Size: 2.5 KB
- Modified: 2025-12-24 15:19

```csharp
using System;
using UnityEngine;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Core
{
    public static class GameEvents
    {
        // --- COMBAT ---
        // OLD: public static Action<Vector3> OnEnemyKilled;

        // Updated Signature: Vector3 pos, Stats, bool rewardPlayer
        public static Action<Vector3, EnemyStatsSO, bool> OnEnemyKilled;

        public static Action OnPlayerHit;
        public static Action OnPlayerDied;

        // Feedback
        public static Action<Vector3, float, bool> OnDamageDealt;
        public static Action<Vector3, string> OnPopupText;

        // Resources
        public static Action<float, float> OnFocusChanged;
        public static Action<int> OnGritChanged;

        // NEW: True = Hull Active, False = Hull Broken (Danger)
        public static Action<bool> OnHullStateChanged;

        // System
        public static Action<Vector3> OnEnemySpawned;
        public static Action OnWaveCleared;
        public static Action OnRoomCleared; // Doors open, but game continues
        public static Action OnGameVictory; // Roll credits
        public static Action<int> OnWaveAnnounce;
        public static Action<string> OnCountdownChange;
        public static Action OnWaveCombatStarted;

        // AI
        public static Action<Transform> OnDecoySpawned;
        public static Action OnDecoyExpired;

        // UI
        public static Action<int, int> OnScoreChanged;

        /// <summary>
        /// CRITICAL FIX-004: Call this when loading scenes or quitting.
        /// Prevents static events from holding references to destroyed objects.
        /// </summary>
        public static void Cleanup()
        {
            OnEnemyKilled = null;
            OnPlayerHit = null;
            OnPlayerDied = null;
            OnDamageDealt = null;
            OnPopupText = null;
            OnFocusChanged = null;
            OnGritChanged = null;
            OnHullStateChanged = null;
            OnEnemySpawned = null;
            OnWaveCleared = null;
            OnRoomCleared = null;
            OnGameVictory = null;
            OnWaveAnnounce = null;
            OnCountdownChange = null;
            OnWaveCombatStarted = null;
            OnDecoySpawned = null;
            OnDecoyExpired = null;
            OnScoreChanged = null;
            
            Debug.Log("[GameEvents] All static listeners cleared.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameTime.cs`
- Lines: 35
- Size: 0.8 KB
- Modified: 2025-12-11 14:18

```csharp
using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Core
{
    public class GameTime : MonoBehaviour
    {
        public static GameTime Instance;
        private bool _isFrozen = false;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public void HitStop(float duration)
        {
            if (_isFrozen) return;
            StartCoroutine(DoHitStop(duration));
        }

        private IEnumerator DoHitStop(float duration)
        {
            _isFrozen = true;
            float originalScale = Time.timeScale;

            Time.timeScale = 0.0f;
            yield return new WaitForSecondsRealtime(duration);

            Time.timeScale = originalScale;
            _isFrozen = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\ICombatTarget.cs`
- Lines: 15
- Size: 0.4 KB
- Modified: 2025-12-19 07:22

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    /// <summary>
    /// Implemented by anything the Player can Lock-On to and Execute (Enemy or Prop).
    /// </summary>
    public interface ICombatTarget
    {
        Transform transform { get; } // Required to get position
        bool IsStaggered { get; }    // Execution condition

        void OnExecutionHit();
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IDamageable.cs`
- Lines: 8
- Size: 0.2 KB
- Modified: 2025-12-19 07:21

```csharp
namespace DarkTowerTron.Core
{
    public interface IDamageable
    {
        bool TakeDamage(DamageInfo info);
        void Kill(bool instant);
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IPoolable.cs`
- Lines: 8
- Size: 0.1 KB
- Modified: 2025-12-19 07:22

```csharp
namespace DarkTowerTron.Core
{
    public interface IPoolable
    {
        void OnSpawn();
        void OnDespawn();
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IReflectable.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2025-12-19 07:22

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner);
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IWeapon.cs`
- Lines: 7
- Size: 0.1 KB
- Modified: 2025-12-19 07:22

```csharp
namespace DarkTowerTron.Core
{
    public interface IWeapon
    {
        void SetFiring(bool isFiring);
    }
}
```

## 📄 `Assets\Scripts\Core\Spinner.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public class Spinner : MonoBehaviour
    {
        public Vector3 axis = new Vector3(0, 1, 0);
        public float speed = 50f;

        void Update()
        {
            transform.Rotate(axis, speed * Time.deltaTime);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Structs\DamageInfo.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2025-12-19 07:21

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    [System.Serializable]
    public struct DamageInfo
    {
        public float damageAmount;
        public float staggerAmount;
        public Vector3 pushDirection;
        public float pushForce;
        public GameObject source;
        public bool isRedirected;
    }
}
```

## 📄 `Assets\Scripts\Core\VoidKiller.cs`
- Lines: 33
- Size: 1.0 KB
- Modified: 2025-12-19 07:32

```csharp
using UnityEngine;
using DarkTowerTron.Player; // Access PlayerHealth directly for special void logic

namespace DarkTowerTron.Core
{
    public class VoidKiller : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            // 1. Check for Player
            PlayerHealth player = other.GetComponentInParent<PlayerHealth>();
            if (player != null)
            {
                player.TakeVoidDamage();
                return;
            }

            // 2. Check for Enemies (Instant Kill)
            IDamageable damageable = other.GetComponentInParent<IDamageable>();
            if (damageable != null)
            {
                damageable.Kill(true);
            }
            else
            {
                // Debris/Bullets
                Destroy(other.gameObject);
                // Note: If object is Pooled, this might break pool logic if not handled.
                // Ideally check for IPoolable, but Destroy is a safe fallback for cleanup.
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Chaser.cs`
- Lines: 133
- Size: 4.1 KB
- Modified: 2025-12-14 10:46

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.States.Chaser;

namespace DarkTowerTron.Enemy.Agents
{
    public enum ChaserMode { Missile, MineLayer }

    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Chaser : EnemyBaseAI
    {
        [Header("Mode Selection")]
        public ChaserMode mode = ChaserMode.Missile;

        [Header("Settings")]
        public float attackRange = 1.5f; 
        
        [Header("Mine Settings")]
        public GameObject hazardPrefab;
        public float fuseDuration = 0.5f;

        [Header("Missile Settings")]
        public float damage = 1f;
        public float explosionForce = 20f;

        [Header("Steering")]
        public System.Collections.Generic.List<SteeringBehavior> chaseBehaviors;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATES --
        public ChaserState_Chase StateChase { get; private set; }
        public ChaserState_Priming StatePriming { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            StateChase = new ChaserState_Chase(this);
            StatePriming = new ChaserState_Priming(this);
        }

        protected override void Start()
        {
            base.Start();
            FSM.Initialize(StateChase);
        }

        protected override void RunAI() { }

        // --- ATTACK LOGIC ---

        public void TriggerAttack()
        {
            if (mode == ChaserMode.Missile)
            {
                // INSTANT BOOM
                DetonateMissile();
            }
            else
            {
                // PRIME MINE (Shake then Boom)
                FSM.ChangeState(StatePriming);
            }
        }

        public void DetonateMissile()
        {
            // Standard damage logic
            if (_currentTarget != null)
            {
                IDamageable targetHealth = _currentTarget.GetComponentInParent<IDamageable>();
                if (targetHealth != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = transform.forward,
                        pushForce = explosionForce,
                        source = gameObject
                    };
                    targetHealth.TakeDamage(info);
                    _controller.SelfDestruct();
                }
                else
                {
                    // Hit Decoy? Reward.
                    if (_currentTarget.name.Contains("AfterImage")) _controller.Kill(true);
                    else _controller.SelfDestruct();
                }
            }
            else
            {
                _controller.SelfDestruct();
            }
        }

        public void DeployMine()
        {
            // Spawn Hazard
            if (hazardPrefab)
            {
                // Spawn at ground level
                Vector3 pos = transform.position;
                pos.y = 0;
                Instantiate(hazardPrefab, pos, Quaternion.identity);
            }
            
            // Die (No Reward, because you didn't kill it, it deployed)
            // Or Reward? Let's say SelfDestruct (No reward).
            _controller.SelfDestruct();
        }

        // ... Gizmos and Getters ...
        public Transform GetTarget() => _currentTarget;
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;
        
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackRange);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Guardian.cs`
- Lines: 152
- Size: 5.0 KB
- Modified: 2025-12-14 11:59

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.States.Guardian;

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Guardian : EnemyBaseAI
    {
        [Header("Patrol Config")]
        public float waypointTolerance = 1.5f;
        public List<SteeringBehavior> moveBehaviors;

        [Header("Combat Config")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public List<AttackPatternSO> attackPatterns;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATE DATA --
        public PatrolPath ActivePath { get; private set; }
        public int CurrentWaypointIndex { get; set; } = 0;

        // -- STATES --
        public GuardianState_Move StateMove { get; private set; }
        public GuardianState_Attack StateAttack { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            StateMove = new GuardianState_Move(this);
            StateAttack = new GuardianState_Attack(this);
        }

        protected override void Start()
        {
            base.Start();

            // Auto-find path if not assigned
            if (ActivePath == null)
            {
                ActivePath = FindNearestPath();
            }

            if (ActivePath != null && ActivePath.waypoints.Count > 0)
            {
                FSM.Initialize(StateMove);
            }
            else
            {
                Debug.LogWarning($"{name}: No PatrolPath found! Standing still.");
                FSM.Initialize(StateAttack);
            }
        }

        protected override void RunAI() { }

        public IEnumerator ExecutePattern(AttackPatternSO pattern)
        {
            if (pattern == null || projectilePrefab == null) yield break;

            yield return new WaitForSeconds(pattern.startDelay);

            float angleStep = (pattern.spreadAngle > 0 && pattern.projectileCount > 1)
                ? pattern.spreadAngle / (pattern.projectileCount - 1)
                : 0;

            float startAngle = -pattern.spreadAngle / 2f;

            for (int i = 0; i < pattern.projectileCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                float currentAngle = startAngle + (angleStep * i);

                if (pattern.spinDuringFire)
                    startAngle += pattern.spinSpeed * pattern.delayBetweenShots;

                Quaternion rot = transform.rotation * Quaternion.Euler(0, currentAngle, 0);
                Vector3 fireDir = rot * Vector3.forward;

                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;

                FireProjectile(projectilePrefab, spawnPos, rot, fireDir, pattern.speed);

                if (pattern.delayBetweenShots > 0)
                    yield return new WaitForSeconds(pattern.delayBetweenShots);
            }
        }

        // --- PATHFINDING HELPERS ---
        private PatrolPath FindNearestPath()
        {
            PatrolPath[] allPaths = FindObjectsOfType<PatrolPath>();
            if (allPaths.Length == 0) return null;

            PatrolPath closest = null;
            float closestDist = float.MaxValue;

            foreach (var path in allPaths)
            {
                if (path.waypoints.Count > 0 && path.waypoints[0] != null)
                {
                    float dist = Vector3.Distance(transform.position, path.waypoints[0].position);
                    if (dist < closestDist)
                    {
                        closestDist = dist;
                        closest = path;
                    }
                }
            }
            return closest;
        }

        public Transform GetCurrentWaypoint()
        {
            if (ActivePath == null || ActivePath.waypoints.Count == 0) return null;
            return ActivePath.waypoints[CurrentWaypointIndex];
        }

        public void AdvanceWaypoint()
        {
            if (ActivePath == null) return;
            CurrentWaypointIndex++;
            if (CurrentWaypointIndex >= ActivePath.waypoints.Count)
            {
                CurrentWaypointIndex = (ActivePath.loop) ? 0 : ActivePath.waypoints.Count - 1;
            }
        }

        // --- PUBLIC ACCESSORS (Fixes CS1061) ---
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;

        // This was the missing one:
        public Transform GetTarget() => _currentTarget;
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Sentinel.cs`
- Lines: 88
- Size: 3.0 KB
- Modified: 2025-12-14 10:25

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.States.Sentinel; // Sub-namespace for States

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Sentinel : EnemyBaseAI
    {
        [Header("Tactics")]
        public float combatRange = 10f; // Switch to Combat
        public float huntRange = 15f;   // Switch back to Hunt

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float fireRate = 2.0f;

        [Header("Steering Profiles")]
        // Assigned in Inspector (e.g. Seek, AvoidWalls)
        public List<SteeringBehavior> huntBehaviors;
        // Assigned in Inspector (e.g. Orbit, Flee, AvoidWalls)
        public List<SteeringBehavior> combatBehaviors;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATES --
        public SentinelState_Hunt StateHunt { get; private set; }
        public SentinelState_Combat StateCombat { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            // Initialize States
            StateHunt = new SentinelState_Hunt(this);
            StateCombat = new SentinelState_Combat(this);
        }

        protected override void Start()
        {
            base.Start();
            // Start Hunting immediately
            FSM.Initialize(StateHunt);
        }

        protected override void RunAI()
        {
            // Logic is delegated to the FSM component via its own Update loop.
        }

        // --- HELPERS FOR STATES ---

        public void HelperFireProjectile()
        {
            if (projectilePrefab && !_controller.IsStaggered)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;

                // Use BaseAI helper to spawn via Pool
                FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f);
            }
        }

        // Expose protected members to States
        public Transform GetTarget() => _currentTarget;
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;

        private void OnDrawGizmosSelected()
        {
            // Visualize the hysteresis ranges
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, combatRange);
            Gizmos.color = new Color(1, 1, 0, 0.3f);
            Gizmos.DrawWireSphere(transform.position, huntRange);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Sniper.cs`
- Lines: 86
- Size: 2.9 KB
- Modified: 2025-12-14 10:23

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.States.Sniper;

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Sniper : EnemyBaseAI
    {
        [Header("Tactics")]
        public float panicDistance = 6f;
        public float attackRange = 18f;

        [Tooltip("How far to jump when panicking")]
        public float teleportDistance = 12f; // NEW: Configurable
        public float teleportCooldown = 5f;
        public LayerMask wallLayer;

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public LineRenderer laserSight;
        public float fireRate = 3.0f;
        public float aimDuration = 1.5f;

        [Header("Steering Profiles (Optimization)")]
        // NEW: Pre-allocated lists to prevent Garbage Collection spikes
        public List<SteeringBehavior> positioningBehaviors;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATES --
        public SniperState_Positioning StatePositioning { get; private set; }
        public SniperState_Aiming StateAiming { get; private set; }
        public SniperState_Teleport StateTeleport { get; private set; }
        public SniperState_Firing StateFiring { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);

            // Initialize States
            StatePositioning = new SniperState_Positioning(this);
            StateAiming = new SniperState_Aiming(this);
            StateTeleport = new SniperState_Teleport(this);
            StateFiring = new SniperState_Firing(this);
        }

        protected override void Start()
        {
            base.Start();
            if (laserSight) laserSight.enabled = false;

            FSM.Initialize(StatePositioning);
        }

        protected override void RunAI()
        {
            // Logic delegated to FSM
        }

        // Helpers
        public void HelperFireProjectile(float speed)
        {
            if (projectilePrefab)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;
                FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, speed);
            }
        }

        public Transform GetTarget() => _currentTarget;
    }
}
```

## 📄 `Assets\Scripts\Enemy\BossController.cs`
- Lines: 97
- Size: 2.9 KB
- Modified: 2025-12-24 13:50

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Environment;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    public class BossController : MonoBehaviour, IDamageable
    {
        [Header("Parts")]
        public Transform coreRotationRoot; // The object that spins
        public List<DamageableProp> hands; // The 4 Hands
        public GameObject shieldVisual;    // The Barrier around the core

        [Header("Settings")]
        public float rotationSpeedIdle = 10f;
        public float rotationSpeedCombat = 30f;
        public float health = 100f;

        private bool _isCombatActive = false;
        private bool _isVulnerable = false;

        private void Start()
        {
            // Boss is invincible until hands are dead
            if (shieldVisual) shieldVisual.SetActive(true);
        }

        private void Update()
        {
            // 1. Rotation Logic
            float currentSpeed = _isCombatActive ? rotationSpeedCombat : rotationSpeedIdle;
            if (coreRotationRoot)
            {
                coreRotationRoot.Rotate(Vector3.up, currentSpeed * Time.deltaTime);
            }

            // 2. Check Hands (Simple Phase Logic)
            if (_isCombatActive && !_isVulnerable)
            {
                int aliveHands = 0;
                foreach (var hand in hands)
                {
                    if (hand.gameObject.activeSelf) aliveHands++;
                }

                if (aliveHands == 0)
                {
                    EnterVulnerablePhase();
                }
            }
        }

        // Called by WaveTrigger or Timeline
        public void ActivateBoss()
        {
            _isCombatActive = true;
            // Optional: Roar sound / Camera Shake
        }

        private void EnterVulnerablePhase()
        {
            _isVulnerable = true;
            if (shieldVisual) shieldVisual.SetActive(false); // Drop Shield

            // Juice
            GameEvents.OnPopupText?.Invoke(transform.position, "SHIELD DOWN");
            // Slow rotation to make hitting easier?
            rotationSpeedCombat = 5f;
        }

        // --- IDamageable (The Core) ---
        public bool TakeDamage(DamageInfo info)
        {
            if (!_isVulnerable)
            {
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
                return false;
            }

            health -= info.damageAmount;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, true);

            if (health <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            // BOSS DEATH
            GameEvents.OnGameVictory?.Invoke(); // Win the game!
            Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyBaseAI.cs`
- Lines: 107
- Size: 3.3 KB
- Modified: 2025-12-14 08:33

```csharp
using UnityEngine;
using DG.Tweening; // Logic relies on Tweening
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(EnemyController))]
    public abstract class EnemyBaseAI : MonoBehaviour, IPoolable
    {
        protected EnemyMotor _motor;
        protected EnemyController _controller;
        protected Transform _player;
        protected Transform _currentTarget;

        // Spawn state gate (prevents AI ticking during spawn animation)
        protected bool _isSpawning = false;

        protected virtual void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _controller = GetComponent<EnemyController>();
        }

        // REPLACE old OnEnable with OnSpawn
        public virtual void OnSpawn()
        {
            _isSpawning = true;
            transform.localScale = Vector3.zero;

            GameEvents.OnEnemySpawned?.Invoke(transform.position);

            transform.DOScale(Vector3.one, 0.8f)
                .SetEase(Ease.OutBack)
                .OnComplete(() => _isSpawning = false);

            // Reset any child AI timers here if needed
        }

        public virtual void OnDespawn()
        {
            transform.DOKill(); // Stop scaling tween
            _isSpawning = false;
        }

        protected virtual void Start()
        {
            GameObject p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p)
            {
                _player = p.transform;
                _currentTarget = _player;
            }

            GameEvents.OnDecoySpawned += OnDecoySpawned;
            GameEvents.OnDecoyExpired += OnDecoyExpired;
        }

        protected virtual void OnDestroy()
        {
            GameEvents.OnDecoySpawned -= OnDecoySpawned;
            GameEvents.OnDecoyExpired -= OnDecoyExpired;
        }

        private void Update()
        {
            // BLOCK LOGIC IF SPAWNING
            if (_isSpawning) return;

            if (_player == null) return;
            if (_currentTarget == null) _currentTarget = _player;
            if (_controller.IsStaggered) return;

            RunAI();
        }

        protected abstract void RunAI();

        // --- HELPER METHODS ---

        /// <summary>
        /// Centralized logic to spawn, reset, and fire a hostile projectile.
        /// </summary>
        protected void FireProjectile(GameObject prefab, Vector3 position, Quaternion rotation, Vector3 direction, float speed)
        {
            if (prefab == null) return;

            // 1. Spawn via Pool
            GameObject p = PoolManager.Instance.Spawn(prefab, position, rotation);

            // 2. Setup Logic
            Projectile proj = p.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.ResetHostility(true); // Enemies always shoot hostile
                proj.speed = speed;
                proj.Initialize(direction);
            }
        }

        // --- EVENTS ---
        private void OnDecoySpawned(Transform decoy) { _currentTarget = decoy; }
        private void OnDecoyExpired() { if (_player != null) _currentTarget = _player; }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyController.cs`
- Lines: 225
- Size: 6.6 KB
- Modified: 2025-12-24 08:12

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable, IPoolable, ICombatTarget
    {
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public ColorPaletteSO palette;

        // Cache colors
        private Color _normalColor;
        private Color _staggerColor;
        private Color _flashColor = Color.white;

        [Header("Audio")]
        public AudioClip staggerClip;

        private EnemyMotor _motor;
        private float _currentStagger;
        private float _lastHitTime;
        public bool IsStaggered { get; private set; }

        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween;
        private int _colorPropID;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();

            _propBlock = new MaterialPropertyBlock();
            _colorPropID = Shader.PropertyToID("_BaseColor");

            // Load defaults
            _normalColor = Color.red;
            _staggerColor = Color.yellow;

            if (palette != null)
            {
                _normalColor = palette.enemyPrimary.mainColor;
                _staggerColor = palette.staggerColor;
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            ResetState();
        }

        public void OnDespawn()
        {
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_normalColor);
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;
            SetColor(_normalColor);
        }

        private void ResetState()
        {
            IsStaggered = false;
            _currentStagger = 0;
            SetColor(_normalColor);
        }

        private void Update()
        {
            if (_stats == null) return;

            if (!IsStaggered && _currentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f)
                {
                    _currentStagger -= _stats.staggerDecay * Time.deltaTime;
                    if (_currentStagger < 0) _currentStagger = 0;
                }
            }
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_stats == null) return false;
            _lastHitTime = Time.time;

            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            if (_stats.hasFrontalShield && !IsStaggered)
            {
                Vector3 incomingDir = info.pushDirection.normalized;
                float impactAngle = Vector3.Dot(transform.forward, -incomingDir);

                if (impactAngle > _stats.shieldAngle)
                {
                    GameEvents.OnPopupText?.Invoke(transform.position, "BLOCKED");
                    return false;
                }
            }

            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            bool isBigHit = info.isRedirected || IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isBigHit);

            if (IsStaggered)
            {
                if (info.damageAmount > 0) Kill(false);
            }
            else
            {
                AddStagger(info.staggerAmount);
                Flash();
            }
            return true;
        }

        private void AddStagger(float amount)
        {
            _currentStagger += amount;
            if (_currentStagger >= _stats.maxStagger) EnterStaggerState();
        }

        private void EnterStaggerState()
        {
            IsStaggered = true;
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (Managers.AudioManager.Instance && staggerClip)
                Managers.AudioManager.Instance.PlaySound(staggerClip, 1f, true);

            if (_flashTween != null) _flashTween.Kill();

            float flashLerp = 0f;
            _flashTween = DOTween.To(() => flashLerp, x => flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });

            DOVirtual.DelayedCall(2.0f, ExitStaggerState).SetId(gameObject);
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;
            if (_flashTween != null) _flashTween.Kill();
            _currentStagger = 0;
            SetColor(_normalColor);
        }

        private void Flash()
        {
            if (!IsStaggered)
            {
                if (_flashTween != null) _flashTween.Kill();

                SetColor(_flashColor);
                _flashTween = DOVirtual.DelayedCall(0.1f, () =>
                {
                    if (!IsStaggered) SetColor(_normalColor);
                }).SetId(gameObject);
            }
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                // Also set Emission to match for the glow effect
                _propBlock.SetColor("_EmissionColor", c);
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }

        public void Kill(bool instant)
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, true);
            SafeDestroy();
        }

        public void SelfDestruct()
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, false);
            SafeDestroy();
        }

        private void SafeDestroy()
        {
#if UNITY_EDITOR
            if (UnityEditor.Selection.activeGameObject == gameObject) 
                UnityEditor.Selection.activeGameObject = null;
#endif
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }

        public void OnExecutionHit()
        {
            Kill(false);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyMotors.cs`
- Lines: 171
- Size: 5.5 KB
- Modified: 2025-12-14 12:17

```csharp
using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(KinematicMover))]
    public class EnemyMotor : MonoBehaviour, IPoolable
    {
        [Header("Data Profile")]
        public EnemyStatsSO stats;

        [Header("Layers")]
        public LayerMask allyLayer;

        private KinematicMover _mover;
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed;
        private Collider[] _neighbors = new Collider[10];

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            if (allyLayer == 0) allyLayer = LayerMask.GetMask(GameConstants.LAYER_ENEMY);
        }

        private void OnEnable()
        {
            // Keep existing behavior even when not spawned via pool
            OnSpawn();
        }

        // --- IPoolable ---
        public void OnSpawn()
        {
            // Reset Physics State
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Reset Position logic
            if (stats != null && stats.rideHeight > 0)
            {
                Vector3 startPos = transform.position;
                startPos.y = 0;
                transform.position = startPos;
            }
        }

        public void OnDespawn()
        {
            // Stop moving immediately so we don't drift while in the pool
            _currentVelocity = Vector3.zero;
        }

        public void Move(Vector3 desiredDirection)
        {
            if (stats == null) return;

            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;
            Vector3 targetVel = desiredDirection * stats.moveSpeed;

            // 1. Separation
            if (stats.moveSpeed > 0.1f)
            {
                Vector3 separationPush = CalculateSeparation();
                targetVel += separationPush;
            }

            // 2. Inertia
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, stats.acceleration * dt);

            // 3. Knockback
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            // 4. COMBINE
            Vector3 finalVelocity = _currentVelocity + _knockbackForce;

            // 5. VERTICAL LOGIC (Flight vs Gravity)
            if (stats.rideHeight > 0)
            {
                // FLYING: Calculate vertical velocity to reach height
                float currentY = transform.position.y;
                float targetY = stats.rideHeight;
                float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, stats.verticalSmoothTime);

                // Convert distance delta back to velocity for the motor
                float verticalVel = (newY - currentY) / dt;
                finalVelocity.y = verticalVel;
            }
            else
            {
                // WALKING: Apply Gravity if not grounded
                if (!_mover.IsGrounded)
                {
                    finalVelocity.y -= 20f; // Standard gravity
                }
                else
                {
                    finalVelocity.y = -2f; // Stick
                }
            }

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        private Vector3 CalculateSeparation()
        {
            Vector3 pushVector = Vector3.zero;

            // Use stats.separationRadius
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, stats.separationRadius, _neighbors, allyLayer);

            for (int i = 0; i < count; i++)
            {
                var neighbor = _neighbors[i];
                if (neighbor.gameObject == gameObject) continue;

                Vector3 direction = transform.position - neighbor.transform.position;
                float dist = direction.magnitude;

                if (dist < 0.01f) direction = Random.insideUnitSphere;

                pushVector += direction.normalized / (dist + 0.1f);
            }

            // Use stats.separationForce
            return pushVector * stats.separationForce;
        }

        // Standard Face Target (Uses Navigation Speed)
        public void FaceTarget(Vector3 targetPosition)
        {
            if (stats == null) return;
            RotateTowards(targetPosition, stats.rotationSpeed);
        }

        // Combat Face Target (Uses Slower Combat Speed)
        public void FaceCombatTarget(Vector3 targetPosition)
        {
            if (stats == null) return;
            RotateTowards(targetPosition, stats.combatRotationSpeed);
        }

        // Helper to avoid duplicate code
        private void RotateTowards(Vector3 targetPosition, float speed)
        {
            Vector3 dir = targetPosition - transform.position;
            dir.y = 0; 
            
            if (dir != Vector3.zero)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, speed * Time.deltaTime);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\PatrolPath.cs`
- Lines: 28
- Size: 0.8 KB
- Modified: 2025-12-14 11:08

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Enemy
{
    public class PatrolPath : MonoBehaviour
    {
        public List<Transform> waypoints;
        public bool loop = true;

        private void OnDrawGizmos()
        {
            if (waypoints == null || waypoints.Count < 2) return;

            Gizmos.color = Color.cyan;
            for (int i = 0; i < waypoints.Count - 1; i++)
            {
                if (waypoints[i] && waypoints[i + 1])
                    Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }

            if (loop && waypoints[0] && waypoints[waypoints.Count - 1])
            {
                Gizmos.DrawLine(waypoints[waypoints.Count - 1].position, waypoints[0].position);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Chaser\ChaserState_Chase.cs`
- Lines: 42
- Size: 1.1 KB
- Modified: 2025-12-14 10:44

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Chaser
{
    public class ChaserState_Chase : State
    {
        private EnemyAgent_Chaser _agent;

        public ChaserState_Chase(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            _agent.Brain.behaviors = _agent.chaseBehaviors;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null) return;

            // 1. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            if (moveDir.sqrMagnitude > 0.1f)
                _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);

            // 2. Transition
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            if (dist <= _agent.attackRange)
            {
                // DELEGATE DECISION TO AGENT
                _agent.TriggerAttack();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Chaser\ChaserState_Primer.cs`
- Lines: 63
- Size: 1.9 KB
- Modified: 2025-12-14 10:45

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using System.Collections.Generic;
using DG.Tweening;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Chaser
{
    public class ChaserState_Priming : State
    {
        private EnemyAgent_Chaser _agent;
        private float _timer;
        private Tween _shakeTween;

        public ChaserState_Priming(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.fuseDuration;

            // VISUAL WARNING: Shake the mesh
            // (Assumes Art is a child, so we shake the child or local rotation)
            // A simple scale punch or color flash works too.
            // Let's do a Color Flash + Scale Shake

            if (_agent.GetController().meshRenderer)
            {
                _agent.GetController().meshRenderer.material.DOColor(Color.red, 0.1f).SetLoops(-1, LoopType.Yoyo);
            }
            _agent.transform.DOShakeScale(_agent.fuseDuration, 0.5f, 20, 90);
        }

        public override void LogicUpdate()
        {
            _timer -= Time.deltaTime;

            // Lock rotation to target so it looks aggressive
            if (_agent.GetTarget() != null)
            {
                _agent.GetMotor().FaceTarget(_agent.GetTarget().position);
            }

            if (_timer <= 0)
            {
                _agent.DeployMine(); // CHANGED: Was Detonate()
            }
        }

        public override void Exit()
        {
            // Cleanup tweens if we get stunned/killed during priming
            _agent.transform.DOKill();
            if (_agent.GetController().meshRenderer)
                _agent.GetController().meshRenderer.material.DOKill();
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Guardian\GuardianState_Attack.cs`
- Lines: 62
- Size: 1.9 KB
- Modified: 2025-12-14 12:18

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Core.Data;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Guardian
{
    public class GuardianState_Attack : State
    {
        private EnemyAgent_Guardian _agent;

        public GuardianState_Attack(EnemyAgent_Guardian agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // 1. Stop Moving
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>(); 
            
            // 2. Start Shooting Routine
            _agent.StartCoroutine(AttackRoutine());
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;

            // Keep facing player while shooting (Slowly!)
            Transform combatTarget = _agent.GetTarget();
            if (combatTarget != null)
            {
                _agent.GetMotor().FaceCombatTarget(combatTarget.position);
            }
        }

        private System.Collections.IEnumerator AttackRoutine()
        {
            // Debug check
            if (_agent.attackPatterns == null || _agent.attackPatterns.Count == 0)
            {
                Debug.LogWarning("Guardian has no Attack Patterns assigned!");
            }
            else
            {
                // Pick random pattern
                AttackPatternSO pattern = _agent.attackPatterns[Random.Range(0, _agent.attackPatterns.Count)];
                
                // Execute and Wait for it to finish
                yield return _agent.ExecutePattern(pattern);
            }
            
            // Cooldown after firing
            yield return new WaitForSeconds(1.5f);

            // Go back to moving
            _stateMachine.ChangeState(_agent.StateMove);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Guardian\GuardianState_Move.cs`
- Lines: 75
- Size: 2.5 KB
- Modified: 2025-12-14 12:17

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.AI.Core; // For AIData
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Guardian
{
    public class GuardianState_Move : State
    {
        private EnemyAgent_Guardian _agent;

        public GuardianState_Move(EnemyAgent_Guardian agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // 1. Set Steering to "Move Profile"
            _agent.Brain.behaviors = _agent.moveBehaviors;

            // 2. Tell the Brain to Seek the Waypoint
            // We must update AIData so ContextSolver knows where to go
            var aiData = _agent.GetComponent<AIData>();
            if (aiData != null)
            {
                aiData.currentTarget = _agent.GetCurrentWaypoint();
            }
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;

            Transform wp = _agent.GetCurrentWaypoint();

            // Safety: If path is broken/missing, switch to attack in place
            if (wp == null)
            {
                _stateMachine.ChangeState(_agent.StateAttack);
                return;
            }

            // --- MOVEMENT ---
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // --- ROTATION (Use SLOW Combat Speed when looking at player) ---
            Transform combatTarget = _agent.GetTarget();

            if (combatTarget != null)
            {
                // Use the slow rotation method for aiming at player
                _agent.GetMotor().FaceCombatTarget(combatTarget.position);
            }
            else
            {
                // Fallback: Face movement direction using normal speed
                if (moveDir.sqrMagnitude > 0.1f)
                    _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);
            }

            // --- TRANSITION ---
            // Check distance to Waypoint (flat check to ignore height diff)
            Vector3 toWaypoint = wp.position - _agent.transform.position;
            toWaypoint.y = 0;

            if (toWaypoint.magnitude < _agent.waypointTolerance)
            {
                _agent.AdvanceWaypoint(); // Select next point for NEXT time
                _stateMachine.ChangeState(_agent.StateAttack);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sentinel\SentinelState_Combat.cs`
- Lines: 56
- Size: 1.7 KB
- Modified: 2025-12-14 10:26

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sentinel
{
    public class SentinelState_Combat : State
    {
        private EnemyAgent_Sentinel _agent;
        private float _fireTimer;

        public SentinelState_Combat(EnemyAgent_Sentinel agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Load "Orbit + Flee" Profile
            _agent.Brain.behaviors = _agent.combatBehaviors;

            // Randomize first shot
            _fireTimer = Random.Range(0.5f, _agent.fireRate);
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;
            if (_agent.GetTarget() == null) return;

            // 1. Move (Orbit/Strafe)
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // 2. Aim (Always lock on target)
            _agent.GetMotor().FaceTarget(_agent.GetTarget().position);

            // 3. Fire
            _fireTimer -= Time.deltaTime;
            if (_fireTimer <= 0)
            {
                _agent.HelperFireProjectile();
                _fireTimer = _agent.fireRate;
            }

            // 4. Transition Check
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            // Use "HuntRange" (hysteresis) to prevent flickering
            if (dist > _agent.huntRange)
            {
                _stateMachine.ChangeState(_agent.StateHunt);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sentinel\SentinelState_Hunt.cs`
- Lines: 44
- Size: 1.2 KB
- Modified: 2025-12-14 10:35

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sentinel
{
    public class SentinelState_Hunt : State
    {
        private EnemyAgent_Sentinel _agent;

        public SentinelState_Hunt(EnemyAgent_Sentinel agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Load "Seek" Profile
            _agent.Brain.behaviors = _agent.huntBehaviors;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;
            if (_agent.GetTarget() == null) return;

            // 1. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // Face movement
            if (moveDir.sqrMagnitude > 0.1f)
                _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);

            // 2. Transition Check
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            if (dist <= _agent.combatRange)
            {
                _stateMachine.ChangeState(_agent.StateCombat);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Aiming.cs`
- Lines: 65
- Size: 1.9 KB
- Modified: 2025-12-14 10:23

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Aiming : State
    {
        private EnemyAgent_Sniper _agent;
        private float _timer;

        public SniperState_Aiming(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING (Clear behaviors or set empty list)
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.aimDuration;
            if (_agent.laserSight) _agent.laserSight.enabled = true;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null)
            {
                _stateMachine.ChangeState(_agent.StatePositioning);
                return;
            }

            _timer -= Time.deltaTime;

            // 1. Visuals
            if (_agent.laserSight)
            {
                Vector3 start = _agent.firePoint ? _agent.firePoint.position : _agent.transform.position;
                // Aim at chest
                Vector3 end = _agent.GetTarget().position + Vector3.up * 1.0f;
                _agent.laserSight.SetPosition(0, start);
                _agent.laserSight.SetPosition(1, end);
            }

            // 2. Tracking (Stop tracking in last 0.2s for fairness)
            if (_timer > 0.2f)
            {
                _agent.GetComponent<EnemyMotor>().FaceTarget(_agent.GetTarget().position);
            }

            // 3. Transition
            if (_timer <= 0)
            {
                _stateMachine.ChangeState(_agent.StateFiring);
            }
        }

        public override void Exit()
        {
            if (_agent.laserSight) _agent.laserSight.enabled = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Firing.cs`
- Lines: 24
- Size: 0.6 KB
- Modified: 2025-12-14 10:24

```csharp
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Firing : State
    {
        private EnemyAgent_Sniper _agent;

        public SniperState_Firing(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Shoot
            _agent.HelperFireProjectile(35f); // Fast bullet

            // Immediately return to positioning
            _stateMachine.ChangeState(_agent.StatePositioning);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Positioning.cs`
- Lines: 54
- Size: 1.6 KB
- Modified: 2025-12-14 10:24

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Positioning : State
    {
        private EnemyAgent_Sniper _agent;
        private float _cooldownTimer;

        public SniperState_Positioning(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // OPTIMIZATION: Assign the pre-filled list reference. 
            // Zero Garbage Allocation.
            _agent.Brain.behaviors = _agent.positioningBehaviors;

            _cooldownTimer = 1.0f;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null) return;

            if (_cooldownTimer > 0) _cooldownTimer -= Time.deltaTime;

            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            // 1. Panic
            if (dist < _agent.panicDistance)
            {
                _stateMachine.ChangeState(_agent.StateTeleport);
                return;
            }

            // 2. Attack
            if (dist < _agent.attackRange && _cooldownTimer <= 0)
            {
                _stateMachine.ChangeState(_agent.StateAiming);
                return;
            }

            // 3. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetComponent<EnemyMotor>().Move(moveDir);
            _agent.GetComponent<EnemyMotor>().FaceTarget(_agent.GetTarget().position);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Teleport.cs`
- Lines: 61
- Size: 1.7 KB
- Modified: 2025-12-14 10:24

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DG.Tweening;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper

{
    public class SniperState_Teleport : State
    {
        private EnemyAgent_Sniper _agent;
        private bool _isTeleporting;

        public SniperState_Teleport(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            _isTeleporting = true;
            _agent.transform.DOScale(Vector3.zero, 0.2f).OnComplete(PerformJump);
        }

        private void PerformJump()
        {
            if (_agent == null) return;

            Vector3 dirAway = (_agent.transform.position - _agent.GetTarget().position).normalized;

            // CONFIGURABLE DISTANCE
            float dist = _agent.teleportDistance;
            Vector3 dest = _agent.transform.position + (dirAway * dist);

            // Wall Check
            if (UnityEngine.Physics.Raycast(_agent.transform.position, dirAway, out RaycastHit hit, dist, _agent.wallLayer))
            {
                dest = hit.point - (dirAway * 2f);
            }

            dest.y = 0;
            _agent.transform.position = dest;

            // Reset Velocity
            _agent.GetComponent<EnemyMotor>().OnSpawn();

            _agent.transform.DOScale(Vector3.one, 0.2f).OnComplete(() =>
            {
                _isTeleporting = false;
            });
        }

        public override void LogicUpdate()
        {
            if (!_isTeleporting)
            {
                _stateMachine.ChangeState(_agent.StatePositioning);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\ArenaGate.cs`
- Lines: 80
- Size: 2.5 KB
- Modified: 2025-12-24 15:19

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class ArenaGate : MonoBehaviour
    {
        [Header("Settings")]
        public float animDuration = 1.0f;
        public float openHeight = -3f; // Move down to hide
        public float closedHeight = 0f; // Move up to block

        [Header("Parts")]
        public Transform gateVisuals;
        public Collider gateCollider;
        public Renderer gateRenderer; // To change color (Red=Locked, Green=Open)

        [Header("Colors")]
        public Color lockedColor = Color.red;
        public Color openColor = Color.green;

        private void Start()
        {
            // Start Open
            OpenGate(true);

            // Listen for full room completion to open gates
            GameEvents.OnRoomCleared += OpenGate;
        }

        private void OnDestroy()
        {
            GameEvents.OnRoomCleared -= OpenGate;
        }

        /// <summary>
        /// Called by WaveTrigger to instantly close this gate.
        /// </summary>
        public void ForceClose()
        {
            SetGate(true); // Close immediately
        }

        // Wrapper methods for event subscription cleanliness
        private void CloseGate() => SetGate(true);
        private void OpenGate() => SetGate(false);
        // Overload for instant snap
        private void OpenGate(bool instant) => SetGate(false, instant);

        private void SetGate(bool isClosed, bool instant = false)
        {
            float targetY = isClosed ? closedHeight : openHeight;
            Color targetColor = isClosed ? lockedColor : openColor;

            if (gateCollider) gateCollider.enabled = isClosed;

            if (gateVisuals)
            {
                if (instant)
                {
                    Vector3 pos = gateVisuals.localPosition;
                    pos.y = targetY;
                    gateVisuals.localPosition = pos;
                }
                else
                {
                    gateVisuals.DOLocalMoveY(targetY, animDuration).SetEase(Ease.OutBack);
                }
            }

            if (gateRenderer)
            {
                // Tween Color/Emission
                gateRenderer.material.DOColor(targetColor, "_BaseColor", animDuration);
                gateRenderer.material.DOColor(targetColor, "_EmissionColor", animDuration);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\CameraZone.cs`
- Lines: 48
- Size: 1.5 KB
- Modified: 2025-12-24 17:20

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Environment
{
    public class CameraZone : MonoBehaviour
    {
        [Header("Camera Overrides")]
        [Tooltip("-1 to keep default")]
        public float targetPitch = 30f; // Lower angle = more "forward" view
        public float targetDistance = 20f; // Zoom in slightly?

        [Header("Axis Locking")]
        public bool lockX = false;
        public bool lockZ = false; // Check this for Side-Scrolling (Left/Right movement only)

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                var rig = FindObjectOfType<CameraRig>();
                if (rig)
                {
                    // Pass the center of THIS trigger as the lock position
                    rig.OverrideCamera(targetPitch, targetDistance, lockX, lockZ, transform.position);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                var rig = FindObjectOfType<CameraRig>();
                if (rig) rig.ResetToDefault();
            }
        }

        // Visualize the Zone
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 1, 1, 0.2f);
            Gizmos.DrawCube(transform.position, transform.localScale);
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\DamageableProp.cs`
- Lines: 172
- Size: 5.4 KB
- Modified: 2025-12-23 17:58

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class DamageableProp : MonoBehaviour, IDamageable, ICombatTarget
    {
        [Header("Stats")]
        public float health = 10f;
        public bool isImmortal = false;
        public bool volatileStructure = false; // NEW: Stagger hurts Health

        [Header("Stagger Logic")]
        public float maxStagger = 1.0f;
        public float staggerDecay = 1.0f;
        public float staggerDuration = 2.0f;

        [Header("Death Rattle")]
        public GameObject spawnOnDeath;
        public bool destroyOnDeath = true;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.cyan;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        private float _currentStagger;
        public bool IsStaggered { get; private set; }

        private void Start()
        {
            if (meshRenderer) meshRenderer.material.color = normalColor;
        }

        private void Update()
        {
            if (!IsStaggered && _currentStagger > 0)
            {
                _currentStagger -= staggerDecay * Time.deltaTime;
                if (_currentStagger < 0) _currentStagger = 0;
            }
        }

        // --- IDamageable ---
        public bool TakeDamage(DamageInfo info)
        {
            Flash();

            // 1. Add Stagger (Standard Logic)
            if (!IsStaggered)
            {
                _currentStagger += info.staggerAmount;
                if (_currentStagger >= maxStagger)
                {
                    EnterStaggerState();
                }
            }

            // 2. Take Health Damage
            if (!isImmortal)
            {
                float finalDamage = info.damageAmount;

                // NEW: If Volatile, Stagger Damage counts as Health Damage
                if (volatileStructure)
                {
                    finalDamage += info.staggerAmount;
                }

                // Crit multiplier if already staggered
                if (IsStaggered) finalDamage *= 2f;

                health -= finalDamage;

                // Only show numbers if damage > 0
                if (finalDamage > 0)
                    GameEvents.OnDamageDealt?.Invoke(transform.position, finalDamage, IsStaggered);

                if (health <= 0)
                {
                    Die();
                }
            }

            return true;
        }

        public void Kill(bool instant) => Die();

        // --- ICombatTarget (Glory Kill) ---
        public void OnExecutionHit()
        {
            if (isImmortal)
            {
                // Anchor Logic (Bounce)
                transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
                IsStaggered = false;
                _currentStagger = 0;
                if (meshRenderer) meshRenderer.material.color = normalColor;
            }
            else
            {
                // Boss Hand / Barrel Logic
                if (volatileStructure)
                {
                    // Volatile things explode instantly on execution
                    Die();
                }
                else
                {
                    // Standard props take massive damage
                    DamageInfo executionDmg = new DamageInfo { damageAmount = 50f };
                    TakeDamage(executionDmg);
                }
            }
        }

        // ... (EnterStaggerState, Flash, Die methods remain the same) ...

        private void EnterStaggerState()
        {
            IsStaggered = true;
            if (meshRenderer) meshRenderer.material.color = staggerColor;
            GameEvents.OnPopupText?.Invoke(transform.position, "READY");

            DOVirtual.DelayedCall(staggerDuration, () =>
            {
                IsStaggered = false;
                _currentStagger = 0;
                if (this != null && meshRenderer) meshRenderer.material.color = normalColor;
            });
        }

        private void Flash()
        {
            if (meshRenderer)
            {
                meshRenderer.material.DOColor(flashColor, 0.1f).OnComplete(() =>
                {
                    if (this != null)
                        meshRenderer.material.color = IsStaggered ? staggerColor : normalColor;
                });
            }
        }

        private void Die()
        {
            if (spawnOnDeath)
            {
                if (Managers.PoolManager.Instance)
                    Managers.PoolManager.Instance.Spawn(spawnOnDeath, transform.position, Quaternion.identity);
                else
                    Instantiate(spawnOnDeath, transform.position, Quaternion.identity);
            }

            // Note: We pass 'false' to reward because blowing up a barrel isn't a "Kill" for stats
            // Unless you want it to be?
            GameEvents.OnEnemyKilled?.Invoke(transform.position, null, false);

            if (destroyOnDeath)
            {
                if (Managers.PoolManager.Instance)
                    Managers.PoolManager.Instance.Despawn(gameObject);
                else
                    gameObject.SetActive(false);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\WaveTrigger.cs`
- Lines: 57
- Size: 1.6 KB
- Modified: 2025-12-24 15:18

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Managers;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Environment
{
    public class WaveTrigger : MonoBehaviour
    {
        [Header("Configuration")]
        public List<WaveDefinitionSO> wavesForThisRoom;
        public Transform[] spawnPointsForThisRoom;

        [Header("Arena Gates")]
        public ArenaGate[] gatesToClose; // Assign gates here

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {

            Debug.Log("WaveTrigger: OnTriggerEnter called.");

            if (_triggered) return;

            if (other.CompareTag("Player"))
            {
                _triggered = true;
                StartRoomEncounter();
            }
        }

        private void StartRoomEncounter()
        {
            var director = FindObjectOfType<WaveDirector>();
            var spawner = FindObjectOfType<ArenaSpawner>();

            if (director && spawner)
            {
                // 1. Setup Data
                spawner.spawnPoints = spawnPointsForThisRoom;
                director.waves = wavesForThisRoom;
                
                // 2. Lock the doors instantly
                foreach (var gate in gatesToClose)
                {
                    if (gate) gate.ForceClose();
                }

                // 3. Start the Show
                director.StartGame();
            }
            
            gameObject.SetActive(false);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\ArenaSpawner.cs`
- Lines: 33
- Size: 1.1 KB
- Modified: 2025-12-24 15:21

```csharp
using UnityEngine;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        // CHANGED: Returns GameObject instead of void
        public GameObject SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            if (spawnPoints.Length == 0 || prefab == null) return null;

            Transform sp;

            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length)
                sp = spawnPoints[forcedIndex];
            else
                sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Vector3 offset = Random.insideUnitSphere * 2.0f;
            
            // Spawn 1.0 meter in the air. 
            // Ground units fall. Flying units use 'OnSpawn' to handle height.
            offset.y = 1.0f;

            // Return the actual instance
            return PoolManager.Instance.Spawn(prefab, sp.position + offset, Quaternion.LookRotation(sp.forward));
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\AudioManager.cs`
- Lines: 40
- Size: 1.1 KB
- Modified: 2025-12-11 14:14

```csharp
using UnityEngine;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        [Header("Sources")]
        [SerializeField] private AudioSource _sfxSource;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        /// <summary>
        /// Plays a sound with optional pitch randomization.
        /// </summary>
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (clip == null || _sfxSource == null) return;

            if (randomizePitch)
            {
                _sfxSource.pitch = Random.Range(0.9f, 1.1f);
            }
            else
            {
                _sfxSource.pitch = 1.0f;
            }

            _sfxSource.PlayOneShot(clip, volume);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\DamageTextManager.cs`
- Lines: 65
- Size: 2.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class DamageTextManager : MonoBehaviour
    {
        [Header("Setup")]
        public GameObject textPrefab; // Assign the prefab here

        [Header("Settings")]
        public Vector3 offset = new Vector3(0, 2f, 0); // Spawn above enemy head
        public Color normalColor = Color.white;
        public Color critColor = Color.yellow;
        public Color infoColor = Color.cyan; // For "STAGGER"

        private void OnEnable()
        {
            GameEvents.OnDamageDealt += ShowDamage;
            GameEvents.OnPopupText += ShowPopup;
        }

        private void OnDisable()
        {
            GameEvents.OnDamageDealt -= ShowDamage;
            GameEvents.OnPopupText -= ShowPopup;
        }

        private void ShowDamage(Vector3 pos, float amount, bool isCrit)
        {
            if (textPrefab == null || PoolManager.Instance == null) return;

            // Spawn
            GameObject obj = PoolManager.Instance.Spawn(textPrefab, pos + offset, Quaternion.identity);

            // Configure
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();
            if (floatingText)
            {
                Color c = isCrit ? critColor : normalColor;
                float scale = isCrit ? 1.5f : 1.0f;

                // N0 formats to integer (10 instead of 10.0)
                floatingText.Initialize(amount.ToString("N0"), c, scale);

                // Billboarding: Make text face the camera
                obj.transform.forward = Camera.main.transform.forward;
            }
        }

        private void ShowPopup(Vector3 pos, string message)
        {
            if (textPrefab == null || PoolManager.Instance == null) return;

            GameObject obj = PoolManager.Instance.Spawn(textPrefab, pos + offset, Quaternion.identity);
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();

            if (floatingText)
            {
                floatingText.Initialize(message, infoColor, 1.2f);
                obj.transform.forward = Camera.main.transform.forward;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\DebugController.cs`
- Lines: 94
- Size: 3.1 KB
- Modified: 2025-12-24 13:35

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn; // Assign prefabs in Inspector

        [Header("Perk Testing")]
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;

        private void Start()
        {
            // Find player components safely
            var p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p)
            {
                _energy = p.GetComponent<PlayerEnergy>();
                _health = p.GetComponent<PlayerHealth>();
                _loadout = p.GetComponent<PlayerLoadout>();
            }
        }

        private void Update()
        {
            // 1. Time Control
            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f; // Slow motion toggle
            }

            // 2. Kill All
            if (Input.GetKeyDown(KeyCode.K))
            {
                var enemies = FindObjectsOfType<DarkTowerTron.Enemy.EnemyController>();
                foreach (var e in enemies) e.Kill(true);
            }

            // 3. Recharge
            if (Input.GetKeyDown(KeyCode.R) && _energy)
            {
                _energy.AddFocus(100f);
                if (_health) _health.HealGrit(2);
            }

            // 4. Manual Spawning (NumPad 1-4)
            if (Input.GetKeyDown(KeyCode.Keypad1)) Spawn(0); // Grunt
            if (Input.GetKeyDown(KeyCode.Keypad2)) Spawn(1); // Sniper
            if (Input.GetKeyDown(KeyCode.Keypad3)) Spawn(2); // Orbiter
            if (Input.GetKeyDown(KeyCode.Keypad4)) Spawn(3); // Guardian

            // 5. Cheats Application
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);

            // 6. Toggle Perks
            if (Input.GetKeyDown(KeyCode.H)) // Homing
            {
                Debug.Log("Cheat: Equipped Homing Missiles");
                if (_loadout) _loadout.EquipProjectile(homingPrefab);
            }

            if (Input.GetKeyDown(KeyCode.J)) // Juke (Decoy)
            {
                Debug.Log("Cheat: Equipped Explosive Decoy");
                if (_loadout) _loadout.EquipDecoy(explosiveDecoyPrefab);
            }
        }

        private void Spawn(int index)
        {
            if (index < 0 || index >= enemiesToSpawn.Length) return;

            // Spawn at cursor logic or random offset
            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0;

            PoolManager.Instance.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\FeedbackDirector.cs`
- Lines: 71
- Size: 2.3 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Visuals; // <--- THIS WAS MISSING

namespace DarkTowerTron.Managers
{
    public class FeedbackDirector : MonoBehaviour
    {
        [Header("Global Audio")]
        public AudioClip hitClip;
        public AudioClip killClip;
        public AudioClip playerHurtClip;

        [Header("Hull")]
        public AudioClip hullBreakClip; // Drag "Glass Shatter" or "Alarm" here

        private bool _hasLastHullState;
        private bool _lastHasHull;

        private void OnEnable()
        {
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnHullStateChanged += OnHullChanged;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnHullStateChanged -= OnHullChanged;
        }

        private void OnHullChanged(bool hasHull)
        {
            bool lostHull = _hasLastHullState && _lastHasHull && !hasHull;

            _hasLastHullState = true;
            _lastHasHull = hasHull;

            // Only play feedback if we LOST the hull (became false)
            if (!lostHull) return;

            if (AudioManager.Instance) AudioManager.Instance.PlaySound(hullBreakClip, 1.0f);
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.5f, 0.7f); // Big shake
            if (GameTime.Instance) GameTime.Instance.HitStop(0.2f); // Dramatic pause
        }

        private void OnPlayerHit()
        {
            // 1. Audio
            if (AudioManager.Instance) AudioManager.Instance.PlaySound(playerHurtClip);

            // 2. Camera
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.3f, 0.5f);

            // 3. Time
            if (GameTime.Instance) GameTime.Instance.HitStop(0.1f);
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            // 1. Audio
            if (AudioManager.Instance) AudioManager.Instance.PlaySound(killClip, 0.8f);

            // 2. Camera (Lighter shake)
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.15f, 0.2f);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\GameFeel.cs`
- Lines: 98
- Size: 3.0 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DG.Tweening; // Requires DOTween

namespace DarkTowerTron.Core
{
    public class GameFeel : MonoBehaviour
    {
        public static GameFeel Instance;

        [Header("Audio Settings")]
        [SerializeField] private AudioSource _sfxSource;
        [SerializeField] private AudioClip _hitClip;
        [SerializeField] private AudioClip _killClip;
        [SerializeField] private AudioClip _playerHurtClip;

        private Camera _childCam; // The camera we shake (Child of Rig)

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // Find the Main Camera (which should be the Child of CameraRig)
            _childCam = Camera.main;
            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            // Auto-hook into events for generic feedback
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        // --- PUBLIC API ---

        public void CameraShake(float duration, float strength)
        {
            if (_childCam == null) return;
            // Shake local position so it doesn't fight the CameraRig's smooth follow
            _childCam.transform.DOShakePosition(duration, strength, 20, 90, false, true);
        }

        public void HitStop(float duration)
        {
            if (Time.timeScale < 0.1f) return; // Don't stack stops
            StartCoroutine(DoHitStop(duration));
        }

        // Updated API: Added 'randomizePitch' bool
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (!clip || !_sfxSource) return;

            if (randomizePitch)
            {
                _sfxSource.pitch = Random.Range(0.9f, 1.1f);
            }
            else
            {
                _sfxSource.pitch = 1.0f;
            }

            _sfxSource.PlayOneShot(clip, volume);
        }

        // --- EVENT HANDLERS ---

        private void OnPlayerHit()
        {
            PlaySound(_playerHurtClip);
            CameraShake(0.3f, 0.5f); // Heavy shake on damage
            HitStop(0.1f);
        }

        // Update the signature
        private void OnEnemyKilled(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats, bool rewardPlayer)
        {
            PlaySound(_killClip, 0.8f);
            CameraShake(0.15f, 0.2f); 
        }

        // --- INTERNAL ---

        System.Collections.IEnumerator DoHitStop(float duration)
        {
            Time.timeScale = 0.0f;
            yield return new WaitForSecondsRealtime(duration);
            Time.timeScale = 1.0f;
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\GameSession.cs`
- Lines: 146
- Size: 4.3 KB
- Modified: 2025-12-24 14:10

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Player;

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("UI References")]
        public GameObject startPanel;
        public GameObject tutorialPanel;
        public GameObject hudPanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel;
        public GameObject pausePanel;

        [Header("Scene References")]
        public PlayerController player;
        
        // CHANGED: Was WaveManager, now WaveDirector
        public WaveDirector waveDirector; 

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls;

        private void Awake()
        {
            _controls = new GameControls();
            _controls.Gameplay.Pause.performed += ctx => TogglePause();
        }

        private void OnEnable() => _controls.Enable();
        private void OnDisable() => _controls.Disable();

        private void Start()
        {
            // CRITICAL CHANGE: Pause physics/time immediately
            Time.timeScale = 0f; 
            
            SetPanelActive(startPanel);

            // Input is disabled, but Time=0 stops gravity too
            if (player) player.ToggleInput(false);

            GameEvents.OnPlayerDied += TriggerGameOver;
            GameEvents.OnGameVictory += TriggerVictory;
        }

        private void OnDestroy()
        {
            // Unsubscribe LOCAL listeners first
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;

            // THEN wipe the static board
            // This ensures no one else triggers events on dead objects during unload
            GameEvents.Cleanup();
        }

        // --- PUBLIC UI FUNCTIONS ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;
            
            // UNPAUSE: Physics and Logic start now
            Time.timeScale = 1f; 
            
            SetPanelActive(hudPanel);

            if (player) player.ToggleInput(true);
            
            // Wave start handled by WaveTrigger at arena entrance
        }

        public void TogglePause()
        {
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0f;
                pausePanel.SetActive(true);
                if (player) player.ToggleInput(false);
            }
            else
            {
                Time.timeScale = 1f;
                pausePanel.SetActive(false);
                if (player) player.ToggleInput(true);
            }
        }

        public void OpenTutorial() { SetPanelActive(tutorialPanel); }
        public void BackToMenu() { SetPanelActive(startPanel); }

        public void RestartGame()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void QuitGame()
        {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        private void TriggerGameOver()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.2f; 
            SetPanelActive(gameOverPanel);
            if (player) player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.5f; 
            SetPanelActive(victoryPanel);
            if (player) player.ToggleInput(false);
        }

        private void SetPanelActive(GameObject activePanel)
        {
            if(startPanel) startPanel.SetActive(false);
            if(tutorialPanel) tutorialPanel.SetActive(false);
            if(hudPanel) hudPanel.SetActive(false);
            if(gameOverPanel) gameOverPanel.SetActive(false);
            if(victoryPanel) victoryPanel.SetActive(false);
            if(pausePanel) pausePanel.SetActive(false);

            if (activePanel) activePanel.SetActive(true);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\HUDManager.cs`
- Lines: 128
- Size: 4.2 KB
- Modified: 2025-12-14 08:19

```csharp
using UnityEngine;
using UnityEngine.UI;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Focus")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color overheatFocusColor = Color.red;

        [Header("Grit (Health)")]
        public GameObject[] gritPips; // Drag your Pip Images here
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f); // Faded

        [Header("Hull / Wound")]
        public Image hullIcon; // Assign the Wound Image
        public Color hullActiveColor = Color.cyan; // Shield is UP
        public Color hullBrokenColor = new Color(1, 0, 0, 0.3f); // Shield BROKEN (Red/Transparent)

        [Header("System")]
        public TMPro.TextMeshProUGUI waveText;

        [Header("Score UI")]
        public TMPro.TextMeshProUGUI scoreText;
        public TMPro.TextMeshProUGUI multiplierText;
        public TMPro.TextMeshProUGUI timerText;

        private void Update()
        {
            // Simple Timer Update
            if (timerText && Managers.ScoreManager.Instance)
            {
                float t = Managers.ScoreManager.Instance.GameTime;
                // Format 00:00
                string minutes = Mathf.Floor(t / 60).ToString("00");
                string seconds = (t % 60).ToString("00");
                timerText.text = $"{minutes}:{seconds}";
            }
        }

        private void OnEnable()
        {
            GameEvents.OnFocusChanged += UpdateFocus;
            GameEvents.OnGritChanged += UpdateGrit;
            GameEvents.OnScoreChanged += UpdateScoreUI;
            GameEvents.OnHullStateChanged += UpdateHull;
            // Optional: Listen for wave changes if we added that event
        }

        private void OnDisable()
        {
            GameEvents.OnFocusChanged -= UpdateFocus;
            GameEvents.OnGritChanged -= UpdateGrit;
            GameEvents.OnScoreChanged -= UpdateScoreUI;
            GameEvents.OnHullStateChanged -= UpdateHull;
        }

        private void UpdateHull(bool hasHull)
        {
            if (!hullIcon) return;

            if (hasHull)
            {
                // Hull is intact
                hullIcon.color = hullActiveColor;
                // Optional: hullIcon.sprite = shieldSprite;
            }
            else
            {
                // Hull is gone (Danger State)
                hullIcon.color = hullBrokenColor;
                // Optional: hullIcon.sprite = brokenSkullSprite;
            }
        }

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider)
            {
                focusSlider.value = current / max;
            }

            // Optional: Change color if full (Overheat warning)
            if (focusFillImage)
            {
                focusFillImage.color = (current >= max) ? overheatFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit)
        {

            Debug.Log($"[DEBUG HUD] Updating Grit UI: {currentGrit}");

            if (gritPips == null) return;

            Debug.Log($"[DEBUG HUD] Grit Pips Length: {gritPips.Length}");

            for (int i = 0; i < gritPips.Length; i++)
            {
                if (gritPips[i] == null) continue;

                Debug.Log($"[DEBUG HUD] Updating Pip {i}");

                Image pipImg = gritPips[i].GetComponent<Image>();
                if (pipImg)
                {

                    Debug.Log($"[DEBUG HUD] Setting Pip {i} Color");

                    // If currentGrit is 2, pips 0 and 1 are active.
                    pipImg.color = (i < currentGrit) ? activePipColor : inactivePipColor;
                }
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0"); // "N0" adds commas (1,000)
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\MusicManager.cs`
- Lines: 53
- Size: 1.5 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DG.Tweening; // For smooth pitch fade
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        private AudioSource _source;
        private float _originalPitch;
        private float _originalVolume;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            _originalPitch = _source.pitch;
            _originalVolume = _source.volume;
        }

        private void OnEnable()
        {
            GameEvents.OnPlayerDied += OnDeath;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerDied -= OnDeath;
        }

        private void Start()
        {
            // Ensure loop is on
            _source.loop = true;
            if (!_source.isPlaying) _source.Play();
        }

        private void OnDeath()
        {
            // The "Power Down" Effect
            // Drop pitch to 0.5 and volume to 0.5 over 1 second
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true); // SetUpdate(true) ignores Time.timeScale = 0
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }

        // Called automatically when scene reloads
        public void ResetMusic()
        {
            _source.pitch = _originalPitch;
            _source.volume = _originalVolume;
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\PaletteManager.cs`
- Lines: 117
- Size: 4.1 KB
- Modified: 2025-12-24 08:10

```csharp
using UnityEngine;
using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Visuals; // For Receiver

namespace DarkTowerTron.Managers
{
    [ExecuteAlways]
    public class PaletteManager : MonoBehaviour
    {
        public static PaletteManager Instance;
        public ColorPaletteSO activePalette;

        // Event for Receivers
        public event Action OnPaletteChanged;

        [Header("Actor Collections")]
        public MaterialCollectionSO playerPrimaryCols;
        public MaterialCollectionSO playerSecondaryCols;
        public MaterialCollectionSO playerTertiaryCols;

        public MaterialCollectionSO enemyPrimaryCols;
        public MaterialCollectionSO enemySecondaryCols;
        public MaterialCollectionSO enemyTertiaryCols;

        [Header("Environment Collections")]
        public MaterialCollectionSO floorCols;
        public MaterialCollectionSO wallCols;
        public MaterialCollectionSO hazardCols;
        public MaterialCollectionSO projectileHostileCols;
        public MaterialCollectionSO projectileFriendlyCols;

        public bool refreshNow = false;

        private void Awake()
        {
            if (Application.isPlaying)
            {
                if (Instance == null) Instance = this;
                else Destroy(gameObject);
            }
            else
            {
                // In Editor mode, allow temporary instance
                Instance = this;
            }
        }

        private void Update()
        {
            if (refreshNow)
            {
                ApplyPalette();
                refreshNow = false;
            }
        }

        private void Start()
        {
            if (Application.isPlaying) ApplyPalette();
        }

        public void ApplyPalette()
        {
            if (activePalette == null) return;

            // 1. Player (Global Materials)
            ApplySurface(playerPrimaryCols, activePalette.playerPrimary);
            ApplySurface(playerSecondaryCols, activePalette.playerSecondary);
            ApplySurface(playerTertiaryCols, activePalette.playerTertiary);

            // 2. Enemies (Global Materials)
            ApplySurface(enemyPrimaryCols, activePalette.enemyPrimary);
            ApplySurface(enemySecondaryCols, activePalette.enemySecondary);
            ApplySurface(enemyTertiaryCols, activePalette.enemyTertiary);

            // 3. Environment (Global Materials)
            ApplySurface(floorCols, activePalette.floor);
            ApplySurface(wallCols, activePalette.walls);
            ApplySurface(hazardCols, activePalette.hazards);
            ApplySurface(projectileHostileCols, activePalette.projectileHostile);
            ApplySurface(projectileFriendlyCols, activePalette.projectileFriendly);

            if (Camera.main)
                Camera.main.backgroundColor = activePalette.skyColor;

            // 2. Notify Actors (Local Property Blocks)
            OnPaletteChanged?.Invoke();

            // Force update editor-time receivers
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                var receivers = FindObjectsOfType<PaletteReceiver>();
                foreach (var r in receivers) r.ManualRefresh();
            }
#endif

            Debug.Log($"Palette Applied: {activePalette.name}");
        }

        // ApplySurface helper remains the same...
        private void ApplySurface(MaterialCollectionSO collection, SurfaceDefinition surf)
        {
            if (collection == null || collection.materials == null) return;
            foreach (var mat in collection.materials)
            {
                if (mat == null) continue;
                if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", surf.mainColor);
                if (mat.HasProperty("_EmissionColor")) mat.SetColor("_EmissionColor", surf.mainColor);
                if (mat.HasProperty("_Smoothness")) mat.SetFloat("_Smoothness", surf.smoothness);
                if (mat.HasProperty("_Metallic")) mat.SetFloat("_Metallic", surf.metallic);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\PoolManager.cs`
- Lines: 87
- Size: 3.0 KB
- Modified: 2025-12-14 12:57

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core; // For IPoolable

namespace DarkTowerTron.Managers
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance;

        // Dictionary mapping Prefab InstanceID -> Queue of Objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();
        // Dictionary mapping Spawned Object InstanceID -> Prefab InstanceID
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            int poolKey = prefab.GetInstanceID();

            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objectToSpawn;

            if (_poolDictionary[poolKey].Count > 0)
            {
                objectToSpawn = _poolDictionary[poolKey].Dequeue();
                // Move before waking up to prevent visual flicker/logic errors
                objectToSpawn.transform.position = position;
                objectToSpawn.transform.rotation = rotation;
                objectToSpawn.SetActive(true);
            }
            else
            {
                objectToSpawn = Instantiate(prefab, position, rotation);
            }

            // Call IPoolable.OnSpawn
            var poolables = objectToSpawn.GetComponentsInChildren<IPoolable>();
            foreach (var p in poolables) p.OnSpawn();

            // Track relationship
            int instanceKey = objectToSpawn.GetInstanceID();
            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }

            return objectToSpawn;
        }

        public void Despawn(GameObject obj)
        {
            int instanceKey = obj.GetInstanceID();

            if (_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                // Call IPoolable.OnDespawn
                var poolables = obj.GetComponentsInChildren<IPoolable>();
                foreach (var p in poolables) p.OnDespawn();

                int poolKey = _spawnedObjectsParentId[instanceKey];

                // CRITICAL FIX-001: Remove tracking entry to prevent memory leak
                _spawnedObjectsParentId.Remove(instanceKey);

                obj.SetActive(false);
                obj.transform.SetParent(transform);

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                // Not a pooled object? Just destroy it.
                Destroy(obj);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\ScoreManager.cs`
- Lines: 98
- Size: 2.7 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Managers
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance;

        [Header("Score Settings")]
        public int baseScorePerKill = 100;
        public int gloryKillBonus = 500;

        [Header("Multiplier Settings")]
        public int currentMultiplier = 1;
        public int maxMultiplier = 5;

        public int TotalScore { get; private set; }
        public float GameTime { get; private set; }

        private bool _isTracking = false;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        private void Start()
        {
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerHit += OnPlayerHit;
            _isTracking = true;
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerHit -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking) GameTime += Time.deltaTime;
        }

        // --- FIXED METHOD SIGNATURE ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Determine score from Stats asset, or use default if missing
            int scoreValue = (stats != null) ? stats.scoreValue : baseScorePerKill;

            // Apply Multiplier
            AddScore(scoreValue * currentMultiplier);

            // Increase Multiplier
            if (currentMultiplier < maxMultiplier)
            {
                currentMultiplier++;
                UpdateUI();
            }
        }
        // -----------------------------

        private void OnPlayerHit()
        {
            if (currentMultiplier > 1)
            {
                currentMultiplier = 1;
                UpdateUI();
            }
        }

        public void StopTracking() { _isTracking = false; }

        public void AddScore(int amount)
        {
            TotalScore += amount;
            UpdateUI();
        }

        public void TriggerGloryKillBonus()
        {
            int bonus = gloryKillBonus * currentMultiplier;
            Debug.Log($"<color=yellow>GLORY KILL! +{bonus}</color>");
            AddScore(bonus);
        }

        private void UpdateUI()
        {
            GameEvents.OnScoreChanged?.Invoke(TotalScore, currentMultiplier);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\VFXManager.cs`
- Lines: 48
- Size: 1.6 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class VFXManager : MonoBehaviour
    {
        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab; 

        private void OnEnable()
        {
            GameEvents.OnEnemyKilled += PlayDeathVFX;
            GameEvents.OnEnemySpawned += PlaySpawnVFX; // NEW
        }

        private void OnDisable()
        {
            GameEvents.OnEnemyKilled -= PlayDeathVFX;
            GameEvents.OnEnemySpawned -= PlaySpawnVFX;
        }

        // Update the signature to match the new Event
        private void PlayDeathVFX(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab && PoolManager.Instance)
            {
                GameObject vfx = PoolManager.Instance.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && PoolManager.Instance)
            {
                // FIX: Force the VFX to the ground level (Y=0.1 to avoid z-fighting)
                Vector3 groundPos = new Vector3(pos.x, 0.1f, pos.z);

                GameObject vfx = PoolManager.Instance.Spawn(spawnPrefab, groundPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\WaveDirector.cs`
- Lines: 193
- Size: 6.4 KB
- Modified: 2025-12-24 15:20

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(ArenaSpawner))]
    public class WaveDirector : MonoBehaviour
    {
        [Header("Configuration")]
        public List<WaveDefinitionSO> waves;
        public float timeBetweenWaves = 3.0f;

        private ArenaSpawner _spawner;

        private int _currentWaveIndex = 0;
        private int _essentialEnemiesAlive = 0;
        private int _gruntsAlive = 0;

        private bool _isSpawningMain = false;
        private bool _gameStarted = false;
        private Coroutine _gruntRoutine;

        private void Awake()
        {
            _spawner = GetComponent<ArenaSpawner>();
        }

        private void OnEnable() => GameEvents.OnEnemyKilled += OnEnemyKilled;
        private void OnDisable() => GameEvents.OnEnemyKilled -= OnEnemyKilled;

        public void StartGame()
        {
            _gameStarted = true;
            _currentWaveIndex = 0;
            StartCoroutine(StartGameRoutine());
        }

        private IEnumerator StartGameRoutine()
        {
            yield return new WaitForSeconds(0.1f);
            StartCoroutine(RunWave(_currentWaveIndex));
        }

        private IEnumerator RunWave(int index)
        {
            // Stop condition: all waves complete
            if (index >= waves.Count)
            {
                Debug.Log("ROOM CLEARED");
                // Open the doors. Boss script will handle Victory separately.
                GameEvents.OnRoomCleared?.Invoke();
                yield break;
            }

            WaveDefinitionSO wave = waves[index];
            Debug.Log($"WAVE {index + 1}: {wave.waveName}");

            // --- COUNTDOWN ---
            GameEvents.OnWaveAnnounce?.Invoke(index);
            yield return new WaitForSeconds(1.0f);
            for (int c = 3; c > 0; c--)
            {
                GameEvents.OnCountdownChange?.Invoke(c.ToString());
                yield return new WaitForSeconds(1.0f);
            }
            GameEvents.OnCountdownChange?.Invoke("ENGAGE");
            GameEvents.OnWaveCombatStarted?.Invoke();
            yield return new WaitForSeconds(0.5f);
            GameEvents.OnCountdownChange?.Invoke("");
            // -----------------

            // Reset
            _isSpawningMain = true;
            _essentialEnemiesAlive = 0;
            _gruntsAlive = 0;

            // Start Grunt Logic (Infinite Reinforcements)
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
            _gruntRoutine = StartCoroutine(GruntLogic(wave));

            // Spawn Main Force
            foreach (var entry in wave.entries)
            {
                for (int i = 0; i < entry.count; i++)
                {
                    SpawnEnemy(entry.enemyPrefab, entry.spawnPointIndex);
                    yield return new WaitForSeconds(entry.rate);
                }
            }

            _isSpawningMain = false;
        }

        private IEnumerator GruntLogic(WaveDefinitionSO wave)
        {
            if (wave.maxGrunts <= 0 || wave.gruntPrefabs == null || wave.gruntPrefabs.Length == 0)
                yield break;

            // Anchor Logic: Keep spawning ONLY while VIPs are alive
            while (_essentialEnemiesAlive > 0 || _isSpawningMain)
            {
                if (_gruntsAlive < wave.maxGrunts)
                {
                    GameObject prefab = wave.gruntPrefabs[Random.Range(0, wave.gruntPrefabs.Length)];
                    SpawnEnemy(prefab, -1);
                }
                yield return new WaitForSeconds(wave.gruntSpawnRate);
            }
        }

        // Updated Spawn Method
        private void SpawnEnemy(GameObject prefab, int forcedIndex)
        {
            if (_spawner == null) return;
            
            if (prefab == null)
            {
                Debug.LogError($"WaveDirector: Attempted to spawn NULL prefab.");
                return;
            }

            // CRITICAL FIX-002: Get the actual spawned instance
            GameObject instance = _spawner.SpawnEnemy(prefab, forcedIndex);

            if (instance == null) return;

            // Check the INSTANCE stats, not the PREFAB stats
            var motor = instance.GetComponentInChildren<DarkTowerTron.Enemy.EnemyMotor>();
            bool countAsEssential = false;

            if (motor != null && motor.stats != null)
            {
                countAsEssential = motor.stats.isEssential;
            }
            else
            {
                Debug.LogWarning($"Enemy {instance.name} missing Stats! Defaulting to Essential.");
                countAsEssential = true;
            }

            if (countAsEssential) _essentialEnemiesAlive++;
            else _gruntsAlive++;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!_gameStarted) return;

            if (stats != null && stats.isEssential)
            {
                _essentialEnemiesAlive--;

                // ANCHOR: If VIPs are dead, cut the reinforcement line immediately
                if (_essentialEnemiesAlive <= 0)
                {
                    if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
                    Debug.Log("VIPs Down. Reinforcements Stopped.");
                }
            }
            else
            {
                _gruntsAlive--;
            }

            // Check victory on EVERY death (Grunt or VIP)
            CheckVictory();
        }

        private void CheckVictory()
        {
            // VICTORY CONDITION: Room must be totally silent.
            if (_essentialEnemiesAlive <= 0 && _gruntsAlive <= 0 && !_isSpawningMain)
            {
                Debug.Log("WAVE CLEARED - SECTOR SECURE");

                if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);

                GameEvents.OnWaveCleared?.Invoke();
                _currentWaveIndex++;
                StartCoroutine(NextWaveRoutine());
            }
        }

        private IEnumerator NextWaveRoutine()
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            StartCoroutine(RunWave(_currentWaveIndex));
        }
    }
}
```

## 📄 `Assets\Scripts\Physics\KinematicMover.cs`
- Lines: 276
- Size: 11.2 KB
- Modified: 2025-12-24 15:01

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;

namespace DarkTowerTron.Physics
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class KinematicMover : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] private LayerMask _obstacleMask;
        [SerializeField] private float _skinWidth = 0.015f;
        [SerializeField] private float _maxStepHeight = 0.3f;
        [Range(0f, 90f)][SerializeField] private float _maxSlopeAngle = 45f;
        [SerializeField] private float _groundSnapDistance = 0.3f;

        [Header("Optimization")]
        public bool useCulling = true;
        public float cullingDistance = 40f; // Beyond this, physics stops

        // Events
        public event System.Action<Vector3> OnCollision;
        public event System.Action<float> OnStepClimbed;

        // State
        private CapsuleCollider _capsule;
        private Vector3 _velocity;
        private Vector3 _groundNormal = Vector3.up;
        private bool _isGrounded;
        private Transform _activePlatform;
        private Vector3 _platformLastPos;
        private Quaternion _platformLastRot;

        private Transform _camTransform;

        // Cache
        private RaycastHit[] _hitBuffer = new RaycastHit[8];
        private HashSet<Collider> _ignoredColliders = new HashSet<Collider>();

        // Properties
        public Vector3 Velocity => _velocity;
        public bool IsGrounded => _isGrounded;
        public Vector3 GroundNormal => _groundNormal;

        private void Awake()
        {
            _capsule = GetComponent<CapsuleCollider>();
            if (Camera.main) _camTransform = Camera.main.transform;
            if (_obstacleMask == 0) _obstacleMask = 1;
        }

        public void Move(Vector3 desiredVelocity)
        {
            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

            // --- CULLING CHECK ---
            // Fix: Never cull the Player, even if camera is far away
            if (useCulling && _camTransform != null && !gameObject.CompareTag(GameConstants.TAG_PLAYER))
            {
                // SqrMagnitude is faster than Distance
                float distSqr = (transform.position - _camTransform.position).sqrMagnitude;
                if (distSqr > cullingDistance * cullingDistance)
                {
                    // CHEAP MOVEMENT: Just translate, ignore walls
                    transform.Translate(desiredVelocity * dt, Space.World);
                    return; // Skip the expensive stuff below
                }
            }
            // ---------------------

            // 1. Safety & Platforming
            Depenetrate();
            HandlePlatformMovement();
            CheckGround();

            // 2. Resolve Collisions using Desired Velocity * dt
            Vector3 finalMotion = ResolveCollisions(desiredVelocity * dt);

            // 3. Apply Movement
            transform.position += finalMotion;
            HandleGroundSnapping(finalMotion);

            // 4. Update Internal Velocity (so caller knows actual speed)
            _velocity = finalMotion / dt;
        }

        public void Teleport(Vector3 pos) { transform.position = pos; _velocity = Vector3.zero; }
        public void IgnoreCollider(Collider col) => _ignoredColliders.Add(col);

        // ================= INTERNAL PHYSICS =================

        private Vector3 ResolveCollisions(Vector3 motion)
        {
            Vector3 pos = transform.position;
            Vector3 remaining = motion;
            Vector3 totalMoved = Vector3.zero;

            for (int i = 0; i < 5; i++)
            {
                float dist = remaining.magnitude;
                if (dist < 1e-5f) break;

                // Step Up
                if (_isGrounded && TryStepUp(pos, remaining, out Vector3 stepMotion, out float h))
                {
                    pos += stepMotion;
                    totalMoved += stepMotion;
                    remaining = Vector3.zero;
                    OnStepClimbed?.Invoke(h);
                    break;
                }

                GetCapsulePoints(pos, out Vector3 p1, out Vector3 p2, out float r);
                
                // QueryTriggerInteraction.Ignore: Do not hit Triggers with this sweep
                int count = UnityEngine.Physics.CapsuleCastNonAlloc(
                    p1, p2, r, remaining.normalized, _hitBuffer, dist + _skinWidth, _obstacleMask,
                    QueryTriggerInteraction.Ignore
                );

                RaycastHit closest = default;
                float closestDist = Mathf.Infinity;
                bool hitFound = false;

                for (int j = 0; j < count; j++)
                {
                    // Double safety check (redundant with QueryTriggerInteraction.Ignore, but good to keep)
                    if (_hitBuffer[j].collider.isTrigger) continue;

                    if (_hitBuffer[j].distance <= 0 || _ignoredColliders.Contains(_hitBuffer[j].collider) || _hitBuffer[j].transform == transform) continue;
                    if (_hitBuffer[j].distance < closestDist)
                    {
                        closestDist = _hitBuffer[j].distance;
                        closest = _hitBuffer[j];
                        hitFound = true;
                    }
                }

                if (hitFound)
                {
                    float moveDist = Mathf.Max(0, closestDist - _skinWidth);
                    Vector3 move = remaining.normalized * moveDist;
                    pos += move;
                    totalMoved += move;

                    remaining -= remaining.normalized * moveDist;
                    remaining = Vector3.ProjectOnPlane(remaining, closest.normal);

                    OnCollision?.Invoke(closest.normal);
                }
                else
                {
                    totalMoved += remaining;
                    break;
                }
            }
            return totalMoved;
        }

        private void HandlePlatformMovement()
        {
            if (_activePlatform == null) return;
            Vector3 dPos = _activePlatform.position - _platformLastPos;
            Quaternion dRot = _activePlatform.rotation * Quaternion.Inverse(_platformLastRot);

            transform.position += dPos;
            Vector3 local = transform.position - _activePlatform.position;
            transform.position = _activePlatform.position + (dRot * local);
            transform.rotation = dRot * transform.rotation;

            _platformLastPos = _activePlatform.position;
            _platformLastRot = _activePlatform.rotation;
        }

        private void CheckGround()
        {
            GetCapsulePoints(transform.position, out Vector3 p1, out Vector3 p2, out float r);
            if (UnityEngine.Physics.SphereCast(p2 + Vector3.up * 0.1f, r * 0.95f, Vector3.down, out RaycastHit hit, _skinWidth + 0.2f, _obstacleMask))
            {
                float angle = Vector3.Angle(hit.normal, Vector3.up);
                if (angle <= _maxSlopeAngle || angle < 85f)
                {
                    _isGrounded = true;
                    _groundNormal = hit.normal;
                    if (angle <= _maxSlopeAngle && hit.transform != _activePlatform)
                    {
                        _activePlatform = hit.transform;
                        _platformLastPos = _activePlatform.position;
                        _platformLastRot = _activePlatform.rotation;
                    }
                    return;
                }
            }
            _isGrounded = false;
            _groundNormal = Vector3.up;
            _activePlatform = null;
        }

        private void HandleGroundSnapping(Vector3 appliedMotion)
        {
            if (_isGrounded && appliedMotion.y <= 0)
            {
                GetCapsulePoints(transform.position, out Vector3 p1, out Vector3 p2, out float r);
                if (UnityEngine.Physics.SphereCast(p2 + Vector3.up * 0.1f, r * 0.95f, Vector3.down, out RaycastHit hit, _groundSnapDistance, _obstacleMask))
                {
                    if (Vector3.Angle(hit.normal, Vector3.up) <= _maxSlopeAngle)
                    {
                        transform.position += Vector3.down * (hit.distance - 0.1f);
                        _isGrounded = true;
                        _groundNormal = hit.normal;
                    }
                }
            }
        }

        private bool TryStepUp(Vector3 pos, Vector3 motion, out Vector3 stepMotion, out float height)
        {
            stepMotion = Vector3.zero; height = 0;
            Vector3 horz = new Vector3(motion.x, 0, motion.z);
            if (horz.sqrMagnitude < 0.001f) return false;

            GetCapsulePoints(pos, out Vector3 p1, out Vector3 p2, out float r);
            float dist = horz.magnitude + _skinWidth;

            for (float h = _maxStepHeight; h >= 0.05f; h -= 0.05f)
            {
                Vector3 up = Vector3.up * h;
                if (UnityEngine.Physics.CheckCapsule(p1 + up, p2 + up, r * 0.99f, _obstacleMask)) continue;
                if (!UnityEngine.Physics.CapsuleCast(p1 + up, p2 + up, r * 0.99f, horz.normalized, dist, _obstacleMask))
                {
                    if (UnityEngine.Physics.Raycast(pos + up + horz.normalized * 0.1f, Vector3.down, out RaycastHit hit, h + 0.1f, _obstacleMask))
                    {
                        float actualH = hit.point.y - pos.y;
                        if (actualH <= _maxStepHeight && actualH > 0.01f)
                        {
                            stepMotion = (Vector3.up * actualH) + horz;
                            height = actualH;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Depenetrate()
        {
            GetCapsulePoints(transform.position, out Vector3 p1, out Vector3 p2, out float r);
            Collider[] buffer = new Collider[5];
            int c = UnityEngine.Physics.OverlapCapsuleNonAlloc(p1, p2, r, buffer, _obstacleMask);
            for (int i = 0; i < c; i++)
            {
                var col = buffer[i];
                // Ignore self AND ignored colliders
                if (col == _capsule || _ignoredColliders.Contains(col)) continue;
                
                // CRITICAL FIX: Do not push out of Triggers!
                if (col.isTrigger) continue;

                if (UnityEngine.Physics.ComputePenetration(_capsule, transform.position, transform.rotation, col, col.transform.position, col.transform.rotation, out Vector3 dir, out float d))
                {
                    transform.position += dir * (d + _skinWidth);
                }
            }
        }

        private void GetCapsulePoints(Vector3 pos, out Vector3 p1, out Vector3 p2, out float r)
        {
            r = _capsule.radius;
            float h = Mathf.Max(0, _capsule.height * 0.5f - r);
            p1 = pos + _capsule.center + Vector3.up * h;
            p2 = pos + _capsule.center - Vector3.up * h;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\AfterImage.cs`
- Lines: 34
- Size: 0.9 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    public class AfterImage : MonoBehaviour
    {
        public float lifetime = 1.0f; // Decoy lasts 1 second (longer than dash)

        private void Start()
        {
            // 1. Notify Enemies: "Look at me!"
            GameEvents.OnDecoySpawned?.Invoke(transform);

            // 2. Visual Fade
            Renderer rend = GetComponentInChildren<Renderer>();
            if (rend)
            {
                // Fade alpha to 0
                rend.material.DOFade(0f, lifetime).SetEase(Ease.Linear);
            }

            // 3. Self Destruct
            Destroy(gameObject, lifetime);
        }

        private void OnDestroy()
        {
            // 4. Notify Enemies: "I'm dead, look at Player!"
            GameEvents.OnDecoyExpired?.Invoke();
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerAttack.cs`
- Lines: 94
- Size: 3.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening; 

namespace DarkTowerTron.Player
{
    public class PlayerAttack : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 0.5f; 
        public float selfRecoil = 15f;
        public LayerMask hitLayers; 
        public GameObject beamVisualPrefab; 

        private PlayerMovement _movement;

        // We override Awake to get the Movement reference, 
        // but we must call base.Awake() to get the Scanner too!
        protected override void Awake()
        {
            base.Awake(); 
            _movement = GetComponent<PlayerMovement>();
        }

        protected override void Fire()
        {
            // 1. Get Aim
            Vector3 fireDir = GetAimDirection();
            float beamLength = range;

            // 2. Hit Detection (Moved up to determine beam length)
            RaycastHit hit;
            bool hasHit = UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out hit, range, hitLayers);

            if (hasHit)
            {
                // NEW: Stop visual beam at the hit point
                // Calculate actual distance to hit
                beamLength = hit.distance;
            }

            // 3. Visuals
            if (beamVisualPrefab)
            {
                // We rotate the firepoint momentarily so the instantiated child aligns perfectly
                Quaternion targetRot = Quaternion.LookRotation(fireDir);
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, targetRot, firePoint);
                
                // Scale Correction Logic
                Vector3 parentScale = firePoint.lossyScale;
                float compX = beamRadius / parentScale.x;
                float compY = beamRadius / parentScale.y; 
                float compZ  = beamLength / parentScale.z; // Use calculated length

                beam.transform.localScale = new Vector3(compX, compY, 0f);
                beam.transform.DOScaleZ(compZ, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 4. Recoil
            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            // 5. Apply Damage
            if (hasHit)
            {
                // LOGIC CHECK:
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();
                
                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = 10f,
                        staggerAmount = 0.4f,
                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject
                    };

                    target.TakeDamage(info);
                    GameEvents.OnPlayerHit?.Invoke(); 
                }
                else
                {
                    // We hit a wall (No IDamageable). 
                    // The visual beam should stop here.
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerController.cs`
- Lines: 186
- Size: 6.0 KB
- Modified: 2025-12-14 08:28

```csharp
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    // [RequireComponent(typeof(Blitz))] <-- REMOVE THIS
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement _movement;
        
        // NEW REFERENCES
        private PlayerDodge _dodgeAbility;
        private PlayerExecution _executionAbility;

        // Weapon References
        private PlayerAttack _beamWeapon;
        private PlayerGun _gunWeapon;

        private GameControls _controls;
        private bool _inputEnabled = true;
        private Camera _cam;

        // Cache actions to avoid lookups in Update
        private InputAction _moveAction;
        private InputAction _lookPadAction;
        private InputAction _lookMouseAction;
        private InputAction _fireBeamAction;
        private InputAction _fireGunAction;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            
            // FIND NEW COMPONENTS
            _dodgeAbility = GetComponent<PlayerDodge>();
            _executionAbility = GetComponent<PlayerExecution>();
            
            _cam = Camera.main;

            _beamWeapon = GetComponent<PlayerAttack>();
            _gunWeapon = GetComponent<PlayerGun>();

            _controls = new GameControls();

            // --- STRICT BINDING (No Strings) ---
            // Direct access ensures compile-time errors if names change.

            // Cache actions once (no FindAction lookups)
            _moveAction = _controls.Gameplay.Move;
            _lookPadAction = _controls.Gameplay.LookGamepad;
            _lookMouseAction = _controls.Gameplay.LookMouse;
            _fireBeamAction = _controls.Gameplay.Melee;
            _fireGunAction = _controls.Gameplay.Gun;
        }

        private void OnEnable()
        {
            _controls.Gameplay.Blitz.performed += OnBlitzPerformed;
            _controls.Gameplay.GloryKill.performed += OnGloryKillPerformed;

            if (_inputEnabled) _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Gameplay.Blitz.performed -= OnBlitzPerformed;
            _controls.Gameplay.GloryKill.performed -= OnGloryKillPerformed;

            _controls.Disable();
        }

        private void OnBlitzPerformed(InputAction.CallbackContext ctx) => OnDodge();
        private void OnGloryKillPerformed(InputAction.CallbackContext ctx) => OnGloryKill();

        private void Update()
        {
            if (!_inputEnabled) return;

            HandleMovement();
            HandleAimingAndScanning();
            HandleFiring();
        }

        private void HandleMovement()
        {
            if (_moveAction == null) return;

            Vector2 input = _moveAction.ReadValue<Vector2>();
            Vector3 dir = new Vector3(input.x, 0, input.y).normalized;
            _movement.SetMoveInput(dir);
        }

        private void HandleAimingAndScanning()
        {
            Vector3 aimDir = transform.forward;

            // 1. Gamepad Stick
            if (_lookPadAction != null)
            {
                Vector2 stickInput = _lookPadAction.ReadValue<Vector2>();
                if (stickInput.sqrMagnitude > 0.05f)
                {
                    aimDir = new Vector3(stickInput.x, 0, stickInput.y).normalized;
                    _movement.LookAtDirection(aimDir);
                    UpdateScanner(aimDir); // Helper function
                    return; // Exit early if using stick
                }
            }

            // 2. Mouse
            if (_lookMouseAction != null)
            {
                Vector2 mousePos = _lookMouseAction.ReadValue<Vector2>();
                Ray ray = _cam.ScreenPointToRay(mousePos);
                Plane ground = new Plane(Vector3.up, Vector3.zero);

                if (ground.Raycast(ray, out float enter))
                {
                    Vector3 worldPoint = ray.GetPoint(enter);
                    Vector3 lookDir = (worldPoint - transform.position);
                    lookDir.y = 0;

                    if (lookDir != Vector3.zero)
                    {
                        aimDir = lookDir.normalized;
                        _movement.LookAtDirection(aimDir);
                    }
                }
            }

            UpdateScanner(aimDir);
        }

        private void UpdateScanner(Vector3 dir)
        {
            var scanner = GetComponent<TargetScanner>();
            if (scanner != null) scanner.UpdateScanner(dir);
        }

        private void HandleFiring()
        {
            // 1. Handle BEAM
            if (_beamWeapon != null)
            {
                // Direct access via generated class
                bool isBeam = _controls.Gameplay.Melee.ReadValue<float>() > 0.5f;
                _beamWeapon.SetFiring(isBeam);
            }

            // 2. Handle GUN
            if (_gunWeapon != null)
            {
                bool isGun = _controls.Gameplay.Gun.ReadValue<float>() > 0.5f;
                _gunWeapon.SetFiring(isGun);
            }
        }

        // --- ACTION HANDLERS ---

        private void OnDodge()
        {
            if (_inputEnabled && _dodgeAbility) _dodgeAbility.PerformDodge();
        }

        private void OnGloryKill()
        {
            if (_inputEnabled && _executionAbility) _executionAbility.PerformGloryKill();
        }

        public void ToggleInput(bool state)
        {
            _inputEnabled = state;
            if (state) _controls.Enable();
            else _controls.Disable();

            if (!state)
            {
                _movement.SetMoveInput(Vector3.zero);
                if (_beamWeapon != null) _beamWeapon.SetFiring(false);
                if (_gunWeapon != null) _gunWeapon.SetFiring(false);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerDodge.cs`
- Lines: 161
- Size: 5.2 KB
- Modified: 2025-12-24 13:12

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerLoadout))]
    public class PlayerDodge : MonoBehaviour
    {
        [Header("Dodge Settings")]
        public float focusCost = 25f;
        public float dashDistance = 8f;
        public float dashDuration = 0.15f;
        public LayerMask projectileLayer;
        public AudioClip dashClip; // Assign in Inspector

        [Header("Visuals")]
        public Transform indicatorRef;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;
        public LayerMask wallLayer;

        public bool IsInvulnerable { get; private set; }
        public bool IsDashing { get; private set; }

        private KinematicMover _mover;
        private PlayerEnergy _energy;
        private PlayerMovement _movement;
        private PlayerLoadout _loadout;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMovement>();
            _loadout = GetComponent<PlayerLoadout>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

            if (_energy.SpendFocus(focusCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        private IEnumerator DodgeRoutine()
        {
            IsDashing = true;

            // PLAY SOUND
            if (GameFeel.Instance && dashClip) 
                GameFeel.Instance.PlaySound(dashClip, 1f, true);

            IsInvulnerable = true;
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // Spawn decoy from loadout
            GameObject decoyToSpawn = _loadout.currentDecoy;
            if (decoyToSpawn) Instantiate(decoyToSpawn, transform.position, transform.rotation);

            // Direction Logic
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dashDir = _movement.MoveInput.normalized;
            else dashDir = transform.forward;

            // Physics Loop
            // Speed in meters/second
            float speed = dashDistance / dashDuration;
            float timer = 0f;

            while (timer < dashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;
                // Do not multiply by dt here.
                // KinematicMover.Move(Velocity) applies (Velocity * dt) internally.
                _mover.Move(dashDir * speed);
                CatchProjectiles();
                yield return null;
            }

            yield return new WaitForSeconds(0.05f); // Recovery frame

            IsInvulnerable = false;
            IsDashing = false;
        }

        private void CatchProjectiles()
        {
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, projectileLayer);
            foreach (var hit in hits)
            {
                IReflectable proj = hit.GetComponent<IReflectable>();
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    proj.Redirect(transform.forward, gameObject);
                    _energy.AddFocus(20f);
                }
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            if (IsDashing)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, dashDistance, wallLayer))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * dashDistance);
            }

            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            if (indicatorRenderer && readyMat && notReadyMat)
            {
                bool canAfford = _energy.HasFocus(focusCost);
                Material targetMat = canAfford ? readyMat : notReadyMat;
                if (indicatorRenderer.sharedMaterial != targetMat)
                {
                    indicatorRenderer.sharedMaterial = targetMat;
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerEnergy.cs`
- Lines: 112
- Size: 3.2 KB
- Modified: 2025-12-24 08:50

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Stats")]
        public float maxFocus = 100f;
        public float decayRate = 5f;

        [Header("Rewards (Defaults)")]
        public float defaultFocusOnKill = 30f;

        private float _currentFocus;
        private bool _isDead;
        private bool _isCombatActive = false;
        private PlayerStats _stats;

        private void Awake()
        {
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            _currentFocus = maxFocus;

            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerDied += OnPlayerDied;

            GameEvents.OnWaveCombatStarted += EnableDecay;
            GameEvents.OnWaveCleared += DisableDecay;
            GameEvents.OnGameVictory += DisableDecay;

            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerDied -= OnPlayerDied;

            GameEvents.OnWaveCombatStarted -= EnableDecay;
            GameEvents.OnWaveCleared -= DisableDecay;
            GameEvents.OnGameVictory -= DisableDecay;
        }

        private void Update()
        {
            if (_isDead) return;

            // Overdrive check
            bool shouldBeOverdrive = _currentFocus >= _stats.baseStats.overdriveThreshold;
            _stats.SetOverdrive(shouldBeOverdrive);

            // Decay logic
            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= decayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                UpdateUI();
            }
        }

        // --- FIXED SIGNATURE ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Use specific reward if available, otherwise default
            float reward = (stats != null) ? stats.focusReward : defaultFocusOnKill;
            AddFocus(reward);
        }
        // -----------------------

        public bool HasFocus(float amount)
        {
            return _currentFocus >= amount;
        }

        public bool SpendFocus(float amount)
        {
            if (_currentFocus >= amount)
            {
                _currentFocus -= amount;
                UpdateUI();
                return true;
            }
            return false;
        }

        public void AddFocus(float amount)
        {
            _currentFocus += amount;
            if (_currentFocus > maxFocus) _currentFocus = maxFocus;
            UpdateUI();
        }

        private void EnableDecay() { _isCombatActive = true; }
        private void DisableDecay() { _isCombatActive = false; }

        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, maxFocus);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerExecution.cs`
- Lines: 91
- Size: 2.9 KB
- Modified: 2025-12-19 07:17

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // For ScoreManager

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public AudioClip executeClip; // Assign in Inspector

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
        }

        public void PerformGloryKill()
        {
            if (_isBusy) return;

            // Logic Checks
            if (_scanner == null || _scanner.CurrentTarget == null)
            {
                // Optional: Play "Error" sound
                return;
            }

            if (!_scanner.CurrentTarget.IsStaggered)
            {
                // Optional: Play "Denied" sound
                return;
            }

            StartCoroutine(ExecutionRoutine(_scanner.CurrentTarget));
        }

        // Change parameter type to Interface
        private IEnumerator ExecutionRoutine(ICombatTarget target)
        {
            _isBusy = true;

            // 1. Teleport
            Vector3 targetPos = target.transform.position;
            Vector3 attackPos = targetPos - (transform.forward * 1.0f);
            transform.position = attackPos;

            // 2. Trigger Target Reaction (Die or Reset)
            target.OnExecutionHit();

            // PLAY SOUND
            if (GameFeel.Instance && executeClip) 
                GameFeel.Instance.PlaySound(executeClip, 1f);

            // 3. Rewards
            // We assume execution always gives Focus (movement fuel)
            _energy.AddFocus(killRewardFocus);
            
            // LOGIC CHECK: Only heal if it was a living enemy? 
            // Or rely on OnEnemyKilled event?
            // Since EnemyController.Kill fires OnEnemyKilled, the health will update automatically.
            // DamageableProp DOES NOT fire OnEnemyKilled (usually), so Anchors won't heal you.
            // This is correct behavior!

            if (ScoreManager.Instance)
                ScoreManager.Instance.TriggerGloryKillBonus();

            // 4. Juice
            if (GameFeel.Instance)
            {
                GameFeel.Instance.HitStop(0.1f);
                GameFeel.Instance.CameraShake(0.2f, 0.5f);
            }

            yield return new WaitForSeconds(0.1f);

            _isBusy = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerGun.cs`
- Lines: 42
- Size: 1.2 KB
- Modified: 2025-12-24 13:36

```csharp
using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    // Inherits from WeaponBase instead of MonoBehaviour
    [RequireComponent(typeof(PlayerLoadout))]
    public class PlayerGun : WeaponBase 
    {
        [Header("Gun Specifics")]
        public float bulletSpeed = 25f;

        private PlayerLoadout _loadout;

        protected override void Awake()
        {
            base.Awake();
            _loadout = GetComponent<PlayerLoadout>();
        }

        protected override void Fire()
        {
            // Read from loadout
            GameObject prefabToSpawn = _loadout.currentProjectile;

            if (prefabToSpawn && firePoint)
            {
                Vector3 aimDir = GetAimDirection();
                GameObject p = PoolManager.Instance.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));
                
                Projectile proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;
                    proj.Initialize(aimDir);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerHealth.cs`
- Lines: 143
- Size: 4.0 KB
- Modified: 2025-12-19 08:21

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers; // For AudioManager

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;
        public bool startWithHull = true;

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        private PlayerMovement _movement;
        private PlayerDodge _dodge;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            _dodge = GetComponent<PlayerDodge>();
        }

        private void Start()
        {
            _currentGrit = maxGrit;
            _hasHull = startWithHull;
            
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            // Invulnerability Check
            if (_dodge != null && _dodge.IsInvulnerable) return false;

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0; 
                GameEvents.OnPlayerHit?.Invoke(); 
            }
            else if (_hasHull)
            {
                _hasHull = false;
                GameEvents.OnPlayerHit?.Invoke(); 
                GameEvents.OnHullStateChanged?.Invoke(false); 
            }
            else
            {
                Kill(false);
            }

            if (!_isDead && _movement) 
                _movement.ApplyKnockback(info.pushDirection * info.pushForce);

            UpdateUI();
            return true;
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();
            Debug.Log("PLAYER DEAD");
            GameEvents.OnPlayerDied?.Invoke();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            _currentGrit = Mathf.Min(_currentGrit + amount, maxGrit);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            if (stats != null)
            {
                if (stats.healsGrit) HealGrit(stats.gritRewardAmount);
            }
            else
            {
                HealGrit(1);
            }
        }

        private void UpdateUI()
        {
            GameEvents.OnGritChanged?.Invoke(_currentGrit);
            GameEvents.OnHullStateChanged?.Invoke(_hasHull);
        }

        public void TakeVoidDamage()
        {
            if (_isDead) return;

            Debug.Log("Fell into Void! Respawning...");

            // 1. Teleport & Reset Physics
            if (_movement)
            {
                // Reset Logic (Inertia)
                _movement.ResetVelocity();
                
                // Teleport Logic (Position)
                var motor = GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            // 2. Take Penalty (1 Grit/Hull) via standard damage path
            DamageInfo info = new DamageInfo
            {
                damageAmount = 1f,
                pushDirection = Vector3.zero,
                pushForce = 0f,
                source = null
            };
            
            TakeDamage(info); 
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerLoadout.cs`
- Lines: 37
- Size: 0.9 KB
- Modified: 2025-12-24 13:11

```csharp
using UnityEngine;

namespace DarkTowerTron.Player
{
    public class PlayerLoadout : MonoBehaviour
    {
        [Header("Defaults")]
        public GameObject defaultProjectile;
        public GameObject defaultDecoy;

        [Header("Active Loadout (Debug/Runtime)")]
        public GameObject currentProjectile;
        public GameObject currentDecoy;

        private void Awake()
        {
            // Initialize with defaults on start
            ResetLoadout();
        }

        public void ResetLoadout()
        {
            currentProjectile = defaultProjectile;
            currentDecoy = defaultDecoy;
        }

        public void EquipProjectile(GameObject newPrefab)
        {
            if (newPrefab != null) currentProjectile = newPrefab;
        }

        public void EquipDecoy(GameObject newPrefab)
        {
            if (newPrefab != null) currentDecoy = newPrefab;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerMovement.cs`
- Lines: 217
- Size: 7.3 KB
- Modified: 2025-12-24 08:49

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Motion Settings")]
        public float deceleration = 40f;
        public float rotationSpeed = 25f;

        [Header("Wall Repulsion (Anti-Stick)")]
        public float wallBuffer = 0.6f; // How close before we push back (0.5 is player radius)
        public float repulsionForce = 5f; // How hard we push
        public LayerMask wallLayer;

        [Header("Physics")]
        public float gravity = 20f; // Gravity is controlled here

        [Header("Safety Net")]
        public float safeGroundTimer = 0.5f; // Time required to be grounded to count as "Safe"
        
        // Read-only property for the Health script to access
        public Vector3 LastSafePosition { get; private set; }

        // Expose input for Blitz
        public Vector3 MoveInput => _inputDir;

        private KinematicMover _mover;
        private Camera _cam;
        private PlayerStats _stats;

        private Vector3 _inputDir;
        private Vector3 _currentVelocity;
        private Vector3 _externalForce;
        private float _groundedTimer;

        // Cache for optimization
        private Collider[] _wallBuffer = new Collider[5];

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _cam = Camera.main;
            _stats = GetComponent<PlayerStats>();

            // Default mask if not set
            if (wallLayer == 0) wallLayer = LayerMask.GetMask(GameConstants.LAYER_WALL, "Default");
        }

        private void Start()
        {
            LastSafePosition = transform.position;
        }

        public void SetMoveInput(Vector3 dir)
        {
            _inputDir = dir;
        }

        public void LookAtDirection(Vector3 direction)
        {
            direction.y = 0;
            if (direction.sqrMagnitude > 0.001f)
            {
                Quaternion targetRot = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
            }
        }

        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            // Use UnityEngine.Physics to disambiguate
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, LayerMask.GetMask(GameConstants.LAYER_GROUND)))
            {
                Vector3 lookDir = hit.point - transform.position;
                LookAtDirection(lookDir);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _externalForce += force;
        }

        private void Update()
        {
            HandleVelocity();
            HandleSafeGround();
        }

        private void HandleVelocity()
        {
            float dt = Time.deltaTime;

            // 1. Calculate Target (Inputs)
            Vector3 targetVel = _inputDir * _stats.MoveSpeed;
            Vector3 wallPush = CalculateWallRepulsion();
            targetVel += wallPush;

            // 2. Acceleration
            if (_inputDir.magnitude > 0.1f)
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, _stats.Acceleration * dt);
            }
            else
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, deceleration * dt);
                if (_currentVelocity.magnitude < 0.01f) _currentVelocity = Vector3.zero;
            }

            // 3. External Forces (Recoil/Knockback)
            if (_externalForce.magnitude > 0.1f)
            {
                _externalForce = Vector3.Lerp(_externalForce, Vector3.zero, 5f * dt);
            }
            else
            {
                _externalForce = Vector3.zero;
            }

            // 4. COMBINE (No dt multiplication here!)
            Vector3 finalVelocity = _currentVelocity + _externalForce;

            // 5. APPLY GRAVITY MANUALLY
            if (!_mover.IsGrounded)
            {
                // For a top-down game, a simple constant downward velocity works if we don't jump.
                finalVelocity.y -= gravity;
            }
            else
            {
                // Stick to ground
                finalVelocity.y = -2f;
            }

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        // NEW METHOD: Call this when teleporting/respawning
        public void ResetVelocity()
        {
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _inputDir = Vector3.zero; // Optional: Stop input until player presses again
        }

        private void HandleSafeGround()
        {
            // STRICT CHECK:
            // 1. Must be physically grounded (Motor check)
            // 2. Must have ground directly beneath center (Raycast check)
            // This prevents saving "The Edge" as a safe spot.
            
            bool isCenterSupported = false;
            
            // Cast from slightly up, downwards. Check GROUND layer only.
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, 2.0f, LayerMask.GetMask(GameConstants.LAYER_GROUND)))
            {
                isCenterSupported = true;
            }

            if (_mover.IsGrounded && isCenterSupported)
            {
                _groundedTimer += Time.deltaTime;
                if (_groundedTimer > safeGroundTimer)
                {
                    // Save position slightly higher to prevent floor clipping
                    LastSafePosition = transform.position + Vector3.up * 0.2f;
                }
            }
            else
            {
                _groundedTimer = 0f;
            }
        }

        private Vector3 CalculateWallRepulsion()
        {
            Vector3 push = Vector3.zero;

            // Find walls within buffer range
            // We use the player's position + slight up offset (center of mass)
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, wallBuffer, _wallBuffer, wallLayer);

            for (int i = 0; i < count; i++)
            {
                Collider wall = _wallBuffer[i];

                // Find the closest point on the wall's surface to the player
                Vector3 closestPoint = wall.ClosestPoint(transform.position + Vector3.up);

                // Calculate direction AWAY from wall
                Vector3 dir = (transform.position - closestPoint);
                dir.y = 0; // Keep it flat

                float dist = dir.magnitude;

                // If we are actually inside/touching/near the wall
                if (dist < wallBuffer)
                {
                    // The closer we are, the stronger the push
                    // Normalized push * strength
                    push += dir.normalized * repulsionForce;
                }
            }

            return push;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerStats.cs`
- Lines: 68
- Size: 1.9 KB
- Modified: 2025-12-24 08:44

```csharp
using UnityEngine;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Base Configuration")]
        public PlayerStatsSO baseStats;

        // --- RUNTIME STATE ---
        public bool IsOverdrive { get; private set; }

        // --- DYNAMIC PROPERTIES ---
        // These calculate the final value every time they are asked

        public float MoveSpeed
        {
            get
            {
                float val = baseStats.moveSpeed;
                if (IsOverdrive) val *= baseStats.overdriveSpeedMult;
                return val;
            }
        }

        public float Acceleration => baseStats.acceleration;

        public float DashCost => baseStats.dashCost;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown;

        public float DamageMultiplier
        {
            get
            {
                float val = baseStats.damageMultiplier;
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        // Lower is faster for fire rate delay
        public float FireRateMultiplier
        {
            get
            {
                float val = baseStats.fireRateMultiplier;
                // Example: Overdrive makes you shoot 50% faster (multiplier 1.5x)
                // We handle the math in WeaponBase
                if (IsOverdrive) val *= 1.5f;
                return val;
            }
        }

        // --- LOGIC ---

        public void SetOverdrive(bool state)
        {
            if (IsOverdrive != state)
            {
                IsOverdrive = state;
                // Optional: Trigger Visuals/Sound here later
                Debug.Log($"Overdrive State: {state}");
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\TargetScanner.cs`
- Lines: 95
- Size: 3.3 KB
- Modified: 2025-12-19 07:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    public class TargetScanner : MonoBehaviour
    {
        [Header("Settings")]
        public float scanRange = 25f; // Increased Default
        public float scanRadius = 2.0f; // Thicker Default
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public Transform reticlePrefab; 
        public Vector3 reticleOffset = new Vector3(0, 0.1f, 0);
        
        // NEW: Visual Feedback settings
        public Color lockedColor = Color.cyan;
        public Color executionColor = Color.yellow; // or Red

        public ICombatTarget CurrentTarget { get; private set; }

        private Transform _reticleInstance;
        private LineRenderer _reticleLine; // Assuming we use the LineRenderer reticle

        private void Start()
        {
            if (reticlePrefab)
            {
                _reticleInstance = Instantiate(reticlePrefab, Vector3.zero, Quaternion.identity);
                _reticleLine = _reticleInstance.GetComponent<LineRenderer>();
                _reticleInstance.gameObject.SetActive(false);
            }
        }

        public void UpdateScanner(Vector3 aimDirection)
        {
            // Lift origin slightly to avoid floor clipping
            Vector3 origin = transform.position + Vector3.up * 1.0f;

            if (UnityEngine.Physics.SphereCast(origin, scanRadius, aimDirection, out RaycastHit hit, scanRange, enemyLayer))
            {
                // FIX: Look for Interface instead of EnemyController
                ICombatTarget target = hit.collider.GetComponentInParent<ICombatTarget>();
                
                if (target != null)
                {
                    CurrentTarget = target;
                }
                else
                {
                    CurrentTarget = null;
                }
            }
            else
            {
                CurrentTarget = null;
            }

            UpdateReticle();
        }

        private void UpdateReticle()
        {
            if (_reticleInstance == null) return;

            if (CurrentTarget != null)
            {
                _reticleInstance.gameObject.SetActive(true);
                _reticleInstance.position = CurrentTarget.transform.position + reticleOffset;
                _reticleInstance.Rotate(Vector3.up * 200 * Time.deltaTime);

                // --- NEW: COLOR LOGIC ---
                if (_reticleLine)
                {
                    // If Staggered -> Show Execution Color (Yellow/Red)
                    // If Healthy -> Show Lock Color (Cyan)
                    Color targetColor = CurrentTarget.IsStaggered ? executionColor : lockedColor;
                    
                    // Simple property block or direct material color change
                    _reticleLine.startColor = targetColor;
                    _reticleLine.endColor = targetColor;
                    // Also update material color for emission glow
                    _reticleLine.material.color = targetColor;
                }
            }
            else
            {
                _reticleInstance.gameObject.SetActive(false);
            }
        }
        
        // Gizmos remain same...
    }
}
```

## 📄 `Assets\Scripts\Player\WeaponBase.cs`
- Lines: 95
- Size: 2.8 KB
- Modified: 2025-12-24 08:49

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    // Abstract means you can't put this directly on an object, 
    // you must extend it (like PlayerGun : WeaponBase)
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;
        public float baseFireRate = 0.2f;
        
        [Header("Audio")]
        public AudioClip fireClip;
        [Range(0f, 1f)] public float volume = 0.8f;

        [Header("Feel")]
        public float inputBufferTime = 0.2f;

        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;
        protected TargetScanner _scanner;
        protected PlayerStats _stats;

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                _bufferTimer = inputBufferTime;
            }

            if (_bufferTimer > 0 && _timer <= 0)
            {
                Fire();
                PlayFireSound();
                _timer = baseFireRate / _stats.FireRateMultiplier;
                _bufferTimer = 0;
            }
        }

        protected abstract void Fire();

        protected void PlayFireSound()
        {
            if (fireClip && Managers.AudioManager.Instance)
            {
                Managers.AudioManager.Instance.PlaySound(fireClip, volume, true);
            }
        }

        // --- SHARED HELPER METHODS ---

        /// <summary>
        /// Calculates the best firing direction. 
        /// Defaults to forward. If Locked On, aims at Enemy Center Mass.
        /// </summary>
        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;
                
                // FIX: Access GetComponent via the .transform property
                var col = _scanner.CurrentTarget.transform.GetComponent<Collider>();
                
                if (col != null) targetPos = col.bounds.center;

                aimDir = (targetPos - firePoint.position).normalized;
            }

            return aimDir;
        }
    }
}
```

## 📄 `Assets\Scripts\UI\CountdownUI.cs`
- Lines: 68
- Size: 2.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core;

namespace DarkTowerTron.UI
{
    public class CountdownUI : MonoBehaviour
    {
        [Header("UI References")]
        public TextMeshProUGUI waveTitleText; // "WAVE 1"
        public TextMeshProUGUI countdownText; // "3"

        private void Awake()
        {
            // Hide by default
            if (waveTitleText) waveTitleText.gameObject.SetActive(false);
            if (countdownText) countdownText.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameEvents.OnWaveAnnounce += ShowWaveTitle;
            GameEvents.OnCountdownChange += UpdateCountdown;
        }

        private void OnDisable()
        {
            GameEvents.OnWaveAnnounce -= ShowWaveTitle;
            GameEvents.OnCountdownChange -= UpdateCountdown;
        }

        private void ShowWaveTitle(int waveIndex)
        {
            if (waveTitleText)
            {
                waveTitleText.text = $"WAVE {waveIndex + 1}"; // +1 because index starts at 0
                waveTitleText.gameObject.SetActive(true);

                // Animation: Scale Up and Fade In
                waveTitleText.transform.localScale = Vector3.zero;
                waveTitleText.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack);
                waveTitleText.alpha = 1f;
            }
        }

        private void UpdateCountdown(string text)
        {
            if (countdownText)
            {
                // If text is empty, hide everything
                if (string.IsNullOrEmpty(text))
                {
                    countdownText.gameObject.SetActive(false);
                    if (waveTitleText) waveTitleText.DOFade(0, 0.5f); // Fade out title
                    return;
                }

                countdownText.gameObject.SetActive(true);
                countdownText.text = text;

                // Punch Animation for every number
                countdownText.transform.localScale = Vector3.one;
                countdownText.transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\FloatingText.cs`
- Lines: 56
- Size: 1.6 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Managers; // Needed to talk to PoolManager

namespace DarkTowerTron.UI
{
    public class FloatingText : MonoBehaviour
    {
        public TextMeshPro textMesh;
        public float floatDistance = 2f;
        public float duration = 0.8f;
        public Ease motionEase = Ease.OutCubic;

        private void Awake()
        {
            if (textMesh == null) textMesh = GetComponent<TextMeshPro>();
        }

        public void Initialize(string text, Color color, float sizeScale = 1f)
        {
            // 1. Setup Text
            textMesh.text = text;
            textMesh.color = color;
            textMesh.alpha = 1f;

            // 2. Reset Transform
            transform.localScale = Vector3.one * sizeScale;

            // 3. Animate Move Up
            transform.DOMoveY(transform.position.y + floatDistance, duration)
                .SetEase(motionEase);

            // 4. Animate Fade Out (start halfway through)
            textMesh.DOFade(0f, duration * 0.5f)
                .SetDelay(duration * 0.5f)
                .OnComplete(Despawn);

            // 5. Juice: Punch Scale
            transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
        }

        private void Despawn()
        {
            // Return to pool
            if (PoolManager.Instance != null)
            {
                PoolManager.Instance.Despawn(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\ResultScreen.cs`
- Lines: 56
- Size: 1.8 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using TMPro;
using DarkTowerTron.Managers;

namespace DarkTowerTron.UI
{
    public class ResultScreen : MonoBehaviour
    {
        [Header("UI References")]
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI timeText;
        public TextMeshProUGUI rankText;

        [Header("Ranking Config")]
        public int rankS_Threshold = 50000;
        public int rankA_Threshold = 25000;
        public int rankB_Threshold = 10000;

        // Called automatically when the GameObject is enabled (SetActive true)
        private void OnEnable()
        {
            if (ScoreManager.Instance == null) return;

            // 1. Stop the Timer
            ScoreManager.Instance.StopTracking();

            // 2. Get Stats
            int finalScore = ScoreManager.Instance.TotalScore;
            float finalTime = ScoreManager.Instance.GameTime;

            // 3. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                string minutes = Mathf.Floor(finalTime / 60).ToString("00");
                string seconds = (finalTime % 60).ToString("00");
                timeText.text = $"{minutes}:{seconds}";
            }

            // 4. Calculate Rank
            if (rankText)
            {
                string rank = "C";
                Color rankColor = Color.grey;

                if (finalScore >= rankS_Threshold) { rank = "S"; rankColor = Color.cyan; }
                else if (finalScore >= rankA_Threshold) { rank = "A"; rankColor = Color.green; }
                else if (finalScore >= rankB_Threshold) { rank = "B"; rankColor = Color.yellow; }

                rankText.text = rank;
                rankText.color = rankColor;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Visuals\CameraShaker.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2025-12-11 14:17

```csharp
using UnityEngine;
using DG.Tweening;

namespace DarkTowerTron.Visuals
{
    public class CameraShaker : MonoBehaviour
    {
        public static CameraShaker Instance;

        private Camera _cam;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            _cam = Camera.main;
        }

        public void Shake(float duration, float strength)
        {
            if (_cam == null) return;

            // Kill previous shakes to prevent glitches
            _cam.transform.DOKill(true);

            // Shake Position (Local so it doesn't break the Rig follow)
            _cam.transform.DOShakePosition(duration, strength, 20, 90, false, true);
        }
    }
}
```

## 📄 `Assets\Scripts\Visuals\PaletteReceiver.cs`
- Lines: 107
- Size: 3.6 KB
- Modified: 2025-12-24 08:11

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Visuals
{
    [ExecuteAlways]
    public class PaletteReceiver : MonoBehaviour
    {
        public enum ActorType { Player, Enemy }

        [Header("Configuration")]
        public ActorType actorType = ActorType.Enemy;

        [Header("Override (Optional)")]
        [Tooltip("Leave empty to use Global Default. Assign 'Elite_Gold' here to override.")]
        public ActorThemeSO themeOverride;

        [Header("Renderer Bindings")]
        public List<Renderer> primaryRenderers;
        public List<Renderer> secondaryRenderers;
        public List<Renderer> tertiaryRenderers;

        private MaterialPropertyBlock _propBlock;

        private void OnEnable()
        {
            if (PaletteManager.Instance != null)
                PaletteManager.Instance.OnPaletteChanged += ApplyTheme;
        }

        private void OnDisable()
        {
            if (PaletteManager.Instance != null)
                PaletteManager.Instance.OnPaletteChanged -= ApplyTheme;
        }

        private void Start()
        {
            ApplyTheme();
        }

        public void ManualRefresh() => ApplyTheme();

        private void ApplyTheme()
        {
            if (_propBlock == null) _propBlock = new MaterialPropertyBlock();

            // 1. CASE A: Use Local Override (Elite/Boss)
            if (themeOverride != null)
            {
                ApplySurfaceToList(primaryRenderers, themeOverride.primary);
                ApplySurfaceToList(secondaryRenderers, themeOverride.secondary);
                ApplySurfaceToList(tertiaryRenderers, themeOverride.tertiary);
                return;
            }

            // 2. CASE B: Use Global Defaults
            if (PaletteManager.Instance == null || PaletteManager.Instance.activePalette == null) return;

            var global = PaletteManager.Instance.activePalette;

            if (actorType == ActorType.Player)
            {
                ApplySurfaceToList(primaryRenderers, global.playerPrimary);
                ApplySurfaceToList(secondaryRenderers, global.playerSecondary);
                ApplySurfaceToList(tertiaryRenderers, global.playerTertiary);
            }
            else // Enemy
            {
                ApplySurfaceToList(primaryRenderers, global.enemyPrimary);
                ApplySurfaceToList(secondaryRenderers, global.enemySecondary);
                ApplySurfaceToList(tertiaryRenderers, global.enemyTertiary);
            }
        }

        private void ApplySurfaceToList(List<Renderer> rends, SurfaceDefinition surf)
        {
            foreach (var r in rends)
            {
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // Set Color
                if (HasProp(r, "_BaseColor")) _propBlock.SetColor("_BaseColor", surf.mainColor);
                else if (HasProp(r, "_Color")) _propBlock.SetColor("_Color", surf.mainColor);

                // Set Emission
                if (HasProp(r, "_EmissionColor")) _propBlock.SetColor("_EmissionColor", surf.mainColor);

                // Set Physics
                if (HasProp(r, "_Smoothness")) _propBlock.SetFloat("_Smoothness", surf.smoothness);
                if (HasProp(r, "_Metallic")) _propBlock.SetFloat("_Metallic", surf.metallic);

                r.SetPropertyBlock(_propBlock);
            }
        }

        private bool HasProp(Renderer r, string name)
        {
            // Simplified check
            return true;
        }
    }
}
```
