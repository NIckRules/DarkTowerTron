# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2026-01-02 09:12
- **Files:** 150
- **Total LOC:** 9450
- **Estimated tokens:** 74496

## 📁 Project Tree
```
Assets
  Data
    AttackPatterns
      Bosses
        Architect
          ARC_Straight.asset
      Nova.asset
      Shotgun.asset
      Sweep.asset
    Audio
      SFX_Enemy_Explode.asset
      SFX_Player_Beam.asset
      SFX_Player_Dash.asset
      SFX_Player_Shoot.asset
    Behaviours
      Beh_Avoidance.asset
      Beh_Flee.asset
      Beh_Orbit_CCW.asset
      Beh_Orbit_CW.asset
      Beh_Seek.asset
    Bosses
      Architect
        ARC_PAT_ClockRotation.asset
        ARC_PAT_HorizontalWall.asset
        ARC_PAT_StraightProjectiles.asset
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
      WA_1_3Mis.asset
      WA_1_3Sen.asset
      WA_1_3Sen_3Chm.asset
  Scripts
    Combat
      BaseHitbox.cs
      DamageReceiver.cs
      HazardZone.cs
      HitBox
        ShieldHitbox.cs
        StandardHitbox.cs
      HitboxRelay.cs
      HomingMissile.cs
      Modules
        StaggerModule.cs
        VitalityModule.cs
      Projectile.cs
    Core
      CameraRig.cs
      CircleRenderer.cs
      Data
        ActorThemeSO.cs
        ArchitectPatternSO.cs
        AttackPatternSO.cs
        ColorPaletteSO.cs
        DebugProfileSO.cs
        EnemyStatsSO.cs
        FeedbackProfileSO.cs
        MaterialCollectionSO.cs
        PlayerStatsSO.cs
        SoundDef.cs
        UIThemeSO.cs
        WaveDefinitionSO.cs
      Debug
        GameLogger.cs
      GameConstants.cs
      GameEvents.cs
      GameServices.cs
      GameTime.cs
      Interfaces
        ICombatTarget.cs
        IDamageable.cs
        IPoolable.cs
        IReflectable.cs
        IWeapon.cs
      LogChannel.cs
      Spinner.cs
      Structs
        DamageInfo.cs
      VoidKiller.cs
    Editor
      SmartDuplicator.cs
    Enemy
      Agents
        EnemyAgent_Chaser.cs
        EnemyAgent_Guardian.cs
        EnemyAgent_Sentinel.cs
        EnemyAgent_Sniper.cs
      Bosses
        Architect
          ArchitectController.cs
          ArchitectHand.cs
      EnemyBaseAI.cs
      EnemyController.cs
      EnemyMotors.cs
      PatrolPath.cs
      States
        Bosses
          Architect
            ArchitectState_Idle.cs
            ArchitectState_Pattern.cs
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
      LevelEndTrigger.cs
      LevelModule.cs
      PlayerStart.cs
      Props
        CombatProp.cs
        Prop_Anchor.cs
        Prop_Explosive.cs
      TileInfo.cs
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
      LevelBuilder.cs
      MusicManager.cs
      PaletteManager.cs
      PoolManager.cs
      ScoreManager.cs
      UIManager.cs
      VFXManager.cs
      WaveDirector.cs
    Physics
      KinematicMover.cs
    Player
      AfterImage.cs
      PlayerBeam.cs
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
      MenuController.cs
      ResultScreen.cs
      UIThemeReceiver.cs
    Visuals
      CameraShaker.cs
      PaletteReceiver.cs
```

## 📄 `Assets\Data\AttackPatterns\Bosses\Architect\ARC_Straight.asset`
- Lines: 24
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Name: ARC_Straight
  m_EditorClassIdentifier: 
  aimMode: 1
  scaleMultiplier: 2.1
  speed: 25
  projectileCount: 5
  spreadAngle: 0
  spinDuringFire: 0
  spinSpeed: 0
  startDelay: 0.5
  delayBetweenShots: 0.2
```

## 📄 `Assets\Data\AttackPatterns\Nova.asset`
- Lines: 22
- Size: 0.5 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Lines: 24
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  aimMode: 0
  scaleMultiplier: 1
  speed: 15
  projectileCount: 10
  spreadAngle: 60
  spinDuringFire: 0
  spinSpeed: 0
  startDelay: 0.5
  delayBetweenShots: 0.1
```

## 📄 `Assets\Data\Audio\SFX_Enemy_Explode.asset`
- Lines: 20
- Size: 0.5 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 90a33418dcfd6f14ea927de15adf6a7d, type: 3}
  m_Name: SFX_Enemy_Explode
  m_EditorClassIdentifier: 
  clips: []
  volume: 1
  pitch: 1
  randomizePitch: 1
  randomPitchRange: 0.1
```

## 📄 `Assets\Data\Audio\SFX_Player_Beam.asset`
- Lines: 20
- Size: 0.5 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 90a33418dcfd6f14ea927de15adf6a7d, type: 3}
  m_Name: SFX_Player_Beam
  m_EditorClassIdentifier: 
  clips: []
  volume: 1
  pitch: 1
  randomizePitch: 1
  randomPitchRange: 0.1
```

## 📄 `Assets\Data\Audio\SFX_Player_Dash.asset`
- Lines: 20
- Size: 0.5 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 90a33418dcfd6f14ea927de15adf6a7d, type: 3}
  m_Name: SFX_Player_Dash
  m_EditorClassIdentifier: 
  clips: []
  volume: 1
  pitch: 1
  randomizePitch: 1
  randomPitchRange: 0.1
```

## 📄 `Assets\Data\Audio\SFX_Player_Shoot.asset`
- Lines: 21
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 90a33418dcfd6f14ea927de15adf6a7d, type: 3}
  m_Name: SFX_Player_Shoot
  m_EditorClassIdentifier: 
  clips:
  - {fileID: 8300000, guid: f16c082ad078e8943990c633ba1ea8b4, type: 3}
  volume: 1
  pitch: 1
  randomizePitch: 1
  randomPitchRange: 0.1
```

## 📄 `Assets\Data\Behaviours\Beh_Avoidance.asset`
- Lines: 17
- Size: 0.4 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Data\Bosses\Architect\ARC_PAT_ClockRotation.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 04afb34efc00fbe419f85ba70442c5dd, type: 3}
  m_Name: ARC_PAT_ClockRotation
  m_EditorClassIdentifier: 
  startDelay: 1
  activeDuration: 3
  rotationSpeed: 20
  extendHands: 01010101
  activateWalls: 01010101
  activeGuns: 00000000
  shootingPattern: {fileID: 0}
```

## 📄 `Assets\Data\Bosses\Architect\ARC_PAT_HorizontalWall.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 04afb34efc00fbe419f85ba70442c5dd, type: 3}
  m_Name: ARC_PAT_HorizontalWall
  m_EditorClassIdentifier: 
  startDelay: 1
  activeDuration: 3
  rotationSpeed: 20
  extendHands: 01000100
  activateWalls: 01000100
  activeGuns: 00010001
  shootingPattern: {fileID: 11400000, guid: de571586b8c5c9645ada6df14bda94ef, type: 2}
```

## 📄 `Assets\Data\Bosses\Architect\ARC_PAT_StraightProjectiles.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Script: {fileID: 11500000, guid: 04afb34efc00fbe419f85ba70442c5dd, type: 3}
  m_Name: ARC_PAT_StraightProjectiles
  m_EditorClassIdentifier: 
  startDelay: 0.5
  activeDuration: 3
  rotationSpeed: 50
  extendHands: 00000000
  activateWalls: 00000000
  activeGuns: 01010101
  shootingPattern: {fileID: 11400000, guid: de571586b8c5c9645ada6df14bda94ef, type: 2}
```

## 📄 `Assets\Data\Enemies\Stats_Chaser.asset`
- Lines: 32
- Size: 0.7 KB
- Modified: 2025-12-31 09:17

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
  combatRotationSpeed: 3
  acceleration: 20
  rideHeight: 1.1
  verticalSmoothTime: 0.5
  separationRadius: 1.5
  separationForce: 8
  maxStagger: 5
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Stats_Guardian.asset`
- Lines: 33
- Size: 0.7 KB
- Modified: 2026-01-01 11:17

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
  maxHealth: 3
  maxStagger: 9
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Stats_Sentinel.asset`
- Lines: 31
- Size: 0.7 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Lines: 34
- Size: 0.8 KB
- Modified: 2026-01-01 12:29

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
  maxGrit: 3
  maxFocus: 100
  focusDecayRate: 5
  baseFocusOnKill: 30
  dashCost: 25
  dashDistance: 8
  dashCooldown: 0.15
  gunFireRate: 0.8
  gunDamage: 0
  gunStagger: 1
  beamFireRate: 0.4
  beamDamage: 1
  beamStagger: 0
  overdriveThreshold: 95
  overdriveSpeedMult: 1.2
  overdriveDamageMult: 2
  overdriveFireRateMult: 1.5
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Enemies.asset`
- Lines: 18
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
  - {fileID: 2100000, guid: 50b32f7aac95a284da161705ef2f83f1, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Hazards.asset`
- Lines: 18
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
  - {fileID: 2100000, guid: 02bb3983b3cf79d46a37acc3579e096d, type: 2}
```

## 📄 `Assets\Data\Visuals\Palettes\PAL_Alt.asset`
- Lines: 83
- Size: 2.4 KB
- Modified: 2025-12-31 09:17

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
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  playerSecondary:
    mainColor: {r: 1, g: 0.16509432, b: 0.16509432, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  playerTertiary:
    mainColor: {r: 0.9528302, g: 0.4809096, b: 0.4809096, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemyPrimary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemySecondary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemyTertiary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  projectileHostile:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  projectileFriendly:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  staggerColor: {r: 0.4811321, g: 0.44333738, b: 0.0068084607, a: 1}
  floor:
    mainColor: {r: 0.8584906, g: 0.8584906, b: 0.8584906, a: 0}
    smoothness: 0
    metallic: 0.00029999999
    emissionColor: {r: 0.42352942, g: 0, b: 0.30123967, a: 0}
    emissionIntensity: 1
  walls:
    mainColor: {r: 0.8018868, g: 0.8018868, b: 0.8018868, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0.33962262, g: 0, b: 0.33961517, a: 0}
    emissionIntensity: 0
  hazards:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  skyColor: {r: 0.89444643, g: 0.93871146, b: 0.9433962, a: 1}
```

## 📄 `Assets\Data\Visuals\Palettes\PAL_Neon.asset`
- Lines: 49
- Size: 1.3 KB
- Modified: 2025-12-31 09:17

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
- Lines: 83
- Size: 2.5 KB
- Modified: 2025-12-31 09:17

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
    mainColor: {r: 0.5952296, g: 0.5955943, b: 0.6037736, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  playerSecondary:
    mainColor: {r: 0.21226418, g: 0.2626792, b: 1, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  playerTertiary:
    mainColor: {r: 0.8679245, g: 0.09416164, b: 0.09416164, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemyPrimary:
    mainColor: {r: 0, g: 0.23518094, b: 0.6792453, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemySecondary:
    mainColor: {r: 0.9528302, g: 0.4179868, b: 0.4179868, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemyTertiary:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  projectileHostile:
    mainColor: {r: 1, g: 0.33965325, b: 0.0990566, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  projectileFriendly:
    mainColor: {r: 0, g: 0.12644672, b: 1, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  staggerColor: {r: 1, g: 0.8, b: 0, a: 1}
  floor:
    mainColor: {r: 0.8666667, g: 0.7882353, b: 0.7882353, a: 0}
    smoothness: 0.00029999999
    metallic: 0
    emissionColor: {r: 0.26352793, g: 0.7660412, b: 0.8867924, a: 0}
    emissionIntensity: 1
  walls:
    mainColor: {r: 0.6886792, g: 0.63995194, b: 0.63995194, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0.2627451, g: 0.7647059, b: 0.8862745, a: 0}
    emissionIntensity: 1
  hazards:
    mainColor: {r: 1, g: 0.1462264, b: 0.1462264, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 1, g: 0.9481132, b: 0.9481132, a: 0}
    emissionIntensity: 0.5
  skyColor: {r: 0.4009434, g: 1, b: 0.95789695, a: 1}
```

## 📄 `Assets\Data\Visuals\Themes\Theme_Enemy_Default.asset`
- Lines: 27
- Size: 0.7 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Data\Waves\WA_1_3Mis.asset`
- Lines: 25
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Name: WA_1_3Mis
  m_EditorClassIdentifier: 
  waveName: Wave 1
  entries:
  - enemyPrefab: {fileID: 3473038045254472648, guid: 1513d0ac6f440b04981069a6ebcff7b7,
      type: 3}
    count: 3
    rate: 0.5
    spawnPointIndex: -1
  gruntPrefabs: []
  maxGrunts: 0
  gruntSpawnRate: 5
```

## 📄 `Assets\Data\Waves\WA_1_3Sen.asset`
- Lines: 25
- Size: 0.6 KB
- Modified: 2025-12-31 09:17

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
  m_Name: WA_1_3Sen
  m_EditorClassIdentifier: 
  waveName: Wave 1
  entries:
  - enemyPrefab: {fileID: 3219024694404494821, guid: 4b198c7d670993e44b7353b1eeff09fd,
      type: 3}
    count: 3
    rate: 0.5
    spawnPointIndex: -1
  gruntPrefabs: []
  maxGrunts: 0
  gruntSpawnRate: 5
```

## 📄 `Assets\Data\Waves\WA_1_3Sen_3Chm.asset`
- Lines: 30
- Size: 0.8 KB
- Modified: 2025-12-31 09:17

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
  m_Name: WA_1_3Sen_3Chm
  m_EditorClassIdentifier: 
  waveName: Wave 1
  entries:
  - enemyPrefab: {fileID: 3219024694404494821, guid: 4b198c7d670993e44b7353b1eeff09fd,
      type: 3}
    count: 3
    rate: 0.5
    spawnPointIndex: -1
  - enemyPrefab: {fileID: 3473038045254472648, guid: 1513d0ac6f440b04981069a6ebcff7b7,
      type: 3}
    count: 3
    rate: 0.5
    spawnPointIndex: -1
  gruntPrefabs: []
  maxGrunts: 0
  gruntSpawnRate: 5
```

## 📄 `Assets\Data\Waves\WAV_TEST_Sentinel.asset`
- Lines: 26
- Size: 0.7 KB
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Combat\BaseHitbox.cs`
- Lines: 32
- Size: 0.9 KB
- Modified: 2026-01-01 09:48

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public abstract class BaseHitbox : MonoBehaviour, IDamageable
    {
        // CHANGED: Now references the new Orchestrator
        [SerializeField] protected DamageReceiver _receiver;

        protected virtual void Awake()
        {
            // Auto-link
            if (_receiver == null) _receiver = GetComponentInParent<DamageReceiver>();
        }

        public virtual bool TakeDamage(DamageInfo info)
        {
            // If no receiver, we still accept the hit but do nothing (Prop logic)
            if (_receiver != null) 
            {
                return _receiver.TakeDamage(info);
            }
            return true;
        }

        public virtual void Kill(bool instant)
        {
            if (_receiver) _receiver.Kill(instant);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\DamageReceiver.cs`
- Lines: 178
- Size: 5.8 KB
- Modified: 2026-01-01 12:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(VitalityModule))]
    [RequireComponent(typeof(StaggerModule))]
    public class DamageReceiver : MonoBehaviour, IDamageable, IPoolable, ICombatTarget
    {
        // --- DEBUG SWITCH ---
        public static bool EnableDebugGizmos = false;

        [Header("Override")]
        public bool useOverrides = false;
        [SerializeField] private float _overrideHealth = 50f;
        [SerializeField] private int _overrideStagger = 3;

        // Dependencies
        private VitalityModule _vitality;
        private StaggerModule _stagger;
        private EnemyStatsSO _stats;

        // Events
        public event System.Action<DamageInfo> OnHitProcessed;
        public event System.Action<EnemyStatsSO, bool> OnDeathProcessed;

        // --- FACADE PROPERTIES (Data Access) ---
        public float CurrentHealth => _vitality != null ? _vitality.CurrentHealth : 0f;
        public float MaxHealth => _vitality != null ? _vitality.MaxHealth : 0f;
        public float CurrentStagger => _stagger != null ? _stagger.CurrentStagger : 0f;
        public float MaxStagger => _stagger != null ? _stagger.MaxStagger : 0f;

        public bool IsStaggered => _stagger != null && _stagger.IsStaggered;
        public bool IsDead => _vitality != null && _vitality.IsDead;

        // --- MODULE ACCESSORS (Fixes CS1061) ---
        public VitalityModule Vitality => _vitality;
        public StaggerModule Stagger => _stagger;
        // ---------------------------------------

        private void Awake()
        {
            _vitality = GetComponent<VitalityModule>();
            _stagger = GetComponent<StaggerModule>();

            // Internal Link: Ensure Vitality death triggers Main death
            if (_vitality) _vitality.OnDeath += HandleVitalityDeath;
        }

        private void OnDestroy()
        {
            if (_vitality) _vitality.OnDeath -= HandleVitalityDeath;
        }

        // --- INITIALIZATION ---
        public void Initialize(EnemyStatsSO stats)
        {
            _stats = stats;
            float hp = 10f; 
            int stg = 1;
            float decay = 1f;

            if (useOverrides)
            {
                hp = _overrideHealth;
                stg = _overrideStagger;
            }
            else if (_stats != null)
            {
                hp = _stats.maxHealth;
                stg = _stats.maxStagger;
                decay = _stats.staggerDecay;
            }

            if (_vitality == null) _vitality = GetComponent<VitalityModule>();
            if (_stagger == null) _stagger = GetComponent<StaggerModule>();
            
            _vitality.Initialize(hp);
            _stagger.Initialize(stg, decay);
        }

        public void OnSpawn() { }

        public void OnDespawn()
        {
            if (_stagger) _stagger.ResetStagger();
        }

        // --- LOGIC PIPELINE ---
        public bool TakeDamage(DamageInfo info)
        {
            if (IsDead) return false;

            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            if (IsStaggered)
            {
                // Damage while staggered = Execution opportunity or Bonus Damage
                // Design Choice: If gun (0 dmg) hits staggered -> No effect?
                // Or if Beam (10 dmg) hits staggered -> Instant Kill?
                if (info.damageAmount > 0) 
                {
                    Kill(true);
                }
            }
            else
            {
                _stagger.AddStagger(info.staggerAmount);
                _vitality.TakeDamage(info.damageAmount);
            }

            OnHitProcessed?.Invoke(info);
            return true;
        }

        public void Kill(bool rewardPlayer)
        {
            if (IsDead) return;
            
            // Fire event immediately
            OnDeathProcessed?.Invoke(_stats, rewardPlayer);
            
            // Force Vitality death
            _vitality.TakeDamage(99999f); 
        }

        private void HandleVitalityDeath()
        {
            // Fired when health drops to 0 naturally
            // We assume natural death grants rewards (true)
            OnDeathProcessed?.Invoke(_stats, true);
        }

        // --- ICombatTarget ---
        public void OnExecutionHit() => Kill(true);
        public bool KeepPlayerGrounded => true;

        // --- DEBUG GIZMOS ---
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (!EnableDebugGizmos || !Application.isPlaying || _vitality == null) return;
            
            GUIStyle style = new GUIStyle();
            style.normal.textColor = Color.white;
            style.fontSize = 20;
            style.alignment = TextAnchor.MiddleCenter;
            style.fontStyle = FontStyle.Bold;

            float hp = CurrentHealth;
            float maxHp = MaxHealth;
            float stg = CurrentStagger;
            float maxStg = MaxStagger;

            string hpColor = (hp < maxHp * 0.3f) ? "red" : "green";
            string stagColor = IsStaggered ? "yellow" : "cyan";

            string label = $"<color={hpColor}>HP: {hp:F0}/{maxHp:F0}</color>\n" +
                           $"<color={stagColor}>STG: {stg:F0}/{maxStg:F0}</color>";

            if (IsStaggered) label += "\n<color=yellow>[STAGGERED]</color>";

            Vector3 labelPos = transform.position + Vector3.up * 5f;
            UnityEditor.Handles.Label(labelPos, label, style);
        }
#endif
    }
}
```

## 📄 `Assets\Scripts\Combat\HazardZone.cs`
- Lines: 91
- Size: 3.0 KB
- Modified: 2025-12-31 12:27

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

        // Tween references so we can safely kill them if the zone is stopped early
        private Tween _scaleTween;
        private Tween _fadeTween;
        private Tween _delayedCallTween;
        private Coroutine _destroyCoroutine;

        private void Start()
        {
            Transform target = visualRing != null ? visualRing : transform;

            // 1. Expand Visuals (Juice)
            target.localScale = Vector3.zero;
            _scaleTween = target.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);

            // 2. Schedule Destruction
            // Fade out shortly before destroying
            _delayedCallTween = DOVirtual.DelayedCall(Mathf.Max(0f, duration - 0.5f), FadeOut);
            _destroyCoroutine = StartCoroutine(AutoDestroyCoroutine());
        }

        private void OnDisable()
        {
            _scaleTween?.Kill();
            _fadeTween?.Kill();
            _delayedCallTween?.Kill();

            if (_destroyCoroutine != null)
            {
                try { StopCoroutine(_destroyCoroutine); } catch { }
                _destroyCoroutine = null;
            }
        }

        private System.Collections.IEnumerator AutoDestroyCoroutine()
        {
            yield return new WaitForSeconds(duration);
            Destroy(gameObject);
        }

        private void FadeOut()
        {
            Transform target = visualRing != null ? visualRing : transform;
            _fadeTween = target.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check Layer
            if ((targetLayer.value & (1 << other.gameObject.layer)) != 0)
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
                        ,
                        // NEW: Environment
                        damageType = DamageType.Environment
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HitBox\ShieldHitbox.cs`
- Lines: 128
- Size: 4.0 KB
- Modified: 2026-01-01 09:49

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class ShieldHitbox : BaseHitbox
    {
        [Header("Heat Mechanics")]
        public float maxHeat = 10f;
        public float coolDownRate = 2f;
        public float staggerToHeatMultiplier = 10f; 
        
        public bool isBroken = false;
        
        [Header("Advanced Mechanics")]
        public bool reflectProjectiles = false; 

        [Header("Visuals")]
        public Renderer shieldRenderer;
        public Color coldColor = Color.grey;
        public Color hotColor = new Color(1f, 0.3f, 0f); 

        [Header("Audio")]
        public AudioClip breakClip;

        private float _currentHeat;
        private float _lastHitTime;

        private void OnEnable()
        {
            _currentHeat = 0;
            isBroken = false;
            if (shieldRenderer) shieldRenderer.enabled = true;
            UpdateVisuals();
        }

        private void Update()
        {
            if (isBroken) return;

            if (_currentHeat > 0 && Time.time > _lastHitTime + 1.0f)
            {
                _currentHeat -= coolDownRate * Time.deltaTime;
                UpdateVisuals();
            }
        }

        public override bool TakeDamage(DamageInfo info)
        {
            // CHANGED: Use _receiver
            if (_receiver == null) return false;
            
            if (isBroken) return base.TakeDamage(info);

            _lastHitTime = Time.time;

            if (info.isRedirected)
            {
                BreakShield();
                return true; 
            }

            if (info.damageType == DamageType.Projectile || info.damageType == DamageType.Generic)
            {
                float heatAdded = info.damageAmount + (info.staggerAmount * staggerToHeatMultiplier);
                _currentHeat += heatAdded;
                
                if (shieldRenderer) shieldRenderer.transform.DOPunchScale(Vector3.one * 0.05f, 0.1f);
                UpdateVisuals();

                if (reflectProjectiles && info.source != null)
                {
                    var proj = info.source.GetComponent<Projectile>();
                    if (proj != null)
                    {
                        proj.DeflectByEnemy(transform.forward);
                        GameEvents.OnPopupText?.Invoke(transform.position, "REFLECT");
                        return true; 
                    }
                }

                GameEvents.OnPopupText?.Invoke(transform.position, "DEFLECT");
                return true; 
            }
            
            else if (info.damageType == DamageType.Melee)
            {
                if (_currentHeat >= maxHeat)
                {
                    BreakShield();
                    return true; 
                }
                else
                {
                    GameEvents.OnPopupText?.Invoke(transform.position, "ARMORED");
                    return false; 
                }
            }

            return base.TakeDamage(info);
        }

        private void BreakShield()
        {
            isBroken = true;
            if (shieldRenderer) shieldRenderer.enabled = false;
            
            GameEvents.OnPopupText?.Invoke(transform.position, "SHATTERED");
            
            if (AudioManager.Instance && breakClip)
                 AudioManager.Instance.PlaySound(breakClip, 1.0f);
                 
            // TODO: Spawn AOE Explosion Hazard here if you want the "Exploding Shield" perk
        }

        private void UpdateVisuals()
        {
            if (shieldRenderer)
            {
                float t = Mathf.Clamp01(_currentHeat / maxHeat);
                shieldRenderer.material.color = Color.Lerp(coldColor, hotColor, t);
                shieldRenderer.material.SetColor("_EmissionColor", Color.Lerp(coldColor, hotColor, t) * (1 + t * 2)); 
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HitBox\StandardHitbox.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2026-01-01 09:48

```csharp
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public class StandardHitbox : BaseHitbox
    {
        public float damageMultiplier = 1.0f; 

        public override bool TakeDamage(DamageInfo info)
        {
            info.damageAmount *= damageMultiplier;
            return base.TakeDamage(info);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HitboxRelay.cs`
- Lines: 67
- Size: 2.4 KB
- Modified: 2025-12-31 17:15

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public class HitboxRelay : MonoBehaviour, IDamageable
    {
        [Header("Link")]
        // CHANGED: Serialized Object reference, cast to Interface at runtime
        // Why GameObject? Unity can't serialize Interfaces directly in Inspector easily.
        [SerializeField] private GameObject _mainControllerObject;

        private IDamageable _mainController;

        [Header("Settings")]
        [SerializeField] private float _damageMultiplier = 1.0f;

        private void Awake()
        {
            // Manual Assignment Logic
            if (_mainControllerObject != null)
            {
                _mainController = _mainControllerObject.GetComponent<IDamageable>();
            }

            // Auto-Link Fallback (If empty)
            if (_mainController == null)
            {
                // Try parent first
                _mainController = GetComponentInParent<IDamageable>();

                // If this object IS the parent (recursion risk), look specifically for other components?
                // No, Relay is usually on a child. 
                // But wait! If Relay is on Child, and Parent has Controller, GetComponentInParent works.
                // Note: GetComponentsInParent includes THIS object. We must ensure we don't find ourselves!

                if (_mainController == this as IDamageable)
                {
                    // If we found ourselves, look at parent specifically
                    if (transform.parent != null)
                        _mainController = transform.parent.GetComponentInParent<IDamageable>();
                }
            }

            if (_mainController == null)
            {
                GameLogger.LogWarning(LogChannel.Combat, $"HitboxRelay on {name} could not find an IDamageable parent!", gameObject);
            }
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_mainController == null) return false;

            // Apply multiplier
            info.damageAmount *= _damageMultiplier;

            // Forward the hit
            return _mainController.TakeDamage(info);
        }

        public void Kill(bool instant)
        {
            if (_mainController != null) _mainController.Kill(instant);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HomingMissile.cs`
- Lines: 49
- Size: 1.7 KB
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Combat\Modules\StaggerModule.cs`
- Lines: 79
- Size: 2.2 KB
- Modified: 2026-01-01 11:40

```csharp
using UnityEngine;
using System;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class StaggerModule : MonoBehaviour
    {
        public event Action OnStaggerBreak;
        public event Action OnStaggerRecover;

        public float CurrentStagger { get; private set; }
        public float MaxStagger { get; private set; }
        public bool IsStaggered { get; private set; }

        private float _decayRate;
        private float _lastHitTime;
        private Tween _recoveryTween;

        public void Initialize(float maxStagger, float decayRate)
        {
            MaxStagger = maxStagger;
            _decayRate = decayRate;
            ResetStagger();
        }

        public void ResetStagger()
        {
            IsStaggered = false;
            CurrentStagger = 0;
            if (_recoveryTween != null) _recoveryTween.Kill();
        }

        private void Update()
        {
            // Passive Decay logic
            if (!IsStaggered && CurrentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f) // Wait 1s before decaying
                {
                    CurrentStagger -= _decayRate * Time.deltaTime;
                    if (CurrentStagger < 0) CurrentStagger = 0;
                }
            }
        }

        public void AddStagger(float amount)
        {
            if (IsStaggered) return; // Already broken

            _lastHitTime = Time.time;
            CurrentStagger += amount;

            if (CurrentStagger >= MaxStagger)
            {
                BreakStagger();
            }
        }

        private void BreakStagger()
        {
            IsStaggered = true;
            OnStaggerBreak?.Invoke();

            // Auto-Recover after 2.0s
            // We use DOTween delay for consistency with visuals
            if (_recoveryTween != null) _recoveryTween.Kill();
            _recoveryTween = DOVirtual.DelayedCall(2.0f, Recover).SetId(gameObject);
        }

        private void Recover()
        {
            if (this == null) return;
            IsStaggered = false;
            CurrentStagger = 0;
            OnStaggerRecover?.Invoke();
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Modules\VitalityModule.cs`
- Lines: 58
- Size: 1.5 KB
- Modified: 2026-01-01 11:40

```csharp
using UnityEngine;
using System;

namespace DarkTowerTron.Combat
{
    public class VitalityModule : MonoBehaviour
    {
        public event Action<float, float> OnHealthChanged; // Current, Max
        public event Action OnDeath;

        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        public bool IsDead { get; private set; }

        public void Initialize(float maxHealth)
        {
            MaxHealth = maxHealth;
            // Safety check
            if (MaxHealth <= 0) MaxHealth = 1f;
            
            Revive();
        }

        public void Revive()
        {
            CurrentHealth = MaxHealth;
            IsDead = false;
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        public void TakeDamage(float amount)
        {
            if (IsDead) return;

            CurrentHealth -= amount;
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);

            if (CurrentHealth <= 0)
            {
                Die();
            }
        }

        public void Heal(float amount)
        {
            if (IsDead) return;
            CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth);
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        private void Die()
        {
            IsDead = true;
            CurrentHealth = 0;
            OnDeath?.Invoke();
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Projectile.cs`
- Lines: 210
- Size: 7.2 KB
- Modified: 2026-01-01 14:57

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
        [Min(0)] public int stagger = 1; // Changed to Int
        public DamageType damageType = DamageType.Projectile; // NEW

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial; // Used when Player Blitzes
        public Material hostileMaterial;  // NEW: Used when Enemy Shield Reflects

        private Material _originalMaterial;
        private Vector3 _direction;
        private GameObject _source;
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private float _lifeTimer;
        // NEW: State to prevent self-destruction on bounce
        private bool _wasDeflectedThisFrame = false;
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

        public void SetSource(GameObject source)
        {
            _source = source;
        }

        private void Update()
        {
            if (!_isInitialized) return;
            _wasDeflectedThisFrame = false; // Reset flag every frame

            // Countdown Grace Period
            if (_graceTimer > 0) _graceTimer -= Time.deltaTime;

            float moveDistance = speed * Time.deltaTime;

            // --- ANTI-TUNNELING RAYCAST ---
            // Cast a ray forward equal to the distance we are about to move
            // We combine all relevant layers into one mask
            int layerMask = LayerMask.GetMask("Default", "Wall", "Player", "Enemy");

            if (UnityEngine.Physics.Raycast(transform.position, _direction, out RaycastHit hit, moveDistance, layerMask))
            {
                // IGNORE SELF / SOURCE
                if (_source != null && (hit.collider.gameObject == _source || hit.transform.IsChildOf(_source.transform))) 
                {
                    // Move normally if we hit the shooter (avoid stuck bullets)
                    transform.Translate(_direction * moveDistance, Space.World);
                }
                else
                {
                    // WE HIT SOMETHING!
                    // Move to the hit point
                    transform.position = hit.point;
                    // Trigger collision logic manually
                    HandleCollision(hit.collider);
                    return; // Stop moving this frame
                }
            }
            else
            {
                // Clear path, move forward
                transform.Translate(_direction * moveDistance, Space.World);
            }
            // -----------------------------

            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0) Despawn();
        }

        // Refactored logic from OnTriggerEnter to a shared method
        private void HandleCollision(Collider other)
        {
            // Respect grace period
            if (_graceTimer > 0) return;

            if (other.isTrigger && other.GetComponent<ShieldHitbox>() == null) return; // Ignore random triggers, but hit Shields

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
                    isRedirected = this._isRedirected,
                    damageType = this.damageType
                };

                if (target.TakeDamage(info))
                {
                    if (!_wasDeflectedThisFrame) Despawn();
                }
            }
        }

        // Keep OnTriggerEnter as a backup for overlaps
        private void OnTriggerEnter(Collider other)
        {
             HandleCollision(other);
        }

        // --- NEW METHOD FOR SHIELDS ---
        public void DeflectByEnemy(Vector3 surfaceNormal)
        {
            _wasDeflectedThisFrame = true;
            isHostile = true; // Now it hurts the player!

            // 1. Physics Math
            _direction = Vector3.Reflect(_direction, surfaceNormal).normalized;
            transform.rotation = Quaternion.LookRotation(_direction);
            speed *= 1.2f;

            // 2. Visual Change
            if (meshRenderer)
            {
                if (hostileMaterial)
                {
                    meshRenderer.material = hostileMaterial;
                }
                else
                {
                    // Fallback
                    meshRenderer.material.color = Color.red;
                }
            }
            
            // 3. Reset Timer
            _lifeTimer = lifetime;
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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Core\Data\ArchitectPatternSO.cs`
- Lines: 29
- Size: 0.8 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Bosses/Architect Pattern")]
    public class ArchitectPatternSO : ScriptableObject
    {
        [Header("Phase Timings")]
        public float startDelay = 1.0f;
        public float activeDuration = 6.0f;

        [Header("Configuration")]
        public float rotationSpeed = 15f;

        [Header("Hands Configuration (Size 4)")]
        [Tooltip("True = Move Outer, False = Move Inner")]
        public bool[] extendHands;

        [Tooltip("True = Laser Wall ON")]
        public bool[] activateWalls;

        [Tooltip("True = Fire Projectiles")]
        public bool[] activeGuns; // NEW: Specific firing control

        [Header("Shooting")]
        public AttackPatternSO shootingPattern;
    }
}
```

## 📄 `Assets\Scripts\Core\Data\AttackPatternSO.cs`
- Lines: 30
- Size: 1.1 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    // Define Enum here so it's accessible
    public enum AimType
    {
        TargetPlayer,   // Guardian style (Aim at player)
        ForwardRadial   // Boss style (Shoot straight out from hand)
    }

    [CreateAssetMenu(menuName = "DarkTowerTron/Combat/Attack Pattern")]
    public class AttackPatternSO : ScriptableObject
    {
        [Header("Aiming & Visuals")]
        public AimType aimMode = AimType.TargetPlayer;
        public float scaleMultiplier = 1.0f; // Boss bullets are huge
        public float speed = 15f;            // Projectile speed

        [Header("Pattern Shape")]
        public int projectileCount = 1;      // How many bullets per "Trigger"
        [Range(0, 360)] public float spreadAngle = 0f;
        public bool spinDuringFire = false;
        public float spinSpeed = 0f;

        [Header("Timing")]
        public float startDelay = 0.5f;      // Windup time
        public float delayBetweenShots = 0.1f; // Time between individual bullets in a burst/stream
    }
}
```

## 📄 `Assets\Scripts\Core\Data\ColorPaletteSO.cs`
- Lines: 47
- Size: 1.8 KB
- Modified: 2025-12-31 09:17

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
        
        [ColorUsage(true, true)] public Color emissionColor;
        [Tooltip("How bright is the emission? (Use HDR)")]
        public float emissionIntensity;
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

## 📄 `Assets\Scripts\Core\Data\DebugProfileSO.cs`
- Lines: 53
- Size: 1.8 KB
- Modified: 2025-12-31 14:46

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "DebugProfile", menuName = "DarkTowerTron/Debug/Profile")]
    public class DebugProfileSO : ScriptableObject
    {
        [Header("Global Toggle")]
        public bool enableLogging = true;

        [Header("Channels")]
        public bool logPlayer = true;
        public bool logAI = true;
        public bool logCombat = true;
        public bool logUI = true;
        public bool logPhysics = false; // Usually noisy, keep off
        public bool logSystem = true;
        public bool logVFX = false;

        public bool IsChannelActive(LogChannel channel)
        {
            if (!enableLogging) return false;

            switch (channel)
            {
                case LogChannel.Player: return logPlayer;
                case LogChannel.AI: return logAI;
                case LogChannel.Combat: return logCombat;
                case LogChannel.UI: return logUI;
                case LogChannel.Physics: return logPhysics;
                case LogChannel.System: return logSystem;
                case LogChannel.VFX: return logVFX;
                default: return true;
            }
        }

        // Color coding for the console to make reading faster
        public string GetColor(LogChannel channel)
        {
            switch (channel)
            {
                case LogChannel.Player: return "cyan";
                case LogChannel.AI: return "orange";
                case LogChannel.Combat: return "red";
                case LogChannel.UI: return "yellow";
                case LogChannel.Physics: return "green";
                case LogChannel.System: return "white";
                default: return "grey";
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\EnemyStatsSO.cs`
- Lines: 66
- Size: 2.4 KB
- Modified: 2026-01-01 09:03

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
        public float maxHealth = 10f; // NEW: Actual HP
        [Min(1)] public int maxStagger = 3; // INT (e.g. 3 hits)
        public float staggerDecay = 1.0f; // Decay speed (1 per second)

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

            // Prevent 0 HP zombies
            maxHealth = Mathf.Max(1f, maxHealth);

            // Stagger must be a positive integer and decay shouldn't be zero
            maxStagger = Mathf.Max(1, maxStagger);
            staggerDecay = Mathf.Max(0.01f, staggerDecay);

            // Flocking safety
            separationRadius = Mathf.Max(0.1f, separationRadius);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\FeedbackProfileSO.cs`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Feedback Profile")]
    public class FeedbackProfileSO : ScriptableObject
    {
        [Header("Camera Shake")]
        public float shakeDuration = 0.2f;
        public float shakeStrength = 0.5f;

        [Header("Time Freeze")]
        public float hitStopDuration = 0.1f;

        [Header("Audio")]
        public SoundDef sound; // Reuses your SoundDef system!
    }
}
```

## 📄 `Assets\Scripts\Core\Data\MaterialCollectionSO.cs`
- Lines: 12
- Size: 0.4 KB
- Modified: 2025-12-31 09:17

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
- Lines: 68
- Size: 2.6 KB
- Modified: 2026-01-01 12:23

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
        public float focusDecayRate = 5f;       // Moved here
        public float baseFocusOnKill = 30f;     // Moved here (Default reward)

        [Header("Dash / Dodge")]
        public float dashCost = 25f;
        public float dashDistance = 8f;
        public float dashCooldown = 0.15f;

        [Header("Weapon: Gun (Ranged)")]
        public float gunFireRate = 0.15f;
        public float gunDamage = 0f;    // Usually 0 for this game
        [Min(0)] public int gunStagger = 1; // 1 shot = 1 point

        [Header("Weapon: Beam (Melee)")]
        public float beamFireRate = 0.4f;
        public float beamDamage = 10f;
        [Min(0)] public int beamStagger = 1; // 1 hit = 1 point

        // --- Validation ---
        private void OnValidate()
        {
            moveSpeed = Mathf.Max(0f, moveSpeed);
            acceleration = Mathf.Max(0.01f, acceleration);

            maxGrit = Mathf.Max(1, maxGrit);
            maxFocus = Mathf.Max(0f, maxFocus);
            focusDecayRate = Mathf.Max(0f, focusDecayRate);
            baseFocusOnKill = Mathf.Max(0f, baseFocusOnKill);

            dashCost = Mathf.Max(0f, dashCost);
            dashDistance = Mathf.Max(0f, dashDistance);
            dashCooldown = Mathf.Max(0.001f, dashCooldown);

            gunFireRate = Mathf.Max(0.001f, gunFireRate);
            gunDamage = Mathf.Max(0f, gunDamage);
            gunStagger = Mathf.Max(0, gunStagger);

            beamFireRate = Mathf.Max(0.001f, beamFireRate);
            beamDamage = Mathf.Max(0f, beamDamage);
            beamStagger = Mathf.Max(0, beamStagger);

            overdriveThreshold = Mathf.Clamp(overdriveThreshold, 0f, 100f);
            overdriveSpeedMult = Mathf.Max(0.01f, overdriveSpeedMult);
            overdriveDamageMult = Mathf.Max(0f, overdriveDamageMult);
            overdriveFireRateMult = Mathf.Max(0.01f, overdriveFireRateMult);
        }

        [Header("Overdrive Modifiers")]
        public float overdriveThreshold = 80f;
        public float overdriveSpeedMult = 1.2f;
        public float overdriveDamageMult = 2.0f; // Doubles damage
        public float overdriveFireRateMult = 1.5f; // Shoots faster (Multiplier > 1 means faster)
    }
}
```

## 📄 `Assets\Scripts\Core\Data\SoundDef.cs`
- Lines: 33
- Size: 1.0 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Sound Definition")]
    public class SoundDef : ScriptableObject
    {
        [Header("Clips")]
        [Tooltip("Randomly plays one of these clips.")]
        public AudioClip[] clips;

        [Header("Settings")]
        [Range(0f, 1f)] public float volume = 1f;
        [Range(0.1f, 3f)] public float pitch = 1f;

        [Header("Variation")]
        public bool randomizePitch = true;
        [Range(0f, 0.5f)] public float randomPitchRange = 0.1f;

        // Logic to pick a clip
        public AudioClip GetClip()
        {
            if (clips == null || clips.Length == 0) return null;
            return clips[Random.Range(0, clips.Length)];
        }

        public float GetPitch()
        {
            if (!randomizePitch) return pitch;
            return pitch + Random.Range(-randomPitchRange, randomPitchRange);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\UIThemeSO.cs`
- Lines: 23
- Size: 0.7 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using TMPro;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/UI Theme")]
    public class UIThemeSO : ScriptableObject
    {
        [Header("Fonts")]
        public TMP_FontAsset mainFont;
        public TMP_FontAsset digitFont;

        [Header("Colors")]
        public Color primaryColor = Color.cyan;   // Titles / Borders
        public Color accentColor = Color.yellow;  // Buttons / Highlights
        public Color dangerColor = Color.red;     // Game Over / Health
        public Color bodyColor = Color.white;     // Normal Text

        [Header("Sprites")]
        public Sprite buttonBackground;
        public Sprite panelBackground;
    }
}
```

## 📄 `Assets\Scripts\Core\Data\WaveDefinitionSO.cs`
- Lines: 30
- Size: 0.8 KB
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Core\Debug\GameLogger.cs`
- Lines: 51
- Size: 1.9 KB
- Modified: 2025-12-31 14:47

```csharp
using UnityEngine;
using System.Diagnostics; // Required for Conditional attribute
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Core
{
    public static class GameLogger
    {
        private static DebugProfileSO _profile;

        // Auto-load the profile from Resources if not set, or assign manually
        private static DebugProfileSO Profile
        {
            get
            {
                if (_profile == null)
                    _profile = Resources.Load<DebugProfileSO>("DebugProfile");
                return _profile;
            }
        }

        // Only compile this code in the Editor or Development Builds
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void Log(LogChannel channel, string message, GameObject context = null)
        {
            if (Profile == null) return;
            if (!Profile.IsChannelActive(channel)) return;

            string color = Profile.GetColor(channel);
            string prefix = $"<color={color}>[{channel}]</color>";
            
            UnityEngine.Debug.Log($"{prefix} {message}", context);
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogWarning(LogChannel channel, string message, GameObject context = null)
        {
            // Warnings usually ignore the filter, or you can add a separate filter
            string prefix = $"<color=yellow>[{channel} WARNING]</color>";
            UnityEngine.Debug.LogWarning($"{prefix} {message}", context);
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogError(LogChannel channel, string message, GameObject context = null)
        {
            // Errors always show
            string prefix = $"<color=red>[{channel} ERROR]</color>";
            UnityEngine.Debug.LogError($"{prefix} {message}", context);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameConstants.cs`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 17:15

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
        public static Action<int, int> OnGritChanged; // Current, Max

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
            
            GameLogger.Log(LogChannel.System, "[GameEvents] All static listeners cleared.", null);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameServices.cs`
- Lines: 52
- Size: 2.0 KB
- Modified: 2025-12-31 17:15

```csharp
using UnityEngine;
using DarkTowerTron.Managers;
using DarkTowerTron.Player;

namespace DarkTowerTron.Core
{
    [DefaultExecutionOrder(-100)] // Init before everything else
    public class GameServices : MonoBehaviour
    {
        public static GameServices Instance { get; private set; }

        [Header("System Services")]
        [SerializeField] private WaveDirector _waveDirector;
        [SerializeField] private ScoreManager _scoreManager;
        [SerializeField] private PoolManager _poolManager;
        [SerializeField] private VFXManager _vfxManager;
        [SerializeField] private AudioManager _audioManager;
        [SerializeField] private DamageTextManager _damageTextManager;

        // Dynamic Services (Set at runtime)
        public static PlayerController Player { get; private set; }

        // Public Accessors
        public static WaveDirector WaveDirector => Instance != null ? Instance._waveDirector : null;
        public static ScoreManager Score => Instance != null ? Instance._scoreManager : null;
        public static PoolManager Pool => Instance != null ? Instance._poolManager : null;
        public static VFXManager VFX => Instance != null ? Instance._vfxManager : null;
        public static AudioManager Audio => Instance != null ? Instance._audioManager : null;
        public static DamageTextManager DamageText => Instance != null ? Instance._damageTextManager : null;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }

        public static void RegisterPlayer(PlayerController player)
        {
            Player = player;
            GameLogger.Log(LogChannel.System, "[GameServices] Player Registered.", player != null ? player.gameObject : null);
        }

        private void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameTime.cs`
- Lines: 35
- Size: 0.8 KB
- Modified: 2025-12-31 09:17

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
- Size: 0.3 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface ICombatTarget
    {
        Transform transform { get; }
        bool IsStaggered { get; }

        // NEW: Tells the Execution script if it should snap Y to ground
        bool KeepPlayerGrounded { get; }

        void OnExecutionHit();
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IDamageable.cs`
- Lines: 8
- Size: 0.2 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

```csharp
namespace DarkTowerTron.Core
{
    public interface IWeapon
    {
        void SetFiring(bool isFiring);
    }
}
```

## 📄 `Assets\Scripts\Core\LogChannel.cs`
- Lines: 14
- Size: 0.4 KB
- Modified: 2025-12-31 14:46

```csharp
namespace DarkTowerTron.Core
{
    public enum LogChannel
    {
        General,    // Default
        Player,     // Input, Movement, State
        AI,         // Decisions, State changes, Pathing
        Combat,     // Damage, Projectiles, Hitboxes
        UI,         // Menu navigation, HUD updates
        Physics,    // Collisions, Triggers
        System,     // Wave Manager, Loading, Saving
        VFX         // Particles, Audio
    }
}
```

## 📄 `Assets\Scripts\Core\Spinner.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2025-12-31 09:17

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
- Lines: 18
- Size: 0.5 KB
- Modified: 2026-01-01 08:58

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public enum DamageType { Generic, Projectile, Melee, Explosion, Environment }

    [System.Serializable]
    public struct DamageInfo
    {
        public float damageAmount;
        public int staggerAmount; // CHANGED TO INT
        public Vector3 pushDirection;
        public float pushForce;
        public GameObject source;
        public bool isRedirected;
        public DamageType damageType; 
    }
}
```

## 📄 `Assets\Scripts\Core\VoidKiller.cs`
- Lines: 33
- Size: 1.0 KB
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Editor\SmartDuplicator.cs`
- Lines: 70
- Size: 2.5 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace DarkTowerTron.EditorTools
{
    public class SmartDuplicator : Editor
    {
        [MenuItem("Edit/Smart Duplicate %#d")]
        public static void DuplicateWithNaming()
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            if (selectedObjects.Length == 0) return;

            Undo.IncrementCurrentGroup();
            int undoIndex = Undo.GetCurrentGroup();

            System.Collections.Generic.List<GameObject> newSelection = new System.Collections.Generic.List<GameObject>();

            foreach (GameObject original in selectedObjects)
            {
                // FIX: Use standard Instantiate. 
                // In the Editor, this preserves the Prefab connection (Blue Text) automatically.
                GameObject clone = Instantiate(original, original.transform.parent);

                // Register Undo so Ctrl+Z removes the object
                Undo.RegisterCreatedObjectUndo(clone, "Smart Duplicate");

                // Match Transform
                clone.transform.localPosition = original.transform.localPosition;
                clone.transform.localRotation = original.transform.localRotation;
                clone.transform.localScale = original.transform.localScale;

                // Calculate Name
                string newName = IncrementName(original.name);
                clone.name = newName;

                newSelection.Add(clone);
            }

            // Select the new objects
            Selection.objects = newSelection.ToArray();
            Undo.CollapseUndoOperations(undoIndex);
        }

        private static string IncrementName(string originalName)
        {
            // Regex to find a number at the end (e.g. "_01" or " 1")
            Match match = Regex.Match(originalName, @"^(.*?)(\d+)$");

            if (match.Success)
            {
                string prefix = match.Groups[1].Value;
                string numberStr = match.Groups[2].Value;

                if (int.TryParse(numberStr, out int number))
                {
                    number++;
                    // Keep the leading zeros format (01 -> 02)
                    string newNumberStr = number.ToString(new string('0', numberStr.Length));
                    return prefix + newNumberStr;
                }
            }

            // Fallback: If no number found, add "_1"
            return originalName + "_1";
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Chaser.cs`
- Lines: 136
- Size: 4.2 KB
- Modified: 2025-12-31 12:26

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
                        ,
                        // NEW: Explicitly Explosion
                        damageType = DamageType.Explosion
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
- Size: 5.1 KB
- Modified: 2025-12-31 17:14

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
                GameLogger.LogWarning(LogChannel.AI, $"{name}: No PatrolPath found! Standing still.", gameObject);
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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Enemy\Bosses\Architect\ArchitectController.cs`
- Lines: 298
- Size: 9.2 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.FSM; // State Machine System
using DarkTowerTron.Managers; // VFX & Pool
using DG.Tweening;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    [RequireComponent(typeof(StateMachine))]
    public class ArchitectController : MonoBehaviour, IDamageable, ICombatTarget
    {
        [Header("Parts")]
        public Transform rotationRig;
        public List<ArchitectHand> hands;
        public GameObject shieldVisual;

        [Header("Stats")]
        public float coreHealth = 50f;
        public float rotationSpeedIdle = 10f;
        public float rotationSpeedCombat = 30f;

        [Header("Configuration")]
        public float radiusOuter = 2.5f; // Local distance for "Outer" position
        public float radiusInner = 0.8f; // Local distance for "Inner" position
        public float patternInterval = 2.0f; // Time between patterns

        [Header("Patterns")]
        public List<ArchitectPatternSO> phase1Patterns;

        [Header("Debug")]
        public bool autoStartCombat = false;

        public bool KeepPlayerGrounded => true;

        // State
        private bool _isCombatActive = false;
        private bool _isVulnerable = false;
        private Transform _player;
        private float _currentRotationSpeed;
        private int _currentPatternIndex = 0;

        // Components
        private StateMachine _fsm;

        // NEW: Idle State reference
        public ArchitectState_Idle StateIdle { get; private set; }

        private void Awake()
        {
            _fsm = GetComponent<StateMachine>();
            StateIdle = new ArchitectState_Idle(); // Initialize it
        }

        private void Start()
        {
            // Use Service Locator for player reference
            if (GameServices.Player != null)
            {
                _player = GameServices.Player.transform;
            }

            // Setup
            SetShield(true);
            _currentRotationSpeed = rotationSpeedIdle;

            if (autoStartCombat)
            {
                Invoke(nameof(ActivateBoss), 1.0f);
            }
        }

        private void Update()
        {
            // 1. Constant Rotation
            if (rotationRig)
            {
                rotationRig.Rotate(Vector3.up, _currentRotationSpeed * Time.deltaTime);
            }

            if (!_isCombatActive) return;

            // 2. Check Hands (Phase Transition)
            if (!_isVulnerable)
            {
                int livingHands = 0;
                foreach (var h in hands)
                {
                    if (h != null && h.IsAlive()) livingHands++;
                }

                if (livingHands == 0)
                {
                    StartCoroutine(EnterVulnerablePhase());
                }
            }
        }

        // --- COMBAT FLOW ---

        public void ActivateBoss()
        {
            if (_isCombatActive) return;

            _isCombatActive = true;
            _currentRotationSpeed = rotationSpeedCombat;

            // Start the first pattern
            StartNextPattern();

            // UI / Audio Juice
            GameEvents.OnWaveAnnounce?.Invoke(666); // Custom ID for Boss
            GameEvents.OnWaveCombatStarted?.Invoke();
        }

        public void StartNextPattern()
        {
            if (_isVulnerable) return; // Stop patterns if phase 2
            if (phase1Patterns == null || phase1Patterns.Count == 0) return;

            // Pick pattern
            ArchitectPatternSO pattern = phase1Patterns[_currentPatternIndex];

            // Increment index loop
            _currentPatternIndex = (_currentPatternIndex + 1) % phase1Patterns.Count;

            // Change State (Creates a new state instance for the specific pattern)
            _fsm.ChangeState(new ArchitectState_Pattern(this, pattern));
        }

        /// <summary>
        /// Called by the State when it finishes its duration.
        /// </summary>
        public void OnPatternFinished()
        {
            if (_isVulnerable) return;
            // Switch to Idle immediately to cleanup the old pattern state
            _fsm.ChangeState(StateIdle);

            // Start the delay timer
            StartCoroutine(WaitAndNextPattern());
        }

        private IEnumerator WaitAndNextPattern()
        {
            // Reset to neutral rotation speed or idle behavior?
            // _currentRotationSpeed = rotationSpeedCombat; 

            yield return new WaitForSeconds(patternInterval);
            StartNextPattern();
        }

        // --- HELPER METHODS FOR STATES ---

        public void SetRotationSpeed(float speed)
        {
            _currentRotationSpeed = speed;
        }

        // 1. Move Hands (Inner vs Outer)
        public void MoveHands(bool[] extendConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;

                // Check config, default to Inner (false) if array is short
                bool extend = (extendConfig != null && i < extendConfig.Length) ? extendConfig[i] : false;
                
                float targetDist = extend ? radiusOuter : radiusInner;
                hands[i].MoveToDistance(targetDist);
            }
        }

        // 2. Telegraph Walls (Rotate)
        public void TelegraphWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].PrepareWall(active);
            }
        }

        // 3. Activate Walls (Laser On)
        public void ActivateWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].SetWall(active);
            }
        }

        // 4. Reset All (Cleanup)
        public void ResetHands()
        {
            foreach (var h in hands)
            {
                if (h == null) continue;
                h.MoveToDistance(radiusInner); // Retract
                h.SetWall(false);              // Off
                h.PrepareWall(false);          // Rotate Flat
            }
        }

        public Transform GetTarget()
        {
            if (_player == null)
            {
                // Re-acquire if lost via Service Locator
                if (GameServices.Player != null) _player = GameServices.Player.transform;
            }
            return _player;
        }

        // --- PHASE LOGIC ---

        private IEnumerator EnterVulnerablePhase()
        {
            _isVulnerable = true;
            SetShield(false);

            // Stop FSM patterns
            _fsm.ChangeState(null); // Or switch to a VulnerableState if you want complex logic

            _currentRotationSpeed = 60f; // Panic Spin

            GameEvents.OnPopupText?.Invoke(transform.position, "SHIELD DOWN");

            yield return null;
        }

        private void SetShield(bool state)
        {
            if (shieldVisual) shieldVisual.SetActive(state);
        }

        // --- IDAMAGEABLE (THE CORE) ---

        public bool TakeDamage(DamageInfo info)
        {
            if (!_isVulnerable)
            {
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
                return false;
            }

            coreHealth -= info.damageAmount;

            // Show Damage Numbers
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, true); // true = Critical visual

            if (coreHealth <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            _isCombatActive = false;
            _currentRotationSpeed = 0;

            // Spawn BIG explosion
            if (VFXManager.Instance && VFXManager.Instance.explosionPrefab)
            {
                // Spawn a few explosions for effect
                PoolManager.Instance.Spawn(VFXManager.Instance.explosionPrefab, transform.position, Quaternion.identity);
            }

            // Win Game
            GameEvents.OnGameVictory?.Invoke();

            Destroy(gameObject, 0.5f);
        }

        // --- ICOMBATTARGET (EXECUTION) ---

        public bool IsStaggered => false; // Boss Core doesn't stagger via normal means

        public void OnExecutionHit()
        {
            if (_isVulnerable)
            {
                DamageInfo info = new DamageInfo { damageAmount = 50f };
                TakeDamage(info);
            }
            else
            {
                // Optional: Push player back if they try to teleport to shield
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Bosses\Architect\ArchitectHand.cs`
- Lines: 132
- Size: 4.2 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Environment; // Access to Prop_Explosive
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    // dependency on the new Prop system
    [RequireComponent(typeof(Prop_Explosive))]
    public class ArchitectHand : MonoBehaviour
    {
        [Header("Visual Components")]
        public Transform visualRoot;    // The object that slides In/Out
        public Transform meshPivot;     // The object that rotates 90 degrees (Telegraph)
        public GameObject wallObject;   // The Laser Hazard (Child)
        public Transform firePoint;     // Where bullets spawn

        [Header("Combat")]
        public GameObject projectilePrefab;
        public float slideDuration = 1.0f;
        public float rotateDuration = 0.5f;

        private Prop_Explosive _prop;
        private bool _isDead = false;

        private void Awake()
        {
            _prop = GetComponent<Prop_Explosive>();

            // Ensure wall is off by default
            if (wallObject) wallObject.SetActive(false);
        }

        private void Update()
        {
            // Check if the Prop took enough damage to "Die"
            // Note: Prop_Explosive handles the explosion VFX internally via its own Die() method,
            // but we need to handle the visual shutdown of the hand here.
            if (!_isDead && _prop.health <= 0)
            {
                Die();
            }
        }

        public bool IsAlive() => !_isDead;

        // --- MOVEMENT ---

        public void MoveToDistance(float localZ)
        {
            if (_isDead) return;
            // Slide along local Z axis relative to the Pivot Parent
            visualRoot.DOLocalMoveZ(localZ, slideDuration).SetEase(Ease.InOutQuad);
        }

        // --- COMBAT ACTIONS ---

        /// <summary>
        /// Telegraphs the wall attack by rotating the hand 90 degrees.
        /// </summary>
        public void PrepareWall(bool willBeActive)
        {
            if (_isDead || meshPivot == null) return;

            // Rotate 90 on Z for Vertical (Wall Mode), 0 for Flat (Gun Mode)
            float targetZ = willBeActive ? 90f : 0f;

            meshPivot.DOLocalRotate(new Vector3(0, 0, targetZ), rotateDuration)
                .SetEase(Ease.OutBack);
        }

        public void SetWall(bool active)
        {
            if (_isDead) active = false;
            if (wallObject) wallObject.SetActive(active);
        }

        public void Shoot(Vector3 targetPos, bool useForward, float scale)
        {
            if (_isDead || !projectilePrefab) return;

            Vector3 dir;
            if (useForward)
            {
                dir = firePoint.forward; // Spiral / Radial aim
            }
            else
            {
                dir = (targetPos - firePoint.position).normalized; // Tracking aim
            }

            // Spawn from Pool
            GameObject p = PoolManager.Instance.Spawn(projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
            p.transform.localScale = Vector3.one * scale;

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = 15f;
                // Ignore the hand itself to prevent instant self-collision
                proj.SetSource(gameObject);
                proj.Initialize(dir);
            }
        }

        // --- STATE MANAGEMENT ---

        private void Die()
        {
            _isDead = true;
            SetWall(false);

            // Visual Shutdown
            if (meshPivot) meshPivot.DOKill();
            visualRoot.DOKill();
            visualRoot.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        public void Revive()
        {
            _isDead = false;
            _prop.OnSpawn(); // Reset Health in the prop component

            // Hard reset visuals
            gameObject.SetActive(true);
            visualRoot.localScale = Vector3.one;
            if (meshPivot) meshPivot.localRotation = Quaternion.identity;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyBaseAI.cs`
- Lines: 111
- Size: 3.5 KB
- Modified: 2025-12-31 09:17

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
            // OLD:
            // GameObject p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            // if (p) { _player = p.transform; ... }

            // NEW: Use the Service Locator
            if (GameServices.Player != null)
            {
                _player = GameServices.Player.transform;
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
- Lines: 220
- Size: 7.3 KB
- Modified: 2026-01-01 11:15

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DarkTowerTron.Combat;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(DamageReceiver))]
    public class EnemyController : MonoBehaviour, IPoolable, ICombatTarget
    {
        private DamageReceiver _receiver;
        private EnemyMotor _motor;
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public ColorPaletteSO palette;
        [Header("Audio")]
        public AudioClip staggerClip;

        // Visual State
        private Color _normalColor;
        private Color _staggerColor;
        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween; 
        private int _colorPropID;
        private int _emissionPropID;

        // Facade Property
        public bool IsStaggered => _receiver != null && _receiver.IsStaggered;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _receiver = GetComponent<DamageReceiver>(); 
            
            if(meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            
            _propBlock = new MaterialPropertyBlock();
            _colorPropID = Shader.PropertyToID("_BaseColor"); 
            _emissionPropID = Shader.PropertyToID("_EmissionColor");

            LoadColors();
        }

        private void Start()
        {
            // 1. Get stats reference from Motor (if not already set)
            if (_motor != null) _stats = _motor.stats;
			
            // 2. SELF-INITIALIZATION (The Fix)
            // If we were placed in the scene manually, OnSpawn() was never called.
            // We check if the Receiver has 0 Health (uninitialized) to decide.
            // Or simpler: Just initialize. It's safe to call twice (it just resets HP to max).
            if (_receiver != null && _stats != null)
            {
                // DamageReceiver.CurrentHealth defaults to 0 before initialization.
                if (_receiver.CurrentHealth <= 0)
                {
                    _receiver.Initialize(_stats);
                }
            }
			
            // 3. Visuals
            LoadColors();
            SetColor(_normalColor);
        }

        private void OnEnable()
        {
            if (_receiver == null) _receiver = GetComponent<DamageReceiver>();

            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;
            
            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover += HandleStaggerExit;
            }
        }
        
        private void OnDisable()
        {
            if (_receiver != null)
            {
                _receiver.OnHitProcessed -= HandleHit;
                _receiver.OnDeathProcessed -= HandleDeath;
                if (_receiver.Stagger != null)
                {
                    _receiver.Stagger.OnStaggerBreak -= HandleStaggerEnter;
                    _receiver.Stagger.OnStaggerRecover -= HandleStaggerExit;
                }
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            
            // Initialize the Receiver (which inits Vitality/Stagger)
            _receiver.Initialize(_stats);
            
            LoadColors();
            SetColor(_normalColor);
        }

        public void OnDespawn()
        {
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_normalColor);
        }

        // --- IDamageable Proxy ---
        public bool TakeDamage(DamageInfo info)
        {
            // FIX: DamageReceiver implements IDamageable, so the method is TakeDamage, not ApplyDamage
            return _receiver.TakeDamage(info);
        }

        public void Kill(bool instant) => _receiver.Kill(true); 
        public void SelfDestruct() => _receiver.Kill(false);    

        // --- ICombatTarget ---
        public void OnExecutionHit()
        {
            _receiver.Kill(true); 
        }
        
        // Proxy property
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
        
        // FIX: Removed 'public Transform transform => base.transform' to fix warning CS0108.
        // MonoBehaviour already satisfies this interface requirement.

        // --- HANDLERS ---
        
        private void HandleHit(DamageInfo info)
        {
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);
            if (!IsStaggered) Flash();
            
            bool isCrit = IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isCrit);
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position, stats, reward);
            
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }

        private void HandleStaggerEnter()
        {
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (AudioManager.Instance && staggerClip)
                AudioManager.Instance.PlaySound(staggerClip, 1f, true);

            if (_flashTween != null) _flashTween.Kill();
            
            float flashLerp = 0f;
            _flashTween = DOTween.To(()=> flashLerp, x=> flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() => {
                    Color c = Color.Lerp(_staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });
        }

        private void HandleStaggerExit()
        {
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_normalColor);
        }

        private void Flash()
        {
            if (_flashTween != null) _flashTween.Kill();
            SetColor(Color.white);
            _flashTween = DOVirtual.DelayedCall(0.1f, () => SetColor(_normalColor)).SetId(gameObject);
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                _propBlock.SetColor(_emissionPropID, c);
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }
        
        private void LoadColors()
        {
            _normalColor = Color.red;
            _staggerColor = Color.yellow;

            if (palette != null)
            {
                // FIX: Access flattened properties directly
                // (We previously removed the nested 'defaultEnemyTheme' object)
                if (palette.enemyPrimary.mainColor != Color.clear)
                {
                     _normalColor = palette.enemyPrimary.mainColor;
                }
                
                _staggerColor = palette.staggerColor; 
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyMotors.cs`
- Lines: 172
- Size: 5.7 KB
- Modified: 2025-12-31 09:17

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
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // REMOVED: The code that snapped transform.position.y = 0
            // logic: We trust the Spawner to put us where we need to be.
            // If rideHeight > 0, the Update loop will naturally float us up/down to that height.
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
            // (Removed y=0 snap. Spawner is responsible for initial Y. If rideHeight > 0, Update loop will float us.)
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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Enemy\States\Bosses\Architect\ArchitectState_Idle.cs`
- Lines: 10
- Size: 0.3 KB
- Modified: 2025-12-31 09:17

```csharp
using DarkTowerTron.AI.FSM;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    public class ArchitectState_Idle : State
    {
        // Does nothing. Just sits there while the Controller handles the timer.
        // The BossController.Update() handles the rotation, so we don't need logic here.
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Bosses\Architect\ArchitectState_Pattern.cs`
- Lines: 153
- Size: 5.4 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic; // FIX: Added for List<>
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    public class ArchitectState_Pattern : State
    {
        // FIX: Reference the Boss Controller, NOT the Guardian Agent
        private ArchitectController _boss;

        private ArchitectPatternSO _currentPattern;
        private float _patternTimer;

        public ArchitectState_Pattern(ArchitectController boss, ArchitectPatternSO pattern)
        {
            _boss = boss;
            _currentPattern = pattern;
        }

        public override void Enter()
        {
            // 1. Apply Rotation
            _boss.SetRotationSpeed(_currentPattern.rotationSpeed);

            // 2. Timer
            _patternTimer = _currentPattern.activeDuration;

            _boss.StartCoroutine(RunPatternSequence());
        }

        // Helper to handle array safety
        private bool GetHandExtend(bool outer)
        {
            // Simple logic: if any in array are true, extend? 
            // Or better: The Controller's SetHandsState iterates the hands and checks the array index.
            // But ArchitectController.SetHandsState currently takes a simple BOOL.
            // Let's stick to simple: If pattern says extend, we extend all.
            // If you want per-hand logic, we need to update Controller.
            // For now: Just check the first element as a master switch
            if (_currentPattern.extendHands != null && _currentPattern.extendHands.Length > 0)
                return _currentPattern.extendHands[0];
            return false;
        }

        private bool GetWallStatus(bool active)
        {
            if (_currentPattern.activateWalls != null && _currentPattern.activateWalls.Length > 0)
                return _currentPattern.activateWalls[0];
            return false;
        }

        public override void LogicUpdate()
        {
            // Boss Core doesn't stagger, so we don't check for it here.

            // Handle Pattern Timer
            _patternTimer -= Time.deltaTime;
            if (_patternTimer <= 0)
            {
                // In a real FSM, we would define what "Next" is.
                // For now, we rely on the Coroutine to transition us back to Idle/Move
            }
        }

        private IEnumerator RunPatternSequence()
        {
            // --- 1. SETUP & TELEGRAPH ---
            bool[] extendConfig = _currentPattern.extendHands;
            bool[] wallConfig = _currentPattern.activateWalls;

            _boss.MoveHands(extendConfig);
            _boss.TelegraphWalls(wallConfig);

            // Wait for Telegraph
            yield return new WaitForSeconds(_currentPattern.startDelay);
            
            // --- 2. ACTIVATE HAZARDS ---
            _boss.ActivateWalls(wallConfig);

            // --- 3. ACTIVE PHASE (Loop for Duration) ---
            float phaseDuration = _currentPattern.activeDuration - _currentPattern.startDelay;
            float timer = 0f;
            
            // vars for shooting
            float shotCooldown = 0f;
            bool hasGun = _currentPattern.shootingPattern != null;

            while (timer < phaseDuration)
            {
                if (_boss.IsStaggered) break; ; // Optional break on stagger

                float dt = Time.deltaTime;
                timer += dt;

                // SHOOTING LOGIC (Running inside the main timer loop)
                if (hasGun)
                {
                    shotCooldown -= dt;
                    if (shotCooldown <= 0)
                    {
                        FireProjectilesFromHands();
                        shotCooldown = _currentPattern.shootingPattern.delayBetweenShots;
                    }
                }

                yield return null;
            }

            // --- 4. CLEANUP ---
            _boss.ResetHands(); // Retracts and turns off walls
            
            yield return new WaitForSeconds(1.0f); // Retract animation buffer

            _boss.OnPatternFinished();
        }

        private void FireProjectilesFromHands()
        {
            // Safety check for shooting pattern
            if (_currentPattern.shootingPattern == null) return;

            AttackPatternSO attackData = _currentPattern.shootingPattern;
            bool useForward = attackData.aimMode == AimType.ForwardRadial;
            float scale = attackData.scaleMultiplier;

            // FIX: Use FOR loop to check index against the Config Arrays
            for (int i = 0; i < _boss.hands.Count; i++)
            {
                var hand = _boss.hands[i];
                if (hand == null) continue;

                // CHECK CONFIG: Does this specific hand have permission to shoot?
                bool canShoot = false;
                if (_currentPattern.activeGuns != null && i < _currentPattern.activeGuns.Length)
                {
                    canShoot = _currentPattern.activeGuns[i];
                }

                if (canShoot)
                {
                    Vector3 targetPos = Vector3.zero;
                    if (_boss.GetTarget() != null) targetPos = _boss.GetTarget().position;

                    hand.Shoot(targetPos, useForward, scale);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Chaser\ChaserState_Chase.cs`
- Lines: 52
- Size: 1.5 KB
- Modified: 2025-12-31 09:17

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

            // 2. Transition (Distance Check)
            // FIX: Flatten positions to ignore height (Y-Axis)
            Vector3 myPos = _agent.transform.position;
            myPos.y = 0;

            Vector3 targetPos = _agent.GetTarget().position;
            targetPos.y = 0;

            float dist = Vector3.Distance(myPos, targetPos);

            // Debug to verify
            // Debug.Log($"Chaser Distance: {dist} / Range: {_agent.attackRange}");

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
- Modified: 2025-12-31 09:17

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
- Lines: 63
- Size: 2.0 KB
- Modified: 2025-12-31 17:13

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Core.Data;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;
using DarkTowerTron.Core;

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
                GameLogger.LogWarning(LogChannel.AI, "Guardian has no Attack Patterns assigned!", _agent.gameObject);
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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
- Lines: 77
- Size: 2.6 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class ArenaGate : MonoBehaviour
    {
        [Header("Parts")]
        public Transform laserWall;    // The Pivot (Scales up/down)
        public Renderer baseRenderer;  // The Floor Strip
        public Renderer wallRenderer;  // NEW: The Actual Wall Mesh (Child)
        public Collider wallCollider;  // The Physics Block

        [Header("Settings")]
        public float animDuration = 0.5f;
        public Vector3 closedScale = new Vector3(1, 1, 1);

        [Header("Colors")]
        public Color lockedColor = Color.red;
        public Color openColor = Color.green;

        private void Start()
        {
            // Initial State: Open
            SetGate(false, true);

            GameEvents.OnRoomCleared += () => SetGate(false);
        }

        private void OnDestroy()
        {
            GameEvents.OnRoomCleared -= () => SetGate(false);
        }

        public void ForceClose()
        {
            SetGate(true, false);
        }

        private void SetGate(bool isClosed, bool instant = false)
        {
            // 1. Collider
            if (wallCollider) wallCollider.enabled = isClosed;

            // 2. Visuals (Scaling the Pivot)
            if (laserWall)
            {
                Vector3 targetScale = isClosed ? closedScale : new Vector3(closedScale.x, 0f, closedScale.z);

                if (instant) laserWall.localScale = targetScale;
                else laserWall.DOScale(targetScale, animDuration).SetEase(Ease.OutBack);
            }

            // 3. Colors
            Color targetColor = isClosed ? lockedColor : openColor;

            // A. Base Strip (Opaque)
            if (baseRenderer)
            {
                baseRenderer.material.DOColor(targetColor, "_BaseColor", animDuration);
                baseRenderer.material.DOColor(targetColor * 2f, "_EmissionColor", animDuration);
            }

            // B. Laser Wall (Transparent) - NEW LOGIC
            if (wallRenderer)
            {
                // We want the wall to be semi-transparent (Alpha ~ 0.3 or 80/255)
                Color transparentColor = new Color(targetColor.r, targetColor.g, targetColor.b, 0.3f);

                // Use DOTween for smooth color transition
                wallRenderer.material.DOColor(transparentColor, "_BaseColor", animDuration);
                wallRenderer.material.DOColor(targetColor, "_EmissionColor", animDuration);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\CameraZone.cs`
- Lines: 48
- Size: 1.5 KB
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Environment\LevelEndTrigger.cs`
- Lines: 32
- Size: 0.9 KB
- Modified: 2025-12-31 17:14

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Environment
{
    public class LevelEndTrigger : MonoBehaviour
    {
        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                GameLogger.Log(LogChannel.System, "LEVEL COMPLETE", gameObject);

                // Trigger Victory Logic
                GameEvents.OnGameVictory?.Invoke();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 1, 0, 0.3f); // Semi-transparent Green
            Gizmos.DrawCube(transform.position, transform.localScale);
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\LevelModule.cs`
- Lines: 49
- Size: 1.7 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Environment
{
    public class LevelModule : MonoBehaviour
    {
        [Header("Sockets")]
        public Transform entryPoint; // Where the previous room connects (South)
        public Transform exitPoint;  // Where the next room connects (North)

        [Header("Debug")]
        public Color gizmoColor = Color.cyan;
        public Vector3 roomSize = new Vector3(40, 10, 40); // For visualization only

        private void OnDrawGizmos()
        {
            // Draw Bounds
            Gizmos.color = new Color(gizmoColor.r, gizmoColor.g, gizmoColor.b, 0.2f);
            Gizmos.DrawCube(transform.position, roomSize);
            Gizmos.color = gizmoColor;
            Gizmos.DrawWireCube(transform.position, roomSize);

            // Draw Sockets
            if (entryPoint)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(entryPoint.position, 1f);
                Gizmos.DrawLine(entryPoint.position, entryPoint.position + Vector3.up * 5);
            }

            if (exitPoint)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(exitPoint.position, 1f);
                Gizmos.DrawLine(exitPoint.position, exitPoint.position + Vector3.up * 5);
            }
        }

        // Helper to snap this room's entry to a target position
        public void SnapTo(Transform targetExit)
        {
            if (entryPoint == null) return;

            // Calculate offset required to move Entry to Target
            Vector3 offset = targetExit.position - entryPoint.position;
            transform.position += offset;
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\PlayerStart.cs`
- Lines: 26
- Size: 0.8 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Environment
{
    public class PlayerStart : MonoBehaviour
    {
        [Tooltip("Unique ID for this spawn point (e.g., 'Start', 'Arena2', 'Boss')")]
        public string spawnID = "Start";

        [Header("Visuals")]
        public Color gizmoColor = Color.green;

        private void OnDrawGizmos()
        {
            Gizmos.color = gizmoColor;
            // Draw a capsule to represent the player
            Gizmos.DrawWireSphere(transform.position + Vector3.up * 0.5f, 0.5f);
            Gizmos.DrawLine(transform.position, transform.position + transform.forward * 2f);

            // Draw label in Scene View
#if UNITY_EDITOR
            UnityEditor.Handles.Label(transform.position + Vector3.up * 2f, $"Spawn: {spawnID}");
#endif
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\Props\CombatProp.cs`
- Lines: 126
- Size: 3.6 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public abstract class CombatProp : MonoBehaviour, IDamageable, ICombatTarget, IPoolable
    {
        [Header("Base Stats")]
        public float health = 10f;
        public float maxStagger = 1.0f;
        public float staggerDecay = 1.0f;

        [Header("Base Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.cyan;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        // State
        protected float _currentHealth;
        protected float _currentStagger;
        public bool IsStaggered { get; protected set; }

        private Tween _flashTween;

        protected virtual void Awake()
        {
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
        }

        public virtual void OnSpawn()
        {
            _currentHealth = health;
            _currentStagger = 0;
            IsStaggered = false;
            ResetVisuals();
        }

        public virtual void OnDespawn()
        {
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();
        }

        private void Update()
        {
            if (!IsStaggered && _currentStagger > 0)
            {
                _currentStagger -= staggerDecay * Time.deltaTime;
                if (_currentStagger < 0) _currentStagger = 0;
            }
        }

        // --- IDAMAGEABLE ---
        public virtual bool TakeDamage(DamageInfo info)
        {
            Flash();

            if (!IsStaggered)
            {
                _currentStagger += info.staggerAmount;
                if (_currentStagger >= maxStagger) EnterStaggerState();
            }

            // Crit multiplier if staggered
            float finalDmg = IsStaggered ? info.damageAmount * 2f : info.damageAmount;

            _currentHealth -= finalDmg;

            if (finalDmg > 0)
                GameEvents.OnDamageDealt?.Invoke(transform.position, finalDmg, IsStaggered);

            if (_currentHealth <= 0)
            {
                Die();
            }

            return true;
        }

        public void Kill(bool instant) => Die();

        // --- ABSTRACT METHODS ---
        protected abstract void Die();
        public abstract void OnExecutionHit();

        // --- HELPERS ---
        protected void EnterStaggerState()
        {
            IsStaggered = true;
            GameEvents.OnPopupText?.Invoke(transform.position, "READY");

            if (meshRenderer)
                meshRenderer.material.DOColor(staggerColor, 0.2f);

            DOVirtual.DelayedCall(2.0f, () =>
            {
                IsStaggered = false;
                _currentStagger = 0;
                ResetVisuals();
            }).SetId(gameObject);
        }

        protected void Flash()
        {
            if (!IsStaggered && meshRenderer)
            {
                if (_flashTween != null) _flashTween.Kill();
                meshRenderer.material.DOColor(flashColor, 0.1f)
                    .OnComplete(() => ResetVisuals());
            }
        }

        protected void ResetVisuals()
        {
            if (meshRenderer) meshRenderer.material.color = IsStaggered ? staggerColor : normalColor;
        }

        // --- ICOMBATTARGET ---
        // 'transform' property is inherited from MonoBehaviour, so we don't define it here.

        public virtual bool KeepPlayerGrounded => true;
    }
}
```

## 📄 `Assets\Scripts\Environment\Props\Prop_Anchor.cs`
- Lines: 75
- Size: 2.2 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class Prop_Anchor : CombatProp
    {
        [Header("Anchor Settings")]
        public float respawnTime = 3.0f;
        public bool keepPlayerInAir = true; // True for traversal

        private Collider _col;

        protected override void Awake()
        {
            base.Awake();
            _col = GetComponent<Collider>();
        }

        // Override: Anchors don't die from damage
        public override bool TakeDamage(DamageInfo info)
        {
            // Only take stagger, ignore health damage
            if (!IsStaggered)
            {
                // We barely invoke base just for the Flash/Stagger logic
                // We hack the info to deal 0 health damage
                info.damageAmount = 0;
                base.TakeDamage(info);
            }
            return true;
        }

        protected override void Die() 
        {
            // Impossible state, but handle gracefully
            StartCoroutine(RespawnRoutine());
        }

        public override void OnExecutionHit()
        {
            // When player teleports here:
            // 1. Visual Bounce
            transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            
            // 2. Hide (Respawn)
            StartCoroutine(RespawnRoutine());
        }

        private IEnumerator RespawnRoutine()
        {
            // Hide
            if (meshRenderer) meshRenderer.enabled = false;
            if (_col) _col.enabled = false;
            
            // Reset internal state
            OnSpawn(); 

            yield return new WaitForSeconds(respawnTime);

            // Show
            if (meshRenderer) meshRenderer.enabled = true;
            if (_col) _col.enabled = true;
            
            // Juice
            transform.localScale = Vector3.zero;
            transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
        }

        // ICombatTarget Override
        public override bool KeepPlayerGrounded => !keepPlayerInAir;
    }
}
```

## 📄 `Assets\Scripts\Environment\Props\Prop_Explosive.cs`
- Lines: 48
- Size: 1.4 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Environment
{
    public class Prop_Explosive : CombatProp
    {
        [Header("Explosive Settings")]
        public GameObject spawnOnDeath; // Hazard Zone
        public bool volatileOnStagger = true; // Stagger damage hurts HP

        public override bool TakeDamage(DamageInfo info)
        {
            // Override to allow Stagger damage to hurt Health (Volatile)
            if (volatileOnStagger)
            {
                // Add stagger amount to damage
                info.damageAmount += info.staggerAmount;
            }
            return base.TakeDamage(info);
        }

        public override void OnExecutionHit()
        {
            // Execution = Instant Explosion
            Die();
        }

        protected override void Die()
        {
            // 1. Spawn Hazard
            if (spawnOnDeath)
            {
                PoolManager.Instance.Spawn(spawnOnDeath, transform.position, Quaternion.identity);
            }

            // 2. VFX
            if (VFXManager.Instance)
            {
                PoolManager.Instance.Spawn(VFXManager.Instance.explosionPrefab, transform.position, Quaternion.identity);
            }

            // 3. Despawn Self
            PoolManager.Instance.Despawn(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\TileInfo.cs`
- Lines: 48
- Size: 1.5 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Environment
{
    [ExecuteAlways]
    public class TileInfo : MonoBehaviour
    {
        public float tileSize = 4f;
        public Color labelColor = Color.cyan;
        public bool showCoordinates = true;

        private void OnDrawGizmos()
        {
            if (!showCoordinates) return;

            // Draw the outline of the tile
            Gizmos.color = new Color(labelColor.r, labelColor.g, labelColor.b, 0.3f);
            Gizmos.DrawWireCube(transform.position, new Vector3(tileSize, 0.1f, tileSize));

#if UNITY_EDITOR
            // Calculate "Local Grid" coordinates relative to parent (The Room Module)
            // If no parent, use World Space
            Vector3 pos = transform.position;
            if (transform.parent != null)
            {
                pos = transform.localPosition;
            }

            // Round to nearest logical index
            int x = Mathf.RoundToInt(pos.x / tileSize);
            int z = Mathf.RoundToInt(pos.z / tileSize);

            string label = $"{x}, {z}";
            
            // Draw text in Scene View
            GUIStyle style = new GUIStyle();
            style.normal.textColor = labelColor;
            style.fontSize = 15;
            style.alignment = TextAnchor.MiddleCenter;
            
            Handles.Label(transform.position + Vector3.up * 0.5f, label, style);
#endif
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\WaveTrigger.cs`
- Lines: 70
- Size: 2.0 KB
- Modified: 2025-12-31 17:13

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Managers;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core; // <--- THIS WAS MISSING

namespace DarkTowerTron.Environment
{
    public class WaveTrigger : MonoBehaviour
    {
        [Header("Configuration")]
        public List<WaveDefinitionSO> wavesForThisRoom;
        public Transform[] spawnPointsForThisRoom;

        [Header("Arena Gates")]
        public ArenaGate[] gatesToClose;

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                StartRoomEncounter();
            }
        }

        private void StartRoomEncounter()
        {
            // USE SERVICE LOCATOR
            var director = GameServices.WaveDirector;

            // Logic: ArenaSpawner is attached to the same object as WaveDirector
            var spawner = director != null ? director.GetComponent<ArenaSpawner>() : null;

            if (director && spawner)
            {
                // 1. Hand off Spawn Points
                if (spawnPointsForThisRoom != null && spawnPointsForThisRoom.Length > 0)
                {
                    spawner.spawnPoints = spawnPointsForThisRoom;
                }

                // 2. Load Waves & Start
                director.waves = wavesForThisRoom;
                director.StartGame();

                // 3. Lock Gates
                ForceCloseGates();
            }
            else
            {
                GameLogger.LogError(LogChannel.System, "WaveTrigger: Could not find WaveDirector via GameServices!", gameObject);
            }

            gameObject.SetActive(false);
        }

        public void ForceCloseGates()
        {
            foreach (var gate in gatesToClose)
            {
                if (gate != null) gate.ForceClose();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\ArenaSpawner.cs`
- Lines: 77
- Size: 3.2 KB
- Modified: 2025-12-31 17:12

```csharp
using UnityEngine;
using DarkTowerTron.Managers; // For PoolManager
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        [Header("Debug")]
        public bool showDebugRays = true;
        public float debugLineDuration = 20f; // Long time to analyze in Scene view

        public GameObject SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            if (spawnPoints == null || spawnPoints.Length == 0 || prefab == null) return null;

            // 1. Pick Point
            Transform sp;
            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length) sp = spawnPoints[forcedIndex];
            else sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // 2. Randomize Offset
            Vector2 randomCircle = Random.insideUnitCircle * 2.0f;
            Vector3 attemptPos = sp.position + new Vector3(randomCircle.x, 0, randomCircle.y);

            // 3. Find Floor
            Vector3 spawnPos;
            int mask = LayerMask.GetMask("Ground", "Default", "Wall");
            Vector3 rayOrigin = attemptPos + Vector3.up * 50f;

            if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 100f, mask))
            {
                spawnPos = hit.point;

                // Call dedicated Debugger
                if (showDebugRays) VisualizeSpawn(rayOrigin, hit, true);
            }
            else
            {
                // Fallback (Air Drop)
                spawnPos = attemptPos + Vector3.up * 2.0f;

                // Call dedicated Debugger
                if (showDebugRays) VisualizeSpawn(rayOrigin, new RaycastHit(), false);
            }

            return PoolManager.Instance.Spawn(prefab, spawnPos, Quaternion.LookRotation(sp.forward));
        }

        // --- NEW DEBUG METHOD ---
        private void VisualizeSpawn(Vector3 origin, RaycastHit hit, bool success)
        {
            if (success)
            {
                // Draw Green Line to exact hit point
                Debug.DrawLine(origin, hit.point, Color.green, debugLineDuration);

                // Draw a small Cross at the hit point so you can see exactly where it landed
                Debug.DrawRay(hit.point, Vector3.up * 0.5f, Color.green, debugLineDuration);
                Debug.DrawRay(hit.point, Vector3.right * 0.5f, Color.green, debugLineDuration);

                // Log details
                string layerName = LayerMask.LayerToName(hit.collider.gameObject.layer);
                GameLogger.Log(LogChannel.System, $"<color=green>[SPAWN HIT]</color> Object: <b>{hit.collider.name}</b> | Layer: <b>{layerName}</b> | Height Y: <b>{hit.point.y:F2}</b>", hit.collider.gameObject);
            }
            else
            {
                // Draw Red Line all the way down
                Debug.DrawRay(origin, Vector3.down * 100f, Color.red, debugLineDuration);
                GameLogger.LogError(LogChannel.System, $"<color=red>[SPAWN MISS]</color> Raycast from {origin} hit NOTHING! Enemy air-dropped.", gameObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\AudioManager.cs`
- Lines: 40
- Size: 1.3 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Core.Data; // Access SoundDef

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;
        [SerializeField] private AudioSource _sfxSource;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        // --- NEW METHOD ---
        public void PlaySound(SoundDef soundDef)
        {
            if (soundDef == null || _sfxSource == null) return;

            AudioClip clip = soundDef.GetClip();
            if (clip == null) return;

            _sfxSource.pitch = soundDef.GetPitch();
            _sfxSource.PlayOneShot(clip, soundDef.volume);
        }

        // Keep legacy method for compatibility until migration is complete
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (clip == null || _sfxSource == null) return;
            _sfxSource.pitch = randomizePitch ? Random.Range(0.9f, 1.1f) : 1f;
            _sfxSource.PlayOneShot(clip, volume);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\DamageTextManager.cs`
- Lines: 65
- Size: 2.2 KB
- Modified: 2025-12-31 09:17

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
- Lines: 115
- Size: 4.0 KB
- Modified: 2026-01-01 12:31

```csharp
using UnityEngine;
using System.Collections; // Required for IEnumerator
using DarkTowerTron.Core;
using DarkTowerTron.Player;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Workflow")]
        public bool autoStartGame = false; // Check this to skip Main Menu

        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

		[Header("Visualization")]
		public bool showEnemyStats = true; // Toggle this in Inspector

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn;

        [Header("Perk Testing")]
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;

        // Changed void to IEnumerator to allow waiting
        private IEnumerator Start()
        {
            // Wait one frame so core systems (GameSession, GameServices) can boot
            yield return null; 

            // 1. Auto-Start Logic
            if (autoStartGame)
            {
                var session = FindObjectOfType<GameSession>();
                if (session)
                {
                    Debug.Log("<color=yellow>[DEBUG] Auto-Starting Game...</color>");
                    session.BeginGame();

                    // Force combat state so focus decay and combat systems are active while testing
                    GameEvents.OnWaveCombatStarted?.Invoke();
                }
            }

            // 2. Locate player via GameServices
            if (GameServices.Player != null)
            {
                _energy = GameServices.Player.GetComponent<PlayerEnergy>();
                _health = GameServices.Player.GetComponent<PlayerHealth>();
                _loadout = GameServices.Player.GetComponent<PlayerLoadout>();
            }
        }

        private void Update()
        {
            // Sync the static flag for enemy debug gizmos
            DarkTowerTron.Combat.DamageReceiver.EnableDebugGizmos = showEnemyStats;

            // Keyboard Shortcut (e.g. Tab) to toggle
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                showEnemyStats = !showEnemyStats;
            }

            // 1. Time Control
            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f;
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
            if (Input.GetKeyDown(KeyCode.Keypad1)) Spawn(0);
            if (Input.GetKeyDown(KeyCode.Keypad2)) Spawn(1);
            if (Input.GetKeyDown(KeyCode.Keypad3)) Spawn(2);
            if (Input.GetKeyDown(KeyCode.Keypad4)) Spawn(3);

            // 5. Cheats Application
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);

            // 6. Perk Toggles
            if (Input.GetKeyDown(KeyCode.H) && _loadout) _loadout.EquipProjectile(homingPrefab);
            if (Input.GetKeyDown(KeyCode.J) && _loadout) _loadout.EquipDecoy(explosiveDecoyPrefab);
        }

        private void Spawn(int index)
        {
            if (index < 0 || index >= enemiesToSpawn.Length) return;
            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0;
            PoolManager.Instance.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\FeedbackDirector.cs`
- Lines: 78
- Size: 2.5 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Visuals; // <--- THIS WAS MISSING

namespace DarkTowerTron.Managers
{
    public class FeedbackDirector : MonoBehaviour
    {
        [Header("Profiles")]
        public FeedbackProfileSO hitProfile;
        public FeedbackProfileSO killProfile;
        public FeedbackProfileSO playerHurtProfile;

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
            ApplyProfile(playerHurtProfile);
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            ApplyProfile(killProfile);
        }

        // --- HELPER ---
        private void ApplyProfile(FeedbackProfileSO profile)
        {
            if (profile == null) return;

            // 1. Audio
            if (profile.sound && Managers.AudioManager.Instance)
                Managers.AudioManager.Instance.PlaySound(profile.sound);

            // 2. Camera
            if (Visuals.CameraShaker.Instance)
                Visuals.CameraShaker.Instance.Shake(profile.shakeDuration, profile.shakeStrength);

            // 3. Time
            if (Core.GameTime.Instance && profile.hitStopDuration > 0)
                Core.GameTime.Instance.HitStop(profile.hitStopDuration);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\GameFeel.cs`
- Lines: 98
- Size: 3.0 KB
- Modified: 2025-12-31 09:17

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
- Lines: 172
- Size: 5.1 KB
- Modified: 2025-12-31 17:13

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Player;

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("Manager References")]
        public UIManager uiManager;

        [Header("Debug")]
        public string activeSpawnID = "Start";

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
            Time.timeScale = 0f;

            // Use UIManager
            if (uiManager) uiManager.ShowStartMenu();

            // Locate Player via Service
            MovePlayerToStart();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);

            GameEvents.OnPlayerDied += TriggerGameOver;
            GameEvents.OnGameVictory += TriggerVictory;
        }

        private void OnDestroy()
        {
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;
            GameEvents.Cleanup();
        }

        // --- PUBLIC UI FUNCTIONS ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;
            Time.timeScale = 1f;

            if (uiManager) uiManager.ShowHUD();

            if (GameServices.Player)
            {
                GameServices.Player.ToggleInput(true);

                // Refresh UI
                var health = GameServices.Player.GetComponent<PlayerHealth>();
                if (health) health.ForceUpdateUI();
            }

            if (GameServices.WaveDirector) GameServices.WaveDirector.StartGame();
        }

        public void TogglePause()
        {
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0f;
                if (uiManager) uiManager.ShowPause();
                if (GameServices.Player) GameServices.Player.ToggleInput(false);
            }
            else
            {
                Time.timeScale = 1f;
                if (uiManager) uiManager.ShowHUD();
                if (GameServices.Player) GameServices.Player.ToggleInput(true);
            }
        }

        public void OpenTutorial()
        {
            if (uiManager) uiManager.ShowTutorial();
        }

        public void BackToMenu()
        {
            if (uiManager) uiManager.ShowStartMenu();
        }

        public void RestartGame()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void QuitGame()
        {
            GameLogger.Log(LogChannel.System, "EXITING...", gameObject);
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        // --- INTERNAL ---

        private void TriggerGameOver()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.2f;
            if (uiManager) uiManager.ShowGameOver();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.5f;
            if (uiManager) uiManager.ShowVictory();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);
        }

        private void MovePlayerToStart()
        {
            if (GameServices.Player == null) return;
            var playerTransform = GameServices.Player.transform;

            var points = FindObjectsOfType<DarkTowerTron.Environment.PlayerStart>();
            Transform targetPoint = null;

            foreach (var p in points)
            {
                if (p.spawnID == activeSpawnID) { targetPoint = p.transform; break; }
            }

            if (targetPoint == null && activeSpawnID != "Start")
            {
                foreach (var p in points) if (p.spawnID == "Start") { targetPoint = p.transform; break; }
            }

            if (targetPoint != null)
            {
                var motor = GameServices.Player.GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor)
                {
                    motor.Teleport(targetPoint.position);
                    playerTransform.rotation = targetPoint.rotation;
                }
                else
                {
                    playerTransform.position = targetPoint.position;
                    playerTransform.rotation = targetPoint.rotation;
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\HUDManager.cs`
- Lines: 156
- Size: 5.3 KB
- Modified: 2026-01-01 19:24

```csharp
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro; // TextMeshPro
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Focus (Energy)")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color fullFocusColor = new Color(1f, 0f, 1f); // Purple/Pink for Overdrive

        [Header("Grit (Health)")]
        public Transform gritContainer; // Assign a HorizontalLayoutGroup object here
        public GameObject pipPrefab;    // Prefab with just an Image component
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f); // Faded

        [Header("Hull (Shield)")]
        public Image hullIcon;
        public Color hullActiveColor = Color.cyan;
        public Color hullBrokenColor = new Color(1, 0, 0, 0.3f);

        [Header("Score & System")]
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI multiplierText;
        public TextMeshProUGUI timerText;

        // Internal State
        private List<Image> _spawnedPips = new List<Image>();

        private void OnEnable()
        {
            GameEvents.OnFocusChanged += UpdateFocus;
            GameEvents.OnGritChanged += UpdateGrit;
            GameEvents.OnHullStateChanged += UpdateHull;
            GameEvents.OnScoreChanged += UpdateScoreUI;
        }

        private void OnDisable()
        {
            GameEvents.OnFocusChanged -= UpdateFocus;
            GameEvents.OnGritChanged -= UpdateGrit;
            GameEvents.OnHullStateChanged -= UpdateHull;
            GameEvents.OnScoreChanged -= UpdateScoreUI;
        }

        private void Update()
        {
            // Update Timer every frame directly from Manager (no event needed)
            if (timerText && ScoreManager.Instance)
            {
                float t = ScoreManager.Instance.GameTime;
                string minutes = Mathf.Floor(t / 60).ToString("00");
                string seconds = (t % 60).ToString("00");
                timerText.text = $"{minutes}:{seconds}";
            }
        }

        // --- EVENT HANDLERS ---

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider)
            {
                // Ensure slider is 0-1
                focusSlider.value = current / max;
            }

            if (focusFillImage)
            {
                // Visual feedback for Overdrive (Full Bar)
                bool isFull = current >= (max * 0.8f); // 80% threshold
                focusFillImage.color = isFull ? fullFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit, int maxGrit)
        {

            // 1. Check if we need to rebuild the layout
            // (Happens on Start or if Max HP changes via Upgrade)
            if (_spawnedPips.Count != maxGrit)
            {
                RebuildGritLayout(maxGrit);
            }

            // 2. Update Colors
            for (int i = 0; i < _spawnedPips.Count; i++)
            {
                if (_spawnedPips[i] == null) continue;

                // Example: Grit 2. 
                // i=0 (<2) -> Active. 
                // i=1 (<2) -> Active. 
                // i=2 (>=2) -> Inactive.
                _spawnedPips[i].color = (i < currentGrit) ? activePipColor : inactivePipColor;
            }
        }

        private void UpdateHull(bool hasHull)
        {
            if (hullIcon)
            {
                GameLogger.Log(LogChannel.UI, $"[HUDManager] Updating Hull Icon. Has Hull: {hasHull}", gameObject);

                Color targetColor = hasHull ? hullActiveColor : hullBrokenColor;
                hullIcon.color = targetColor;
            }else{
                GameLogger.Log(LogChannel.UI, $"[HUDManager] Hull Icon reference is missing!", gameObject);
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0");
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }

        // --- HELPERS ---

        private void RebuildGritLayout(int max)
        {

            GameLogger.Log(LogChannel.UI, $"[HUDManager] Rebuilding Grit Layout for Max Grit: {max}", gameObject);

            if (gritContainer == null || pipPrefab == null) return;

            // Clear existing
            foreach (Transform child in gritContainer)
            {
                Destroy(child.gameObject);
            }
            _spawnedPips.Clear();

            // Spawn new
            for (int i = 0; i < max; i++)
            {

                GameLogger.Log(LogChannel.UI, $"[HUDManager] Spawning Grit Pip {i + 1}/{max}", gameObject);

                GameObject newPip = Instantiate(pipPrefab, gritContainer);
                Image img = newPip.GetComponent<Image>();
                if (img)
                {
                    GameLogger.Log(LogChannel.UI, $"[HUDManager] Successfully spawned pip and added to list.", newPip);
                    _spawnedPips.Add(img);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\LevelBuilder.cs`
- Lines: 43
- Size: 1.1 KB
- Modified: 2025-12-31 17:13

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Environment;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    [ExecuteInEditMode]
    public class LevelBuilder : MonoBehaviour
    {
        [Header("Build Configuration")]
        public List<LevelModule> rooms;

        [Header("Actions")]
        public bool snapNow = false;

        private void Update()
        {
            if (snapNow)
            {
                SnapRooms();
                snapNow = false;
            }
        }

        public void SnapRooms()
        {
            if (rooms == null || rooms.Count < 2) return;

            for (int i = 1; i < rooms.Count; i++)
            {
                LevelModule previous = rooms[i - 1];
                LevelModule current = rooms[i];

                if (previous != null && current != null && previous.exitPoint != null)
                {
                    current.SnapTo(previous.exitPoint);
                }
            }
            GameLogger.Log(LogChannel.System, "Level Snapped!", gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\MusicManager.cs`
- Lines: 53
- Size: 1.5 KB
- Modified: 2025-12-31 09:17

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
- Lines: 146
- Size: 5.5 KB
- Modified: 2025-12-31 17:13

```csharp
using UnityEngine;
using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core;
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

            GameLogger.Log(LogChannel.VFX, $"Palette Applied: {activePalette.name}", this.gameObject);
        }

        // ApplySurface helper remains the same...
        private void ApplySurface(MaterialCollectionSO collection, SurfaceDefinition surf)
        {
            if (collection == null || collection.materials == null) return;
            foreach (var mat in collection.materials)
            {
                if (mat == null) continue;

                // --- 1. BASE COLOR ---
                if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", surf.mainColor);
                else if (mat.HasProperty("_Color")) mat.SetColor("_Color", surf.mainColor);

                // --- 2. GLOW / EMISSION (The Fix) ---
                // Option A: Standard URP Lit
                if (mat.HasProperty("_EmissionColor"))
                {
                    // Use the specific emission color defined in the palette
                    mat.SetColor("_EmissionColor", surf.emissionColor);
                    // Handle Intensity (HDR math)
                    // If the shader supports a separate intensity float, set it.
                    // Otherwise, we assume surf.emissionColor already has HDR intensity baked in.
                    if (mat.HasProperty("_EmissionIntensity"))
                    {
                        mat.SetFloat("_EmissionIntensity", surf.emissionIntensity);
                    }
                    mat.EnableKeyword("_EMISSION");
                }
                // Option B: Your Custom Shader (GlowColor)
                // We check for the specific reference name used in Shader Graph
                else if (mat.HasProperty("_GlowColor"))
                {
                    // Combine Color * Intensity for the final HDR result
                    Color finalGlow = surf.emissionColor * Mathf.LinearToGammaSpace(surf.emissionIntensity);
                    mat.SetColor("_GlowColor", finalGlow);
                }

                // --- 3. PHYSICS ---
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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 17:13

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
            GameLogger.Log(LogChannel.Combat, $"<color=yellow>GLORY KILL! +{bonus}</color>", this.gameObject);
            AddScore(bonus);
        }

        private void UpdateUI()
        {
            GameEvents.OnScoreChanged?.Invoke(TotalScore, currentMultiplier);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\UIManager.cs`
- Lines: 35
- Size: 1.3 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;

namespace DarkTowerTron.Managers
{
    public class UIManager : MonoBehaviour
    {
        [Header("Panels")]
        public GameObject startPanel;
        public GameObject tutorialPanel;
        public GameObject hudPanel;
        public GameObject pausePanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel;

        public void ShowStartMenu() => SetPanelActive(startPanel);
        public void ShowTutorial() => SetPanelActive(tutorialPanel);
        public void ShowHUD() => SetPanelActive(hudPanel);
        public void ShowPause() => SetPanelActive(pausePanel);
        public void ShowGameOver() => SetPanelActive(gameOverPanel);
        public void ShowVictory() => SetPanelActive(victoryPanel);

        // Helper to ensure exclusive visibility
        private void SetPanelActive(GameObject activePanel)
        {
            if (startPanel) startPanel.SetActive(false);
            if (tutorialPanel) tutorialPanel.SetActive(false);
            if (hudPanel) hudPanel.SetActive(false);
            if (pausePanel) pausePanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(false);
            if (victoryPanel) victoryPanel.SetActive(false);

            if (activePanel) activePanel.SetActive(true);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\VFXManager.cs`
- Lines: 75
- Size: 2.6 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Managers
{
    public class VFXManager : MonoBehaviour
    {
        public static VFXManager Instance;

        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab;

        [Header("Settings")]
        public LayerMask groundLayer; // Set to 'Ground', 'Default', 'Wall'

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // Default mask if forgotten
            if (groundLayer == 0) groundLayer = LayerMask.GetMask("Ground", "Default", "Wall");
        }

        private void OnEnable()
        {
            GameEvents.OnEnemyKilled += PlayDeathVFX;
            GameEvents.OnEnemySpawned += PlaySpawnVFX;
        }

        private void OnDisable()
        {
            GameEvents.OnEnemyKilled -= PlayDeathVFX;
            GameEvents.OnEnemySpawned -= PlaySpawnVFX;
        }

        private void PlayDeathVFX(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab && PoolManager.Instance)
            {
                // Explosion happens exactly where the enemy died (center mass)
                GameObject vfx = PoolManager.Instance.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && PoolManager.Instance)
            {
                // FIX: Find the actual floor below the spawn position
                Vector3 vfxPos = pos;

                // Cast from slightly above the spawn point downwards
                if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2.0f, Vector3.down, out RaycastHit hit, 10f, groundLayer))
                {
                    // Found ground! Snap visual to it + slight offset to prevent z-fighting
                    vfxPos = hit.point + Vector3.up * 0.1f;
                }
                else
                {
                    // Fallback: Just put it at the enemy's feet (assuming pos is feet)
                    vfxPos = pos + Vector3.up * 0.1f;
                }

                GameObject vfx = PoolManager.Instance.Spawn(spawnPrefab, vfxPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\WaveDirector.cs`
- Lines: 193
- Size: 6.6 KB
- Modified: 2025-12-31 17:13

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
                GameLogger.Log(LogChannel.System, "ROOM CLEARED", gameObject);
                // Open the doors. Boss script will handle Victory separately.
                GameEvents.OnRoomCleared?.Invoke();
                yield break;
            }

            WaveDefinitionSO wave = waves[index];
            GameLogger.Log(LogChannel.System, $"WAVE {index + 1}: {wave.waveName}", gameObject);

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
                GameLogger.LogError(LogChannel.System, $"WaveDirector: Attempted to spawn NULL prefab.", gameObject);
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
                GameLogger.LogWarning(LogChannel.System, $"Enemy {instance.name} missing Stats! Defaulting to Essential.", instance);
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
                    GameLogger.Log(LogChannel.System, "VIPs Down. Reinforcements Stopped.", gameObject);
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
                GameLogger.Log(LogChannel.System, "WAVE CLEARED - SECTOR SECURE", gameObject);

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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\Player\PlayerBeam.cs`
- Lines: 84
- Size: 2.7 KB
- Modified: 2025-12-31 12:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    // RENAMED: Was PlayerAttack
    public class PlayerBeam : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 0.5f;
        public float selfRecoil = 15f;
        public LayerMask hitLayers;
        public GameObject beamVisualPrefab;

        private PlayerMovement _movement;

        protected override void Awake()
        {
            base.Awake();
            _movement = GetComponent<PlayerMovement>();
        }

        // Implement Abstract Method from WeaponBase
        protected override float GetCurrentFireRate()
        {
            // Read specific Beam stat
            return _stats.BeamRate;
        }

        protected override void Fire()
        {
            Vector3 fireDir = GetAimDirection();

            // 1. Visuals
            if (beamVisualPrefab)
            {
                Quaternion targetRot = Quaternion.LookRotation(fireDir);
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, targetRot, firePoint);

                Vector3 parentScale = firePoint.lossyScale;
                float compX = beamRadius / parentScale.x;
                float compY = beamRadius / parentScale.y;
                float compZ = range / parentScale.z;

                beam.transform.localScale = new Vector3(compX, compY, 0f);
                beam.transform.DOScaleZ(compZ, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 2. Recoil
            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            // 3. Hit Detection
            if (UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out RaycastHit hit, range, hitLayers))
            {
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();

                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        // Read Stats
                        damageAmount = _stats.BeamDamage,
                        staggerAmount = _stats.BeamStagger,

                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject
                        ,
                        // NEW: Explicitly Melee
                        damageType = DamageType.Melee
                    };

                    target.TakeDamage(info);
                    GameEvents.OnPlayerHit?.Invoke();
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerController.cs`
- Lines: 216
- Size: 6.9 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerExecution))]
    public class PlayerController : MonoBehaviour
    {
        [Header("Components")]
        private PlayerMovement _movement;
        private PlayerDodge _dodge;
        private PlayerExecution _execution;
        private TargetScanner _scanner;

        // Weapon References
        private PlayerBeam _beamWeapon; // Left Trigger / LMB
        private PlayerGun _gunWeapon;     // Right Trigger / RMB

        // Input State
        private GameControls _controls;
        private bool _inputEnabled = true;
        private float _safetyTimer = 0f; // Prevents UI clicks from firing weapons
        private Camera _cam;

        // Cached Actions (Optimization)
        private InputAction _moveAction;
        private InputAction _lookPadAction;
        private InputAction _lookMouseAction;
        private InputAction _fireBeamAction;
        private InputAction _fireGunAction;

        private void Awake()
        {
            // 1. Get Components
            _movement = GetComponent<PlayerMovement>();
            _dodge = GetComponent<PlayerDodge>();
            _execution = GetComponent<PlayerExecution>();
            _scanner = GetComponent<TargetScanner>();

            _beamWeapon = GetComponent<PlayerBeam>();
            _gunWeapon = GetComponent<PlayerGun>();

            _cam = Camera.main;

            // 2. Initialize Input System
            _controls = new GameControls();

            // 3. Cache Actions
            _moveAction = _controls.Gameplay.Move;
            _lookPadAction = _controls.Gameplay.LookGamepad;
            _lookMouseAction = _controls.Gameplay.LookMouse;

            // Use safe lookups
            _fireBeamAction = _controls.asset.FindAction("Melee");
            _fireGunAction = _controls.asset.FindAction("Gun");

            // 4. Bind One-Shot Actions
            var dodgeAction = _controls.asset.FindAction("Blitz");
            if (dodgeAction != null) dodgeAction.performed += ctx => OnDodge();

            var killAction = _controls.asset.FindAction("GloryKill");
            if (killAction != null) killAction.performed += ctx => OnGloryKill();

            // NEW: Register self
            GameServices.RegisterPlayer(this);
        }

        private void OnEnable()
        {
            if (_inputEnabled) _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        private void Update()
        {
            if (!_inputEnabled) return;

            // SAFETY CHECK:
            // Prevents shooting immediately after clicking a UI button
            if (_safetyTimer > 0)
            {
                _safetyTimer -= Time.deltaTime;

                // Ensure weapons are silent while safety is active
                if (_beamWeapon) _beamWeapon.SetFiring(false);
                if (_gunWeapon) _gunWeapon.SetFiring(false);

                // Still allow movement processing so it doesn't feel stuck
                HandleMovement();
                return;
            }

            // Normal Loop
            HandleMovement();
            HandleAimingAndScanning();
            HandleFiring();
        }

        // --- INPUT HANDLERS ---

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

            // Priority 1: Gamepad Stick
            if (_lookPadAction != null)
            {
                Vector2 stickInput = _lookPadAction.ReadValue<Vector2>();
                if (stickInput.sqrMagnitude > 0.05f)
                {
                    aimDir = new Vector3(stickInput.x, 0, stickInput.y).normalized;
                    _movement.LookAtDirection(aimDir);
                    UpdateScanner(aimDir);
                    return; // Stick overrides mouse
                }
            }

            // Priority 2: Mouse Position
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
            if (_scanner != null) _scanner.UpdateScanner(dir);
        }

        private void HandleFiring()
        {
            // 1. BEAM (Left Trigger / Left Click)
            if (_beamWeapon != null && _fireBeamAction != null)
            {
                bool isBeam = _fireBeamAction.ReadValue<float>() > 0.5f;
                _beamWeapon.SetFiring(isBeam);
            }

            // 2. GUN (Right Trigger / Right Click)
            if (_gunWeapon != null && _fireGunAction != null)
            {
                bool isGun = _fireGunAction.ReadValue<float>() > 0.5f;
                _gunWeapon.SetFiring(isGun);
            }
        }

        private void OnDodge()
        {
            if (_inputEnabled && _safetyTimer <= 0 && _dodge != null)
                _dodge.PerformDodge();
        }

        private void OnGloryKill()
        {
            if (_inputEnabled && _safetyTimer <= 0 && _execution != null)
                _execution.PerformGloryKill();
        }

        // --- PUBLIC API ---

        public void ToggleInput(bool state)
        {
            _inputEnabled = state;

            if (state)
            {
                _controls.Enable();
                // Add small delay to prevent click-through
                _safetyTimer = 0.2f;
            }
            else
            {
                _controls.Disable();

                // Reset everything
                _movement.SetMoveInput(Vector3.zero);
                if (_beamWeapon) _beamWeapon.SetFiring(false);
                if (_gunWeapon) _gunWeapon.SetFiring(false);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerDodge.cs`
- Lines: 199
- Size: 6.6 KB
- Modified: 2025-12-31 09:17

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

        [Header("Traversal (Gravity Control)")]
        [Tooltip("How long to suspend gravity AFTER the dash ends (Coyote Time).")]
        public float hangTime = 0.2f;

        [Header("Interaction Settings")]
        public LayerMask projectileLayer;
        public LayerMask wallLayer;

        [Header("Audio")]
        public AudioClip dashClip;

        [Header("Visual Indicator")]
        public Transform indicatorRef;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;
        public bool showIndicator = true;

        // State Properties
        public bool IsInvulnerable { get; private set; }
        public bool IsDashing { get; private set; }

        // Dependencies
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

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", "Wall");
        }

        private void Update()
        {
            HandleIndicator();
        }

        /// <summary>
        /// Called by PlayerController when Spacebar/Dash button is pressed.
        /// </summary>
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
            IsInvulnerable = true;

            // Hide indicator during movement
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // --- 1. GRAVITY SUSPENSION ---
            // We tell movement to ignore gravity for the dash duration + hang time.
            // This allows "Air Dashing" without falling immediately.
            _movement.SuspendGravity(dashDuration + hangTime);

            // --- 2. AUDIO & VISUALS ---
            if (Managers.AudioManager.Instance && dashClip)
                Managers.AudioManager.Instance.PlaySound(dashClip, 1f, true);

            // Spawn Decoy from Loadout (Standard or Explosive)
            if (_loadout && _loadout.currentDecoy)
                Instantiate(_loadout.currentDecoy, transform.position, transform.rotation);

            // --- 3. DIRECTION LOGIC ---
            Vector3 dashDir;
            // If moving input exists, dash that way. Otherwise dash forward.
            if (_movement.MoveInput.sqrMagnitude > 0.1f)
                dashDir = _movement.MoveInput.normalized;
            else
                dashDir = transform.forward;

            // --- 4. PHYSICS LOOP ---
            float speed = dashDistance / dashDuration;
            float timer = 0f;

            while (timer < dashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;

                // Move via Motor (Pass Velocity)
                _mover.Move(dashDir * speed);

                // Active Intercept
                CatchProjectiles();

                yield return null;
            }

            // Small recovery frame before state resets
            yield return new WaitForSeconds(0.05f);

            IsInvulnerable = false;
            IsDashing = false;

            // Note: Gravity remains suspended for the duration of 'hangTime' 
            // handled by PlayerMovement timer.
        }

        private void CatchProjectiles()
        {
            // Detect hostile bullets in close range
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, projectileLayer);

            foreach (var hit in hits)
            {
                IReflectable proj = hit.GetComponent<IReflectable>();
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    // Redirect in the direction we are dashing
                    proj.Redirect(transform.forward, gameObject);

                    // Reward for technical play
                    _energy.AddFocus(20f);
                }
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            if (!showIndicator || IsDashing)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            // Calculate Destination based on Input
            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;

            // Raycast to stop indicator at walls
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

            // Visual Feedback (Can we afford it?)
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
- Lines: 133
- Size: 4.0 KB
- Modified: 2025-12-31 14:58

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerEnergy : MonoBehaviour
    {
        // NO INSPECTOR VARIABLES! All data comes from PlayerStats.

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
            if (_stats == null)
            {
                GameLogger.LogError(LogChannel.Player, "PlayerEnergy missing PlayerStats component!", gameObject);
                return;
            }

            // Init
            _currentFocus = _stats.MaxFocus;
            GameLogger.Log(LogChannel.Player, $"Energy Initialized. Max: {_stats.MaxFocus}", gameObject);

            // Subscriptions
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

            // Check Overdrive Threshold via Stats
            // (We assume the threshold is static in SO for now)
            bool shouldBeOverdrive = _currentFocus >= _stats.baseStats.overdriveThreshold;
            _stats.SetOverdrive(shouldBeOverdrive);

            // Decay Logic
            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= _stats.FocusDecayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                
                UpdateUI();
            }
        }

        // --- PUBLIC API ---

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
            float max = _stats.MaxFocus;
            _currentFocus += amount;
            if (_currentFocus > max) _currentFocus = max;
            UpdateUI();
        }

        // --- EVENT HANDLERS ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Use enemy specific reward, or fallback to player base stat
            float gain = (stats != null) ? stats.focusReward : _stats.BaseFocusOnKill;
            
            GameLogger.Log(LogChannel.Player, $"Enemy Killed. +{gain} Focus.", gameObject);
            AddFocus(gain);
        }

        private void EnableDecay() 
        { 
            _isCombatActive = true;
            GameLogger.Log(LogChannel.System, "Combat Started. Focus Decay ON.");
        }

        private void DisableDecay() 
        { 
            _isCombatActive = false; 
            GameLogger.Log(LogChannel.System, "Combat Ended. Focus Decay OFF.");
        }

        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, _stats.MaxFocus);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerExecution.cs`
- Lines: 122
- Size: 4.0 KB
- Modified: 2025-12-31 09:17

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
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public float postKillHangTime = 0.4f; // NEW: Time to float after teleport
        public AudioClip executeClip; // Assign in Inspector

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private PlayerMovement _movement;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
            _movement = GetComponent<PlayerMovement>();
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

            // 1. Calculate Position
            Vector3 targetPos = target.transform.position;
            Vector3 attackPos = targetPos - (transform.forward * 1.0f); 

            // 2. Y-Axis Logic (The Fix)
            if (target.KeepPlayerGrounded)
            {
                // Find the ground below the target
                if (UnityEngine.Physics.Raycast(targetPos + Vector3.up, Vector3.down, out RaycastHit hit, 10f, LayerMask.GetMask("Ground")))
                {
                    attackPos.y = hit.point.y;
                }
                else
                {
                    attackPos.y = targetPos.y; // Fallback
                }
            }
            else
            {
                // Go to exact height (e.g. Floating Anchor)
                attackPos.y = targetPos.y;
            }

            transform.position = attackPos;

            // 2. Suspend Gravity (The "Matrix" Pause)
            if (_movement)
            {
                _movement.ResetVelocity();
                _movement.SuspendGravity(postKillHangTime);
            }

            // 3. Trigger Target Reaction (Die or Reset)
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
- Lines: 58
- Size: 1.8 KB
- Modified: 2025-12-31 18:22

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
                GameObject p = Managers.PoolManager.Instance.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));
                
                var proj = p.GetComponent<Combat.Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false; 
                    
                    // --- DATA INJECTION ---
                    // Overwrite the Prefab's damage with our RPG stats
                    proj.damage = _stats.GunDamage;
                    proj.stagger = _stats.GunStagger;
                    // ---------------------


                    Debug.Log($"[GUN DEBUG] Firing Bullet. Damage: {proj.damage} | Stagger: {proj.stagger}");
                    
                    proj.Initialize(aimDir);
                }
            }
        }

        // 1. Return the rate from Stats
        protected override float GetCurrentFireRate()
        {
            return _stats.GunRate;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerHealth.cs`
- Lines: 172
- Size: 5.1 KB
- Modified: 2025-12-31 14:52

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerStats))] // NEW DEPENDENCY
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Configuration")]
        public bool startWithHull = true;

        // State
        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        
        // Dependencies
        private PlayerMovement _movement;
        private PlayerDodge _dodge;
        private PlayerStats _stats; // NEW

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            _dodge = GetComponent<PlayerDodge>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            // FIX: Read Max Grit from Data, not Inspector
            if (_stats != null && _stats.baseStats != null)
            {
                _currentGrit = _stats.baseStats.maxGrit;
                GameLogger.Log(LogChannel.Player, $"Health Initialized. Max Grit: {_currentGrit}", gameObject);
            }
            else
            {
                _currentGrit = 2; // Fallback
                GameLogger.LogError(LogChannel.Player, "Missing PlayerStatsSO! Defaulting to 2 Grit.", gameObject);
            }

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

            if (_dodge != null && _dodge.IsInvulnerable) 
            {
                GameLogger.Log(LogChannel.Combat, "Damage Dodged (Invulnerable)", gameObject);
                return false;
            }

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0; 
                
                GameLogger.Log(LogChannel.Combat, $"Player Hit! Grit: {_currentGrit}", gameObject);
                GameEvents.OnPlayerHit?.Invoke(); 
            }
            else if (_hasHull)
            {
                _hasHull = false;
                
                GameLogger.Log(LogChannel.Combat, "HULL BREACHED!", gameObject);
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

        public void TakeVoidDamage()
        {
            if (_isDead) return;

            GameLogger.Log(LogChannel.Physics, "Fell into Void. Respawning.", gameObject);

            if (_movement)
            {
                _movement.ResetVelocity();
                var motor = GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            DamageInfo info = new DamageInfo
            {
                damageAmount = 1f,
                pushDirection = Vector3.zero,
                pushForce = 0f,
                source = null,
                damageType = DamageType.Environment
            };
            
            TakeDamage(info); 
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();
            
            GameLogger.Log(LogChannel.Player, "PLAYER DEAD", gameObject);
            GameEvents.OnPlayerDied?.Invoke();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            
            int max = _stats ? _stats.baseStats.maxGrit : 2;
            _currentGrit = Mathf.Min(_currentGrit + amount, max);
            
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

        public void ForceUpdateUI()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            int max = _stats ? _stats.baseStats.maxGrit : 2;
            GameEvents.OnGritChanged?.Invoke(_currentGrit, max);
            GameEvents.OnHullStateChanged?.Invoke(_hasHull);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerLoadout.cs`
- Lines: 37
- Size: 0.9 KB
- Modified: 2025-12-31 09:17

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
- Lines: 236
- Size: 8.0 KB
- Modified: 2025-12-31 09:17

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
        private float _gravitySuspendTimer = 0f;
        
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

            if (_gravitySuspendTimer > 0) _gravitySuspendTimer -= Time.deltaTime;

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

            // --- GRAVITY LOGIC UPDATE ---
            // Only apply gravity if NOT grounded AND NOT suspended
            if (!_mover.IsGrounded && _gravitySuspendTimer <= 0)
            {
                finalVelocity.y -= gravity;
            }
            else if (_mover.IsGrounded)
            {
                finalVelocity.y = -2f; // Stick to ground
            }
            else
            {
                // We are in Air + Suspended = Zero Gravity (Hover)
                finalVelocity.y = 0f;
            }
            // ----------------------------

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

        public void SuspendGravity(float duration)
        {
            _gravitySuspendTimer = duration;

            // CRITICAL: Kill existing downward momentum immediately
            // so we don't carry "falling speed" into the hover.
            if (_externalForce.y < 0) _externalForce.y = 0;
            if (_currentVelocity.y < 0) _currentVelocity.y = 0;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerStats.cs`
- Lines: 46
- Size: 1.9 KB
- Modified: 2026-01-01 09:05

```csharp
using UnityEngine;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Base Configuration")]
        public PlayerStatsSO baseStats;

        public bool IsOverdrive { get; private set; }

        // --- MOVEMENT ---
        public float MoveSpeed => IsOverdrive ? baseStats.moveSpeed * baseStats.overdriveSpeedMult : baseStats.moveSpeed;
        public float Acceleration => baseStats.acceleration;

        // --- ABILITIES ---
        public float DashCost => baseStats.dashCost;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown;

        // --- WEAPON: GUN ---
        public float GunDamage => IsOverdrive ? baseStats.gunDamage * baseStats.overdriveDamageMult : baseStats.gunDamage;
        public int GunStagger => baseStats.gunStagger;
        // Rate: Lower is faster. If OverdriveMult is 1.5 (Faster), we divide the delay.
        public float GunRate => IsOverdrive ? baseStats.gunFireRate / baseStats.overdriveFireRateMult : baseStats.gunFireRate;

        // --- WEAPON: BEAM ---
        public float BeamDamage => IsOverdrive ? baseStats.beamDamage * baseStats.overdriveDamageMult : baseStats.beamDamage;
        public int BeamStagger => baseStats.beamStagger;
        public float BeamRate => IsOverdrive ? baseStats.beamFireRate / baseStats.overdriveFireRateMult : baseStats.beamFireRate;

        // --- RESOURCES ---
        public int MaxGrit => baseStats.maxGrit;
        public float MaxFocus => baseStats.maxFocus;
        
        // Future proofing: Modifiers could change these later
        public float FocusDecayRate => baseStats.focusDecayRate; 
        public float BaseFocusOnKill => baseStats.baseFocusOnKill;

        public void SetOverdrive(bool state)
        {
            IsOverdrive = state;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\TargetScanner.cs`
- Lines: 95
- Size: 3.3 KB
- Modified: 2025-12-31 09:17

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
- Lines: 110
- Size: 3.3 KB
- Modified: 2025-12-31 17:58

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; 
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;
        
        [Header("Behavior")]
        public bool isAutomatic = true; // Gun = True, Beam = False

        [Header("Audio")]
        public SoundDef fireSound; 

        [Header("Feel")]
        public float inputBufferTime = 0.2f;

        protected PlayerStats _stats;
        protected TargetScanner _scanner;
        
        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;
        
        // NEW: Tracks if we already shot during this specific button press
        private bool _hasFiredThisPress = false;

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
            
            // RESET Logic: If we released the button, we can fire again
            if (!state)
            {
                _hasFiredThisPress = false;
            }
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                // Only fill buffer if we are allowed to fire (for Semi-Auto)
                if (isAutomatic || !_hasFiredThisPress)
                {
                    _bufferTimer = inputBufferTime;
                }
            }

            // TRIGGER LOGIC
            if (_bufferTimer > 0 && _timer <= 0)
            {
                // Semi-Auto Check
                if (!isAutomatic && _hasFiredThisPress)
                {
                    // Do nothing, waiting for release
                    return;
                }

                Fire();
                PlayFireSound();
                
                _timer = GetCurrentFireRate();
                _bufferTimer = 0;
                
                // Mark as fired
                _hasFiredThisPress = true; 
            }
        }

        // ... (Rest of script: GetCurrentFireRate, Fire, Helpers match previous) ...
        protected abstract float GetCurrentFireRate();
        protected abstract void Fire();

        protected void PlayFireSound()
        {
            if (fireSound && AudioManager.Instance)
                AudioManager.Instance.PlaySound(fireSound); 
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;
            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;
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
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\UI\MenuController.cs`
- Lines: 30
- Size: 0.8 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace DarkTowerTron.UI
{
    public class MenuController : MonoBehaviour
    {
        [Header("Navigation")]
        public GameObject firstSelectedObject;

        private void OnEnable()
        {
            // Wait one frame to ensure EventSystem is ready
            StartCoroutine(SelectButtonRoutine());
        }

        private System.Collections.IEnumerator SelectButtonRoutine()
        {
            yield return null;

            if (firstSelectedObject && EventSystem.current)
            {
                // Clear selection then set new one to force highlight update
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(firstSelectedObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\ResultScreen.cs`
- Lines: 56
- Size: 1.8 KB
- Modified: 2025-12-31 09:17

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

## 📄 `Assets\Scripts\UI\UIThemeReceiver.cs`
- Lines: 48
- Size: 1.6 KB
- Modified: 2025-12-31 09:17

```csharp
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.UI
{
    public enum UIElementType { Title, Body, Button, Panel, Digits, Danger }

    public class UIThemeReceiver : MonoBehaviour
    {
        public UIThemeSO theme; // Assign in Inspector or Load from Manager
        public UIElementType type = UIElementType.Body;

        private void OnEnable()
        {
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            if (theme == null) return;

            var text = GetComponent<TextMeshProUGUI>();
            var img = GetComponent<Image>();

            switch (type)
            {
                case UIElementType.Title:
                    if (text) { text.font = theme.mainFont; text.color = theme.primaryColor; }
                    break;
                case UIElementType.Body:
                    if (text) { text.font = theme.mainFont; text.color = theme.bodyColor; }
                    break;
                case UIElementType.Digits:
                    if (text) { text.font = theme.digitFont; text.color = theme.accentColor; }
                    break;
                case UIElementType.Danger:
                    if (text) { text.font = theme.mainFont; text.color = theme.dangerColor; }
                    break;
                case UIElementType.Button:
                    if (img) { img.sprite = theme.buttonBackground; img.color = theme.accentColor; }
                    // Button text is usually handled by a child receiver set to "Body" or "Title"
                    break;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Visuals\CameraShaker.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2025-12-31 09:17

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
- Modified: 2025-12-31 09:17

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
