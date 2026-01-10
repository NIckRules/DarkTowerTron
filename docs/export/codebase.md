# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2026-01-09 14:49
- **Files:** 242
- **Total LOC:** 13048
- **Estimated tokens:** 104837

## 📁 Project Tree
```
Assets
  Data
    AI
      Agents
        Chaser
          State_Chaser_Detonate.asset
          State_Chaser_Melee.asset
          State_Chaser_Prime.asset
          State_Chaser_Pursue.asset
        Guardian
          State_Guardian_Attack.asset
          State_Guardian_Patrol.asset
        Sentinel
          State_Sentinel_Engage.asset
      AttackPattern
        Attack_Guardian_Basic.asset
        Attack_Sentinel_Basic.asset
    AttackPatterns
      Bosses
        Architect
          ARC_Straight.asset
      Guardian_Attack_Basic.asset
      Nova.asset
      Sentinel_Attack_Pulsar.asset
      Shotgun.asset
      Sweep.asset
    Audio
      SFX_Enemy_Explode.asset
      SFX_Player_Beam.asset
      SFX_Player_Dash.asset
      SFX_Player_Shoot.asset
    Bosses
      Architect
        ARC_PAT_ClockRotation.asset
        ARC_PAT_HorizontalWall.asset
        ARC_PAT_StraightProjectiles.asset
    Enemies
      Chaser
        Stats_Chaser.asset
      Enemy_Visual_Default.asset
      Guardian
        Attack_Guardian.asset
        Stats_Guardian.asset
      Sentinel
        Stats_Sentinel_Attack.asset
        Stats_Sentinel_Health.asset
      Stats_Sniper.asset
    Events
      Combat
        Event_EnemyKilled.asset
        Event_PlayerHit.asset
      Event_Damage.asset
      Event_Decoy_Expired.asset
      Event_Focus.asset
      Event_Grit.asset
      Event_Hull.asset
      Event_Score.asset
      Event_Wave_Cleared.asset
      Event_Wave_Started.asset
      System
        Event_Game_Victory.asset
        Event_Player_Died.asset
        Event_Room_Cleared.asset
      UI
        Event_Countdown.asset
        Event_Popup.asset
        Event_Wave_Announce.asset
      Visuals
        Event_Decoy_Spawned.asset
        Event_Enemy_Spawned.asset
    Feedback
      Commands
        Enemy_Explosion.asset
      Events
        Enemy_Die.asset
    Narrative
      Narrative_Main.asset
    Player
      Stats_Player_Default.asset
    Visuals
      Collections
        Collection_Anchors.asset
        Collection_Enemies.asset
        Collection_Enemies_Core.asset
        Collection_Enemies_Secondary.asset
        Collection_Floors.asset
        Collection_Hazards.asset
        Collection_Player.asset
        Collection_Player_Beam.asset
        Collection_Player_Core.asset
        Collection_Player_Seconday.asset
        Collection_Projectiles_Friendly.asset
        Collection_Projectiles_Hostile.asset
        Collection_Void.asset
        Collection_Walls.asset
      Palettes
        PAL_Neon.asset
        PAL_Nier.asset
        Pal_Alternative.asset
        Pal_Stranger.asset
      Themes
        Theme_Enemy_Default.asset
        Theme_Guardian.asset
        Theme_Player_Default.asset
    Waves
      WAV_TEST_Sentinel.asset
      WA_1_3Mis.asset
      WA_1_3Sen.asset
      WA_1_3Sen_3Chm.asset
  Modules
    AI
      Behaviours
        AvoidanceBehavior.cs
        FleeBehaviour.cs
        OrbitBehavior.cs
        SeekBehaviour.cs
        VoidAvoidanceBehavior.cs
      Core
        AIData.cs
        ContextSolver.cs
        Detector.cs
        SteeringBehaviour.cs
      Detectors
        ObstacleDetector.cs
        TargetDetector.cs
      Paths
        AutoAssignPatrolPath.cs
        PatrolPath.cs
        Waypoint.cs
      Pluggable
        Actions
          Action_ContextSteering.cs
          Action_FirePattern.cs
          Action_Patrol.cs
          Action_SelfDestruct.cs
          Action_Visual_Prime.cs
        Core
          AIAction.cs
          AIBlackboard.cs
          AIDecision.cs
          AIState.cs
          PluggableAIController.cs
        Decisions
          Decision_InRange.cs
          Decision_LineOfSight.cs
          Decision_TimeElapsed.cs
      Utils
        AIDebugger.cs
        AIDirections.cs
  Scripts
    Combat
      BaseHitbox.cs
      ContactDamager.cs
      DamageReceiver.cs
      FirePointRegistry.cs
      HazardZone.cs
      HitBox
        ShieldHitbox.cs
        StandardHitbox.cs
      Modules
        StaggerModule.cs
        VitalityModule.cs
      PatternExecutor.cs
      Projectile.cs
      Strategies
        HomingMovement.cs
        LinearMovement.cs
        SineWaveMovement.cs
    Core
      CameraRig.cs
      CircleRenderer.cs
      Data
        ActorThemeSO.cs
        ArchitectPatternSO.cs
        AttackPatternSO.cs
        ColorPaletteSO.cs
        DebugProfileSO.cs
        EnemyAttackSO.cs
        EnemyStatsSO.cs
        EnemyVisualProfileSO.cs
        FeedbackProfileSO.cs
        MaterialCollectionSO.cs
        PlayerStatsSO.cs
        SoundDef.cs
        SurfaceType.cs
        UIThemeSO.cs
        WaveDefinitionSO.cs
      Debug
        GameLogger.cs
        LogChannel.cs
      Events
        BoolEventChannelSO.cs
        DamageTextEventChannelSO.cs
        EnemyKilledEventChannelSO.cs
        FloatFloatEventChannelSO.cs
        IntEventChannelSO.cs
        IntIntEventChannelSO.cs
        NarrativeEventChannelSO.cs
        PopupTextEventChannelSO.cs
        StringEventChannelSO.cs
        TransformEventChannelSO.cs
        Vector3EventChannelSO.cs
        VoidEventChannelSO.cs
        VoidEventListener.cs
      Feedback
        Command
          CameraShakeCommand.cs
          PlaySoundCommand.cs
          SpawnVFXCommand.cs
          TimeFreezeCommand.cs
        FeedbackCommand.cs
        FeedbackConfigurationSO.cs
      GameConstants.cs
      GameServices.cs
      GameTime.cs
      Global.cs
      Input
        InputBuffer.cs
      Interfaces
        IAimTarget.cs
        ICombatTarget.cs
        IDamageable.cs
        IMovementStrategy.cs
        IMover.cs
        IPoolable.cs
        IReflectable.cs
        IWeapon.cs
      Services
        BootLoader.cs
        GameBootstrap.cs
        ServiceLocator.cs
      Spinner.cs
      Structs
        DamageInfo.cs
      Utils
        LayerAutomator.cs
        Rotator.cs
      VoidKiller.cs
    Editor
      SmartDuplicator.cs
    Enemy
      Bosses
        Architect
          ArchitectController.cs
          ArchitectHand.cs
      EnemyBaseAI.cs
      EnemyController.cs
      EnemyMotors.cs
      Modules
        EnemyPatrolModule.cs
      Visuals
        EnemyVisuals.cs
    Environment
      ArenaGate.cs
      CameraZone.cs
      LevelEndTrigger.cs
      LevelModule.cs
      PlayerStart.cs
      Props
        Prop_Anchor.cs
        Prop_Explosive.cs
      TileInfo.cs
      WaveTrigger.cs
    Managers
      ArenaSpawner.cs
      DebugController.cs
      GameSession.cs
      LevelBuilder.cs
      LevelPrewarmer.cs
      WaveDirector.cs
    Physics
      KinematicMover.cs
      UnityCharacterMover.cs
    Player
      Combat
        PlayerBeam.cs
        PlayerExecution.cs
        PlayerGun.cs
        PlayerWeaponController.cs
        TargetScanner.cs
        WeaponBase.cs
      Controller
        PlayerController.cs
        PlayerInputHandler.cs
      Movement
        AfterImage.cs
        PlayerDodge.cs
        PlayerMotor.cs
      Stats
        PlayerEnergy.cs
        PlayerHealth.cs
        PlayerLoadout.cs
        PlayerStats.cs
    Services
      AudioManager.cs
      MusicManager.cs
      PaletteManager.cs
      PoolManager.cs
      ScoreManager.cs
      VFXManager.cs
    Systems
      Narrative
        NarrativeDirector.cs
        NarrativeLibrarySO.cs
        TextCorruptor.cs
      Persistence
        Editor
          PersistenceManagerEditor.cs
        PersistenceManager.cs
        SaveData.cs
        StatsTracker.cs
    UI
      CountdownUI.cs
      DamageTextManager.cs
      FloatingText.cs
      HUDManager.cs
      MenuController.cs
      NarrativeUI.cs
      ResultScreen.cs
      UIManager.cs
      UIThemeReceiver.cs
    Visuals
      CameraShaker.cs
      PaletteReceiver.cs
```

## 📄 `Assets\Data\AI\Agents\Chaser\State_Chaser_Detonate.asset`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 07:08

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Chaser_Detonate
  m_EditorClassIdentifier: 
  onEnterActions:
  - {fileID: 11400000, guid: b0e0ecc103e94e34fbe35707854f8e37, type: 2}
  actions:
  - {fileID: 11400000, guid: b0e0ecc103e94e34fbe35707854f8e37, type: 2}
  transitions: []
```

## 📄 `Assets\Data\AI\Agents\Chaser\State_Chaser_Melee.asset`
- Lines: 19
- Size: 0.5 KB
- Modified: 2026-01-09 00:05

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Chaser_Melee
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: d131394403aa6e24db73676416e45e91, type: 2}
  transitions: []
```

## 📄 `Assets\Data\AI\Agents\Chaser\State_Chaser_Prime.asset`
- Lines: 23
- Size: 0.8 KB
- Modified: 2026-01-08 07:08

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Chaser_Prime
  m_EditorClassIdentifier: 
  onEnterActions:
  - {fileID: 11400000, guid: 6170974fdce893b46b9ed1536d3ea9ae, type: 2}
  actions:
  - {fileID: 11400000, guid: d131394403aa6e24db73676416e45e91, type: 2}
  transitions:
  - decision: {fileID: 11400000, guid: 33cf2d553cae320428b90dfc7c42e2ed, type: 2}
    trueState: {fileID: 11400000, guid: f890b1b0aa61d7148a8e23c87ebff24e, type: 2}
    falseState: {fileID: 11400000, guid: d996aa5731d315f4297290ff5661f6b6, type: 2}
```

## 📄 `Assets\Data\AI\Agents\Chaser\State_Chaser_Pursue.asset`
- Lines: 22
- Size: 0.8 KB
- Modified: 2026-01-08 07:28

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Chaser_Pursue
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: d131394403aa6e24db73676416e45e91, type: 2}
  transitions:
  - decision: {fileID: 11400000, guid: 61e7edb3077eaa84284210fbcf2c3d0f, type: 2}
    trueState: {fileID: 11400000, guid: 9524212464a4f14439a6a4d8b6a3b55c, type: 2}
    falseState: {fileID: 11400000, guid: d996aa5731d315f4297290ff5661f6b6, type: 2}
```

## 📄 `Assets\Data\AI\Agents\Guardian\State_Guardian_Attack.asset`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-08 18:27

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Guardian_Attack
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: 9623c5a22d656874ea447fa7f31857c2, type: 2}
  transitions:
  - decision: {fileID: 11400000, guid: e9ef885431e6ee64cad1a462cf223266, type: 2}
    trueState: {fileID: 11400000}
    falseState: {fileID: 11400000, guid: 88b63b7e3004c5e46bf1b70e838965dc, type: 2}
```

## 📄 `Assets\Data\AI\Agents\Guardian\State_Guardian_Patrol.asset`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-08 14:32

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Guardian_Patrol
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: a4deedcacb40c5d4daa644286f11362a, type: 2}
  transitions:
  - decision: {fileID: 11400000, guid: e9ef885431e6ee64cad1a462cf223266, type: 2}
    trueState: {fileID: 11400000, guid: ae4b0efbfe3612b44bcd26f8fb8844e5, type: 2}
    falseState: {fileID: 11400000}
```

## 📄 `Assets\Data\AI\Agents\Sentinel\State_Sentinel_Engage.asset`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-09 07:36

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
  m_Script: {fileID: 11500000, guid: 6178fbad902a7554db41283da1e14295, type: 3}
  m_Name: State_Sentinel_Engage
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: d377730163350c64caa4770d49dd750a, type: 2}
  - {fileID: 11400000, guid: 76756452026f9b846bc0fde5294e8141, type: 2}
  transitions: []
```

## 📄 `Assets\Data\AI\AttackPattern\Attack_Guardian_Basic.asset`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-08 23:59

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
  m_Script: {fileID: 11500000, guid: e3a54a2f904891841a6788c97bb0b82f, type: 3}
  m_Name: Attack_Guardian_Basic
  m_EditorClassIdentifier: 
  pattern: {fileID: 11400000, guid: 7f702b6a0de7c33498936259a779dbc6, type: 2}
  attackStats: {fileID: 11400000, guid: 37ef7c7bef119b241b5c8ca136720b75, type: 2}
```

## 📄 `Assets\Data\AI\AttackPattern\Attack_Sentinel_Basic.asset`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-09 07:19

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
  m_Script: {fileID: 11500000, guid: e3a54a2f904891841a6788c97bb0b82f, type: 3}
  m_Name: Attack_Sentinel_Basic
  m_EditorClassIdentifier: 
  pattern: {fileID: 11400000, guid: 7f702b6a0de7c33498936259a779dbc6, type: 2}
  attackStats: {fileID: 11400000, guid: 37ef7c7bef119b241b5c8ca136720b75, type: 2}
```

## 📄 `Assets\Data\AttackPatterns\Bosses\Architect\ARC_Straight.asset`
- Lines: 24
- Size: 0.6 KB
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\AttackPatterns\Guardian_Attack_Basic.asset`
- Lines: 26
- Size: 0.6 KB
- Modified: 2026-01-09 07:32

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
  m_Name: Guardian_Attack_Basic
  m_EditorClassIdentifier: 
  firePointID: FirePoint_Primary
  aimMode: 0
  scaleMultiplier: 1
  speed: 15
  projectileCount: 3
  spreadAngle: 0
  spinDuringFire: 0
  spinSpeed: 0
  startDelay: 0.5
  delayBetweenShots: 0.2
  cooldownAfterBurst: 3
```

## 📄 `Assets\Data\AttackPatterns\Nova.asset`
- Lines: 22
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\AttackPatterns\Sentinel_Attack_Pulsar.asset`
- Lines: 26
- Size: 0.6 KB
- Modified: 2026-01-09 07:36

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
  m_Name: Sentinel_Attack_Pulsar
  m_EditorClassIdentifier: 
  firePointID: FirePoint_Primary
  aimMode: 0
  scaleMultiplier: 1
  speed: 15
  projectileCount: 1
  spreadAngle: 0
  spinDuringFire: 0
  spinSpeed: 0
  startDelay: 0.5
  delayBetweenShots: 0
  cooldownAfterBurst: 1.5
```

## 📄 `Assets\Data\AttackPatterns\Shotgun.asset`
- Lines: 22
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

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
- Lines: 26
- Size: 0.6 KB
- Modified: 2026-01-08 18:27

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
  firePointID: FirePoint_Primary
  aimMode: 0
  scaleMultiplier: 1
  speed: 15
  projectileCount: 10
  spreadAngle: 60
  spinDuringFire: 0
  spinSpeed: 0
  startDelay: 0.5
  delayBetweenShots: 0.1
  cooldownAfterBurst: 1
```

## 📄 `Assets\Data\Audio\SFX_Enemy_Explode.asset`
- Lines: 20
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\Bosses\Architect\ARC_PAT_ClockRotation.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\Enemies\Chaser\Stats_Chaser.asset`
- Lines: 33
- Size: 0.7 KB
- Modified: 2026-01-08 07:08

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
  rideHeight: 1.4
  verticalSmoothTime: 0.5
  separationRadius: 1.5
  separationForce: 8
  maxHealth: 10
  maxStagger: 5
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Enemy_Visual_Default.asset`
- Lines: 18
- Size: 0.5 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: c8aa1121de5760045a840eb95a0dbc31, type: 3}
  m_Name: Enemy_Visual_Default
  m_EditorClassIdentifier: 
  hitFlashDuration: 0.1
  staggerPulseDuration: 0.4
  dangerPulseColor: {r: 1, g: 0, b: 0, a: 1}
```

## 📄 `Assets\Data\Enemies\Guardian\Attack_Guardian.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2026-01-08 23:59

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
  m_Script: {fileID: 11500000, guid: 6b269f952b696774fb25e5db3b40ed34, type: 3}
  m_Name: Attack_Guardian
  m_EditorClassIdentifier: 
  damage: 1
  stagger: 0
  projectilePrefab: {fileID: 4816501585111597516, guid: 2f354b46747ecbc4a9c42c9ce1a719e0,
    type: 3}
  projectileSpeed: 15
  lifetime: 7
  spreadAngle: 0
```

## 📄 `Assets\Data\Enemies\Guardian\Stats_Guardian.asset`
- Lines: 33
- Size: 0.7 KB
- Modified: 2026-01-08 08:10

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
  rideHeight: 1.3
  verticalSmoothTime: 0.5
  separationRadius: 1.5
  separationForce: 8
  maxHealth: 3
  maxStagger: 9
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Sentinel\Stats_Sentinel_Attack.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2026-01-09 07:31

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
  m_Script: {fileID: 11500000, guid: 6b269f952b696774fb25e5db3b40ed34, type: 3}
  m_Name: Stats_Sentinel_Attack
  m_EditorClassIdentifier: 
  damage: 1
  stagger: 0
  projectilePrefab: {fileID: 4816501585111597516, guid: 2f354b46747ecbc4a9c42c9ce1a719e0,
    type: 3}
  projectileSpeed: 25
  lifetime: 5
  spreadAngle: 0
```

## 📄 `Assets\Data\Enemies\Sentinel\Stats_Sentinel_Health.asset`
- Lines: 33
- Size: 0.7 KB
- Modified: 2026-01-09 07:31

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
  m_Name: Stats_Sentinel_Health
  m_EditorClassIdentifier: 
  isEssential: 0
  scoreValue: 100
  focusReward: 30
  healsGrit: 0
  gritRewardAmount: 1
  moveSpeed: 7
  rotationSpeed: 15
  combatRotationSpeed: 3
  acceleration: 20
  rideHeight: 1.1
  verticalSmoothTime: 0.5
  separationRadius: 5
  separationForce: 7
  maxHealth: 3
  maxStagger: 9
  staggerDecay: 0.5
  hasFrontalShield: 0
  shieldAngle: 0.5
```

## 📄 `Assets\Data\Enemies\Stats_Sniper.asset`
- Lines: 31
- Size: 0.7 KB
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\Events\Combat\Event_EnemyKilled.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: 55f9f970bd6bb4641a051f7ba14addb7, type: 3}
  m_Name: Event_EnemyKilled
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Combat\Event_PlayerHit.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_PlayerHit
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Damage.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 10:20

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
  m_Script: {fileID: 11500000, guid: 770008717575a6d47963dfa2c4387fb5, type: 3}
  m_Name: Event_Damage
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Decoy_Expired.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:36

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_Decoy_Expired
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Focus.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: 77db8a05c50bf5d48982086d7f89fe36, type: 3}
  m_Name: Event_Focus
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Grit.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: df1a6f2a16adf0b469b3d2d772e13959, type: 3}
  m_Name: Event_Grit
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Hull.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: 4176f100a9d83234cbbf541c11479c2c, type: 3}
  m_Name: Event_Hull
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Score.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

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
  m_Script: {fileID: 11500000, guid: df1a6f2a16adf0b469b3d2d772e13959, type: 3}
  m_Name: Event_Score
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Wave_Cleared.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:16

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_Wave_Cleared
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Event_Wave_Started.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:15

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_Wave_Started
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\System\Event_Game_Victory.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:16

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_Game_Victory
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\System\Event_Player_Died.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:16

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_Player_Died
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\System\Event_Room_Cleared.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:16

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
  m_Script: {fileID: 11500000, guid: 970f6552445842c4f9344b5cfaa80755, type: 3}
  m_Name: Event_Room_Cleared
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\UI\Event_Countdown.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:12

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
  m_Script: {fileID: 11500000, guid: e6650363b51a67f4cae6616f6c77447e, type: 3}
  m_Name: Event_Countdown
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\UI\Event_Popup.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 10:58

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
  m_Script: {fileID: 0}
  m_Name: Event_Popup
  m_EditorClassIdentifier: Assembly-CSharp:DarkTowerTron.Core.Events:PopupTextEventChannelSO
```

## 📄 `Assets\Data\Events\UI\Event_Wave_Announce.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:12

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
  m_Script: {fileID: 11500000, guid: 99c73a4b747983b429da5e92e0ce6971, type: 3}
  m_Name: Event_Wave_Announce
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Visuals\Event_Decoy_Spawned.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:36

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
  m_Script: {fileID: 11500000, guid: 53db0f89a59b246438e566bcc32d98fe, type: 3}
  m_Name: Event_Decoy_Spawned
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\Visuals\Event_Enemy_Spawned.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-06 15:35

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
  m_Script: {fileID: 11500000, guid: 0877295e77ae1894f812a17eb73a1f4a, type: 3}
  m_Name: Event_Enemy_Spawned
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Feedback\Commands\Enemy_Explosion.asset`
- Lines: 18
- Size: 0.5 KB
- Modified: 2026-01-07 07:36

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
  m_Script: {fileID: 11500000, guid: 9938b19f9c11d32408de7e5a0836cadc, type: 3}
  m_Name: Enemy_Explosion
  m_EditorClassIdentifier: 
  prefab: {fileID: 648059833510886341, guid: 68f25ab6f4dbf344187bc8a7231afda4, type: 3}
  attachToParent: 1
  offset: {x: 0, y: 0, z: 0}
```

## 📄 `Assets\Data\Feedback\Events\Enemy_Die.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-07 07:36

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
  m_Script: {fileID: 11500000, guid: 14d97b7dd6b915f47a904b3d56571d78, type: 3}
  m_Name: Enemy_Die
  m_EditorClassIdentifier: 
  commands:
  - {fileID: 11400000, guid: 2f5828803fa1ee747a9b1585bc26739a, type: 2}
```

## 📄 `Assets\Data\Narrative\Narrative_Main.asset`
- Lines: 34
- Size: 0.7 KB
- Modified: 2026-01-09 14:45

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
  m_Script: {fileID: 11500000, guid: 85c4d407bf1cf5440bbe715eb5977b09, type: 3}
  m_Name: Narrative_Main
  m_EditorClassIdentifier: 
  introLines:
  - Unauthorized Access
  - Security protocols engaging
  - Stay a while. Stay forever
  - What are you?
  hurtLines:
  - Bleed
  - Fragile
  - Yield
  killLines:
  - Unit lost
  - Ineficient
  - Freedom
  deathLines:
  - System purged
  - Die. Die. Die
  - Again
  - Ha. Ha. Ha
  victoryLines: []
```

## 📄 `Assets\Data\Player\Stats_Player_Default.asset`
- Lines: 41
- Size: 0.9 KB
- Modified: 2026-01-06 09:15

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
  deceleration: 40
  rotationSpeed: 25
  gravity: 20
  wallRepulsionForce: 100
  actionHangTime: 0.3
  scanRange: 25
  scanRadius: 2
  maxGrit: 3
  maxFocus: 100
  focusDecayRate: 5
  baseFocusOnKill: 30
  dashCost: 25
  dashDistance: 8
  dashCooldown: 0.15
  gunFireRate: 0.3
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

## 📄 `Assets\Data\Visuals\Collections\Collection_Anchors.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-06 09:15

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
  m_Name: Collection_Anchors
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 94ba67094e633924b819f87e8c71f644, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Enemies.asset`
- Lines: 18
- Size: 0.6 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\Visuals\Collections\Collection_Player_Beam.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-06 09:15

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
  m_Name: Collection_Player_Beam
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 5d5a22571b7839b45bc2241ed1188761, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Player_Core.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\Visuals\Collections\Collection_Void.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-06 09:15

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
  m_Name: Collection_Void
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: 233ba63db12e9814a8277c02e825374d, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Walls.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Data\Visuals\Palettes\Pal_Alternative.asset`
- Lines: 83
- Size: 2.5 KB
- Modified: 2026-01-06 09:15

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
  m_Name: Pal_Alternative
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
- Modified: 2026-01-06 09:15

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
  m_Name: Pal_Neon
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
- Lines: 116
- Size: 3.6 KB
- Modified: 2026-01-06 09:15

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
  m_Name: Pal_Nier
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
    mainColor: {r: 0.16660735, g: 0.9056604, b: 0.59294343, a: 1}
    smoothness: 0
    metallic: 0.7
    emissionColor: {r: 0.16470589, g: 0.90588236, b: 0.5921569, a: 1}
    emissionIntensity: 0.2
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
  beamAttack:
    mainColor: {r: 0.035899233, g: 0.02300641, b: 0.4433962, a: 0}
    smoothness: 0
    metallic: 0.3
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 1
  blitzReady:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  blitzCooldown:
    mainColor: {r: 0, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  hitFlashColor: {r: 1, g: 1, b: 1, a: 1}
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
  voidZone:
    mainColor: {r: 0.990566, g: 0.65881985, b: 0.65881985, a: 0.7058824}
    smoothness: 0.3
    metallic: 0.2
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  anchor:
    mainColor: {r: 0, g: 0.3962264, b: 0.18193561, a: 0}
    smoothness: 0.2
    metallic: 0.6
    emissionColor: {r: 0, g: 0.39607844, b: 0.18039216, a: 0}
    emissionIntensity: 0
  skyColor: {r: 0.01668743, g: 0.51363224, b: 0.7075472, a: 1}
  fogDensity: 0.0068
  variants: []
```

## 📄 `Assets\Data\Visuals\Palettes\Pal_Stranger.asset`
- Lines: 103
- Size: 3.2 KB
- Modified: 2026-01-06 09:15

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
  m_Name: Pal_Stranger
  m_EditorClassIdentifier: 
  playerPrimary:
    mainColor: {r: 0.14901961, g: 0.27058825, b: 0.45882353, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  playerSecondary:
    mainColor: {r: 1, g: 0.84313726, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  playerTertiary:
    mainColor: {r: 0.627451, g: 0.1254902, b: 0.9411765, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0.627451, g: 0.1254902, b: 0.9411765, a: 0}
    emissionIntensity: 3
  enemyPrimary:
    mainColor: {r: 0.56078434, g: 0.56078434, b: 0.56078434, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemySecondary:
    mainColor: {r: 0.1254902, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  enemyTertiary:
    mainColor: {r: 1, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 1, g: 0, b: 0, a: 0}
    emissionIntensity: 3
  projectileHostile:
    mainColor: {r: 1, g: 0.27058825, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 1, g: 0.27058825, b: 0, a: 0}
    emissionIntensity: 3
  projectileFriendly:
    mainColor: {r: 0.098002106, g: 0.4811321, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0.09803922, g: 0.48235294, b: 0, a: 0}
    emissionIntensity: 3
  beamAttack:
    mainColor: {r: 0, g: 0.0014649518, b: 0.2264151, a: 1}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  blitzReady:
    mainColor: {r: 0, g: 1, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 1, b: 0, a: 0}
    emissionIntensity: 2
  blitzCooldown:
    mainColor: {r: 0.19607843, g: 0.19607843, b: 0.19607843, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0, g: 0, b: 0, a: 0}
    emissionIntensity: 0
  hitFlashColor: {r: 0.3160377, g: 0.6067947, b: 1, a: 1}
  staggerColor: {r: 1.6862745, g: 1.6862745, b: 0, a: 1}
  floor:
    mainColor: {r: 0.101960786, g: 0.12156863, b: 0.16862746, a: 0}
    smoothness: 0.8
    metallic: 0
    emissionColor: {r: 0, g: 0.06666667, b: 0.2, a: 0}
    emissionIntensity: 0.5
  walls:
    mainColor: {r: 0.18039216, g: 0.16470589, b: 0.14509805, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 0.18039216, g: 0.16470589, b: 0.14509805, a: 0}
    emissionIntensity: 0
  hazards:
    mainColor: {r: 1, g: 0, b: 0, a: 0}
    smoothness: 0
    metallic: 0
    emissionColor: {r: 1, g: 0, b: 0, a: 0}
    emissionIntensity: 4
  skyColor: {r: 0.3962264, g: 0.07961101, b: 0.0018689969, a: 0.5882353}
  variants: []
```

## 📄 `Assets\Data\Visuals\Themes\Theme_Enemy_Default.asset`
- Lines: 27
- Size: 0.7 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2026-01-09 07:48

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
  - enemyPrefab: {fileID: 3473038045254472648, guid: fc07c4c7cd445f94580bcaad84f8c003,
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
- Modified: 2025-12-30 09:50

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
- Modified: 2026-01-09 07:48

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
  - enemyPrefab: {fileID: 3473038045254472648, guid: fc07c4c7cd445f94580bcaad84f8c003,
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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Modules\AI\Behaviours\AvoidanceBehavior.cs`
- Lines: 47
- Size: 1.7 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using DarkTowerTron.AI.Utils;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Avoidance", menuName = "DarkTowerTron/AI/Behaviors/Obstacle Avoidance")]
    public class AvoidanceBehavior : SteeringBehavior
    {
        public float avoidanceRadius = 2f;
        public float dangerWeight = 1f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // 1. Safety Check: Use data from the agent
            if (aiData.ownerCollider == null) return;

            // 2. Logic
            if (aiData.obstacles == null || aiData.obstacles.Count == 0) return;

            foreach (Collider obstacle in aiData.obstacles)
            {
                // FIX: Access the collider via aiData
                Vector3 closestPoint = aiData.ownerCollider.ClosestPoint(aiData.transform.position);

                Vector3 dirToObstacle = closestPoint - aiData.transform.position;
                dirToObstacle.y = 0;

                float distance = dirToObstacle.magnitude;

                if (distance > avoidanceRadius) continue;

                Vector3 dirNormalized = dirToObstacle.normalized;

                for (int i = 0; i < AIDirections.EightDirections.Count; i++)
                {
                    float dot = Vector3.Dot(dirNormalized, AIDirections.EightDirections[i]);
                    if (dot > 0.6f)
                    {
                        float weight = dangerWeight * (1 - (distance / avoidanceRadius));
                        if (weight > danger[i]) danger[i] = weight;
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Behaviours\FleeBehaviour.cs`
- Lines: 53
- Size: 1.9 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Flee", menuName = "DarkTowerTron/AI/Behaviors/Flee")]
    public class FleeBehavior : SteeringBehavior
    {
        [Tooltip("Enemy will only flee if target is closer than this distance.")]
        public float fleeDistance = 10f;

        [Tooltip("Strength of the flee desire (0 to 1).")]
        public float weight = 1.0f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Safety Check
            if (aiData.currentTarget == null) return;

            // 1. Calculate vector TO the target
            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0; // Keep it flat

            float distanceSqr = vectorToTarget.sqrMagnitude;

            // 2. Distance Check (Optimization)
            // If we are far enough away, we don't need to flee.
            if (distanceSqr > fleeDistance * fleeDistance) return;

            // 3. Calculate "Away" Direction
            Vector3 dirAway = -vectorToTarget.normalized;

            // 4. Map to 8 Directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: How well does this compass direction align with "Away"?
                float dot = Vector3.Dot(dirAway, AIDirections.EightDirections[i]);

                // We only care about directions that actually take us away (> 0)
                if (dot > 0)
                {
                    float value = dot * weight;

                    // If this behavior suggests a stronger interest than existing ones, override it
                    if (value > interest[i])
                    {
                        interest[i] = value;
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Behaviours\OrbitBehavior.cs`
- Lines: 56
- Size: 2.1 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Orbit", menuName = "DarkTowerTron/AI/Behaviors/Orbit")]
    public class OrbitBehavior : SteeringBehavior
    {
        [Header("Orbit Settings")]
        public float idealDistance = 7f;
        public float distanceCorrectionStrength = 0.5f; // How hard we push back/in
        public bool clockwise = true;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            if (aiData.currentTarget == null) return;

            // 1. Calculate Vectors
            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0; // Flatten
            float distance = vectorToTarget.magnitude;
            Vector3 dirToTarget = vectorToTarget.normalized;

            // 2. Calculate Tangent (The Orbit Direction)
            // Cross product of Up(0,1,0) and Forward gives Right
            Vector3 tangent = Vector3.Cross(Vector3.up, dirToTarget).normalized;
            if (!clockwise) tangent = -tangent;

            // 3. Calculate Correction (Push In or Pull Out)
            Vector3 correction = Vector3.zero;

            // Allow a "dead zone" of 1 unit where we just orbit purely
            if (distance > idealDistance + 1f)
            {
                correction = dirToTarget * distanceCorrectionStrength; // Move closer
            }
            else if (distance < idealDistance - 1f)
            {
                correction = -dirToTarget * distanceCorrectionStrength; // Back away
            }

            // 4. Combine
            Vector3 finalDir = (tangent + correction).normalized;

            // 5. Map to 8 Directions
            for (int i = 0; i < interest.Length; i++)
            {
                float dot = Vector3.Dot(finalDir, AIDirections.EightDirections[i]);
                if (dot > 0 && dot > interest[i])
                {
                    interest[i] = dot;
                }
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Behaviours\SeekBehaviour.cs`
- Lines: 40
- Size: 1.4 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Seek", menuName = "DarkTowerTron/AI/Behaviors/Seek")]
    public class SeekBehavior : SteeringBehavior
    {
        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Safety Check
            if (aiData.currentTarget == null) return;

            // 1. Calculate direction to target
            Vector3 directionToTarget = (aiData.currentTarget.position - aiData.transform.position);
            directionToTarget.y = 0; // Flatten (keep on ground plane)

            // Normalize
            directionToTarget.Normalize();

            // 2. Compare against our 8 compass directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: 1.0 = Perfect Alignment, 0.0 = 90 deg, -1.0 = Opposite
                float dot = Vector3.Dot(directionToTarget, AIDirections.EightDirections[i]);

                // We only care if the direction brings us closer (>0)
                if (dot > 0)
                {
                    // Apply interest
                    // We use the dot value directly (0 to 1) as the weight
                    if (dot > interest[i])
                    {
                        interest[i] = dot;
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Behaviours\VoidAvoidanceBehavior.cs`
- Lines: 42
- Size: 1.8 KB
- Modified: 2026-01-06 12:29

```csharp
using UnityEngine;
using DarkTowerTron.Core; // For GameConstants
using DarkTowerTron.AI.Utils; // For AIDirections

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_VoidAvoidance", menuName = "DarkTowerTron/AI/Behaviors/Void Avoidance")]
    public class VoidAvoidanceBehavior : SteeringBehavior
    {
        [Header("Settings")]
        public float lookAheadDistance = 2f;
        public float voidDangerWeight = 1f; // 1.0 means "Absolutely Not"

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Loop through all 8 generic directions (N, NE, E, SE, S, SW, W, NW)
            for (int i = 0; i < AIDirections.EightDirections.Count; i++)
            {
                Vector3 direction = AIDirections.EightDirections[i];

                // 1. Calculate where this direction takes us
                // We use the AI's current position + direction * distance
                // Note: AIDirections are usually local or world? Context steering usually uses World Space directions relative to the agent.
                // Assuming AIDirections are unit vectors.

                Vector3 checkPos = aiData.transform.position + (direction * lookAheadDistance);

                // 2. Check for Ground
                // Lift origin up slightly to ensure we cast downwards cleanly
                Vector3 rayOrigin = checkPos + Vector3.up * 2.0f;

                // 3. The Logic: If we DO NOT hit ground, it is DANGEROUS
                if (!UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, 10f, GameConstants.MASK_GROUND_ONLY))
                {
                    // VOID DETECTED!
                    // Set danger for this specific direction slot
                    danger[i] = voidDangerWeight;
                }
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Core\AIData.cs`
- Lines: 25
- Size: 0.7 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.AI.Core
{
    public class AIData : MonoBehaviour
    {
        [Header("Targets")]
        public Transform currentTarget;

        [Header("Dynamic Info (Read Only)")]
        public List<Transform> targets = new List<Transform>();
        public List<Collider> obstacles = new List<Collider>();

        // NEW: Cache the owner's collider here
        public Collider ownerCollider;

        private void Awake()
        {
            ownerCollider = GetComponent<Collider>();
        }

        public int GetTargetsCount() => targets != null ? targets.Count : 0;
    }
}
```

## 📄 `Assets\Modules\AI\Core\ContextSolver.cs`
- Lines: 82
- Size: 2.7 KB
- Modified: 2025-12-30 09:50

```csharp
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core
{
    [RequireComponent(typeof(AIData))]
    public class ContextSolver : MonoBehaviour
    {
        [Header("Settings")]
        public List<SteeringBehavior> behaviors;
        public List<Detector> detectors;

        [Header("Debug")]
        public bool showGizmos = true;

        private float[] _interestMap = new float[8];
        private float[] _dangerMap = new float[8];
        private AIData _aiData;
        private Collider _ownerCollider;

        private void Awake()
        {
            _aiData = GetComponent<AIData>();
            // Get the AI's own collider (usually on the root)
            _ownerCollider = GetComponent<Collider>();
        }

        public Vector3 GetDirectionToMove()
        {
            // SAFETY CHECK: If we are called before Awake or missing component
            if (_aiData == null) return transform.forward;

            // 1. Reset Maps
            System.Array.Clear(_interestMap, 0, 8);
            System.Array.Clear(_dangerMap, 0, 8);

            // 2. Run Detectors
            foreach (var detector in detectors)
            {
                // Extra safety check in case a detector slot is null in Inspector
                if (detector != null) detector.Detect(_aiData);
            }

            // 3. Run Behaviors
            foreach (var behavior in behaviors)
            {
                if (behavior != null) behavior.GetSteering(_interestMap, _dangerMap, _aiData);
            }

            // 4. Process Maps
            for (int i = 0; i < 8; i++)
            {
                if (_dangerMap[i] > 0)
                {
                    _interestMap[i] = Mathf.Clamp01(_interestMap[i] - _dangerMap[i]);
                }
            }

            // 5. Average
            Vector3 outputDirection = Vector3.zero;
            for (int i = 0; i < 8; i++)
            {
                outputDirection += AIDirections.EightDirections[i] * _interestMap[i];
            }

            return outputDirection.normalized;
        }

        private void OnDrawGizmos()
        {
            // STRICT SAFETY CHECKS FOR EDITOR GIZMOS
            if (!showGizmos) return;
            if (!Application.isPlaying) return; // Only draw when logic is actually running
            if (_aiData == null) return;        // Don't draw if not initialized

            Gizmos.color = Color.yellow;
            // This call was causing the crash because it ran when _aiData was null
            Gizmos.DrawRay(transform.position, GetDirectionToMove() * 2);
        }
    }
}
```

## 📄 `Assets\Modules\AI\Core\Detector.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;

namespace DarkTowerTron.AI.Core
{
    public abstract class Detector : MonoBehaviour
    {
        public abstract void Detect(AIData aiData);
    }
}
```

## 📄 `Assets\Modules\AI\Core\SteeringBehaviour.cs`
- Lines: 12
- Size: 0.3 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;

namespace DarkTowerTron.AI.Core
{
    public abstract class SteeringBehavior : ScriptableObject
    {
        // REMOVED: protected Collider ownerCollider;
        // REMOVED: public virtual void Initialize(...)

        public abstract void GetSteering(float[] interest, float[] danger, AIData aiData);
    }
}
```

## 📄 `Assets\Modules\AI\Detectors\ObstacleDetector.cs`
- Lines: 40
- Size: 1.2 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.AI.Detectors
{
    public class ObstacleDetector : Detector
    {
        [Header("Settings")]
        public float detectionRadius = 2f;
        public LayerMask obstacleMask;
        public bool showGizmos = true;

        // Optimization: Recycle this array to avoid Garbage Collection
        private Collider[] _colliders = new Collider[10];

        public override void Detect(AIData aiData)
        {
            // Clear previous data
            aiData.obstacles.Clear();

            // Find physics objects
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, detectionRadius, _colliders, obstacleMask);

            for (int i = 0; i < count; i++)
            {
                // Add to the data packet
                aiData.obstacles.Add(_colliders[i]);
            }
        }

        private void OnDrawGizmos()
        {
            if (showGizmos && Application.isPlaying)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(transform.position, detectionRadius);
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Detectors\TargetDetector.cs`
- Lines: 47
- Size: 1.5 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.AI.Detectors
{
    public class TargetDetector : Detector
    {
        [Header("Settings")]
        public float detectionRange = 20f;
        public LayerMask targetLayer; // Set to 'Player' and 'AfterImage'
        public bool showGizmos = false;

        private Collider[] _colliders = new Collider[5];

        public override void Detect(AIData aiData)
        {
            // 1. Find potential targets
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, detectionRange, _colliders, targetLayer);

            // 2. Logic: Pick the closest one
            float closestDist = float.MaxValue;
            Transform bestTarget = null;

            for (int i = 0; i < count; i++)
            {
                float dist = Vector3.SqrMagnitude(_colliders[i].transform.position - transform.position);
                if (dist < closestDist)
                {
                    closestDist = dist;
                    bestTarget = _colliders[i].transform;
                }
            }

            // 3. Output
            aiData.currentTarget = bestTarget;
        }

        private void OnDrawGizmos()
        {
            if (showGizmos && Application.isPlaying)
            {
                Gizmos.color = Color.magenta;
                Gizmos.DrawWireSphere(transform.position, detectionRange);
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Paths\AutoAssignPatrolPath.cs`
- Lines: 77
- Size: 2.4 KB
- Modified: 2026-01-09 13:59

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Enemy.Modules;

namespace DarkTowerTron.AI.Paths
{
    [RequireComponent(typeof(EnemyPatrolModule))]
    public class AutoAssignPatrolPath : MonoBehaviour
    {
        public bool autoFindNearest = true;
        public PatrolPath explicitPath;

        private void Start()
        {
            if (gameObject.scene.name == null) return;
            var patrolModule = GetComponent<EnemyPatrolModule>();

            if (explicitPath != null)
            {
                SetPath(patrolModule, explicitPath);
            }
            else if (autoFindNearest)
            {
                StartCoroutine(FindAndAssignPathRoutine(patrolModule));
            }
        }

        private IEnumerator FindAndAssignPathRoutine(EnemyPatrolModule module)
        {
            yield return null;
            PatrolPath nearest = FindNearestPath();
            if (nearest != null) SetPath(module, nearest);
        }

        private void SetPath(EnemyPatrolModule module, PatrolPath path)
        {
            if (module != null)
            {
                module.patrolPath = path;
                module.currentWaypointIndex = GetClosestWaypointIndex(path);
            }
        }

        private PatrolPath FindNearestPath()
        {
            var allPaths = FindObjectsOfType<PatrolPath>();
            if (allPaths.Length == 0) return null;

            PatrolPath best = null;
            float closestDist = float.MaxValue;

            foreach (var path in allPaths)
            {
                if (path.waypoints.Count > 0 && path.waypoints[0] != null)
                {
                    float d = Vector3.Distance(transform.position, path.waypoints[0].transform.position);
                    if (d < closestDist) { closestDist = d; best = path; }
                }
            }
            return best;
        }

        private int GetClosestWaypointIndex(PatrolPath path)
        {
            int bestIndex = 0;
            float closestDist = float.MaxValue;

            for (int i = 0; i < path.waypoints.Count; i++)
            {
                if (path.waypoints[i] == null) continue;
                float d = Vector3.Distance(transform.position, path.waypoints[i].transform.position);
                if (d < closestDist) { closestDist = d; bestIndex = i; }
            }
            return bestIndex;
        }
    }
}
```

## 📄 `Assets\Modules\AI\Paths\PatrolPath.cs`
- Lines: 28
- Size: 0.9 KB
- Modified: 2026-01-08 13:37

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.AI.Paths
{
    public class PatrolPath : MonoBehaviour
    {
        public List<Waypoint> waypoints;
        public bool loop = true;

        private void OnDrawGizmos()
        {
            if (waypoints == null || waypoints.Count < 2) return;

            Gizmos.color = Color.cyan;
            for (int i = 0; i < waypoints.Count - 1; i++)
            {
                if (waypoints[i] && waypoints[i + 1])
                    Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
            }

            if (loop && waypoints[0] && waypoints[waypoints.Count - 1])
            {
                Gizmos.DrawLine(waypoints[waypoints.Count - 1].transform.position, waypoints[0].transform.position);
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Paths\Waypoint.cs`
- Lines: 27
- Size: 0.6 KB
- Modified: 2026-01-09 13:25

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;

#if UNITY_EDITOR
using UnityEditor; // <--- WRAP THIS
#endif

namespace DarkTowerTron.AI.Paths
{
    public class Waypoint : MonoBehaviour
    {
        public float waitTime = 0f;
        public AIState overrideState;
        public float overrideDuration = 5f;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, 0.5f);

            // --- WRAP THE LABEL LOGIC ---
#if UNITY_EDITOR
            Handles.Label(transform.position + Vector3.up, name);
#endif
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Actions\Action_ContextSteering.cs`
- Lines: 41
- Size: 1.7 KB
- Modified: 2026-01-07 19:33

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.AI.Core; // For SteeringBehavior list
using System.Collections.Generic;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Move via Context Steering")]
    public class Action_ContextSteering : AIAction
    {
        [Header("Movement Profile")]
        public float speedMultiplier = 1.0f;

        [Header("Behaviors to Apply")]
        // We configure the specific steering behaviors HERE in the asset
        public List<SteeringBehavior> behaviors;

        public override void Act(PluggableAIController controller)
        {
            // 1. Inject Behaviors into the Solver
            // Optimization Note: Doing this every frame is wasteful if the list doesn't change.
            // A better way is to do this in "OnEnter State", but for simplicity/robustness:
            controller.blackboard.ContextSolver.behaviors = behaviors;

            // 2. Get Direction
            Vector3 dir = controller.blackboard.ContextSolver.GetDirectionToMove();

            // 3. Move via IMover interface
            // (Assuming EnemyStats logic is handled inside the IMover or passed here. 
            // For now, let's assume the controller's Motor handles the base speed from StatsSO)
            controller.blackboard.Mover.Move(dir * speedMultiplier);

            // 4. Face Movement
            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, targetRot, 10f * Time.deltaTime);
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Actions\Action_FirePattern.cs`
- Lines: 35
- Size: 1.1 KB
- Modified: 2026-01-08 23:36

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Core.Data; // For EnemyAttackSO & AttackPatternSO
using DarkTowerTron.Enemy;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Combat/Fire Pattern")]
    public class Action_FirePattern : AIAction
    {
        [Header("The Shape")]
        public AttackPatternSO pattern;

        [Header("The Payload")]
        public EnemyAttackSO attackStats; // <--- REPLACES 'projectilePrefab'

        public override void Act(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return;

            // 1. Face the Target
            if (controller.blackboard.Mover is EnemyMotor motor)
            {
                motor.FaceCombatTarget(controller.blackboard.Target.position);
            }

            // 2. Fire
            if (controller.blackboard.Weapon != null)
            {
                // Pass BOTH config objects to the weapon
                controller.blackboard.Weapon.Fire(pattern, attackStats, controller.blackboard.Target);
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Actions\Action_Patrol.cs`
- Lines: 52
- Size: 1.9 KB
- Modified: 2026-01-09 14:00

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Enemy.Modules;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Move/Patrol")]
    public class Action_Patrol : AIAction
    {
        public float waypointTolerance = 1.0f;
        public float speedMultiplier = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            var patrol = controller.GetComponent<EnemyPatrolModule>();
            if (patrol == null || patrol.patrolPath == null) return;

            Transform targetPoint = patrol.GetCurrentWaypointTarget();
            if (targetPoint == null) return;

            // 1. Calculate Flat Distance
            Vector3 flatPos = controller.transform.position; flatPos.y = 0;
            Vector3 flatTarget = targetPoint.position; flatTarget.y = 0;
            if (Vector3.Distance(flatPos, flatTarget) < waypointTolerance)
            {
                patrol.AdvanceWaypoint();

                Transform nextPoint = patrol.GetCurrentWaypointTarget();
                if (nextPoint != null) MoveTowards(controller, nextPoint.position);
            }
            else
            {
                // 3. Keep Moving
                MoveTowards(controller, targetPoint.position);
            }
        }

        private void MoveTowards(PluggableAIController controller, Vector3 targetPos)
        {
            Vector3 dir = (targetPos - controller.transform.position).normalized;
            controller.blackboard.Mover.Move(dir * speedMultiplier);

            // Store in blackboard for Debugger visualization
            controller.blackboard.MoveDirection = dir;

            if (controller.blackboard.Mover is DarkTowerTron.Enemy.EnemyMotor motor)
            {
                motor.FaceTarget(targetPos);
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Actions\Action_SelfDestruct.cs`
- Lines: 51
- Size: 1.9 KB
- Modified: 2026-01-07 19:45

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Core; // For DamageInfo/GameConstants
using DarkTowerTron.Core.Feedback; // For Juice

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Combat/Self Destruct")]
    public class Action_SelfDestruct : AIAction
    {
        [Header("Explosion Stats")]
        public float radius = 2.0f;
        public float damage = 10f;
        public float knockback = 20f;

        [Header("Juice")]
        public FeedbackConfigurationSO explosionFeedback;

        public override void Act(PluggableAIController controller)
        {
            // 1. Play Feedback (Sound/VFX)
            if (explosionFeedback)
                explosionFeedback.Play(null, controller.transform.position);

            // 2. Find Targets
            // We use OverlapSphere to hit player OR other enemies (if friendly fire)
            int mask = LayerMask.GetMask("Player"); // Or use GameConstants
            Collider[] hits = UnityEngine.Physics.OverlapSphere(controller.transform.position, radius, mask);

            foreach (var hit in hits)
            {
                IDamageable target = hit.GetComponentInParent<IDamageable>();
                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = (hit.transform.position - controller.transform.position).normalized,
                        pushForce = knockback,
                        source = controller.gameObject,
                        damageType = DamageType.Explosion
                    };
                    target.TakeDamage(info);
                }
            }

            // 3. Die (No Reward, because it exploded itself)
            controller.blackboard.Controller.SelfDestruct();
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Actions\Action_Visual_Prime.cs`
- Lines: 25
- Size: 0.8 KB
- Modified: 2026-01-08 06:42

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DG.Tweening; // For the shake

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Visuals/Prime Effect")]
    public class Action_Visual_Prime : AIAction
    {
        public float shakeDuration = 0.5f;
        public float shakeStrength = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            // 1. Visual Color Flash (Using the System we built in Phase 2)
            if (controller.blackboard.Controller.Visuals != null)
            {
                controller.blackboard.Controller.Visuals.StartPrimingEffect();
            }

            // 2. Physical Shake
            controller.transform.DOShakeScale(shakeDuration, shakeStrength, 20, 90);
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Core\AIAction.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2026-01-07 19:32

```csharp
using UnityEngine;

namespace DarkTowerTron.AI.Pluggable.Core
{
    public abstract class AIAction : ScriptableObject
    {
        public abstract void Act(PluggableAIController controller);
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Core\AIBlackboard.cs`
- Lines: 28
- Size: 0.8 KB
- Modified: 2026-01-09 13:58

```csharp
using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.AI.Core;
using DarkTowerTron.Enemy;
// REMOVED: using DarkTowerTron.AI.Paths; 

namespace DarkTowerTron.AI.Pluggable.Core
{
    [System.Serializable]
    public class AIBlackboard
    {
        [Header("Runtime Data")]
        public Transform Target;
        public Vector3 MoveDirection;
        public float StateTimeElapsed;

        // Component Cache (The "Universal" Body)
        public IMover Mover;
        public ContextSolver ContextSolver;
        public DamageReceiver Health;
        public EnemyController Controller;
        public PatternExecutor Weapon; // Optional but common enough to keep

        // REMOVED: public PatrolPath patrolPath;
        // REMOVED: public int currentWaypointIndex;
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Core\AIDecision.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2026-01-07 19:32

```csharp
using UnityEngine;

namespace DarkTowerTron.AI.Pluggable.Core
{
    public abstract class AIDecision : ScriptableObject
    {
        public abstract bool Decide(PluggableAIController controller);
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Core\AIState.cs`
- Lines: 76
- Size: 2.3 KB
- Modified: 2026-01-08 06:41

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.AI.Pluggable.Core
{
    [CreateAssetMenu(menuName = "AI/Pluggable/State")]
    public class AIState : ScriptableObject
    {
        [Header("Run Once (On Enter)")]
        public List<AIAction> onEnterActions;

        [Header("Run Every Frame")]
        public List<AIAction> actions;
        public List<Transition> transitions;

        public void EnterState(PluggableAIController controller)
        {
            if (onEnterActions == null || onEnterActions.Count == 0) return;

            for (int i = 0; i < onEnterActions.Count; i++)
            {
                var action = onEnterActions[i];
                if (action == null) continue;
                action.Act(controller);
            }
        }

        public void UpdateState(PluggableAIController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }

        private void DoActions(PluggableAIController controller)
        {
            if (actions == null || actions.Count == 0) return;

            for (int i = 0; i < actions.Count; i++)
            {
                var action = actions[i];
                if (action == null) continue;
                action.Act(controller);
            }
        }

        private void CheckTransitions(PluggableAIController controller)
        {
            if (transitions == null || transitions.Count == 0) return;

            for (int i = 0; i < transitions.Count; i++)
            {
                var transition = transitions[i];
                if (transition.decision == null) continue;

                bool decisionSucceeded = transition.decision.Decide(controller);

                if (decisionSucceeded)
                {
                    controller.TransitionToState(transition.trueState);
                }
                else
                {
                    controller.TransitionToState(transition.falseState);
                }
            }
        }
    }

    [System.Serializable]
    public struct Transition
    {
        public AIDecision decision;
        public AIState trueState;
        public AIState falseState; // Usually "RemainState"
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Core\PluggableAIController.cs`
- Lines: 136
- Size: 4.7 KB
- Modified: 2026-01-09 14:02

```csharp
using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.Paths;
using DarkTowerTron.Enemy; // For EnemyController

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.AI.Pluggable.Core
{
    [RequireComponent(typeof(IMover))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(EnemyController))]
    public class PluggableAIController : MonoBehaviour
    {
        [Header("Configuration")]
        public AIState currentState;
        public AIState remainState; // Special "Do Nothing" state marker

        [Header("Setup")]
        [Tooltip("Optional. If empty, auto-searches for a PatternExecutor on self/children.")]
        public PatternExecutor specificWeapon;

        [Header("Debug")]
        public bool aiActive = true;
        public AIBlackboard blackboard; // Exposed for Inspector debugging

        private void Awake()
        {
            blackboard ??= new AIBlackboard();

            // The AI needs a mover. EnemyMotor is the preferred component for full AI behavior.
            // A fallback to other movers might result in simplified or incorrect behavior.
            var motor = GetComponent<EnemyMotor>();
            if (motor != null)
            {
                blackboard.Mover = motor;
            }
            else
            {
                // Fallback to any IMover, which is guaranteed by [RequireComponent]
                var mover = GetComponent<IMover>();
                blackboard.Mover = mover;
                Debug.LogWarning($"[AI Setup] {name} is using a fallback mover '{mover.GetType().Name}'. " +
                                 "This may cause unintended behavior. Consider adding an 'EnemyMotor' component for full AI capabilities.", gameObject);
            }

            blackboard.ContextSolver = GetComponent<ContextSolver>();
            blackboard.Health = GetComponent<DamageReceiver>();
            blackboard.Controller = GetComponent<EnemyController>();

            // --- WEAPON SETUP ---
            if (specificWeapon != null)
            {
                blackboard.Weapon = specificWeapon;
            }
            else
            {
                blackboard.Weapon = GetComponent<PatternExecutor>();
                if (blackboard.Weapon == null)
                {
                    // Auto-add if missing (Fire and Forget)
                    blackboard.Weapon = gameObject.AddComponent<PatternExecutor>();
                    // PatternExecutor requires FirePointRegistry; Unity will add it due to [RequireComponent]
                }
            }
        }

        private void Start()
        {
            // Find Player (using Service Locator logic ideally, or global find for now)
            if (DarkTowerTron.Core.GameServices.Player != null)
                blackboard.Target = DarkTowerTron.Core.GameServices.Player.transform;

            // Setup ContextSolver target
            if (blackboard.ContextSolver != null)
            {
                var aiData = GetComponent<AIData>();
                if (aiData) aiData.currentTarget = blackboard.Target;
            }

            if (currentState != null)
            {
                blackboard.StateTimeElapsed = 0f;
                currentState.EnterState(this);
            }
        }

        private void Update()
        {
            if (!aiActive || blackboard.Controller.IsStaggered) return;

            blackboard.StateTimeElapsed += Time.deltaTime;
            if (currentState != null)
            {
                currentState.UpdateState(this);
            }
        }

        public void TransitionToState(AIState nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
                blackboard.StateTimeElapsed = 0f;

                // --- NEW: Execute OnEnter Actions ---
                if (currentState != null && currentState.onEnterActions != null)
                {
                    for (int i = 0; i < currentState.onEnterActions.Count; i++)
                    {
                        var action = currentState.onEnterActions[i];
                        if (action == null) continue;
                        action.Act(this);
                    }
                }
            }
        }


        // Draw Gizmos to see current state in Scene View
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (currentState != null)
            {
                Gizmos.color = Color.green;
                Handles.Label(transform.position + Vector3.up * 2.5f, $"State: {currentState.name}");
            }
        }
#endif
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Decisions\Decision_InRange.cs`
- Lines: 30
- Size: 0.9 KB
- Modified: 2026-01-08 07:09

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;

namespace DarkTowerTron.AI.Pluggable.Decisions
{
    [CreateAssetMenu(menuName = "AI/Decisions/In Range")]
    public class Decision_InRange : AIDecision
    {
        public float range = 1.5f;

        public override bool Decide(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return false;

            // 1. Get Positions
            Vector3 myPos = controller.transform.position;
            Vector3 targetPos = controller.blackboard.Target.position;

            // 2. Flatten Y (Ignore Height)
            // This turns the check from a Sphere into a Cylinder (Infinite height)
            myPos.y = 0;
            targetPos.y = 0;

            // 3. Compare Squared Distance (Optimization)
            float distSqr = (myPos - targetPos).sqrMagnitude;

            return distSqr < (range * range);
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Decisions\Decision_LineOfSight.cs`
- Lines: 33
- Size: 1.0 KB
- Modified: 2026-01-08 07:17

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Core; // GameConstants

namespace DarkTowerTron.AI.Pluggable.Decisions
{
    [CreateAssetMenu(menuName = "AI/Decisions/Line Of Sight")]
    public class Decision_LineOfSight : AIDecision
    {
        public float range = 15f;
        public LayerMask blockLayer;

        public override bool Decide(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return false;

            Vector3 eyePos = controller.transform.position + Vector3.up * 1.0f;
            Vector3 targetPos = controller.blackboard.Target.position + Vector3.up * 1.0f;
            Vector3 dir = targetPos - eyePos;
            float dist = dir.magnitude;

            if (dist > range) return false;

            // Check if wall is in between
            if (UnityEngine.Physics.Raycast(eyePos, dir, dist, blockLayer))
            {
                return false; // Hit a wall
            }

            return true; // Clear shot
        }
    }
}
```

## 📄 `Assets\Modules\AI\Pluggable\Decisions\Decision_TimeElapsed.cs`
- Lines: 16
- Size: 0.4 KB
- Modified: 2026-01-07 19:33

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;

namespace DarkTowerTron.AI.Pluggable.Decisions
{
    [CreateAssetMenu(menuName = "AI/Decisions/Time Elapsed")]
    public class Decision_TimeElapsed : AIDecision
    {
        public float duration = 2.0f;

        public override bool Decide(PluggableAIController controller)
        {
            return controller.blackboard.StateTimeElapsed >= duration;
        }
    }
}
```

## 📄 `Assets\Modules\AI\Utils\AIDebugger.cs`
- Lines: 79
- Size: 2.9 KB
- Modified: 2026-01-09 14:01

```csharp
using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Enemy;
using DarkTowerTron.Enemy.Modules;

namespace DarkTowerTron.AI.Utils
{
    [ExecuteAlways]
    public class AIDebugger : MonoBehaviour
    {
        [Header("Settings")]
        public bool showGizmos = true;
        public float lineScale = 2.0f;

        [Header("References")]
        public PluggableAIController controller;
        public EnemyMotor motor;

        private void OnEnable()
        {
            if (controller == null) controller = GetComponent<PluggableAIController>();
            if (motor == null) motor = GetComponent<EnemyMotor>();
        }

        private void OnDrawGizmos()
        {
            if (!showGizmos || Application.isPlaying == false) return;

            Vector3 pos = transform.position + Vector3.up * 1.0f; // Lift up to see better

            // 1. Draw ACTUAL Velocity (Green) - Where we are actually going
            if (motor != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawRay(pos, motor.Velocity.normalized * lineScale);
                // Draw arrow head
                Vector3 velTip = pos + motor.Velocity.normalized * lineScale;
                Gizmos.DrawSphere(velTip, 0.1f);
            }

            // 2. Draw LOGIC Intent (Yellow) - Where the Blackboard says we should go
            if (controller != null && controller.blackboard != null)
            {
                // Note: You need to ensure your Actions actually write to 'MoveDirection' in Blackboard
                // Currently Action_Patrol calculates it locally. We should fix that.
                /* 
                Gizmos.color = Color.yellow;
                Gizmos.DrawRay(pos, controller.blackboard.MoveDirection * lineScale * 0.8f);
                */
            }

            // 3. Draw TARGET Line (Red)
            if (controller != null && controller.blackboard != null)
            {
                // Target Entity
                if (controller.blackboard.Target != null)
                {
                    Gizmos.color = Color.red;
                    Gizmos.DrawLine(pos, controller.blackboard.Target.position);
                }
                // Patrol Target
                else
                {
                    var patrol = controller.GetComponent<EnemyPatrolModule>();
                    if (patrol != null)
                    {
                        Transform wp = patrol.GetCurrentWaypointTarget();
                        if (wp != null)
                        {
                            Gizmos.color = new Color(1, 0.5f, 0); // Orange
                            Gizmos.DrawLine(pos, wp.position);
                            Gizmos.DrawWireSphere(wp.position, 0.5f);
                        }
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\Modules\AI\Utils\AIDirections.cs`
- Lines: 20
- Size: 0.7 KB
- Modified: 2025-12-30 09:50

```csharp
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.AI.Utils
{
    public static class AIDirections
    {
        public static List<Vector3> EightDirections = new List<Vector3>
        {
            new Vector3(0,0,1).normalized,   // 0: North
            new Vector3(1,0,1).normalized,   // 1: NorthEast
            new Vector3(1,0,0).normalized,   // 2: East
            new Vector3(1,0,-1).normalized,  // 3: SouthEast
            new Vector3(0,0,-1).normalized,  // 4: South
            new Vector3(-1,0,-1).normalized, // 5: SouthWest
            new Vector3(-1,0,0).normalized,  // 6: West
            new Vector3(-1,0,1).normalized   // 7: NorthWest
        };
    }
}
```

## 📄 `Assets\Scripts\Combat\BaseHitbox.cs`
- Lines: 44
- Size: 1.3 KB
- Modified: 2026-01-08 18:24

```csharp
using DarkTowerTron.Core;
using UnityEngine;

namespace DarkTowerTron.Combat
{
    public abstract class BaseHitbox : MonoBehaviour, IDamageable
    {
        // CHANGED: Use Interface, not concrete class
        protected IDamageable _damageableParent;

        protected virtual void Awake()
        {
            // Auto-link: Look for ANY damageable component in parents
            // BUT ensure we don't grab ourselves!
            if (_damageableParent != null) return;

            var damageables = GetComponentsInParent<IDamageable>();
            for (int i = 0; i < damageables.Length; i++)
            {
                var d = damageables[i];
                if (d == null) continue;

                // Skip self (this hitbox also implements IDamageable)
                if (ReferenceEquals(d, this)) continue;

                _damageableParent = d;
                break;
            }
        }

        public virtual bool TakeDamage(DamageInfo info)
        {
            // Forward damage to the main health component
            if (_damageableParent != null)
                return _damageableParent.TakeDamage(info);
            return true;
        }

        public virtual void Kill(bool instant)
        {
            if (_damageableParent != null) _damageableParent.Kill(instant);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\ContactDamager.cs`
- Lines: 53
- Size: 1.7 KB
- Modified: 2026-01-09 07:04

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;


namespace DarkTowerTron.Combat
{
    public class ContactDamager : MonoBehaviour
    {
        public float damage = 1f;
        public float pushForce = 10f;
        public float damageCooldown = 1.0f;
        public bool destroySelfOnHit = false; // Turn on for Kamikaze units

        private float _lastHitTime;

        private void OnTriggerStay(Collider other)
        {

            GameLogger.Log(LogChannel.Combat, $"ContactDamager triggered with {other.name}", gameObject);

            if (Time.time < _lastHitTime + damageCooldown) return;

            // Check Tag (Optimization)
            if (!other.CompareTag(GameConstants.TAG_PLAYER)) return;

            IDamageable target = other.GetComponentInParent<IDamageable>();
            if (target != null)
            {
                Vector3 pushDir = (other.transform.position - transform.position).normalized;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = damage,
                    pushDirection = pushDir,
                    pushForce = pushForce,
                    source = gameObject,
                    damageType = DamageType.Melee
                };

                if (target.TakeDamage(info))
                {
                    _lastHitTime = Time.time;
                    if (destroySelfOnHit)
                    {
                        var health = GetComponent<IDamageable>();
                        if (health != null) health.Kill(false);
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\DamageReceiver.cs`
- Lines: 210
- Size: 7.1 KB
- Modified: 2026-01-09 13:26

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Managers;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(VitalityModule))]
    [RequireComponent(typeof(StaggerModule))]
    public class DamageReceiver : MonoBehaviour, IDamageable, IPoolable, ICombatTarget, IAimTarget
    {
        // --- DEBUG SWITCH ---
        public static bool EnableDebugGizmos = false;

        [Header("Override")]
        public bool useOverrides = false;
        [SerializeField] private float _overrideHealth = 50f;
        [SerializeField] private int _overrideStagger = 3;

        [Header("Aiming Configuration")]
        [Tooltip("Assign a child object (e.g. 'CenterMass') to act as the lock-on target.")]
        [SerializeField] private Transform _aimTarget;
        [SerializeField] private float _magnetismRadius = 0.75f;

        [Header("Execution Settings")]
        [SerializeField] private bool _keepPlayerGrounded = true; // Default True for Enemies

        [Header("Juice")]
        [Tooltip("Played when taking damage (Health or Shield).")]
        [SerializeField] private FeedbackConfigurationSO _hitFeedback;

        [Tooltip("Played when Health reaches zero.")]
        [SerializeField] private FeedbackConfigurationSO _deathFeedback;

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

            if (_hitFeedback != null) _hitFeedback.Play(gameObject, transform.position);

            OnHitProcessed?.Invoke(info);
            return true;
        }

        public void Kill(bool rewardPlayer)
        {
            if (IsDead) return;

            if (_deathFeedback != null) _deathFeedback.Play(gameObject, transform.position);
            
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
        public bool KeepPlayerGrounded => _keepPlayerGrounded;

        // --- IAimTarget ---
        public Vector3 AimPoint
        {
            get
            {
                // Robust Fallback: If designer forgot to assign, guess Chest Height
                if (_aimTarget == null) return transform.position + Vector3.up * 1.0f;
                return _aimTarget.position;
            }
        }
        public float TargetRadius => _magnetismRadius;

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
            Handles.Label(labelPos, label, style);
        }
#endif
    }
}
```

## 📄 `Assets\Scripts\Combat\FirePointRegistry.cs`
- Lines: 61
- Size: 1.8 KB
- Modified: 2026-01-08 16:48

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Combat
{
    public class FirePointRegistry : MonoBehaviour
    {
        [System.Serializable]
        public struct NamedPoint
        {
            public string id;
            public Transform point;
        }

        [Header("Configuration")]
        [Tooltip("If empty, auto-collects children starting with 'FirePoint_'.")]
        public List<NamedPoint> points = new List<NamedPoint>();

        private Dictionary<string, Transform> _lookup = new Dictionary<string, Transform>();

        private void Awake()
        {
            // 1. Load Manual Assignments
            foreach (var p in points)
            {
                if (!string.IsNullOrEmpty(p.id) && p.point != null)
                    _lookup[p.id] = p.point;
            }

            // 2. Auto-Discovery (Naming Convention: "FirePoint_Muzzle")
            var children = GetComponentsInChildren<Transform>(true);
            foreach (var t in children)
            {
                if (t.name.StartsWith("FirePoint_"))
                {
                    string id = t.name.Replace("FirePoint_", ""); // "Muzzle"
                    if (!_lookup.ContainsKey(id))
                    {
                        _lookup.Add(id, t);
                    }
                }
            }

            // 3. Fallback "Default"
            if (!_lookup.ContainsKey("Default"))
            {
                _lookup["Default"] = transform;
            }
        }

        public Transform GetPoint(string id)
        {
            if (string.IsNullOrEmpty(id)) id = "Default";

            if (_lookup.TryGetValue(id, out Transform t)) return t;

            // Graceful failure
            return _lookup["Default"];
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HazardZone.cs`
- Lines: 91
- Size: 3.0 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core;
using DG.Tweening;
using UnityEngine;

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
- Lines: 152
- Size: 4.8 KB
- Modified: 2026-01-09 13:53

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DG.Tweening;
using UnityEngine;
using DarkTowerTron;

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
        [ColorUsage(true, true)] public Color hotColor = new Color(1f, 0.3f, 0f);

        [Header("Feedback")]
        [SerializeField] private PopupTextEventChannelSO _popupEvent;
        public AudioClip breakClip;

        private float _currentHeat;
        private float _lastHitTime;

        // Optimization: Property Block
        private MaterialPropertyBlock _propBlock;
        private int _baseColorID;
        private int _emissionColorID;

        protected override void Awake()
        {
            base.Awake(); // Sets up _damageableParent

            _propBlock = new MaterialPropertyBlock();
            _baseColorID = Shader.PropertyToID("_BaseColor");
            _emissionColorID = Shader.PropertyToID("_EmissionColor");
        }

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
            // FIX: Use the Interface reference from BaseHitbox
            if (_damageableParent == null) return false;

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

                        // CRITICAL FIX: Claim ownership so the bullet doesn't hit us again instantly
                        proj.SetSource(this.gameObject);

                        _popupEvent?.Raise(transform.position, "REFLECT");
                        return true;
                    }
                }

                _popupEvent?.Raise(transform.position, "DEFLECT");
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
                    _popupEvent?.Raise(transform.position, "ARMORED");
                    return false;
                }
            }

            return base.TakeDamage(info);
        }

        private void BreakShield()
        {
            isBroken = true;
            if (shieldRenderer) shieldRenderer.enabled = false;

            _popupEvent?.Raise(transform.position, "SHATTERED");

            if (Global.Audio != null && breakClip)
                Global.Audio.PlaySound(breakClip, 1.0f);
        }

        private void UpdateVisuals()
        {
            if (shieldRenderer)
            {
                float t = Mathf.Clamp01(_currentHeat / maxHeat);
                Color c = Color.Lerp(coldColor, hotColor, t);
                Color e = Color.Lerp(coldColor, hotColor, t) * (1 + t * 2);

                // Use Property Block to avoid creating Material Instances
                shieldRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_baseColorID, c);
                _propBlock.SetColor(_emissionColorID, e);
                shieldRenderer.SetPropertyBlock(_propBlock);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\HitBox\StandardHitbox.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2026-01-06 09:15

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

## 📄 `Assets\Scripts\Combat\Modules\StaggerModule.cs`
- Lines: 79
- Size: 2.2 KB
- Modified: 2026-01-06 09:15

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
- Modified: 2026-01-06 09:15

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

## 📄 `Assets\Scripts\Combat\PatternExecutor.cs`
- Lines: 132
- Size: 4.5 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(FirePointRegistry))]
    public class PatternExecutor : MonoBehaviour
    {
        private FirePointRegistry _registry;
        private bool _isFiring;

        // Exposed for AI Decision making
        public bool IsFiring => _isFiring;

        private void Awake()
        {
            _registry = GetComponent<FirePointRegistry>();
        }

        public bool Fire(AttackPatternSO pattern, EnemyAttackSO stats, Transform target)
        {
            if (_isFiring) return false; // Busy
            if (pattern == null || stats == null || stats.projectilePrefab == null) return false;

            StartCoroutine(ExecuteRoutine(pattern, stats, target));
            return true;
        }

        public void StopFiring()
        {
            StopAllCoroutines();
            _isFiring = false;
        }

        private IEnumerator ExecuteRoutine(AttackPatternSO pattern, EnemyAttackSO stats, Transform target)
        {
            _isFiring = true;

            // 1. Resolve Fire Point
            Transform firePoint = _registry.GetPoint(pattern.firePointID);

            // 2. Resolve Smart Aim Target (Optimization: Check once per burst)
            IAimTarget aimTarget = null;
            if (target != null)
            {
                aimTarget = target.GetComponent<IAimTarget>();
                if (aimTarget == null) aimTarget = target.GetComponentInChildren<IAimTarget>();
            }

            // 3. Windup
            yield return new WaitForSeconds(pattern.startDelay);

            // 4. Burst Loop
            float spinOffset = 0f;

            for (int i = 0; i < pattern.projectileCount; i++)
            {
                // Dynamic Aim Calculation per shot (Tracks moving player)
                Vector3 aimDir = firePoint.forward;

                if (pattern.aimMode == AimType.TargetPlayer && target != null)
                {
                    Vector3 targetPos;

                    // --- SMART AIM LOGIC ---
                    if (aimTarget != null)
                    {
                        targetPos = aimTarget.AimPoint;
                    }
                    else
                    {
                        // Fallback: Guess center mass
                        targetPos = target.position + Vector3.up;
                    }
                    // -----------------------

                    aimDir = (targetPos - firePoint.position).normalized;
                }

                // Apply Spin
                if (pattern.spinDuringFire)
                {
                    spinOffset += pattern.spinSpeed * pattern.delayBetweenShots; // Increment spin
                    aimDir = Quaternion.Euler(0, spinOffset, 0) * aimDir;
                }

                // Apply Spread (Random noise)
                float totalSpread = pattern.spreadAngle + stats.spreadAngle;
                if (totalSpread > 0)
                {
                    float noise = Random.Range(-totalSpread / 2f, totalSpread / 2f);
                    aimDir = Quaternion.Euler(0, noise, 0) * aimDir;
                }

                SpawnProjectile(pattern, stats, firePoint.position, aimDir);

                if (pattern.delayBetweenShots > 0)
                    yield return new WaitForSeconds(pattern.delayBetweenShots);
            }

            // 5. Cooldown
            yield return new WaitForSeconds(pattern.cooldownAfterBurst);

            _isFiring = false;
        }

        private void SpawnProjectile(AttackPatternSO pattern, EnemyAttackSO stats, Vector3 pos, Vector3 dir)
        {
            if (Global.Pool == null) return;

            GameObject p = Global.Pool.Spawn(stats.projectilePrefab, pos, Quaternion.LookRotation(dir));
            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);

                proj.damage = stats.damage;
                proj.stagger = stats.stagger;

                // Prefer stats as the source of truth for ballistics; fallback to pattern if needed.
                proj.speed = stats.projectileSpeed > 0 ? stats.projectileSpeed : pattern.speed;
                if (stats.lifetime > 0) proj.lifetime = stats.lifetime;

                proj.SetSource(gameObject); // Ignore self
                proj.Initialize(dir);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Projectile.cs`
- Lines: 283
- Size: 10.3 KB
- Modified: 2026-01-09 13:53

```csharp
using System.Collections.Generic;
using DarkTowerTron.Combat.Strategies;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Feedback;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Ballistics")]
        public float speed = 25f;
        public float lifetime = 5f;
        public bool isHostile = true;
        
        [Header("Damage")]
        public float damage = 10f;
        public int stagger = 1;
        public DamageType damageType = DamageType.Projectile;

        [Header("Juice")]
        public FeedbackConfigurationSO spawnFeedback;
        public FeedbackConfigurationSO impactFeedback;

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial; 
        public Material hostileMaterial; 

        private Vector3 _direction; 
        private GameObject _source;
        private IMovementStrategy _movementStrategy;
        
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private float _lifeTimer;
        private bool _wasDeflectedThisFrame = false;
        private List<Collider> _ignoredColliders = new List<Collider>();

        public void OnSpawn()
        {
            // LOG 1: Check initial state coming out of pool
            GameLogger.Log(LogChannel.Combat, $"[PROJ] OnSpawn - Pos: {transform.position} | Active: {gameObject.activeSelf}", gameObject);

            // 1. SAFE PHYSICS RESET
            if (TryGetComponent(out Rigidbody rb))
            {
                // Only reset velocity if the body is NOT Kinematic
                // (Kinematic bodies are moved by transform, so velocity doesn't apply)
                if (!rb.isKinematic)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                    rb.Sleep();
                }
                else
                {
                    // Verify if we are kinematic
                    GameLogger.Log(LogChannel.Combat, "[PROJ] Body is Kinematic. Skipping velocity reset.", gameObject);
                }
            }

            // 2. RESET TRAILS
            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.emitting = false;
                trail.Clear();
                GameLogger.Log(LogChannel.Combat, "[PROJ] Trail Cleared.", gameObject);
            }

            // 3. Play spawn feedback
            if (spawnFeedback != null) spawnFeedback.Play(gameObject, transform.position);
        }

        public void OnDespawn() 
        {
            // 1. Clean up Physics (CRITICAL for Pooling)
            ResetIgnoredColliders();

            // 2. Reset Logic
            _isInitialized = false;
            _movementStrategy = null; 
            _source = null;
            isHostile = true; // Reset default hostility
        }

        public void Initialize(Vector3 dir)
        {
            // LOG 2: Check state right before moving
            GameLogger.Log(LogChannel.Combat, $"[PROJ] Initialize - Dir: {dir} | StartPos: {transform.position}", gameObject);

            if (_movementStrategy == null) SetStrategy(new LinearMovement());

            _direction = dir.normalized;
            _movementStrategy.Initialize(transform, _direction, speed);

            _isInitialized = true;
            _lifeTimer = lifetime;
            _isRedirected = false;
            
            UpdateVisuals();

            // 4. RE-ENABLE TRAIL (The second half of the fix)
            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.Clear();
                trail.emitting = true;
                GameLogger.Log(LogChannel.Combat, "[PROJ] Trail Restarted.", gameObject);
            }
        }

        public void SetStrategy(IMovementStrategy strategy) => _movementStrategy = strategy;
        
        public void SetSource(GameObject source)
        {
            _source = source;
            
            // 1. Reset previous ignores (Safety if reused without Despawn)
            ResetIgnoredColliders();

            if (_source != null)
            {
                Collider myCol = GetComponent<Collider>();
                Collider[] sourceCols = _source.GetComponentsInChildren<Collider>();

                foreach (Collider c in sourceCols)
                {
                    // CRITICAL: Don't ignore triggers (like detection zones), only physical blockers
                    if (!c.isTrigger) 
                    {
                        UnityEngine.Physics.IgnoreCollision(myCol, c, true);
                        _ignoredColliders.Add(c); // Remember this so we can undo it
                    }
                }
            }
        }
        
        public void ResetHostility(bool startHostile) { isHostile = startHostile; UpdateVisuals(); }

        private void ResetIgnoredColliders()
        {
            Collider myCol = GetComponent<Collider>();
            
            // If our collider was destroyed or missing, we can't un-ignore
            if (myCol == null) return;

            // Loop backwards or forwards, doesn't matter here
            foreach (Collider c in _ignoredColliders)
            {
                if (c != null)
                {
                    UnityEngine.Physics.IgnoreCollision(myCol, c, false);
                }
            }
            _ignoredColliders.Clear();
        }

        private void Update()
        {
            if (!_isInitialized) return;
            _wasDeflectedThisFrame = false;
            float dt = Time.deltaTime;

            Vector3 oldPos = transform.position;
            _movementStrategy.Move(transform, dt);
            
            Vector3 newPos = transform.position;
            Vector3 travelVec = newPos - oldPos;
            float moveDistance = travelVec.magnitude;

            if (moveDistance > 0)
            {
                int mask = GameConstants.MASK_PROJECTILE_COLLISION;

                // Ensure the Raycast detects Trigger hitboxes (e.g. Player/Enemy hitbox colliders)
                if (UnityEngine.Physics.Raycast(oldPos, travelVec.normalized, out RaycastHit hit, moveDistance, mask, QueryTriggerInteraction.Collide))
                {
                    if (_source != null && (hit.collider.gameObject == _source || hit.transform.IsChildOf(_source.transform)))
                    {
                        return; 
                    }

                    transform.position = hit.point;
                    HandleCollision(hit.collider);
                }
            }

            _lifeTimer -= dt;
            if (_lifeTimer <= 0) Despawn();
        }

        private void HandleCollision(Collider other)
        {
            // If this is a trigger and NOT a hitbox/health component, ignore it (it's likely a zone)
            IDamageable target = other.GetComponent<IDamageable>();
            if (target == null) target = other.GetComponentInParent<IDamageable>();
            if (other.isTrigger && target == null) return;

            if (other.gameObject.layer == GameConstants.LAYER_WALL || other.gameObject.layer == GameConstants.LAYER_DEFAULT)
            {
                if (impactFeedback != null) impactFeedback.Play(null, transform.position);
                Despawn();
                return;
            }

            if (target != null)
            {
                if (isHostile && other.CompareTag(GameConstants.TAG_ENEMY)) return;
                if (!isHostile && other.CompareTag(GameConstants.TAG_PLAYER)) return;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = this.damage,
                    staggerAmount = this.stagger,
                    pushDirection = transform.forward,
                    pushForce = 5f,
                    source = gameObject,
                    isRedirected = this._isRedirected,
                    damageType = this.damageType
                };

                if (target.TakeDamage(info))
                {
                    if (impactFeedback != null) impactFeedback.Play(null, transform.position);
                    if (!_wasDeflectedThisFrame) Despawn();
                }
            }
        }

        private void OnTriggerEnter(Collider other) { }

        public void DeflectByEnemy(Vector3 surfaceNormal, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = true; 
            _direction = Vector3.Reflect(_direction, surfaceNormal).normalized;
            _source = null; 
            ApplyStrategy(overrideStrategy ?? new LinearMovement());
            UpdateVisuals();
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = false; 
            _isRedirected = true;
            _direction = newDirection.normalized;
            _source = newOwner;
            speed *= 1.5f;
            _lifeTimer = 3.0f;
            ApplyStrategy(overrideStrategy ?? new LinearMovement());
            UpdateVisuals();
        }

        private void ApplyStrategy(IMovementStrategy strategy)
        {
            SetStrategy(strategy);
            _movementStrategy.Initialize(transform, _direction, speed);
        }

        private void UpdateVisuals()
        {
            // CRITICAL FIX: Use sharedMaterial to respect the Palette Manager
            if (meshRenderer) 
                meshRenderer.sharedMaterial = isHostile ? hostileMaterial : friendlyMaterial;
        }

        private void Despawn()
        {
            GameLogger.Log(LogChannel.Combat, $"[PROJ] Despawn at {transform.position}", gameObject);

            // USE ALIAS 'Global' to avoid namespace collision
            if (Global.Pool) Global.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Strategies\HomingMovement.cs`
- Lines: 45
- Size: 1.4 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat.Strategies
{
    public class HomingMovement : IMovementStrategy
    {
        private Transform _target;
        private float _turnSpeed;
        private float _speed;
        private Vector3 _currentDirection;

        public HomingMovement(Transform target, float turnSpeed)
        {
            _target = target;
            _turnSpeed = turnSpeed;
        }

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _currentDirection = direction.normalized;
            transform.rotation = Quaternion.LookRotation(_currentDirection);
        }

        public void Move(Transform transform, float deltaTime)
        {
            if (_target != null)
            {
                Vector3 dirToTarget = (_target.position - transform.position).normalized;
                
                // Rotate towards target
                _currentDirection = Vector3.RotateTowards(
                    _currentDirection, 
                    dirToTarget, 
                    _turnSpeed * Mathf.Deg2Rad * deltaTime, 
                    0.0f
                );
            }

            transform.rotation = Quaternion.LookRotation(_currentDirection);
            transform.Translate(_currentDirection * _speed * deltaTime, Space.World);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Strategies\LinearMovement.cs`
- Lines: 23
- Size: 0.6 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat.Strategies
{
    public class LinearMovement : IMovementStrategy
    {
        private float _speed;
        private Vector3 _direction;

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _direction = direction.normalized;
            transform.rotation = Quaternion.LookRotation(_direction);
        }

        public void Move(Transform transform, float deltaTime)
        {
            transform.Translate(_direction * _speed * deltaTime, Space.World);
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Strategies\SineWaveMovement.cs`
- Lines: 54
- Size: 1.9 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat.Strategies
{
    public class SineWaveMovement : IMovementStrategy
    {
        private float _speed;
        private Vector3 _forward;
        private Vector3 _right;
        private float _frequency = 5f;
        private float _amplitude = 2f;
        private float _timeAlive;

        // You could pass config in a Constructor if you weren't using simple interfaces
        // For now, hardcoded or set via property setters
        public SineWaveMovement(float freq, float amp)
        {
            _frequency = freq;
            _amplitude = amp;
        }

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _forward = direction.normalized;
            _right = Vector3.Cross(_forward, Vector3.up); // Calculate "Right" relative to bullet
            _timeAlive = 0f;
            
            transform.rotation = Quaternion.LookRotation(_forward);
        }

        public void Move(Transform transform, float deltaTime)
        {
            _timeAlive += deltaTime;

            // 1. Move Forward
            Vector3 forwardMove = _forward * _speed * deltaTime;

            // 2. Calculate Sine Offset (Mathf.Sin)
            // We apply velocity to the "Right" based on the derivative of Sine, 
            // OR simpler: just offset position (which interacts weirdly with Physics Raycasts).
            
            // Better approach for Raycast-based projectiles: 
            // Calculate current velocity vector and move along it.
            
            // For simplicity in this demo: We will just mutate direction slightly
            float wave = Mathf.Cos(_timeAlive * _frequency) * _amplitude;
            Vector3 finalMove = forwardMove + (_right * wave * deltaTime);

            transform.Translate(finalMove, Space.World);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\CameraRig.cs`
- Lines: 84
- Size: 2.9 KB
- Modified: 2026-01-09 13:37

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

        private void Awake()
        {
            GameServices.RegisterCamera(this);
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
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Lines: 37
- Size: 1.3 KB
- Modified: 2026-01-08 16:47

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
        [Header("Anatomy")]
        [Tooltip("Must match an ID in the Enemy's FirePointRegistry (e.g. 'Muzzle', 'Eye').")]
        public string firePointID = "Default";

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

        [Header("Cooldown")]
        public float cooldownAfterBurst = 1.0f; // Enforce pacing
    }
}
```

## 📄 `Assets\Scripts\Core\Data\ColorPaletteSO.cs`
- Lines: 174
- Size: 6.6 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using System.Collections.Generic;
using System;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public struct SurfaceDefinition
    {
        [ColorUsage(true, true)] public Color mainColor;
        [Range(0f, 1f)] public float smoothness;
        [Range(0f, 1f)] public float metallic;
        
        [ColorUsage(true, true)] public Color emissionColor;
        public float emissionIntensity;
    }

    [System.Serializable]
    public struct SurfaceOverride
    {
        // Legacy (string-based) surface name. Kept for migration/backward compatibility.
        [HideInInspector] public string surfaceName; // e.g., "EnemyTertiary"

        public SurfaceType surfaceType;
        public SurfaceDefinition definition;
    }

    [System.Serializable]
    public class PaletteVariant
    {
        public string variantName; // e.g., "Enraged"
        public List<SurfaceOverride> overrides;
    }

    [CreateAssetMenu(fileName = "NewPalette", menuName = "DarkTowerTron/Visuals/Color Palette")]
    public class ColorPaletteSO : ScriptableObject
    {
        [Header("Player Theme")]
        public SurfaceDefinition playerPrimary;   
        public SurfaceDefinition playerSecondary; 
        public SurfaceDefinition playerTertiary;  

        [Header("Enemy Theme")]
        public SurfaceDefinition enemyPrimary;    
        public SurfaceDefinition enemySecondary;  
        public SurfaceDefinition enemyTertiary;   

        [Header("Combat & FX")]
        public SurfaceDefinition projectileHostile;
        public SurfaceDefinition projectileFriendly;
        public SurfaceDefinition beamAttack;
        public SurfaceDefinition blitzReady;
        public SurfaceDefinition blitzCooldown;
        [ColorUsage(true, true)] public Color hitFlashColor = Color.white;
        [ColorUsage(true, true)] public Color staggerColor = Color.yellow;

        [Header("Environment")]
        public SurfaceDefinition floor;
        public SurfaceDefinition walls;
        public SurfaceDefinition hazards;
        public SurfaceDefinition voidZone;
        public SurfaceDefinition anchor;

        [Header("Global Environment")]
        public Color skyColor = Color.black;

        [Range(0f, 0.1f)]
        public float fogDensity = 0.02f; // Default "Atmosphere"

        [Header("Variants")]
        public List<PaletteVariant> variants;

        // --- LOGIC ---

        /// <summary>
        /// Returns the base definition, or an override if the active variant has one.
        /// </summary>
        public SurfaceDefinition GetSurface(SurfaceType type, string activeVariantName)
        {
            // 1. Check Variant Override
            if (!string.IsNullOrEmpty(activeVariantName) && variants != null)
            {
                PaletteVariant activeVariant = variants.Find(v => v.variantName == activeVariantName);
                if (activeVariant != null && activeVariant.overrides != null)
                {
                    // Find specific override
                    int index = activeVariant.overrides.FindIndex(o => o.surfaceType == type);
                    if (index >= 0) return activeVariant.overrides[index].definition;

                    // Backward compatibility: if the asset still uses legacy strings,
                    // resolve them on the fly.
                    index = activeVariant.overrides.FindIndex(o =>
                        o.surfaceType == SurfaceType.None &&
                        TryParseSurfaceType(o.surfaceName, out var parsed) &&
                        parsed == type);
                    if (index >= 0) return activeVariant.overrides[index].definition;
                }
            }

            // 2. Return Base
            return GetBaseSurface(type);
        }

        private SurfaceDefinition GetBaseSurface(SurfaceType type)
        {
            switch (type)
            {
                case SurfaceType.None: return new SurfaceDefinition();
                case SurfaceType.PlayerPrimary: return playerPrimary;
                case SurfaceType.PlayerSecondary: return playerSecondary;
                case SurfaceType.PlayerTertiary: return playerTertiary;

                case SurfaceType.EnemyPrimary: return enemyPrimary;
                case SurfaceType.EnemySecondary: return enemySecondary;
                case SurfaceType.EnemyTertiary: return enemyTertiary;

                case SurfaceType.ProjectileHostile: return projectileHostile;
                case SurfaceType.ProjectileFriendly: return projectileFriendly;
                case SurfaceType.BeamAttack: return beamAttack;
                case SurfaceType.BlitzReady: return blitzReady;
                case SurfaceType.BlitzCooldown: return blitzCooldown;

                case SurfaceType.Floor: return floor;
                case SurfaceType.Walls: return walls;
                case SurfaceType.Hazards: return hazards;
                case SurfaceType.VoidZone: return voidZone;
                case SurfaceType.Anchor: return anchor;

                default:
                    return new SurfaceDefinition();
            }
        }

        private static bool TryParseSurfaceType(string surfaceName, out SurfaceType type)
        {
            if (string.IsNullOrWhiteSpace(surfaceName))
            {
                type = SurfaceType.None;
                return false;
            }

            return Enum.TryParse(surfaceName.Trim(), true, out type) && type != SurfaceType.None;
        }

        private void OnValidate()
        {
            // Migrate legacy string overrides into enum values.
            if (variants == null) return;

            for (int variantIndex = 0; variantIndex < variants.Count; variantIndex++)
            {
                PaletteVariant variant = variants[variantIndex];
                if (variant == null || variant.overrides == null) continue;

                bool changed = false;
                for (int overrideIndex = 0; overrideIndex < variant.overrides.Count; overrideIndex++)
                {
                    SurfaceOverride ov = variant.overrides[overrideIndex];
                    if (ov.surfaceType == SurfaceType.None && TryParseSurfaceType(ov.surfaceName, out var parsed))
                    {
                        ov.surfaceType = parsed;
                        variant.overrides[overrideIndex] = ov;
                        changed = true;
                    }
                }

                if (changed)
                {
                    variants[variantIndex] = variant;
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\DebugProfileSO.cs`
- Lines: 54
- Size: 1.8 KB
- Modified: 2026-01-08 05:58

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Debug;

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

## 📄 `Assets\Scripts\Core\Data\EnemyAttackSO.cs`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-06 12:10

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "Attack_New", menuName = "DarkTowerTron/Combat/Enemy Attack Profile")]
    public class EnemyAttackSO : ScriptableObject
    {
        [Header("Offensive Stats")]
        public float damage = 10f;
        [Min(0)] public int stagger = 1;

        [Header("Projectile Settings")]
        [Tooltip("Leave empty if this is a melee attack.")]
        public GameObject projectilePrefab;
        public float projectileSpeed = 15f;
        public float lifetime = 5f;

        [Header("Accuracy")]
        [Tooltip("0 = Perfect Aim. Higher = More spread.")]
        public float spreadAngle = 0f;
    }
}
```

## 📄 `Assets\Scripts\Core\Data\EnemyStatsSO.cs`
- Lines: 66
- Size: 2.4 KB
- Modified: 2026-01-06 09:15

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

## 📄 `Assets\Scripts\Core\Data\EnemyVisualProfileSO.cs`
- Lines: 20
- Size: 0.7 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "Visuals_Default", menuName = "DarkTowerTron/Visuals/Enemy Visual Profile")]
    public class EnemyVisualProfileSO : ScriptableObject
    {
        [Header("Impact Feel")]
        [Tooltip("How long the white flash lasts on impact.")]
        public float hitFlashDuration = 0.1f;

        [Header("Status Effects")]
        [Tooltip("Time for one full pulse (Stagger -> Danger -> Stagger).")]
        public float staggerPulseDuration = 0.4f;
        
        [Tooltip("Color to pulse to during stagger (usually Red for danger).")]
        [ColorUsage(true, true)] 
        public Color dangerPulseColor = Color.red; 
    }
}
```

## 📄 `Assets\Scripts\Core\Data\FeedbackProfileSO.cs`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Lines: 91
- Size: 3.5 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "PlayerStats_Default", menuName = "DarkTowerTron/Player/Base Stats")]
    public class PlayerStatsSO : ScriptableObject
    {
        [Header("Movement")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;
        public float deceleration = 40f;
        public float rotationSpeed = 25f;

        [Header("Physics & Feel")]
        public float gravity = 20f;
        public float wallRepulsionForce = 5f;
        [Tooltip("Time gravity is suspended after a dash/kill")]
        [FormerlySerializedAs("postActionHangTime")]
        public float actionHangTime = 0.2f;

        [Header("Scanner")]
        public float scanRange = 25f;
        public float scanRadius = 2f;

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
            deceleration = Mathf.Max(0f, deceleration);
            rotationSpeed = Mathf.Max(0f, rotationSpeed);

            gravity = Mathf.Max(0f, gravity);
            wallRepulsionForce = Mathf.Max(0f, wallRepulsionForce);
            actionHangTime = Mathf.Max(0f, actionHangTime);

            scanRange = Mathf.Max(0f, scanRange);
            scanRadius = Mathf.Max(0f, scanRadius);

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Scripts\Core\Data\SurfaceType.cs`
- Lines: 35
- Size: 0.6 KB
- Modified: 2026-01-06 09:15

```csharp
namespace DarkTowerTron.Core.Data
{
    public enum SurfaceType
    {

        None = 0, // <--- ADD THIS. Acts as a "Null" safety.

        // Actors
        PlayerPrimary,
        PlayerSecondary,
        PlayerTertiary,
        
        EnemyPrimary,
        EnemySecondary,
        EnemyTertiary,
        
        // Combat
        ProjectileHostile,
        ProjectileFriendly,
        BeamAttack,
        BlitzReady,
        BlitzCooldown,
        
        // Environment
        Floor,
        Walls,
        Hazards,
        VoidZone,
        Anchor,
        
        // UI/VFX
        UI_Main,
        VFX_General
    }
}
```

## 📄 `Assets\Scripts\Core\Data\UIThemeSO.cs`
- Lines: 23
- Size: 0.7 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Modified: 2026-01-08 06:09

```csharp
using System.Diagnostics;
using DarkTowerTron.Core.Data;
using UnityEngine;

namespace DarkTowerTron.Core.Debug
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

## 📄 `Assets\Scripts\Core\Debug\LogChannel.cs`
- Lines: 14
- Size: 0.5 KB
- Modified: 2026-01-08 05:51

```csharp
namespace DarkTowerTron.Core.Debug
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

## 📄 `Assets\Scripts\Core\Events\BoolEventChannelSO.cs`
- Lines: 21
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Bool Event Channel")]
    public class BoolEventChannelSO : ScriptableObject
    {
        public UnityAction<bool> OnEventRaised;

        public void Raise(bool value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Bool Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\DamageTextEventChannelSO.cs`
- Lines: 21
- Size: 0.7 KB
- Modified: 2026-01-09 13:31

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Damage Text Channel")]
    public class DamageTextEventChannelSO : ScriptableObject
    {
        // Added 'isStagger' bool to the signature
        public UnityAction<Vector3, float, bool, bool> OnEventRaised;

        public void Raise(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(pos, amount, isCrit, isStagger);
            else
                GameLogger.LogWarning(LogChannel.UI, $"DamageText Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\EnemyKilledEventChannelSO.cs`
- Lines: 22
- Size: 0.8 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Enemy Killed Channel")]
    public class EnemyKilledEventChannelSO : ScriptableObject
    {
        // The action signature matches your old GameEvents logic
        public UnityAction<Vector3, EnemyStatsSO, bool> OnEventRaised;

        public void Raise(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(position, stats, rewardPlayer);
            else
                GameLogger.LogWarning(LogChannel.Combat, $"EnemyKilled Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\FloatFloatEventChannelSO.cs`
- Lines: 21
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Float Float Event Channel")]
    public class FloatFloatEventChannelSO : ScriptableObject
    {
        public UnityAction<float, float> OnEventRaised;

        public void Raise(float current, float max)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(current, max);
            else
                GameLogger.LogWarning(LogChannel.System, $"FloatFloat Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\IntEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Event Channel")]
    public class IntEventChannelSO : ScriptableObject
    {
        public UnityAction<int> OnEventRaised;

        public void Raise(int value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Int Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\IntIntEventChannelSO.cs`
- Lines: 21
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Int Event Channel")]
    public class IntIntEventChannelSO : ScriptableObject
    {
        public UnityAction<int, int> OnEventRaised;

        public void Raise(int current, int max)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(current, max);
            else
                GameLogger.LogWarning(LogChannel.System, $"IntInt Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\NarrativeEventChannelSO.cs`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-09 14:33

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Narrative Text Channel")]
    public class NarrativeEventChannelSO : ScriptableObject
    {
        // String = Text, Float = Duration
        public UnityAction<string, float> OnEventRaised;

        public void Raise(string text, float duration = 3f)
        {
            OnEventRaised?.Invoke(text, duration);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\PopupTextEventChannelSO.cs`
- Lines: 14
- Size: 0.4 KB
- Modified: 2026-01-09 13:31

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Popup Text Channel")]
    public class PopupTextEventChannelSO : ScriptableObject
    {
        public UnityAction<Vector3, string> OnEventRaised;

        public void Raise(Vector3 pos, string message)
            => OnEventRaised?.Invoke(pos, message);
    }
}
```

## 📄 `Assets\Scripts\Core\Events\StringEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/String Event Channel")]
    public class StringEventChannelSO : ScriptableObject
    {
        public UnityAction<string> OnEventRaised;

        public void Raise(string value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"String Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\TransformEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Transform Event Channel")]
    public class TransformEventChannelSO : ScriptableObject
    {
        public UnityAction<Transform> OnEventRaised;

        public void Raise(Transform value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Transform Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\Vector3EventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Vector3 Event Channel")]
    public class Vector3EventChannelSO : ScriptableObject
    {
        public UnityAction<Vector3> OnEventRaised;

        public void Raise(Vector3 value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Vector3 Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\VoidEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public UnityAction OnEventRaised;

        public void Raise()
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke();
            else
                GameLogger.LogWarning(LogChannel.System, $"Void Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Events\VoidEventListener.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    public class VoidEventListener : MonoBehaviour
    {
        [Tooltip("The Event to listen to")]
        public VoidEventChannelSO channel;

        [Tooltip("What to do when the event triggers")]
        public UnityEvent response;

        private void OnEnable()
        {
            if (channel != null) channel.OnEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (channel != null) channel.OnEventRaised -= Respond;
        }

        private void Respond()
        {
            response?.Invoke();
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Feedback\Command\CameraShakeCommand.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Visuals;
using UnityEngine;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Camera Shake")]
    public class CameraShakeCommand : FeedbackCommand
    {
        public float duration = 0.2f;
        public float strength = 0.5f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (CameraShaker.Instance != null)
            {
                CameraShaker.Instance.Shake(duration, strength);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Feedback\Command\PlaySoundCommand.cs`
- Lines: 23
- Size: 0.7 KB
- Modified: 2026-01-09 13:53

```csharp
using DarkTowerTron.Core.Data;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Play Sound")]
    public class PlaySoundCommand : FeedbackCommand
    {
        [Tooltip("The sound definition to play.")]
        public SoundDef sound;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (sound != null && Global.Audio != null)
            {
                // Note: Your AudioManager.PlaySound currently ignores position (2D).
                // If you add 3D sound support later, pass 'position' here.
                Global.Audio.PlaySound(sound);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Feedback\Command\SpawnVFXCommand.cs`
- Lines: 36
- Size: 1.1 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Spawn VFX")]
    public class SpawnVFXCommand : FeedbackCommand
    {
        public GameObject prefab;
        public bool attachToParent = false;

        [Tooltip("Offset relative to the position rotation.")]
        public Vector3 offset = Vector3.zero;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (prefab == null || Global.Pool == null) return;

            // Calculate rotation
            Quaternion rot = Quaternion.identity;
            if (owner != null) rot = owner.transform.rotation;

            // Spawn
            GameObject instance = Global.Pool.Spawn(prefab, position + (rot * offset), rot);
            // Logic
            if (attachToParent && owner != null)
            {
                instance.transform.SetParent(owner.transform);
            }

            // Auto-Play Particle if it exists
            var ps = instance.GetComponent<ParticleSystem>();
            if (ps) ps.Play();
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Feedback\Command\TimeFreezeCommand.cs`
- Lines: 19
- Size: 0.5 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Time Freeze")]
    public class TimeFreezeCommand : FeedbackCommand
    {
        [Range(0f, 1f)] public float duration = 0.05f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (Global.Time != null)
            {
                Global.Time.HitStop(duration);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Feedback\FeedbackCommand.cs`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-06 19:21

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    /// <summary>
    /// Base class for a single "Juice" action (e.g., Play Sound, Shake Camera).
    /// </summary>
    public abstract class FeedbackCommand : ScriptableObject
    {
        /// <summary>
        /// Executes the feedback.
        /// </summary>
        /// <param name="owner">The object causing the feedback (e.g. Player, Bullet).</param>
        /// <param name="position">Where the effect happens (e.g. Impact point).</param>
        public abstract void Execute(GameObject owner, Vector3 position);
    }
}
```

## 📄 `Assets\Scripts\Core\Feedback\FeedbackConfigurationSO.cs`
- Lines: 32
- Size: 1.0 KB
- Modified: 2026-01-08 06:09

```csharp
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(fileName = "Feedback_New", menuName = "DarkTowerTron/Feedback/Configuration Package")]
    public class FeedbackConfigurationSO : ScriptableObject
    {
        [Header("Juice List")]
        public List<FeedbackCommand> commands = new List<FeedbackCommand>();

        /// <summary>
        /// Runs every command in the package.
        /// </summary>
        public void Play(GameObject owner, Vector3 position)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i] != null)
                {
                    commands[i].Execute(owner, position);
                }
            }
        }

        // Overload for simple usage (uses owner's position)
        public void Play(GameObject owner)
        {
            if (owner != null) Play(owner, owner.transform.position);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameConstants.cs`
- Lines: 56
- Size: 3.1 KB
- Modified: 2026-01-08 14:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public static class GameConstants
    {
        // ========================================================================
        // 🏷️ TAGS
        // ========================================================================
        public const string TAG_PLAYER = "Player";
        public const string TAG_ENEMY = "Enemy";
        public const string TAG_PROJECTILE = "Projectile";
        public const string TAG_UNTAGGED = "Untagged";

        // ========================================================================
        // 🧱 LAYERS (Indices - for gameObject.layer check)
        // ========================================================================
        // Note: These must match your Project Settings -> Tags and Layers
        public static readonly int LAYER_DEFAULT = LayerMask.NameToLayer("Default");
        public static readonly int LAYER_TRANSPARENT_FX = LayerMask.NameToLayer("TransparentFX");
        public static readonly int LAYER_IGNORE_RAYCAST = LayerMask.NameToLayer("Ignore Raycast");
        public static readonly int LAYER_WATER = LayerMask.NameToLayer("Water");
        public static readonly int LAYER_UI = LayerMask.NameToLayer("UI");
        
        // Custom Layers
        public static readonly int LAYER_PLAYER = LayerMask.NameToLayer("Player");
        public static readonly int LAYER_ENEMY = LayerMask.NameToLayer("Enemy");
        public static readonly int LAYER_PROJECTILE = LayerMask.NameToLayer("Projectile");
        public static readonly int LAYER_HITBOX = LayerMask.NameToLayer("Hitbox");
        public static readonly int LAYER_WALL = LayerMask.NameToLayer("Wall");
        public static readonly int LAYER_GROUND = LayerMask.NameToLayer("Ground");

        // ========================================================================
        // 🎭 MASKS (Bitmasks - for Physics.Raycast / OverlapSphere)
        // ========================================================================
        
        // 1. Movement: Can I walk here?
        // EXCLUDES 'Hitbox' and 'Enemy'. Enemies should not treat other enemies as static walls.
        // They should overlap and let 'EnemyMotor' separation handle the spacing.
        public static readonly int MASK_PHYSICS_OBSTACLES = LayerMask.GetMask("Default", "Wall", "Ground");

        // 2. Projectiles: What do I hit?
        // INCLUDES 'Hitbox' (Shoot the arm) and 'Enemy' (Shoot the capsule)
        public static readonly int MASK_PROJECTILE_COLLISION = LayerMask.GetMask("Default", "Wall", "Player", "Enemy", "Hitbox");

        // Used by Wall Detection (Pushback)
        public static readonly int MASK_WALLS = LayerMask.GetMask("Default", "Wall");

        // Used by "Safe Ground" checks (Falling into void)
        public static readonly int MASK_GROUND_ONLY = LayerMask.GetMask("Ground");
        
        // 3. Sight/AI: What blocks vision?
        // Usually just Walls and Ground. We don't want an enemy to block another enemy's view of the player.
        public static readonly int MASK_SIGHT_BLOCKING = LayerMask.GetMask("Default", "Wall", "Ground");
    }
}
```

## 📄 `Assets\Scripts\Core\GameServices.cs`
- Lines: 68
- Size: 2.7 KB
- Modified: 2026-01-09 13:41

```csharp
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Managers;
using DarkTowerTron.Player.Controller;
using DarkTowerTron.UI;
using UnityEngine;

namespace DarkTowerTron.Core
{
    [DefaultExecutionOrder(-100)] // Init before everything else
    public class GameServices : MonoBehaviour
    {
        public static GameServices Instance { get; private set; }

        [Header("System Services")]
        [SerializeField] private WaveDirector _waveDirector;
        //[SerializeField] private ScoreManager _scoreManager;
        //[SerializeField] private PoolManager _poolManager;
        //[SerializeField] private VFXManager _vfxManager;
        //[SerializeField] private AudioManager _audioManager;
        [SerializeField] private DamageTextManager _damageTextManager;

        // Dynamic Services (Set at runtime)
        public static PlayerController Player { get; private set; }
        public static CameraRig CameraRig { get; private set; }
        public static GameSession Session { get; private set; }

        // Public Accessors
        public static WaveDirector WaveDirector => Instance != null ? Instance._waveDirector : null;
        //public static ScoreManager Score => Instance != null ? Instance._scoreManager : null;
        //public static PoolManager Pool => Instance != null ? Instance._poolManager : null;
        //public static VFXManager VFX => Instance != null ? Instance._vfxManager : null;
        //public static AudioManager Audio => Instance != null ? Instance._audioManager : null;
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

        public static void RegisterCamera(CameraRig rig)
        {
            CameraRig = rig;
            GameLogger.Log(LogChannel.System, "[GameServices] CameraRig Registered.", rig != null ? rig.gameObject : null);
        }

        public static void RegisterSession(GameSession session)
        {
            Session = session;
            GameLogger.Log(LogChannel.System, "[GameServices] GameSession Registered.", session != null ? session.gameObject : null);
        }

        private void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameTime.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2026-01-09 13:47

```csharp
using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Systems
{
    public class GameTime : MonoBehaviour
    {
        private bool _isFrozen = false;

        public void HitStop(float duration)
        {
            if (_isFrozen) return;
            if (duration <= 0) return;
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

## 📄 `Assets\Scripts\Core\Global.cs`
- Lines: 32
- Size: 1.3 KB
- Modified: 2026-01-09 13:44

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Systems;       // NEW Namespace for Managers (see Step 2)

namespace DarkTowerTron
{
    /// <summary>
    /// Global Access Point for all Game Systems.
    /// Replaces "Services" class to avoid namespace conflicts.
    /// </summary>
    public static class Global
    {
        // Core Systems
        public static AudioManager Audio => ServiceLocator.Get<AudioManager>();
        public static MusicManager Music => ServiceLocator.Get<MusicManager>();
        public static PaletteManager Palette => ServiceLocator.Get<PaletteManager>();
        public static PoolManager Pool => ServiceLocator.Get<PoolManager>();
        public static ScoreManager Score => ServiceLocator.Get<ScoreManager>();
        public static VFXManager VFX => ServiceLocator.Get<VFXManager>();
        public static GameTime Time => ServiceLocator.Get<GameTime>();

        // Dynamic Systems
        public static DarkTowerTron.Player.Controller.PlayerController Player
            => DarkTowerTron.Core.GameServices.Player;

        public static DarkTowerTron.Core.CameraRig Camera
            => DarkTowerTron.Core.GameServices.CameraRig;

        public static DarkTowerTron.Managers.GameSession Session
            => DarkTowerTron.Core.GameServices.Session;
    }
}
```

## 📄 `Assets\Scripts\Core\Input\InputBuffer.cs`
- Lines: 41
- Size: 1.2 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Input
{
    /// <summary>
    /// queues inputs for a short time to allow "Early" presses to register.
    /// </summary>
    public class InputBuffer
    {
        private float _bufferTime;
        private Dictionary<string, float> _queuedActions = new Dictionary<string, float>();

        public InputBuffer(float bufferTime = 0.15f)
        {
            _bufferTime = bufferTime;
        }

        public void BufferAction(string actionID)
        {
            // Record the timestamp of the press
            _queuedActions[actionID] = Time.time;
        }

        public bool TryConsumeAction(string actionID)
        {
            if (_queuedActions.TryGetValue(actionID, out float timeStamp))
            {
                // Is the press recent enough?
                if (Time.time - timeStamp <= _bufferTime)
                {
                    _queuedActions.Remove(actionID); // Consume it
                    return true;
                }
            }
            return false;
        }

        public void Clear() => _queuedActions.Clear();
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IAimTarget.cs`
- Lines: 17
- Size: 0.4 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface IAimTarget
    {
        /// <summary>
        /// The world-space position aiming systems should target (Center of Mass).
        /// </summary>
        Vector3 AimPoint { get; }

        /// <summary>
        /// Approximate radius for magnetism forgiveness.
        /// </summary>
        float TargetRadius { get; }
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\ICombatTarget.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Scripts\Core\Interfaces\IMovementStrategy.cs`
- Lines: 10
- Size: 0.2 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface IMovementStrategy
    {
        void Initialize(Transform transform, Vector3 direction, float speed);
        void Move(Transform transform, float deltaTime);
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IMover.cs`
- Lines: 18
- Size: 0.4 KB
- Modified: 2026-01-06 15:00

```csharp
using UnityEngine;

namespace DarkTowerTron.Physics
{
    public interface IMover
    {
        // Data Access
        Vector3 Velocity { get; }
        bool IsGrounded { get; }

        // Actions
        void Move(Vector3 velocity); // Accepts Velocity (units/sec)
        void Teleport(Vector3 position);

        // Settings (Optional, for syncing)
        void SetEnabled(bool state);
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IPoolable.cs`
- Lines: 8
- Size: 0.1 KB
- Modified: 2025-12-30 09:50

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
- Lines: 10
- Size: 0.2 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using DarkTowerTron.Combat.Strategies; 

namespace DarkTowerTron.Core
{
    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null);
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces\IWeapon.cs`
- Lines: 7
- Size: 0.1 KB
- Modified: 2025-12-30 09:50

```csharp
namespace DarkTowerTron.Core
{
    public interface IWeapon
    {
        void SetFiring(bool isFiring);
    }
}
```

## 📄 `Assets\Scripts\Core\Services\BootLoader.cs`
- Lines: 32
- Size: 1.1 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Debug;
using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    /// <summary>
    /// Automatically loads the SystemBootloader prefab before any scene loads.
    /// </summary>
    public static class Bootloader
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Execute()
        {
            // 1. Check if it already exists (prevent duplicates in Editor)
            if (Object.FindObjectOfType<GameBootstrap>() != null) return;

            // 2. Load from Resources
            var prefab = Resources.Load<GameObject>("SystemBootloader");
            if (prefab == null)
            {
                GameLogger.LogError(LogChannel.System, "CRITICAL: Missing 'SystemBootloader' in Resources folder!");
                return;
            }

            // 3. Spawn
            var instance = Object.Instantiate(prefab);
            instance.name = "[SYSTEM_BOOT]";
            
            // Note: DontDestroyOnLoad is handled by the GameBootstrap component in Awake.
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Services\GameBootstrap.cs`
- Lines: 43
- Size: 1.3 KB
- Modified: 2026-01-09 13:53

```csharp
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Managers;
using DarkTowerTron.Systems;
using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    [DefaultExecutionOrder(-1000)]
    public class GameBootstrap : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.Clear();
            DontDestroyOnLoad(gameObject);

            // 1. Register Core Systems
            Register<AudioManager>();
            Register<GameTime>();
            Register<MusicManager>();
            Register<PaletteManager>();
            Register<PoolManager>();
            Register<ScoreManager>(); 
            Register<VFXManager>();
            
            GameLogger.Log(LogChannel.System, "System Core & Managers Initialized.");
        }

        private void Register<T>() where T : MonoBehaviour
        {
            var component = GetComponentInChildren<T>();
            if (component != null)
            {
                ServiceLocator.Register(component);
            }
            else
            {
                // Fallback: Try to add it if missing? 
                // Better to error so you fix the prefab.
                GameLogger.LogError(LogChannel.System, $"[BOOT] Critical: Missing {typeof(T).Name} on SystemBootloader!", gameObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Services\ServiceLocator.cs`
- Lines: 69
- Size: 2.1 KB
- Modified: 2026-01-08 06:09

```csharp
using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Debug;
using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    /// <summary>
    /// A simple, static registry for game systems.
    /// Replaces the Singleton pattern for Managers.
    /// </summary>
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _services = new();

        public static bool IsInitialized => _services.Count > 0;

        /// <summary>
        /// Registers a service instance. Overwrites if type already exists.
        /// </summary>
        public static void Register<T>(T service) where T : class
        {
            var type = typeof(T);
            if (_services.ContainsKey(type))
            {
                GameLogger.LogWarning(LogChannel.System, $"[ServiceLocator] Service {type.Name} is being overwritten.");
            }
            _services[type] = service;
        }

        /// <summary>
        /// Gets a service instance. Throws error if missing.
        /// </summary>
        public static T Get<T>() where T : class
        {
            var type = typeof(T);
            if (_services.TryGetValue(type, out var service))
            {
                return service as T;
            }

            throw new InvalidOperationException($"[ServiceLocator] Service {type.Name} not registered! Ensure SystemBootloader is running.");
        }

        /// <summary>
        /// Safely tries to get a service. Useful for optional dependencies (e.g. testing AI without UI).
        /// </summary>
        public static bool TryGet<T>(out T service) where T : class
        {
            var type = typeof(T);
            if (_services.TryGetValue(type, out var obj))
            {
                service = obj as T;
                return true;
            }

            service = null;
            return false;
        }

        /// <summary>
        /// Clears all services. Call on Domain Reload or Application Quit.
        /// </summary>
        public static void Clear()
        {
            _services.Clear();
        }
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
- Lines: 18
- Size: 0.5 KB
- Modified: 2026-01-06 09:15

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

## 📄 `Assets\Scripts\Core\Utils\LayerAutomator.cs`
- Lines: 76
- Size: 2.2 KB
- Modified: 2026-01-08 14:10

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Utils
{
    [ExecuteAlways] // Runs in Editor Mode
    public class LayerAutomator : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("The layer for the Root object (Movement Capsule).")]
        public string rootLayerName = "Enemy";

        [Tooltip("The layer for all child objects (Visuals/Hitboxes).")]
        public string childLayerName = "Hitbox";

        [Tooltip("If true, updates happens automatically when you change something.")]
        public bool autoUpdate = true;

        private void Update()
        {
            // Don't run in the actual game, only in Editor
            if (Application.isPlaying) return;

            if (autoUpdate)
            {
                EnforceLayers();
            }
        }

        [ContextMenu("Force Fix Layers Now")]
        public void EnforceLayers()
        {
            int rootLayer = LayerMask.NameToLayer(rootLayerName);
            int childLayer = LayerMask.NameToLayer(childLayerName);

            // Safety Check: Do layers exist?
            if (rootLayer == -1 || childLayer == -1) return;

            // 1. Fix Root
            if (gameObject.layer != rootLayer)
            {
                gameObject.layer = rootLayer;
            }

            // 2. Fix Children
            foreach (Transform child in transform)
            {
                SetLayerRecursive(child, childLayer);
            }
        }

        private void SetLayerRecursive(Transform t, int layer)
        {
            // Optional: Don't overwrite Triggers if you want them on a specific layer?
            // For now, Hitbox layer is usually fine for triggers too if configured right.

            if (t.gameObject.layer != layer)
            {
                t.gameObject.layer = layer;
            }

            foreach (Transform child in t)
            {
                SetLayerRecursive(child, layer);
            }
        }

        private void Awake()
        {
            // Self-Destruct in Play Mode to save memory
            if (Application.isPlaying)
            {
                Destroy(this);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Utils\Rotator.cs`
- Lines: 45
- Size: 1.3 KB
- Modified: 2026-01-06 11:54

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Utils
{
    public class Rotator : MonoBehaviour
    {
        public enum RotateDirection
        {
            Clockwise = 1,
            CounterClockwise = -1
        }

        [Header("Settings")]
        public Vector3 axis = Vector3.up;
        public float speed = 100f;

        [Tooltip("Direction of rotation relative to the axis.")]
        public RotateDirection direction = RotateDirection.Clockwise;

        public bool localSpace = true;

        private void Update()
        {
            if (speed == 0) return;

            // Math: Speed * Direction (1 or -1) * DeltaTime
            float finalStep = speed * (int)direction * Time.deltaTime;

            if (localSpace)
                transform.Rotate(axis, finalStep, Space.Self);
            else
                transform.Rotate(axis, finalStep, Space.World);
        }

        // API for AI/Events to change direction at runtime
        public void SetDirection(RotateDirection newDir) => direction = newDir;

        public void ToggleDirection()
        {
            direction = direction == RotateDirection.Clockwise ?
                        RotateDirection.CounterClockwise :
                        RotateDirection.Clockwise;
        }
    }
}
```

## 📄 `Assets\Scripts\Core\VoidKiller.cs`
- Lines: 33
- Size: 1.1 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using DarkTowerTron.Player.Stats; // Access PlayerHealth directly for special void logic

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
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Scripts\Enemy\Bosses\Architect\ArchitectController.cs`
- Lines: 269
- Size: 8.8 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DG.Tweening;
using DarkTowerTron;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    // REMOVED: [RequireComponent(typeof(StateMachine))] <-- Old FSM deleted
    public class ArchitectController : MonoBehaviour, IDamageable, ICombatTarget, IAimTarget
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
        public float radiusOuter = 2.5f;
        public float radiusInner = 0.8f;

        // We keep the data, but we aren't using it automatically right now
        [Header("Patterns")]
        public List<ArchitectPatternSO> phase1Patterns;

        [Header("Event Wiring")]
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;
        [SerializeField] private IntEventChannelSO _waveAnnounceEvent; // Updated type
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;
        [SerializeField] private PopupTextEventChannelSO _popupEvent;
        [SerializeField] private DamageTextEventChannelSO _damageTextEvent;

        [Header("Aiming")]
        [SerializeField] private float _aimOffset = 0f;
        [SerializeField] private float _coreRadius = 1.5f;

        // Interfaces
        public bool KeepPlayerGrounded => true;
        public Vector3 AimPoint => transform.position + (Vector3.up * _aimOffset);
        public float TargetRadius => _coreRadius;
        public bool IsStaggered => false;

        // Internal State
        private bool _isVulnerable = false;
        private float _currentRotationSpeed;
        private Transform _player;

        // REMOVED: StateMachine _fsm;
        // REMOVED: ArchitectState_Idle, ArchitectState_Pattern variables

        private void Start()
        {
            if (DarkTowerTron.Core.GameServices.Player != null)
                _player = DarkTowerTron.Core.GameServices.Player.transform;

            SetShield(true);
            _currentRotationSpeed = rotationSpeedIdle;
        }

        private void Update()
        {
            if (rotationRig)
                rotationRig.Rotate(Vector3.up, _currentRotationSpeed * Time.deltaTime);

            // Phase Logic (Simplified for now)
            if (!_isVulnerable)
            {
                bool anyHandAlive = false;
                foreach (var h in hands)
                {
                    if (h != null && h.IsAlive())
                    {
                        anyHandAlive = true;
                        break;
                    }
                }

                if (!anyHandAlive)
                {
                    StartCoroutine(EnterVulnerablePhase());
                }
            }
        }

        // --- PUBLIC API (The "Body" Commands) ---
        // These will be called by the Pluggable AI Action later

        public void SetRotationSpeed(float speed) => _currentRotationSpeed = speed;

        public void ActivateBoss()
        {
            _currentRotationSpeed = rotationSpeedCombat;
            _waveAnnounceEvent?.Raise(666);
            _combatStartedEvent?.Raise();

            // Temporary: Just run the first pattern manually to prove it works
            // In future, the Pluggable AI will call RunPattern()
            if (phase1Patterns.Count > 0) StartCoroutine(RunPatternSequence(phase1Patterns[0]));
        }

        // Adapted from the old State logic into a standalone Coroutine
        public IEnumerator RunPatternSequence(ArchitectPatternSO pattern)
        {
            if (_isVulnerable) yield break;

            SetRotationSpeed(pattern.rotationSpeed);

            // 1. Setup
            MoveHands(pattern.extendHands);
            TelegraphWalls(pattern.activateWalls);

            yield return new WaitForSeconds(pattern.startDelay);

            // 2. Active
            ActivateWalls(pattern.activateWalls);

            float timer = 0f;
            float duration = pattern.activeDuration - pattern.startDelay;
            float shotCooldown = 0f;
            bool hasGun = pattern.shootingPattern != null;

            while (timer < duration)
            {
                if (_isVulnerable) break;

                float dt = Time.deltaTime;
                timer += dt;

                if (hasGun)
                {
                    shotCooldown -= dt;
                    if (shotCooldown <= 0)
                    {
                        FireProjectiles(pattern);
                        shotCooldown = pattern.shootingPattern.delayBetweenShots;
                    }
                }
                yield return null;
            }

            // 3. Cleanup
            ResetHands();
        }

        // --- HELPER METHODS ---

        private void FireProjectiles(ArchitectPatternSO pattern)
        {
            if (pattern.shootingPattern == null) return;
            bool useForward = pattern.shootingPattern.aimMode == AimType.ForwardRadial;
            float scale = pattern.shootingPattern.scaleMultiplier;

            for (int i = 0; i < hands.Count; i++)
            {
                var hand = hands[i];
                if (hand == null || !hand.IsAlive()) continue;

                // Check Config Array safety
                if (pattern.activeGuns != null && i < pattern.activeGuns.Length && pattern.activeGuns[i])
                {
                    Vector3 targetPos = (_player != null) ? _player.position : Vector3.zero;
                    hand.Shoot(targetPos, useForward, scale);
                }
            }
        }

        public void MoveHands(bool[] extendConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool extend = (extendConfig != null && i < extendConfig.Length) ? extendConfig[i] : false;
                hands[i].MoveToDistance(extend ? radiusOuter : radiusInner);
            }
        }

        public void TelegraphWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].PrepareWall(active);
            }
        }

        public void ActivateWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].SetWall(active);
            }
        }

        public void ResetHands()
        {
            foreach (var h in hands)
            {
                if (h == null) continue;
                h.MoveToDistance(radiusInner);
                h.SetWall(false);
                h.PrepareWall(false);
            }
        }

        // --- PHASE LOGIC ---

        private IEnumerator EnterVulnerablePhase()
        {
            _isVulnerable = true;
            SetShield(false);
            _currentRotationSpeed = 60f;
            _popupEvent?.Raise(transform.position, "SHIELD DOWN");
            yield return null;
        }

        private void SetShield(bool state)
        {
            if (shieldVisual) shieldVisual.SetActive(state);
        }

        // --- IDAMAGEABLE ---

        public bool TakeDamage(DamageInfo info)
        {
            if (!_isVulnerable)
            {
                _popupEvent?.Raise(transform.position, "SHIELDED");
                return false;
            }

            coreHealth -= info.damageAmount;
            _damageTextEvent?.Raise(transform.position, info.damageAmount, true, false);

            if (coreHealth <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            _gameVictoryEvent?.Raise();
            if (Global.VFX != null && Global.VFX.explosionPrefab)
                Global.Pool?.Spawn(Global.VFX.explosionPrefab, transform.position, Quaternion.identity);

            Destroy(gameObject, 0.5f);
        }

        public void OnExecutionHit()
        {
            if (_isVulnerable)
            {
                TakeDamage(new DamageInfo { damageAmount = 50f });
            }
            else
            {
                _popupEvent?.Raise(transform.position, "SHIELDED");
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Bosses\Architect\ArchitectHand.cs`
- Lines: 195
- Size: 6.2 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Enemy.Visuals; // For Visuals
using DG.Tweening;
using DarkTowerTron;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class ArchitectHand : MonoBehaviour
    {
        [Header("Visual Components")]
        public Transform visualRoot;    // The object that slides In/Out
        public Transform meshPivot;     // The object that rotates 90 degrees
        public GameObject wallObject;   // The Laser Hazard (Child)
        public Transform firePoint;     // Where bullets spawn

        [Header("Combat Configuration")]
        public GameObject projectilePrefab;
        public GameObject deathExplosionEffect; // Optional: Explosion VFX on disable

        [Header("Animation")]
        public float slideDuration = 1.0f;
        public float rotateDuration = 0.5f;

        // Dependencies
        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;
        private bool _isDead = false;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();

            // Ensure wall is off by default
            if (wallObject) wallObject.SetActive(false);
        }

        private void Start()
        {
            // Initialize DamageReceiver (No Stats SO needed, uses Inspector overrides)
            _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            _receiver.OnDeathProcessed += HandleDeath;
            _receiver.OnHitProcessed += HandleHit;

            // Wire up Stagger Visuals
            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
            }
        }

        private void OnDisable()
        {
            _receiver.OnDeathProcessed -= HandleDeath;
            _receiver.OnHitProcessed -= HandleHit;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
            }
        }

        public bool IsAlive() => !_isDead;

        // --- HANDLERS ---

        private void HandleHit(Core.DamageInfo info)
        {
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            if (_isDead) return;
            Die();
        }

        // --- MOVEMENT ---

        public void MoveToDistance(float localZ)
        {
            if (_isDead) return;
            // Slide along local Z axis relative to the Pivot Parent
            visualRoot.DOLocalMoveZ(localZ, slideDuration).SetEase(Ease.InOutQuad);
        }

        // --- COMBAT ACTIONS ---

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

            // Spawn from Pool using Global Alias
            GameObject p = Global.Pool.Spawn(projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
            p.transform.localScale = Vector3.one * scale;

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = 15f;

                // CRITICAL: Set Source so the bullet ignores the HandCollider immediately
                proj.SetSource(gameObject);

                proj.Initialize(dir);
            }
        }

        // --- STATE MANAGEMENT ---

        private void Die()
        {
            _isDead = true;
            SetWall(false);

            // 1. VFX
            if (deathExplosionEffect && Global.Pool != null)
            {
                Global.Pool.Spawn(deathExplosionEffect, transform.position, Quaternion.identity);
            }

            // 2. Visual Shutdown (Shrink)
            if (meshPivot) meshPivot.DOKill();
            visualRoot.DOKill();
            visualRoot.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);

            // 3. Disable Logic (but keep GameObject active for Revive)
            // We disable the collider via the DamageReceiver's component or manually?
            // Usually simpler to just rely on _isDead flag to ignore logic, 
            // but we should disable collider to stop blocking shots.
            var col = GetComponent<Collider>();
            if (col) col.enabled = false;
        }

        public void Revive()
        {
            _isDead = false;

            // revive modules
            _receiver.Vitality.Revive();
            _receiver.Stagger.ResetStagger();
            _visuals.ResetVisuals();

            // Enable collider
            var col = GetComponent<Collider>();
            if (col) col.enabled = true;

            // Visual Pop-in
            gameObject.SetActive(true);
            visualRoot.localScale = Vector3.zero;
            visualRoot.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);

            if (meshPivot) meshPivot.localRotation = Quaternion.identity;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyBaseAI.cs`
- Lines: 218
- Size: 7.6 KB
- Modified: 2026-01-09 13:54

```csharp
using UnityEngine;
using DG.Tweening; // Logic relies on Tweening
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Managers;
using DarkTowerTron;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(EnemyController))]
    public abstract class EnemyBaseAI : MonoBehaviour, IPoolable
    {
        [Header("AI Event Wiring")]
        [SerializeField] private Vector3EventChannelSO _enemySpawnedEvent;
        [SerializeField] private TransformEventChannelSO _decoySpawnedEvent;
        [SerializeField] private VoidEventChannelSO _decoyExpiredEvent;

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

            _enemySpawnedEvent?.Raise(transform.position);

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

            if (_decoySpawnedEvent != null) _decoySpawnedEvent.OnEventRaised += OnDecoySpawned;
            if (_decoyExpiredEvent != null) _decoyExpiredEvent.OnEventRaised += OnDecoyExpired;
        }

        protected virtual void OnDestroy()
        {
            if (_decoySpawnedEvent != null) _decoySpawnedEvent.OnEventRaised -= OnDecoySpawned;
            if (_decoyExpiredEvent != null) _decoyExpiredEvent.OnEventRaised -= OnDecoyExpired;
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
            GameObject p = Global.Pool.Spawn(prefab, position, rotation);

            // 2. Setup Logic
            Projectile proj = p.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.ResetHostility(true); // Enemies always shoot hostile
                proj.speed = speed;
                proj.Initialize(direction);
            }
        }

        /// <summary>
        /// Smart Firing Logic: Calculates vector to Target's Center of Mass.
        /// </summary>
        protected void FireAtTarget(GameObject prefab, Transform firePointOrigin, float speed, float accuracyError = 0f)
        {
            if (prefab == null || _currentTarget == null) return;

            // 1. Determine Origin
            Vector3 origin = firePointOrigin ? firePointOrigin.position : transform.position;

            // 2. Determine Destination (AimPoint)
            Vector3 targetPos;
            var aimTarget = _currentTarget.GetComponent<IAimTarget>();

            if (aimTarget != null)
            {
                targetPos = aimTarget.AimPoint;
            }
            else
            {
                // Fallback for dumb objects
                targetPos = _currentTarget.position + Vector3.up * 1.0f;
            }

            // 3. Calculate Vector
            Vector3 direction = (targetPos - origin).normalized;

            // 4. Apply Inaccuracy (Optional)
            if (accuracyError > 0f)
            {
                direction = ApplySpread(direction, accuracyError);
            }

            // 5. Spawn & Init
            GameObject p = Global.Pool.Spawn(prefab, origin, Quaternion.LookRotation(direction));

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = speed;

                // CRITICAL: Set Source to SELF (The Root Enemy Object)
                // This ensures the bullet ignores the enemy's own colliders
                proj.SetSource(this.gameObject);

                proj.Initialize(direction);
            }
        }

        /// <summary>
        /// Fires using a specific Attack Profile (Single Source of Truth).
        /// </summary>
        protected void FireAtTarget(EnemyAttackSO attackProfile, Transform firePointOrigin)
        {
            if (attackProfile == null || attackProfile.projectilePrefab == null || _currentTarget == null) return;

            // 1. Origin
            Vector3 origin = firePointOrigin ? firePointOrigin.position : transform.position;

            // 2. Destination (Smart Aim)
            Vector3 targetPos;
            var aimTarget = _currentTarget.GetComponent<IAimTarget>();

            if (aimTarget != null) targetPos = aimTarget.AimPoint;
            else targetPos = _currentTarget.position + Vector3.up * 1.0f;

            // 3. Vector
            Vector3 direction = (targetPos - origin).normalized;

            // 4. Spread (From Profile)
            if (attackProfile.spreadAngle > 0f)
            {
                direction = ApplySpread(direction, attackProfile.spreadAngle);
            }

            // 5. Spawn & Inject Data
            GameObject p = Global.Pool.Spawn(attackProfile.projectilePrefab, origin, Quaternion.LookRotation(direction));

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                // INJECT DATA FROM SO
                proj.damage = attackProfile.damage;
                proj.stagger = attackProfile.stagger;
                proj.speed = attackProfile.projectileSpeed;
                proj.lifetime = attackProfile.lifetime;

                proj.ResetHostility(true);
                proj.SetSource(this.gameObject);
                proj.Initialize(direction);
            }
        }

        private Vector3 ApplySpread(Vector3 dir, float angle)
        {
            return Quaternion.Euler(Random.Range(-angle, angle), Random.Range(-angle, angle), 0f) * dir;
        }

        // --- EVENTS ---
        private void OnDecoySpawned(Transform decoy) { _currentTarget = decoy; }
        private void OnDecoyExpired() { if (_player != null) _currentTarget = _player; }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyController.cs`
- Lines: 163
- Size: 5.3 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // Event Channels
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.Visuals;
using DarkTowerTron;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class EnemyController : MonoBehaviour, IPoolable, ICombatTarget
    {
        // --- Dependencies ---
        private DamageReceiver _receiver;
        private EnemyMotor _motor;
        private EnemyVisuals _visuals;
        private EnemyStatsSO _stats;

        // --- Event Wiring ---
        [Header("Broadcasting")]
        [Tooltip("Notifies ScoreManager and WaveDirector when this enemy dies.")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Visual Feedback")]
        [Tooltip("Spawns floating damage numbers.")]
        [SerializeField] private DamageTextEventChannelSO _damageEvent;

        [Tooltip("Spawns status text (e.g. STAGGER).")]
        [SerializeField] private PopupTextEventChannelSO _popupEvent;

        [Header("Audio")]
        public AudioClip staggerClip;

        // --- Public Accessors ---
        public bool IsStaggered => _receiver != null && _receiver.IsStaggered;
        public EnemyVisuals Visuals => _visuals;

        // --- Lifecycle ---

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;

            // Self-Initialization safety check
            if (_receiver != null && _stats != null && _receiver.CurrentHealth <= 0)
            {
                _receiver.Initialize(_stats);
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            
            // Reset Modules
            _receiver.Initialize(_stats);
            _visuals.ResetVisuals();
        }

        public void OnDespawn()
        {
            _visuals.ResetVisuals();
            // Note: Shooting coroutines in PatternExecutor are automatically killed 
            // when the GameObject is disabled/despawned.
        }

        private void OnEnable()
        {
            if (_receiver == null) return;

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
            if (_receiver == null) return;

            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover -= HandleStaggerExit;
            }
        }

        // --- Handlers ---

        private void HandleHit(DamageInfo info)
        {
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            // Visuals
            if (!IsStaggered) _visuals.PlayHitFlash();

            bool isCrit = IsStaggered;

            // LOGIC FIX:
            // If Health damage is > 0, we show Health Damage (White/Yellow).
            // If Health damage is 0 but Stagger > 0, we show Stagger Damage (Cyan).
            if (info.damageAmount > 0)
            {
                _damageEvent?.Raise(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                _damageEvent?.Raise(transform.position, info.staggerAmount, false, true);
            }
        }

        private void HandleStaggerEnter()
        {
            // Popup Text (New Event System)
            _popupEvent?.Raise(transform.position, "STAGGER");

            // Audio via Service Locator
            if (Global.Audio != null && staggerClip)
                Global.Audio.PlaySound(staggerClip, 1f, true);

            _visuals.StartStaggerEffect();
        }

        private void HandleStaggerExit()
        {
            _visuals.StopStaggerEffect();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            // Notify Game Logic (Wave Director / Score)
            _enemyKilledEvent?.Raise(transform.position, stats, reward);

            // Despawn
            if (Global.Pool != null) Global.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }

        // --- Interface Implementation ---
        public bool TakeDamage(DamageInfo info) => _receiver.TakeDamage(info);
        public void Kill(bool instant) => _receiver.Kill(true);
        public void SelfDestruct() => _receiver.Kill(false);
        public void OnExecutionHit() => _receiver.Kill(true);
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyMotors.cs`
- Lines: 226
- Size: 8.0 KB
- Modified: 2026-01-08 23:27

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Physics;
using UnityEngine;

namespace DarkTowerTron.Enemy
{
    // We implement IMover so the PluggableAIController can talk to us directly.
    public class EnemyMotor : MonoBehaviour, IPoolable, IMover
    {
        [Header("Data Profile")]
        public EnemyStatsSO stats;

        [Header("Layers")]
        public LayerMask allyLayer;

        // The underlying Physics Engine (KinematicMover or UnityCharacterMover)
        private IMover _physicsMover;

        // Internal State
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed; // For smooth hovering
        private Collider[] _neighbors = new Collider[10]; // For separation

        // --- IMover Interface Properties (Pass-Through) ---
        public Vector3 Velocity => _physicsMover != null ? _physicsMover.Velocity : Vector3.zero;
        public bool IsGrounded => _physicsMover != null && _physicsMover.IsGrounded;

        private void Awake()
        {
            // 1. Find the REAL physics mover attached to this object.
            // Since EnemyMotor acts as a wrapper, we need to find the "Other" IMover.
            var allMovers = GetComponents<IMover>();
            foreach (var m in allMovers)
            {
                // Cast to interface to compare references
                if (m != (IMover)this)
                {

                    GameLogger.Log(LogChannel.AI, "[EnemyMotor] Found Physics Mover: " + m.GetType().Name, this.gameObject);

                    _physicsMover = m;
                    break;
                }
            }

            // 2. Fallback Safety: If no physics mover exists, add the default KinematicMover.
            if (_physicsMover == null)
            {
                _physicsMover = gameObject.AddComponent<KinematicMover>();
            }

            if (allyLayer == 0) allyLayer = 1 << GameConstants.LAYER_ENEMY;
        }

        // --- IPoolable Implementation ---

        public void OnSpawn()
        {
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Forward the spawn event to the physics engine if it supports it
            if (_physicsMover is IPoolable p) p.OnSpawn();
        }

        public void OnDespawn()
        {
            _currentVelocity = Vector3.zero;
            if (_physicsMover is IPoolable p) p.OnDespawn();
        }

        // --- IMover Implementation (The Logic) ---

        public void Teleport(Vector3 pos) => _physicsMover?.Teleport(pos);

        public void SetEnabled(bool state)
        {
            this.enabled = state;
            // Optionally enable/disable the physics mover too, 
            // though usually we want physics to run even if AI logic is paused.
        }

        /// <summary>
        /// Receives a Direction (usually Magnitude 1) from the AI.
        /// Applies Speed, Acceleration, Hovering, and Separation.
        /// </summary>
        public void Move(Vector3 inputVector)
        {

            GameLogger.Log(LogChannel.AI, "[EnemyMotor] Move Called with Input: " + inputVector.ToString("F2"), this.gameObject);

            if (stats == null || _physicsMover == null) return;

            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

            GameLogger.Log(LogChannel.AI, "[EnemyMotor] Move Input: " + inputVector.ToString("F2"), this.gameObject);

            // 1. Apply Speed Stats
            // The AI sends a direction. We make it a Velocity based on stats.
            Vector3 targetVel = inputVector.normalized * stats.moveSpeed;

            // 2. Separation Logic (Don't stack on top of other enemies)
            if (stats.moveSpeed > 0.1f)
            {
                targetVel += CalculateSeparation();
            }

            // 3. Inertia (Acceleration)
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, stats.acceleration * dt);

            // 4. Knockback Decay
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            Vector3 finalVelocity = _currentVelocity + _knockbackForce;

            // 5. Vertical Logic (Hover vs Gravity)
            if (stats.rideHeight > 0)
            {
                // --- HOVER LOGIC ---
                float groundY = -999f;
                Vector3 rayOrigin = transform.position + Vector3.up * 1.0f;

                // Cast down to find floor/obstacles
                if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 20f, GameConstants.MASK_PHYSICS_OBSTACLES))
                {
                    groundY = hit.point.y;
                }
                else
                {
                    // No ground? Maintain current relative height
                    groundY = transform.position.y - stats.rideHeight;
                }

                float targetY = groundY + stats.rideHeight;
                float currentY = transform.position.y;

                // Smoothly interpolate height
                float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, stats.verticalSmoothTime);

                // Convert position change back to velocity for the Mover
                finalVelocity.y = (newY - currentY) / dt;
            }
            else
            {
                // --- GRAVITY LOGIC ---
                if (!_physicsMover.IsGrounded)
                {
                    finalVelocity.y -= 20f; // Standard Gravity
                }
                else
                {
                    finalVelocity.y = -2f; // Stick to ground
                }
            }

            // 6. Final Execution
            _physicsMover.Move(finalVelocity);
        }

        // --- Helper Methods ---

        private Vector3 CalculateSeparation()
        {
            Vector3 pushVector = Vector3.zero;
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, stats.separationRadius, _neighbors, allyLayer);

            for (int i = 0; i < count; i++)
            {
                var neighbor = _neighbors[i];
                if (neighbor.gameObject == gameObject) continue;

                Vector3 direction = transform.position - neighbor.transform.position;
                float dist = direction.magnitude;

                // Prevent division by zero
                if (dist < 0.01f) direction = Random.insideUnitSphere;

                // Stronger push the closer they are
                pushVector += direction.normalized / (dist + 0.1f);
            }

            return pushVector * stats.separationForce;
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }

        public void FaceTarget(Vector3 targetPos)
        {
            // Ignore Y axis for rotation
            Vector3 dir = targetPos - transform.position;
            dir.y = 0;

            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion rot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, stats.rotationSpeed * Time.deltaTime);
            }
        }

        public void FaceCombatTarget(Vector3 targetPos)
        {
            // Ignore Y axis
            Vector3 dir = targetPos - transform.position;
            dir.y = 0;

            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion rot = Quaternion.LookRotation(dir);
                // Use COMBAT rotation speed (slower/smoother) instead of navigation speed
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, stats.combatRotationSpeed * Time.deltaTime);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Modules\EnemyPatrolModule.cs`
- Lines: 30
- Size: 0.9 KB
- Modified: 2026-01-09 13:56

```csharp
using UnityEngine;
using DarkTowerTron.AI.Paths;

namespace DarkTowerTron.Enemy.Modules
{
    public class EnemyPatrolModule : MonoBehaviour
    {
        [Header("Runtime Data")]
        public PatrolPath patrolPath;
        public int currentWaypointIndex;

        // Helper to get the current target transform safely
        public Transform GetCurrentWaypointTarget()
        {
            if (patrolPath == null || patrolPath.waypoints.Count == 0) return null;

            // Safety wrap
            if (currentWaypointIndex >= patrolPath.waypoints.Count) currentWaypointIndex = 0;

            var wp = patrolPath.waypoints[currentWaypointIndex];
            return wp != null ? wp.transform : null;
        }

        public void AdvanceWaypoint()
        {
            if (patrolPath == null) return;
            currentWaypointIndex = (currentWaypointIndex + 1) % patrolPath.waypoints.Count;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Visuals\EnemyVisuals.cs`
- Lines: 210
- Size: 7.0 KB
- Modified: 2026-01-09 13:53

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Enemy.Visuals
{
    public class EnemyVisuals : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("Leave EMPTY to use the Global Palette.")]
        [FormerlySerializedAs("palette")]
        public ColorPaletteSO paletteOverride;

        [Tooltip("Defines timing and animation curves. Required.")]
        public EnemyVisualProfileSO profile;

        [Header("References")]
        [Tooltip("Assign all mesh parts here. If empty, auto-finds in children.")]
        [SerializeField] private Renderer[] _renderers;

        // Internal
        private MaterialPropertyBlock _propBlock;
        private int _colorPropID;
        private int _emissionPropID;

        // State
        private Color[] _baseColors; // Snapshot of original colors per renderer
        private Color _staggerColor;
        private Color _hitColor;
        private Tween _flashTween;

        private void Awake()
        {
            // Auto-find if not assigned (Convenience)
            if (_renderers == null || _renderers.Length == 0)
                _renderers = GetComponentsInChildren<Renderer>();

            // Validate
            if (_renderers.Length == 0)
            {
                // Warn but don't crash, logic will just loop 0 times
                GameLogger.LogWarning(LogChannel.AI, $"[EnemyVisuals] No Renderers found on {name}", gameObject);
            }

            _baseColors = new Color[_renderers.Length];
            _propBlock = new MaterialPropertyBlock();

            _colorPropID = Shader.PropertyToID("_BaseColor");
            _emissionPropID = Shader.PropertyToID("_EmissionColor");
        }

        private void Start()
        {
            if (profile == null)
            {
                GameLogger.LogError(LogChannel.AI, $"[EnemyVisuals] Profile missing on {gameObject.name}. Animations will fail.", gameObject);
                enabled = false;
                return;
            }

            // Wait one frame to ensure PaletteReceiver has run (Execution Order usually handles this, but safety first)
            InitializeColors();
        }

        public void InitializeColors()
        {
            // 1. Resolve Palette (Override -> Service -> Instance)
            ColorPaletteSO activePalette = paletteOverride;

            if (activePalette == null)
            {
                if (ServiceLocator.TryGet<PaletteManager>(out var manager))
                    activePalette = manager.activePalette;
                else if (PaletteManager.Instance != null)
                    activePalette = PaletteManager.Instance.activePalette;
            }

            // 2. Cache Flash Colors
            if (activePalette != null)
            {
                _staggerColor = activePalette.staggerColor;
                _hitColor = activePalette.hitFlashColor;
            }
            else
            {
                _staggerColor = Color.yellow;
                _hitColor = Color.white;
            }

            // 3. Snapshot Base Colors (The "Memory")
            // We read what is currently on the mesh (set by PaletteReceiver or Material)
            for (int i = 0; i < _renderers.Length; i++)
            {
                Renderer r = _renderers[i];
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // If MPB is empty, fall back to material color
                if (_propBlock.isEmpty || _propBlock.GetColor(_colorPropID) == Color.clear)
                {
                    if (r.sharedMaterial != null && r.sharedMaterial.HasProperty(_colorPropID))
                        _baseColors[i] = r.sharedMaterial.GetColor(_colorPropID);
                    else
                        _baseColors[i] = Color.white;
                }
                else
                {
                    _baseColors[i] = _propBlock.GetColor(_colorPropID);
                }
            }
        }

        // --- VISUAL FX METHODS ---

        public void PlayHitFlash()
        {
            if (profile == null) return;
            if (_flashTween != null && _flashTween.IsActive()) _flashTween.Kill();

            // Flash all parts to pure White
            SetAllColors(_hitColor);

            _flashTween = DOVirtual.DelayedCall(profile.hitFlashDuration, ResetVisuals);
        }

        public void StartStaggerEffect()
        {
            if (profile == null) return;
            if (_flashTween != null) _flashTween.Kill();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, profile.staggerPulseDuration / 2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_staggerColor, profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopStaggerEffect() => ResetVisuals();

        public void StartPrimingEffect()
        {
            if (profile == null) return;
            if (_flashTween != null) _flashTween.Kill();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, 0.1f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(GetBaseColorSafe(0), profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopPrimingEffect() => ResetVisuals();

        public void ResetVisuals()
        {
            if (_flashTween != null) _flashTween.Kill();

            // Restore individual colors
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], _baseColors[i]);
            }
        }

        // --- HELPERS ---

        private void SetAllColors(Color c)
        {
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], c);
            }
        }

        private void ApplyColorToRenderer(Renderer r, Color c)
        {
            if (r == null) return;
            r.GetPropertyBlock(_propBlock);
            _propBlock.SetColor(_colorPropID, c);
            _propBlock.SetColor(_emissionPropID, c);
            r.SetPropertyBlock(_propBlock);
        }

        private Color GetBaseColorSafe(int index)
        {
            if (_baseColors != null && index < _baseColors.Length)
                return _baseColors[index];
            return Color.white;
        }

        private void OnDestroy()
        {
            if (_flashTween != null) _flashTween.Kill();
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\ArenaGate.cs`
- Lines: 89
- Size: 2.9 KB
- Modified: 2026-01-06 15:31

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class ArenaGate : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private VoidEventChannelSO _roomClearedEvent;

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
        }

        private void OnEnable()
        {
            if (_roomClearedEvent != null) _roomClearedEvent.OnEventRaised += OnRoomCleared;
        }

        private void OnDisable()
        {
            if (_roomClearedEvent != null) _roomClearedEvent.OnEventRaised -= OnRoomCleared;
        }

        private void OnRoomCleared()
        {
            SetGate(false);
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
- Lines: 49
- Size: 1.7 KB
- Modified: 2026-01-09 13:37

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
            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                // FIX: Use service reference instead of FindObjectOfType
                var rig = GameServices.CameraRig;
                if (rig != null)
                {
                    // Pass the center of THIS trigger as the lock position
                    rig.OverrideCamera(targetPitch, targetDistance, lockX, lockZ, transform.position);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                var rig = GameServices.CameraRig;
                if (rig != null) rig.ResetToDefault();
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
- Lines: 37
- Size: 1.1 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using UnityEngine;

namespace DarkTowerTron.Environment
{
    public class LevelEndTrigger : MonoBehaviour
    {
        [Header("Broadcasting")]
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                GameLogger.Log(LogChannel.System, "LEVEL COMPLETE", gameObject);

                // Trigger Victory Logic
                _gameVictoryEvent?.Raise();
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
- Modified: 2025-12-30 09:50

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
- Lines: 65
- Size: 2.2 KB
- Modified: 2026-01-09 13:39

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Environment
{
    public class PlayerStart : MonoBehaviour
    {
        [Tooltip("Unique ID for this spawn point (e.g., 'Start', 'Arena2', 'Boss')")]
        public string spawnID = "Start";

        [Header("Visuals")]
        public Color gizmoColor = Color.green;

        // --- THE REGISTRY ---
        private static readonly Dictionary<string, Transform> _registry = new Dictionary<string, Transform>();

        private void OnEnable()
        {
            if (string.IsNullOrWhiteSpace(spawnID)) return;

            if (!_registry.ContainsKey(spawnID))
            {
                _registry.Add(spawnID, transform);
            }
            else if (_registry[spawnID] != transform)
            {
                Debug.LogWarning($"[PlayerStart] Duplicate spawnID '{spawnID}' found on '{name}'. Keeping first registration.", gameObject);
            }
        }

        private void OnDisable()
        {
            if (string.IsNullOrWhiteSpace(spawnID)) return;

            if (_registry.TryGetValue(spawnID, out Transform registered) && registered == transform)
            {
                _registry.Remove(spawnID);
            }
        }

        public static Transform GetSpawnPoint(string id)
        {
            if (!string.IsNullOrWhiteSpace(id) && _registry.TryGetValue(id, out Transform t)) return t;

            // Fallback: Try "Start" if the requested one is missing
            if (id != "Start" && _registry.TryGetValue("Start", out Transform def)) return def;

            return null;
        }
        // --------------------

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

## 📄 `Assets\Scripts\Environment\Props\Prop_Anchor.cs`
- Lines: 118
- Size: 4.1 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat; // For DamageReceiver
using DarkTowerTron.Core.Data;
using DarkTowerTron.Enemy.Visuals; // For EnemyVisuals
using DG.Tweening;
using UnityEngine.Scripting.APIUpdating;

namespace DarkTowerTron.Environment.Props
{
    [MovedFrom(true, "DarkTowerTron.Environment", "Assembly-CSharp", "Prop_Anchor")]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Anchor : MonoBehaviour
    {
        [Header("Anchor Settings")]
        public float respawnTime = 5.0f;
        public GameObject visualRoot; // Assign the mesh object
        public Collider mainCollider;

        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();

            if (visualRoot == null && transform.childCount > 0) visualRoot = transform.GetChild(0).gameObject;
            if (mainCollider == null) mainCollider = GetComponent<Collider>();
        }

        private void Start()
        {
            // Trigger the DamageReceiver to read the Inspector Overrides
            // We pass 'null' for stats because we are using overrides
            if (_receiver != null) _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            if (_receiver != null)
            {
                _receiver.OnDeathProcessed += HandleDeath;
                _receiver.OnHitProcessed += HandleHit;

                // Wire up Stagger Visuals
                if (_receiver.Stagger != null && _visuals != null)
                {
                    _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                    _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
                }
            }
        }

        private void OnDisable()
        {
            if (_receiver != null)
            {
                _receiver.OnDeathProcessed -= HandleDeath;
                _receiver.OnHitProcessed -= HandleHit;

                if (_receiver.Stagger != null && _visuals != null)
                {
                    _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                    _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
                }
            }
        }

        private void HandleHit(DarkTowerTron.Core.DamageInfo info)
        {
            // Trigger the Flash via the Visuals component
            if (_receiver != null && _visuals != null && !_receiver.IsStaggered)
            {
                _visuals.PlayHitFlash();
            }
        }

        private void HandleDeath(EnemyStatsSO stats, bool rewardPlayer)
        {
            // The PlayerExecution just triggered Kill().
            // Instead of destroying the object, we "Disable" it temporarily.
            StartCoroutine(RespawnRoutine());
        }

        private IEnumerator RespawnRoutine()
        {
            // 1. Hide
            if (visualRoot) visualRoot.SetActive(false);
            if (mainCollider) mainCollider.enabled = false;

            // 2. Wait
            yield return new WaitForSeconds(respawnTime);

            // 3. Reset Health
            // We need to revive the Vitality/Stagger modules manually
            if (_receiver != null)
            {
                if (_receiver.Vitality != null) _receiver.Vitality.Revive();
                if (_receiver.Stagger != null) _receiver.Stagger.ResetStagger();
            }

            if (_visuals != null) _visuals.ResetVisuals();

            // 4. Show (with Pop-in animation)
            if (visualRoot)
            {
                visualRoot.SetActive(true);
                visualRoot.transform.DOKill();
                visualRoot.transform.localScale = Vector3.zero;
                visualRoot.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
            }

            if (mainCollider) mainCollider.enabled = true;
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\Props\Prop_Explosive.cs`
- Lines: 108
- Size: 3.4 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Enemy.Visuals;
using DarkTowerTron;

namespace DarkTowerTron.Environment.Props
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Explosive : MonoBehaviour
    {
        [Header("Explosive Settings")]
        public GameObject hazardZonePrefab;

        [Tooltip("If true, Stagger Damage from weapons is applied directly to Health.")]
        public bool volatileOnStagger = true;

        [Header("Visual Feedback")]
        [SerializeField] private DamageTextEventChannelSO _damageTextEvent;

        // References
        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
            }
        }

        private void OnDisable()
        {
            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
            }
        }

        private void HandleHit(DarkTowerTron.Core.DamageInfo info)
        {
            // 1. Visual Flash
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();

            // 2. Damage Numbers (Updated Logic)
            bool isCrit = _receiver.IsStaggered;

            if (info.damageAmount > 0)
            {
                // Show Health Damage (White/Yellow)
                _damageTextEvent?.Raise(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                // Show Stagger Damage (Cyan) - Fixes the "0 Damage" issue
                _damageTextEvent?.Raise(transform.position, info.staggerAmount, false, true);
            }

            // 3. Volatile Logic
            // If this prop is volatile, Stagger actually hurts it
            if (volatileOnStagger && info.staggerAmount > 0)
            {
                _receiver.Vitality.TakeDamage(info.staggerAmount);
            }
        }

        private void HandleDeath(EnemyStatsSO stats, bool rewardPlayer)
        {
            Explode();
        }

        private void Explode()
        {
            Vector3 pos = transform.position;

            if (hazardZonePrefab)
                Global.Pool.Spawn(hazardZonePrefab, pos, Quaternion.identity);

            if (Global.VFX != null && Global.VFX.explosionPrefab)
                Global.Pool.Spawn(Global.VFX.explosionPrefab, pos, Quaternion.identity);

            Global.Pool.Despawn(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Environment\TileInfo.cs`
- Lines: 41
- Size: 1.2 KB
- Modified: 2026-01-09 13:25

```csharp
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor; // <--- WRAP THIS
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

            Gizmos.color = new Color(labelColor.r, labelColor.g, labelColor.b, 0.3f);
            Gizmos.DrawWireCube(transform.position, new Vector3(tileSize, 0.1f, tileSize));

            // --- WRAP THE LABEL LOGIC ---
#if UNITY_EDITOR
            Vector3 pos = transform.position;
            if (transform.parent != null) pos = transform.localPosition;

            int x = Mathf.RoundToInt(pos.x / tileSize);
            int z = Mathf.RoundToInt(pos.z / tileSize);
            string label = $"{x}, {z}";
            
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
- Lines: 71
- Size: 2.0 KB
- Modified: 2026-01-08 06:09

```csharp
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Managers;
using UnityEngine;

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
- Lines: 84
- Size: 3.2 KB
- Modified: 2026-01-09 13:54

```csharp
using DarkTowerTron.Core.Debug;
using DarkTowerTron;
using UnityEngine;

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        [Header("Debug")]
        public bool showDebugRays = true;
        public float debugLineDuration = 20f;

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

            return Global.Pool.Spawn(prefab, spawnPos, Quaternion.LookRotation(sp.forward));
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

                GameLogger.Log(LogChannel.System,
                    $"<color=green>[SPAWN HIT]</color> Object: <b>{hit.collider.name}</b> | Layer: <b>{layerName}</b> | Height Y: <b>{hit.point.y:F2}</b>",
                    hit.collider.gameObject);
            }
            else
            {
                // Draw Red Line all the way down
                Debug.DrawRay(origin, Vector3.down * 100f, Color.red, debugLineDuration);

                GameLogger.LogError(LogChannel.System,
                    $"<color=red>[SPAWN MISS]</color> Raycast from {origin} hit NOTHING! Enemy air-dropped.",
                    gameObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\DebugController.cs`
- Lines: 141
- Size: 4.8 KB
- Modified: 2026-01-09 13:53

```csharp
using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Player.Controller;
using DarkTowerTron.Player.Stats;
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Workflow")]
        public bool autoStartGame = false;

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;

        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Visualization")]
        public bool showEnemyStats = true;

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn;

        [Header("Perk Testing")]
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;

        private IEnumerator Start()
        {
            // Wait for Bootloader and Scene Init
            yield return null;

            // 1. Auto-Start Logic
            if (autoStartGame)
            {
                // FIX: Use Service
                if (GameServices.Session != null)
                {
                    GameLogger.Log(LogChannel.System, "[DEBUG] Auto-Starting Game...", gameObject);
                    GameServices.Session.BeginGame();

                    // Force combat state active
                    _combatStartedEvent?.Raise();
                }
            }

            // 2. Locate Player (Robust Find)
            // (Already cached in Services)
            if (GameServices.Player != null)
            {
                var p = GameServices.Player;
                _energy = p.GetComponent<PlayerEnergy>();
                _health = p.GetComponent<PlayerHealth>();
                _loadout = p.GetComponent<PlayerLoadout>();
            }
        }

        private void Update()
        {
            // Safety check for Input System
            if (Keyboard.current == null) return;

            // Sync debug flag
            DamageReceiver.EnableDebugGizmos = showEnemyStats;

            // [TAB] Toggle Visuals
            if (Keyboard.current.tabKey.wasPressedThisFrame)
            {
                showEnemyStats = !showEnemyStats;
            }

            // [T] Time Control
            if (Keyboard.current.tKey.wasPressedThisFrame)
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f;
                GameLogger.Log(LogChannel.System, $"Time Scale: {Time.timeScale}");
            }

            // [K] Kill All Enemies
            if (Keyboard.current.kKey.wasPressedThisFrame)
            {
                var enemies = FindObjectsOfType<DarkTowerTron.Enemy.EnemyController>();
                foreach (var e in enemies) e.Kill(true);
                GameLogger.Log(LogChannel.Combat, "Nuke Triggered.");
            }

            // [R] Recharge Stats
            if (Keyboard.current.rKey.wasPressedThisFrame && _energy)
            {
                _energy.AddFocus(100f);
                if (_health) _health.HealGrit(2);
            }

            // [NumPad 1-4] Spawning
            if (Keyboard.current.numpad1Key.wasPressedThisFrame) Spawn(0);
            if (Keyboard.current.numpad2Key.wasPressedThisFrame) Spawn(1);
            if (Keyboard.current.numpad3Key.wasPressedThisFrame) Spawn(2);
            if (Keyboard.current.numpad4Key.wasPressedThisFrame) Spawn(3);

            // Cheats Application (Continuous)
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);

            // [H / J] Perk Testing
            if (Keyboard.current.hKey.wasPressedThisFrame && _loadout)
            {
                _loadout.EquipProjectile(homingPrefab);
                GameLogger.Log(LogChannel.Player, "Equipped Homing Projectile");
            }

            if (Keyboard.current.jKey.wasPressedThisFrame && _loadout)
            {
                _loadout.EquipDecoy(explosiveDecoyPrefab);
                GameLogger.Log(LogChannel.Player, "Equipped Explosive Decoy");
            }
        }

        private void Spawn(int index)
        {
            if (enemiesToSpawn == null || index < 0 || index >= enemiesToSpawn.Length) return;

            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0; // Reset height (Motors will handle hovering)

            if (Global.Pool != null)
                Global.Pool.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\GameSession.cs`
- Lines: 178
- Size: 5.4 KB
- Modified: 2026-01-09 13:41

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Environment;
using DarkTowerTron.Physics;
using DarkTowerTron.Player.Stats;
using DarkTowerTron.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;

        [Header("Manager References")]
        public UIManager uiManager;

        [Header("Debug")]
        public string activeSpawnID = "Start";

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls;

        private void Awake()
        {
            GameServices.RegisterSession(this);
            _controls = new GameControls();
            _controls.Gameplay.Pause.performed += ctx => TogglePause();
        }

        private void OnEnable()
        {
            _controls.Enable();
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += TriggerGameOver;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised += TriggerVictory;
        }

        private void OnDisable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= TriggerGameOver;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised -= TriggerVictory;
            _controls.Disable();
        }

        private void Start()
        {
            Time.timeScale = 0f;

            // Use UIManager
            if (uiManager) uiManager.ShowStartMenu();

            // Locate Player via Service
            MovePlayerToStart();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);
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

            // FIX: Query the Registry
            Transform targetPoint = PlayerStart.GetSpawnPoint(activeSpawnID);
            if (targetPoint == null)
            {
                Debug.LogWarning($"[GameSession] Spawn Point '{activeSpawnID}' not found!");
                return;
            }

            // Move Logic
            var uMover = GameServices.Player.GetComponent<UnityCharacterMover>();
            if (uMover != null)
            {
                uMover.Teleport(targetPoint.position);
            }
            else
            {
                // Back-compat: some setups may still use the custom mover
                var kMover = GameServices.Player.GetComponent<KinematicMover>();
                if (kMover != null) kMover.Teleport(targetPoint.position);
                else GameServices.Player.transform.position = targetPoint.position;
            }

            GameServices.Player.transform.rotation = targetPoint.rotation;
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\LevelBuilder.cs`
- Lines: 43
- Size: 1.1 KB
- Modified: 2026-01-08 06:09

```csharp
using System.Collections.Generic;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Environment;
using UnityEngine;

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

## 📄 `Assets\Scripts\Managers\LevelPrewarmer.cs`
- Lines: 30
- Size: 0.7 KB
- Modified: 2026-01-09 13:54

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron;

namespace DarkTowerTron.Managers
{
    public class LevelPrewarmer : MonoBehaviour
    {
        [System.Serializable]
        public struct PoolRequest
        {
            public GameObject prefab;
            public int count;
        }

        public List<PoolRequest> prewarmList;

        private void Start()
        {
            // Wait one frame for Services to be ready (if not using Execution Order)
            if (Global.Pool != null)
            {
                foreach (var req in prewarmList)
                {
                    Global.Pool.Prewarm(req.prefab, req.count);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\WaveDirector.cs`
- Lines: 224
- Size: 7.7 KB
- Modified: 2026-01-08 06:09

```csharp
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using UnityEngine;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(ArenaSpawner))]
    public class WaveDirector : MonoBehaviour
    {
        [Header("Wiring")]
        [Tooltip("Listens for enemy deaths to track wave progress.")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Broadcasting")]
        [SerializeField] private IntEventChannelSO _announceEvent;
        [SerializeField] private StringEventChannelSO _countdownEvent;
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;
        [SerializeField] private VoidEventChannelSO _waveClearedEvent;
        [SerializeField] private VoidEventChannelSO _roomClearedEvent;

        [Header("Configuration")]
        public List<WaveDefinitionSO> waves;
        public float timeBetweenWaves = 3.0f;

        // Internal State
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

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) 
                _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) 
                _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        // --- PUBLIC API ---

        public void StartGame()
        {
            _gameStarted = true;
            _currentWaveIndex = 0;
            StartCoroutine(StartGameRoutine());
        }

        // --- CORE LOGIC ---

        private IEnumerator StartGameRoutine()
        {
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(RunWave(_currentWaveIndex));
        }

        private IEnumerator RunWave(int index)
        {
            // Stop condition: all waves complete
            if (index >= waves.Count)
            {
                GameLogger.Log(LogChannel.System, "ROOM CLEARED", gameObject);
                
                // Triggers doors opening, etc.
                _roomClearedEvent?.Raise();
                yield break;
            }

            WaveDefinitionSO wave = waves[index];
            GameLogger.Log(LogChannel.System, $"STARTING WAVE {index + 1}: {wave.waveName}", gameObject);

            // --- UI ANNOUNCEMENT (Legacy Static Events) ---
            _announceEvent?.Raise(index + 1);
            yield return new WaitForSeconds(1.0f);
            
            _countdownEvent?.Raise("3");
            yield return new WaitForSeconds(1.0f);
            _countdownEvent?.Raise("2");
            yield return new WaitForSeconds(1.0f);
            _countdownEvent?.Raise("1");
            yield return new WaitForSeconds(1.0f);
            
            _countdownEvent?.Raise("ENGAGE");
            _combatStartedEvent?.Raise();
            yield return new WaitForSeconds(0.5f);
            _countdownEvent?.Raise("");
            // -----------------

            // Reset Counters
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
            
            // Check victory in case everything died while we were still spawning
            CheckVictory();
        }

        private IEnumerator GruntLogic(WaveDefinitionSO wave)
        {
            if (wave.maxGrunts <= 0 || wave.gruntPrefabs == null || wave.gruntPrefabs.Length == 0)
                yield break;

            // Anchor Logic: Keep spawning ONLY while VIPs are alive (or main force is still spawning)
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

        private void SpawnEnemy(GameObject prefab, int forcedIndex)
        {
            if (_spawner == null || prefab == null) return;

            // Spawn via Pool
            GameObject instance = _spawner.SpawnEnemy(prefab, forcedIndex);
            if (instance == null) return;

            // Determine if Essential based on the Instance's Stats
            var motor = instance.GetComponent<DarkTowerTron.Enemy.EnemyMotor>();
            bool countAsEssential = false;

            if (motor != null && motor.stats != null)
            {
                countAsEssential = motor.stats.isEssential;
            }
            else
            {
                // Fallback for safety
                countAsEssential = true;
            }

            if (countAsEssential) _essentialEnemiesAlive++;
            else _gruntsAlive++;
        }

        // --- EVENT HANDLERS ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!_gameStarted) return;

            // Logic: Identify who died based on the Stats passed by the event
            if (stats != null && stats.isEssential)
            {
                _essentialEnemiesAlive--;
                GameLogger.Log(LogChannel.System, $"VIP Killed. Remaining: {_essentialEnemiesAlive}", gameObject);

                // Cut reinforcements immediately if VIPs are dead
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

            // Safety clamp
            if (_essentialEnemiesAlive < 0) _essentialEnemiesAlive = 0;
            if (_gruntsAlive < 0) _gruntsAlive = 0;

            CheckVictory();
        }

        private void CheckVictory()
        {
            // VICTORY CONDITION: Room must be totally silent.
            if (_essentialEnemiesAlive <= 0 && _gruntsAlive <= 0 && !_isSpawningMain)
            {
                GameLogger.Log(LogChannel.System, "WAVE CLEARED - SECTOR SECURE", gameObject);

                if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);

                _waveClearedEvent?.Raise(); // UI/FX Feedback
                
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
- Lines: 318
- Size: 12.7 KB
- Modified: 2026-01-08 14:09

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;

namespace DarkTowerTron.Physics
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class KinematicMover : MonoBehaviour, IMover
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
        // OPTIMIZATION: HashSet lookup is O(1) - incredibly fast
        private readonly HashSet<Collider> _myColliders = new HashSet<Collider>();
        private readonly HashSet<Collider> _ignoredExternalColliders = new HashSet<Collider>();

        // Properties
        public Vector3 Velocity => _velocity;
        public bool IsGrounded => _isGrounded;
        public Vector3 GroundNormal => _groundNormal;

        private void Awake()
        {
            _capsule = GetComponent<CapsuleCollider>();

            // 1. Auto-Register Self
            // Find ALL colliders in children (Hitboxes, sensors, shield)
            var childCols = GetComponentsInChildren<Collider>(true); // true = include inactive
            foreach (var c in childCols)
            {
                _myColliders.Add(c);

                // Also ignore physical collision between the capsule and children
                // (Redundant if using Layers, but good for safety)
                if (c != _capsule)
                {
                    UnityEngine.Physics.IgnoreCollision(_capsule, c, true);
                }
            }

            if (Camera.main) _camTransform = Camera.main.transform;
            if (_obstacleMask == 0) _obstacleMask = GameConstants.MASK_PHYSICS_OBSTACLES;
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
        public void SetEnabled(bool state) => enabled = state;

        // Helper for other scripts to check "Is this me?"
        public bool IsMyCollider(Collider c) => c != null && _myColliders.Contains(c);

        public void IgnoreCollider(Collider col)
        {
            if (col == null) return;
            _ignoredExternalColliders.Add(col);
        }

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

                    RaycastHit hit = _hitBuffer[j];
                    Collider col = hit.collider;

                    // FAST CHECK:
                    // 1. Is it me? (O(1))
                    // 2. Is it explicitly ignored? (O(1))
                    // 3. Is it a trigger?
                    if (_myColliders.Contains(col) ||
                        _ignoredExternalColliders.Contains(col) ||
                        col.isTrigger)
                    {
                        continue;
                    }

                    if (hit.distance <= 0) continue;

                    if (hit.distance < closestDist)
                    {
                        closestDist = hit.distance;
                        closest = hit;
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
                if (_myColliders.Contains(col) || _ignoredExternalColliders.Contains(col)) continue;
                
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

## 📄 `Assets\Scripts\Physics\UnityCharacterMover.cs`
- Lines: 54
- Size: 1.6 KB
- Modified: 2026-01-06 15:01

```csharp
using UnityEngine;

namespace DarkTowerTron.Physics
{
    [RequireComponent(typeof(CharacterController))]
    public class UnityCharacterMover : MonoBehaviour, IMover
    {
        private CharacterController _cc;

        // We calculate velocity manually because _cc.velocity is sometimes 
        // strictly based on movement, not external forces we want to track.
        public Vector3 Velocity { get; private set; }

        public bool IsGrounded => _cc.isGrounded;

        private void Awake()
        {
            _cc = GetComponent<CharacterController>();
        }

        public void Move(Vector3 velocity)
        {
            if (!_cc.enabled) return;

            float dt = Time.deltaTime;

            // 1. Apply Movement
            // CC.Move takes Displacement (Velocity * Time)
            _cc.Move(velocity * dt);

            // 2. Update Public Velocity
            // We store what was passed in, so other scripts (Animation/Sound) know how fast we intend to go
            Velocity = velocity;
        }

        public void Teleport(Vector3 position)
        {
            // Critical: CC overrides transform.position. 
            // You must disable it, move, then re-enable.
            bool wasEnabled = _cc.enabled;
            _cc.enabled = false;
            transform.position = position;
            _cc.enabled = wasEnabled;

            Velocity = Vector3.zero;
        }

        public void SetEnabled(bool state)
        {
            this.enabled = state;
            if (_cc) _cc.enabled = state;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Combat\PlayerBeam.cs`
- Lines: 84
- Size: 2.8 KB
- Modified: 2026-01-09 13:53

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Player.Stats;
using DG.Tweening;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Player.Combat
{
    public class PlayerBeam : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 0.5f;
        public float selfRecoil = 15f;
        public GameObject beamVisualPrefab;

        private DarkTowerTron.Player.Movement.PlayerMotor _movement;

        protected override void Awake()
        {
            base.Awake();
            _movement = GetComponent<DarkTowerTron.Player.Movement.PlayerMotor>();
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.BeamRate;
        }

        protected override void Fire()
        {
            // Use Smart Aim (Magnetism)
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
            // Use Mask from Constants
            int mask = GameConstants.MASK_WALLS | (1 << GameConstants.LAYER_ENEMY);

            if (UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out RaycastHit hit, range, mask))
            {
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();

                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = _stats.BeamDamage,
                        staggerAmount = _stats.BeamStagger,
                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject,
                        damageType = DamageType.Melee
                    };

                    target.TakeDamage(info);

                    // Optional: Call Global.Audio.PlaySound(hitSound) here
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Combat\PlayerExecution.cs`
- Lines: 129
- Size: 4.5 KB
- Modified: 2026-01-09 13:53

```csharp
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Movement;
using DarkTowerTron.Player.Stats;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public AudioClip executeClip;

        [Header("Positioning")]
        [Tooltip("How high above the ground to teleport to prevent clipping. 0.1 is usually enough.")]
        public float verticalBuffer = 0.2f;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private PlayerMotor _movement;
        private PlayerStats _stats;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
            _movement = GetComponent<PlayerMotor>();
            _stats = GetComponent<PlayerStats>();
        }

        public void PerformGloryKill()
        {
            if (_isBusy) return;

            // Logic Checks
            if (_scanner == null || _scanner.CurrentTarget == null) return;

            if (!_scanner.CurrentTarget.IsStaggered) return;

            StartCoroutine(ExecutionRoutine(_scanner.CurrentTarget));
        }

        private IEnumerator ExecutionRoutine(ICombatTarget target)
        {
            _isBusy = true;

            // 1. Calculate Base Position (Horizontal only first)
            Vector3 targetPos = target.transform.position;
            
            // Back up slightly from the target so we don't clip inside them
            Vector3 attackPos = targetPos - (transform.forward * 1.5f);

            // 2. Y-Axis Logic (Safe Ground Snap)
            if (target.KeepPlayerGrounded)
            {
                // FIX: Cast from High Up (Enemy Head + 2m) downwards
                // This ensures we don't start the raycast inside the floor if the enemy is short
                Vector3 rayOrigin = targetPos;
                rayOrigin.y += 2.0f;

                int groundMask = DarkTowerTron.Core.GameConstants.MASK_GROUND_ONLY;

                if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 10f, groundMask))
                {
                    // Add a small buffer so we don't clip into the floor after teleport.
                    attackPos.y = hit.point.y + verticalBuffer;
                }
                else
                {
                    // Fallback: Use Player's current height if we can't find ground
                    // This prevents teleporting into the void if the enemy is flying over a pit
                    attackPos.y = transform.position.y + verticalBuffer;
                }
            }
            else
            {
                // Air execution (maintain enemy height)
                attackPos.y = targetPos.y;
            }

            // 3. SAFE TELEPORT (Fixes the "Falling through ground" bug)
            if (_movement)
            {
                _movement.Teleport(attackPos);
                
                // Suspend gravity so we hang in the air during the animation
                _movement.SuspendGravity(_stats.ActionHangTime + 0.5f);
            }

            // 4. Trigger Target Reaction (Die or Reset)
            target.OnExecutionHit();

            // 5. Audio (Service Locator)
            if (executeClip && Global.Audio != null)
                Global.Audio.PlaySound(executeClip, 1f);

            // 6. Rewards
            _energy.AddFocus(killRewardFocus);

            if (Global.Score != null)
                Global.Score.TriggerGloryKillBonus();

            // 7. Juice
            // Replaced GameFeel with specific services

            // A. Time Stop
            if (Global.Time != null)
                Global.Time.HitStop(0.1f);

            // B. Shake (CameraShaker is still a Scene Singleton for now)
            if (DarkTowerTron.Visuals.CameraShaker.Instance)
                DarkTowerTron.Visuals.CameraShaker.Instance.Shake(0.2f, 0.5f);

            yield return new WaitForSeconds(0.1f);

            _isBusy = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Combat\PlayerGun.cs`
- Lines: 57
- Size: 1.6 KB
- Modified: 2026-01-09 13:53

```csharp
using DarkTowerTron.Combat;
using DarkTowerTron.Player.Stats;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(DarkTowerTron.Player.Stats.PlayerLoadout))]
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
            GameObject prefabToSpawn = _loadout.currentProjectile;

            if (prefabToSpawn && firePoint)
            {
                // Use Smart Aim
                Vector3 aimDir = GetAimDirection();

                // Use Global Pool
                GameObject p = Global.Pool.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));

                var proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;

                    // Stats Injection
                    proj.damage = _stats.GunDamage;
                    proj.stagger = _stats.GunStagger;

                    // CRITICAL: Self-Hit Protection
                    proj.SetSource(gameObject);

                    proj.Initialize(aimDir);
                }
            }
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.GunRate;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Combat\PlayerWeaponController.cs`
- Lines: 35
- Size: 1.1 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Player.Combat
{
    public class PlayerWeaponController : MonoBehaviour
    {
        [Header("Inventory")]
        // We link these in Inspector or Awake
        [SerializeField] private WeaponBase _primaryWeapon;   // Beam
        [SerializeField] private WeaponBase _secondaryWeapon; // Gun

        private void Awake()
        {
            // Auto-link if empty (Backwards compatibility with current prefab setup)
            if (_primaryWeapon == null) _primaryWeapon = GetComponent<PlayerBeam>();
            if (_secondaryWeapon == null) _secondaryWeapon = GetComponent<PlayerGun>();
        }

        public void SetPrimaryFire(bool isFiring)
        {
            if (_primaryWeapon) _primaryWeapon.SetFiring(isFiring);
        }

        public void SetSecondaryFire(bool isFiring)
        {
            if (_secondaryWeapon) _secondaryWeapon.SetFiring(isFiring);
        }

        public void StopAll()
        {
            SetPrimaryFire(false);
            SetSecondaryFire(false);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Combat\TargetScanner.cs`
- Lines: 111
- Size: 3.9 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerStats))]
    public class TargetScanner : MonoBehaviour
    {
        [Header("Settings")]
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
        private PlayerStats _stats;

        private void Awake()
        {
            _stats = GetComponent<PlayerStats>();
        }

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
            // NEW: Create a tall vertical capsule
            // From: 5 units below feet (catch things down stairs)
            // To: 10 units above feet (catch flying drones)
            Vector3 p1 = transform.position + (Vector3.down * 5f);
            Vector3 p2 = transform.position + (Vector3.up * 10f);
            
            int layerMask = 1 << GameConstants.LAYER_ENEMY;

            // Use Stats for width/range
            float range = _stats ? _stats.ScanRange : 25f;
            float rad = _stats ? _stats.ScanRadius : 2f; // Width of the pole

            // Change SphereCast to CapsuleCast
            if (UnityEngine.Physics.CapsuleCast(p1, p2, rad, aimDirection, out RaycastHit hit, range, layerMask))
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

## 📄 `Assets\Scripts\Player\Combat\WeaponBase.cs`
- Lines: 151
- Size: 4.9 KB
- Modified: 2026-01-08 06:10

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Player.Stats;
using UnityEngine;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;

        [Header("Behavior")]
        public bool isAutomatic = true;

        [Header("Game Feel")]
        [Tooltip("Audio, Shake, Flash, etc. happens here.")]
        public FeedbackConfigurationSO fireFeedback;

        [Header("Input")]
        public float inputBufferTime = 0.2f;

        protected PlayerStats _stats;
        protected TargetScanner _scanner;

        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;

        private bool _hasFiredThisPress = false;
        private RaycastHit[] _aimBuffer = new RaycastHit[10];

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
            if (!state) _hasFiredThisPress = false;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                if (isAutomatic || !_hasFiredThisPress)
                    _bufferTimer = inputBufferTime;
            }

            if (_bufferTimer > 0 && _timer <= 0)
            {
                if (!isAutomatic && _hasFiredThisPress) return;

                Fire();
                PlayFireFeedback();

                _timer = GetCurrentFireRate();
                _bufferTimer = 0;
                _hasFiredThisPress = true;
            }
        }

        protected abstract float GetCurrentFireRate();
        protected abstract void Fire();

        protected void PlayFireFeedback()
        {
            if (fireFeedback == null) return;

            Vector3 playPos = firePoint != null ? firePoint.position : transform.position;
            fireFeedback.Play(gameObject, playPos);
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            // 1. HARD LOCK
            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                if (_scanner.CurrentTarget is IAimTarget aimTarget)
                    return (aimTarget.AimPoint - firePoint.position).normalized;

                return (_scanner.CurrentTarget.transform.position - firePoint.position).normalized;
            }

            Vector3 inputDir = transform.forward;

            // 2. SMART MAGNETISM
            float range = _stats ? _stats.ScanRange : 20f;
            float radius = 1.5f;
            int mask = (1 << GameConstants.LAYER_ENEMY) | GameConstants.MASK_WALLS;

            Vector3 p1 = transform.position + (Vector3.down * 2f);
            Vector3 p2 = transform.position + (Vector3.up * 8f);

            int hitCount = UnityEngine.Physics.CapsuleCastNonAlloc(
                p1, p2, radius, inputDir, _aimBuffer, range, mask
            );

            IAimTarget bestTarget = null;
            float bestScore = -1f;

            for (int i = 0; i < hitCount; i++)
            {
                RaycastHit hit = _aimBuffer[i];
                IAimTarget candidate = hit.collider.GetComponentInParent<IAimTarget>();

                if (candidate == null) continue;

                // A. Wall Check
                Vector3 directionToTarget = candidate.AimPoint - firePoint.position;
                float distToTarget = directionToTarget.magnitude;

                if (UnityEngine.Physics.Raycast(firePoint.position, directionToTarget, distToTarget, GameConstants.MASK_WALLS))
                    continue;

                // B. Priority Scoring
                float angleScore = Vector3.Dot(inputDir, directionToTarget.normalized);

                if (angleScore > bestScore)
                {
                    bestScore = angleScore;
                    bestTarget = candidate;
                }
            }

            if (bestTarget != null)
            {
                return (bestTarget.AimPoint - firePoint.position).normalized;
            }

            // 3. TERRAIN FALLBACK
            Vector3 futurePos = transform.position + (inputDir * 15f);
            if (UnityEngine.Physics.Raycast(futurePos + Vector3.up * 10f, Vector3.down, out RaycastHit groundHit, 20f, GameConstants.MASK_GROUND_ONLY))
            {
                Vector3 aimAtPoint = groundHit.point + (Vector3.up * 1.5f);
                return (aimAtPoint - firePoint.position).normalized;
            }

            return inputDir;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Controller\PlayerController.cs`
- Lines: 94
- Size: 3.0 KB
- Modified: 2026-01-08 06:00

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Combat;   // Ensure these match your folders
using DarkTowerTron.Player.Movement;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Controller
{
    [RequireComponent(typeof(PlayerInputHandler))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerExecution))]
    [RequireComponent(typeof(PlayerWeaponController))]
    public class PlayerController : MonoBehaviour
    {
        // --- Dependencies ---
        private PlayerInputHandler _input;
        private PlayerMotor _movement;
        private PlayerDodge _dodge;
        private PlayerExecution _execution;
        private PlayerWeaponController _weapons;
        private TargetScanner _scanner;

        private void Awake()
        {
            // 1. Get Components
            _input = GetComponent<PlayerInputHandler>();
            _movement = GetComponent<PlayerMotor>();
            _dodge = GetComponent<PlayerDodge>();
            _execution = GetComponent<PlayerExecution>();
            _weapons = GetComponent<PlayerWeaponController>();
            _scanner = GetComponent<TargetScanner>();

            // 2. Bind Input Events
            _input.OnDash += PerformDodge;
            _input.OnGloryKill += PerformGloryKill;

            // 3. Register Service
            GameServices.RegisterPlayer(this);
        }

        private void OnDestroy()
        {
            if (_input)
            {
                _input.OnDash -= PerformDodge;
                _input.OnGloryKill -= PerformGloryKill;
            }
        }

        private void Update()
        {
            // 1. Movement
            // We read from the Handler. If Handler is crashing (null refs), this returns (0,0)
            Vector3 moveDir = new Vector3(_input.MoveInput.x, 0, _input.MoveInput.y).normalized;
            _movement.SetMoveInput(moveDir);

            // 2. Looking / Aiming
            Vector3 aimDir = _input.LookDirection;
            if (aimDir == Vector3.zero) aimDir = transform.forward; 
            
            _movement.LookAtDirection(aimDir);
            if (_scanner) _scanner.UpdateScanner(aimDir);

            // 3. Weapons
            _weapons.SetPrimaryFire(_input.FirePrimary);
            _weapons.SetSecondaryFire(_input.FireSecondary);
        }

        // --- ACTION HANDLERS ---

        private void PerformDodge()
        {
            if (_dodge) _dodge.PerformDodge();
        }

        private void PerformGloryKill()
        {
            if (_execution) _execution.PerformGloryKill();
        }

        // --- PUBLIC API ---

        public void ToggleInput(bool state)
        {
            if (_input) _input.ToggleInput(state);
            if (!state)
            {
                _movement.SetMoveInput(Vector3.zero);
                _weapons.StopAll();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Controller\PlayerInputHandler.cs`
- Lines: 207
- Size: 7.0 KB
- Modified: 2026-01-08 06:11

```csharp
using System;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DarkTowerTron.Player.Controller
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [Header("Input Assets")]
        [SerializeField] private InputActionReference _moveAction;
        [SerializeField] private InputActionReference _aimGamepadAction;
        [SerializeField] private InputActionReference _aimMouseAction;
        
        [Header("Actions")]
        [SerializeField] private InputActionReference _firePrimaryAction;   // Beam
        [SerializeField] private InputActionReference _fireSecondaryAction; // Gun
        [SerializeField] private InputActionReference _dashAction;
        [SerializeField] private InputActionReference _gloryKillAction;

        [Header("Settings")]
        public float bufferTime = 0.15f;

        // --- PUBLIC DATA ---
        public Vector2 MoveInput { get; private set; }
        public Vector3 LookDirection { get; private set; } 
        public bool FirePrimary { get; private set; }   
        public bool FireSecondary { get; private set; } 

        // --- EVENTS ---
        public event Action OnDash;
        public event Action OnGloryKill;

        // --- INTERNAL ---
        private InputBuffer _buffer;
        private bool _inputEnabled = true;
        private Camera _cam;

        private void Awake()
        {
            // 1. Dependency Validation
            if (!AreInputsBound())
            {
                GameLogger.LogError(LogChannel.Player,
                    "CRITICAL: Missing Input Action References! Disabling InputHandler to prevent crash.", gameObject);

                enabled = false; // Stop Update() from running
                return;
            }

            // 2. Normal Init
            _cam = Camera.main;
            _buffer = new InputBuffer(bufferTime);
        }

        private void OnEnable()
        {
            EnableActions();
        }

        private void OnDisable()
        {
            DisableActions();
        }

        private void Update()
        {
            // 1. Always Read Continuous Input (Move/Aim)
            // Even if input is "disabled" via gameplay state, we might want to read it 
            // but return zero in the properties.
            if (_inputEnabled)
            {
                ProcessContinuousInputs();
                ProcessBufferedInputs();
            }
            else
            {
                ClearInputs();
            }
        }

        private void ProcessContinuousInputs()
        {
            // 1. Movement
            MoveInput = _moveAction.action.ReadValue<Vector2>();

            // 2. Aiming
            HandleAiming();

            // 3. Weapons (Hold)
            FirePrimary = _firePrimaryAction.action.ReadValue<float>() > 0.5f;
            FireSecondary = _fireSecondaryAction.action.ReadValue<float>() > 0.5f;
        }

        private void ProcessBufferedInputs()
        {
            // Check buffer for queued actions
            if (_buffer.TryConsumeAction("Dash")) OnDash?.Invoke();
            if (_buffer.TryConsumeAction("GloryKill")) OnGloryKill?.Invoke();
        }

        private void HandleAiming()
        {
            // Similar logic to before, but using References
            Vector2 stick = _aimGamepadAction.action.ReadValue<Vector2>();
            if (stick.sqrMagnitude > 0.05f)
            {
                LookDirection = new Vector3(stick.x, 0, stick.y).normalized;
                return; 
            }

            Vector2 mousePos = _aimMouseAction.action.ReadValue<Vector2>();
            Ray ray = _cam.ScreenPointToRay(mousePos);
            Plane ground = new Plane(Vector3.up, Vector3.zero);

            if (ground.Raycast(ray, out float enter))
            {
                Vector3 worldPoint = ray.GetPoint(enter);
                Vector3 dir = (worldPoint - transform.position);
                dir.y = 0;
                
                if (dir.sqrMagnitude > 0.001f) LookDirection = dir.normalized;
            }
        }

        // --- EVENT LISTENERS ---
        // We bind these in Enable/Disable
        private void OnDashPerformed(InputAction.CallbackContext ctx) => _buffer.BufferAction("Dash");
        private void OnKillPerformed(InputAction.CallbackContext ctx) => _buffer.BufferAction("GloryKill");

        private void ClearInputs()
        {
            MoveInput = Vector2.zero;
            FirePrimary = false;
            FireSecondary = false;
            _buffer.Clear();
        }

        public void ToggleInput(bool state)
        {
            _inputEnabled = state;
            if (!state) ClearInputs();
        }

        // --- HELPER: BOILERPLATE BINDING ---
        private void EnableActions()
        {
            SetActionState(_moveAction, true);
            SetActionState(_aimGamepadAction, true);
            SetActionState(_aimMouseAction, true);
            SetActionState(_firePrimaryAction, true);
            SetActionState(_fireSecondaryAction, true);

            if (_dashAction != null)
            {
                _dashAction.action.performed += OnDashPerformed;
                _dashAction.action.Enable();
            }
            if (_gloryKillAction != null)
            {
                _gloryKillAction.action.performed += OnKillPerformed;
                _gloryKillAction.action.Enable();
            }
        }

        private void DisableActions()
        {
            SetActionState(_moveAction, false);
            SetActionState(_aimGamepadAction, false);
            SetActionState(_aimMouseAction, false);
            SetActionState(_firePrimaryAction, false);
            SetActionState(_fireSecondaryAction, false);

            if (_dashAction != null)
            {
                _dashAction.action.performed -= OnDashPerformed;
                _dashAction.action.Disable();
            }
            if (_gloryKillAction != null)
            {
                _gloryKillAction.action.performed -= OnKillPerformed;
                _gloryKillAction.action.Disable();
            }
        }

        private void SetActionState(InputActionReference refAction, bool enable)
        {
            if (refAction == null) return;
            if (enable) refAction.action.Enable();
            else refAction.action.Disable();
        }

        private bool AreInputsBound()
        {
            // Check the essential ones.
            // If secondary weapons/abilities are optional, you can leave them out of this check.
            if (_moveAction == null) return false;
            if (_aimGamepadAction == null) return false;
            if (_aimMouseAction == null) return false;
            if (_firePrimaryAction == null) return false;
            // if (_dashAction == null) return false; // Uncomment if Dash is mandatory

            return true;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Movement\AfterImage.cs`
- Lines: 93
- Size: 2.5 KB
- Modified: 2026-01-06 15:28

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Events;
using DG.Tweening;

namespace DarkTowerTron.Player.Movement
{
    public class AfterImage : MonoBehaviour, IDamageable, ICombatTarget
    {
        [Header("Broadcasting")]
        [SerializeField] private TransformEventChannelSO _decoySpawnedEvent;
        [SerializeField] private VoidEventChannelSO _decoyExpiredEvent;

        [Header("Stats")]
        public float lifetime = 1.0f;
        public float health = 10f; // Default hp

        // State
        private bool _isDead = false;
        private Tween _fadeTween;

        // ICombatTarget
        public bool IsStaggered => false; // Decoys cannot be staggered
        public bool KeepPlayerGrounded => false;
        // Transform property is inherited from MonoBehaviour

        private void Start()
        {
            // 1. Notify AI
            _decoySpawnedEvent?.Raise(transform);

            // 2. Visual Fade
            Renderer rend = GetComponentInChildren<Renderer>();
            if (rend)
            {
                // Ensure we don't crash if material is missing
                _fadeTween = rend.material.DOFade(0f, lifetime).SetEase(Ease.Linear);
            }

            // 3. Schedule Death (Use Invoke to be safe against Tween errors)
            Invoke(nameof(Expire), lifetime);
        }

        private void OnDestroy()
        {
            // Cleanup
            if (_fadeTween != null) _fadeTween.Kill();

            _decoyExpiredEvent?.Raise();
        }

        public void OnExecutionHit()
        {
            // If player attacks their own decoy, pop it
            Kill(true);
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            // Take damage
            health -= info.damageAmount;

            // Visual Shake (Feedback)
            transform.DOPunchScale(Vector3.one * 0.2f, 0.1f);

            if (health <= 0)
            {
                Kill(false);
            }
            
            // Return true so bullets register a hit and despawn
            return true; 
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;

            // Optional: Play "Pop" sound here via Services.Audio

            Destroy(gameObject);
        }

        private void Expire()
        {
            Kill(false);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Movement\PlayerDodge.cs`
- Lines: 187
- Size: 6.0 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.Player.Stats;
using DarkTowerTron;

namespace DarkTowerTron.Player.Movement
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerLoadout))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerDodge : MonoBehaviour
    {
        // REMOVED: public float focusCost, dashDistance, dashDuration 
        // (Moved to PlayerStatsSO)

        // REMOVED: public LayerMask projectileLayer, wallLayer
        // (Moved to GameConstants)

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
        private PlayerMotor _movement;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMotor>();
            _loadout = GetComponent<PlayerLoadout>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

            // CHANGE: Use Stats
            if (_energy.SpendFocus(_stats.DashCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        private IEnumerator DodgeRoutine()
        {
            IsDashing = true;
            IsInvulnerable = true;

            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // 1. Gravity Suspension (Stats)
            _movement.SuspendGravity(_stats.DashDuration + _stats.ActionHangTime);

            // 2. Audio (Service Locator)
            if (Global.Audio != null && dashClip)
                Global.Audio.PlaySound(dashClip, 1f, true);

            // 3. Decoy
            if (_loadout && _loadout.currentDecoy)
                Instantiate(_loadout.currentDecoy, transform.position, transform.rotation);

            // 4. Direction
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f)
                dashDir = _movement.MoveInput.normalized;
            else
                dashDir = transform.forward;

            // 5. Physics Loop (Stats)
            float speed = _stats.DashDistance / _stats.DashDuration;
            float timer = 0f;

            while (timer < _stats.DashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;

                _mover.Move(dashDir * speed);
                CatchProjectiles();

                yield return null;
            }

            yield return new WaitForSeconds(0.05f);

            IsInvulnerable = false;
            IsDashing = false;
        }

        private void CatchProjectiles()
        {
            // CHANGE: Use GameConstants
            int layerMask = 1 << GameConstants.LAYER_PROJECTILE;
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, layerMask);

            foreach (var hit in hits)
            {
                // Check Interface via Component
                IReflectable proj = hit.GetComponent<IReflectable>();

                // Check Projectile specific implementation for hostility
                // (Ideally IReflectable should have IsHostile, but for now we cast to concrete)
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    // Redirect
                    proj.Redirect(transform.forward, gameObject);

                    // Reward
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

            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;

            // CHANGE: Use GameConstants and Stats
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, _stats.DashDistance, GameConstants.MASK_WALLS))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * _stats.DashDistance);
            }

            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            // Visual Feedback
            if (indicatorRenderer && readyMat && notReadyMat)
            {
                // CHANGE: Use Stats
                bool canAfford = _energy.HasFocus(_stats.DashCost);
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

## 📄 `Assets\Scripts\Player\Movement\PlayerMotor.cs`
- Lines: 291
- Size: 9.9 KB
- Modified: 2026-01-09 07:11

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Physics;
using DarkTowerTron.Player.Stats;
using UnityEngine;

namespace DarkTowerTron.Player.Movement
{
    // Intentionally not requiring a specific mover so we can swap implementations.
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMotor : MonoBehaviour
    {
        [Header("Mover Selection")]
        [Tooltip("If true, attempts to use UnityCharacterMover. If false, uses KinematicMover.")]
        public bool useUnityController = false;

        [Header("Wall Repulsion")]
        public float wallBuffer = 0.6f; // Keep this (Collider size dependency)

        [Header("Safety Net")]
        public float safeGroundTimer = 0.5f; // Time required to be grounded to count as "Safe"
        
        // Read-only property for the Health script to access
        public Vector3 LastSafePosition { get; private set; }

        // Expose input for Blitz
        public Vector3 MoveInput => _inputDir;

        private IMover _mover;
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
            _cam = Camera.main;
            _stats = GetComponent<PlayerStats>();

            InitializeMover();
        }

        private void Start()
        {
            LastSafePosition = transform.position;
        }

        private void InitializeMover()
        {
            var kMover = GetComponent<KinematicMover>();
            var uMover = GetComponent<UnityCharacterMover>();

            // Disable both initially
            if (kMover) kMover.SetEnabled(false);
            if (uMover) uMover.SetEnabled(false);

            if (useUnityController)
            {
                if (uMover == null) uMover = gameObject.AddComponent<UnityCharacterMover>();
                _mover = uMover;

                // Disable collision on KinematicMover (CapsuleCollider) to avoid double collision
                if (kMover && kMover.GetComponent<Collider>())
                    kMover.GetComponent<Collider>().enabled = false;
            }
            else
            {
                if (kMover == null) kMover = gameObject.AddComponent<KinematicMover>();
                _mover = kMover;

                // Re-enable CapsuleCollider
                if (kMover.GetComponent<Collider>())
                    kMover.GetComponent<Collider>().enabled = true;
            }

            _mover?.SetEnabled(true);
            if (_mover != null) GameLogger.Log(LogChannel.Player, $"[PlayerMovement] Using Mover: {_mover.GetType().Name}");
        }

        [ContextMenu("Swap Mover")]
        public void SwapMover()
        {
            useUnityController = !useUnityController;
            InitializeMover();
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
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, _stats.RotationSpeed * Time.deltaTime);
            }
        }

        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            // Use UnityEngine.Physics to disambiguate
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, GameConstants.MASK_GROUND_ONLY))
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
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, _stats.Deceleration * dt);
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
                finalVelocity.y -= _stats.Gravity;
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

        public void Teleport(Vector3 position)
        {
            // 1. Reset Velocities
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _gravitySuspendTimer = 0f;

            // 2. Delegate to the Interface (which handles the CC enable/disable safety)
            if (_mover != null)
            {
                _mover.Teleport(position);
            }
            else
            {
                transform.position = position;
            }
        }

        private void HandleSafeGround()
        {
            // STRICT CHECK:
            // 1. Must be physically grounded (Motor check)
            // 2. Must have ground directly beneath center (Raycast check)
            // This prevents saving "The Edge" as a safe spot.
            
            bool isCenterSupported = false;
            
            // Cast from slightly up, downwards. Check GROUND layer only.
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, 2.0f, GameConstants.MASK_GROUND_ONLY))
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

            // CHANGE: Use Constant instead of variable
            int layerMask = GameConstants.MASK_WALLS;

            // Find walls within buffer range
            // We use the player's position + slight up offset (center of mass)
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, wallBuffer, _wallBuffer, layerMask);

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
                    push += dir.normalized * _stats.WallRepulsion;
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

## 📄 `Assets\Scripts\Player\Stats\PlayerEnergy.cs`
- Lines: 115
- Size: 4.2 KB
- Modified: 2026-01-06 15:30

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Access to Event Channels

namespace DarkTowerTron.Player.Stats
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Broadcasting")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent; // Replaces OnFocusChanged

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;         // Replaces OnPlayerDied
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;      // Replaces OnWaveCombatStarted
        [SerializeField] private VoidEventChannelSO _waveClearedEvent;        // Replaces OnWaveCleared
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;        // Replaces OnGameVictory

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
            if (_stats == null) return;
            _currentFocus = _stats.MaxFocus;
            UpdateUI();
        }

        private void OnEnable()
        {
            // Subscribe to SO Event
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;

            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += OnPlayerDied;
            if (_combatStartedEvent != null) _combatStartedEvent.OnEventRaised += EnableDecay;
            if (_waveClearedEvent != null) _waveClearedEvent.OnEventRaised += DisableDecay;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised += DisableDecay;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;

            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
            if (_combatStartedEvent != null) _combatStartedEvent.OnEventRaised -= EnableDecay;
            if (_waveClearedEvent != null) _waveClearedEvent.OnEventRaised -= DisableDecay;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised -= DisableDecay;
        }

        private void Update()
        {
            if (_isDead) return;

            bool shouldBeOverdrive = _currentFocus >= _stats.baseStats.overdriveThreshold;
            _stats.SetOverdrive(shouldBeOverdrive);

            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= _stats.FocusDecayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                UpdateUI();
            }
        }

        // --- PUBLIC API ---
        public bool HasFocus(float amount) => _currentFocus >= amount;

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
            if (_currentFocus > _stats.MaxFocus) _currentFocus = _stats.MaxFocus;
            UpdateUI();
        }

        // --- HANDLERS ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;
            float gain = (stats != null) ? stats.focusReward : _stats.BaseFocusOnKill;
            AddFocus(gain);
        }

        private void EnableDecay() { _isCombatActive = true; }
        private void DisableDecay() { _isCombatActive = false; }
        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            // NEW: Raise via Channel
            if (_focusEvent != null) 
                _focusEvent.Raise(_currentFocus, _stats.MaxFocus);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\Stats\PlayerHealth.cs`
- Lines: 187
- Size: 6.1 KB
- Modified: 2026-01-08 23:44

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Player.Movement;
using UnityEngine;

namespace DarkTowerTron.Player.Stats
{
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerHealth : MonoBehaviour, IDamageable, IAimTarget
    {
        [Header("Configuration")]
        public bool startWithHull = true;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget; // Assign 'CameraTarget' or 'Visuals/Spine'

        [Header("Juice")]
        [SerializeField] private FeedbackConfigurationSO _damageFeedback;
        [SerializeField] private FeedbackConfigurationSO _deathFeedback;

        [Header("Broadcasting")]
        [SerializeField] private IntIntEventChannelSO _gritEvent;      // Replaces OnGritChanged
        [SerializeField] private BoolEventChannelSO _hullEvent;        // Replaces OnHullStateChanged
        [SerializeField] private VoidEventChannelSO _playerHitEvent;   // Replaces OnPlayerHit
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;  // Replaces OnPlayerDied

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        
        private PlayerMotor _movement;
        private PlayerDodge _dodge;
        private PlayerStats _stats;

        private void Awake()
        {
            _movement = GetComponent<PlayerMotor>();
            _dodge = GetComponent<PlayerDodge>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            _currentGrit = _stats ? _stats.MaxGrit : 2;
            _hasHull = startWithHull;
            UpdateUI();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;
            if (_dodge != null && _dodge.IsInvulnerable) return false;

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            GameLogger.Log(LogChannel.Player, $"[PlayerHealth] Taking {dmg} Damage. Grit: {_currentGrit} -> {_currentGrit - dmg}", gameObject);

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0;

                // NEW: Raise Void Event for FX/Camera Shake
                _playerHitEvent?.Raise();
                _damageFeedback?.Play(gameObject, transform.position);
            }
            else if (_hasHull)
            {
                _hasHull = false;
                _playerHitEvent?.Raise();
                _damageFeedback?.Play(gameObject, transform.position);
            }
            else
            {
                Kill(false);
            }

            if (!_isDead && _movement) 
                _movement.ApplyKnockback(info.pushDirection * info.pushForce);

            GameLogger.Log(LogChannel.Player, $"[PlayerHealth] Post-Damage State. Grit: {_currentGrit}, HasHull: {_hasHull}", gameObject);

            UpdateUI();
            return true;
        }

        public void TakeVoidDamage()
        {
            if (_isDead) return;
            
            if (_movement)
            {
                _movement.ResetVelocity();
                var motor = GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            // Simulate Environment Damage
            TakeDamage(new DamageInfo { damageAmount = 1f, damageType = DamageType.Environment });
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            
            _deathFeedback?.Play(gameObject, transform.position);
            
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();
            
            GameLogger.Log(LogChannel.Player, "PLAYER DEAD", gameObject);
            _playerDiedEvent?.Raise();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            int max = _stats ? _stats.MaxGrit : 2;
            _currentGrit = Mathf.Min(_currentGrit + amount, max);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Case A: Stats exist (Standard Enemy)
            if (stats != null)
            {
                if (stats.healsGrit)
                {
                    HealGrit(stats.gritRewardAmount);
                }
                // If !healsGrit, do nothing. Correct.
            }
            // Case B: No Stats (Debug Enemy / Test Dummy)
            else
            {
                // Fallback: Default behavior for untyped enemies
                HealGrit(1);
            }
        }

        public void ForceUpdateUI() => UpdateUI();

        private void UpdateUI()
        {
            int max = _stats ? _stats.MaxGrit : 2;
            
            // NEW: Raise Typed Events
            _gritEvent?.Raise(_currentGrit, max);
            _hullEvent?.Raise(_hasHull);
        }

        // --- IAimTarget ---
        public Vector3 AimPoint
        {
            get
            {
                if (_aimTarget == null) return transform.position + Vector3.up * 1.2f;
                return _aimTarget.position;
            }
        }
        public float TargetRadius => 0.5f;
    }
}
```

## 📄 `Assets\Scripts\Player\Stats\PlayerLoadout.cs`
- Lines: 37
- Size: 0.9 KB
- Modified: 2026-01-06 09:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Player.Stats
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

## 📄 `Assets\Scripts\Player\Stats\PlayerStats.cs`
- Lines: 79
- Size: 3.1 KB
- Modified: 2026-01-08 06:09

```csharp
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using UnityEngine;

namespace DarkTowerTron.Player.Stats
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Base Configuration")]
        public PlayerStatsSO baseStats;

        public bool IsOverdrive { get; private set; }

        // Helper property to shorten null checks
        private PlayerStatsSO Base => baseStats;

        private void Awake()
        {
            if (baseStats == null)
            {
                GameLogger.LogError(LogChannel.Player,
                    $"[PlayerStats] CRITICAL: Missing PlayerStatsSO on {name}! Drag 'Stats_Player_Default' into the inspector.",
                    gameObject);
            }
        }

        // --- MOVEMENT & PHYSICS ---
        public float MoveSpeed => IsOverdrive
            ? (Base?.moveSpeed ?? 12f) * (Base?.overdriveSpeedMult ?? 1f)
            : (Base?.moveSpeed ?? 12f);
        public float Acceleration => Base?.acceleration ?? 60f;
        public float Deceleration => Base?.deceleration ?? 40f;
        public float RotationSpeed => Base?.rotationSpeed ?? 25f;
        public float Gravity => Base?.gravity ?? 20f;
        public float WallRepulsion => Base?.wallRepulsionForce ?? 5f;
        public float ActionHangTime => Base?.actionHangTime ?? 0.2f;

        // --- SCANNER ---
        public float ScanRange => Base?.scanRange ?? 25f;
        public float ScanRadius => Base?.scanRadius ?? 2f;

        // --- ABILITIES ---
        public float DashCost => Base?.dashCost ?? 0f;
        public float DashDistance => Base?.dashDistance ?? 0f;
        public float DashDuration => Base?.dashCooldown ?? 0f;

        // --- WEAPON: GUN ---
        public float GunDamage => IsOverdrive
            ? (Base?.gunDamage ?? 1f) * (Base?.overdriveDamageMult ?? 1f)
            : (Base?.gunDamage ?? 1f);
        public int GunStagger => Base?.gunStagger ?? 0;
        // Rate: Lower is faster. If OverdriveMult is 1.5 (Faster), we divide the delay.
        public float GunRate => IsOverdrive
            ? (Base?.gunFireRate ?? 0.2f) / (Base?.overdriveFireRateMult ?? 1f)
            : (Base?.gunFireRate ?? 0.2f);

        // --- WEAPON: BEAM ---
        public float BeamDamage => IsOverdrive
            ? (Base?.beamDamage ?? 1f) * (Base?.overdriveDamageMult ?? 1f)
            : (Base?.beamDamage ?? 1f);
        public int BeamStagger => Base?.beamStagger ?? 0;
        public float BeamRate => IsOverdrive
            ? (Base?.beamFireRate ?? 0.2f) / (Base?.overdriveFireRateMult ?? 1f)
            : (Base?.beamFireRate ?? 0.2f);

        // --- RESOURCES ---
        public int MaxGrit => Base?.maxGrit ?? 3;
        public float MaxFocus => Base?.maxFocus ?? 100f;
        
        // Future proofing: Modifiers could change these later
        public float FocusDecayRate => Base?.focusDecayRate ?? 5f; 
        public float BaseFocusOnKill => Base?.baseFocusOnKill ?? 20f;

        public void SetOverdrive(bool state)
        {
            IsOverdrive = state;
        }
    }
}
```

## 📄 `Assets\Scripts\Services\AudioManager.cs`
- Lines: 39
- Size: 1.2 KB
- Modified: 2026-01-09 13:47

```csharp
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core; // For GameLogger

namespace DarkTowerTron.Systems
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        // REMOVED: public static AudioManager Instance;

        [SerializeField] private AudioSource _sfxSource;

        private void Awake()
        {
            // REMOVED: Singleton check
            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        public void PlaySound(SoundDef soundDef)
        {
            if (soundDef == null || _sfxSource == null) return;

            AudioClip clip = soundDef.GetClip();
            if (clip == null) return;

            _sfxSource.pitch = soundDef.GetPitch();
            _sfxSource.PlayOneShot(clip, soundDef.volume);
        }

        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (clip == null || _sfxSource == null) return;
            _sfxSource.pitch = randomizePitch ? Random.Range(0.9f, 1.1f) : 1f;
            _sfxSource.PlayOneShot(clip, volume);
        }
    }
}
```

## 📄 `Assets\Scripts\Services\MusicManager.cs`
- Lines: 61
- Size: 1.7 KB
- Modified: 2026-01-09 13:47

```csharp
using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Core; // For GameEvents
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        [Header("Listening")]
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        private AudioSource _source;
        private float _originalPitch;
        private float _originalVolume;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            _originalPitch = _source.pitch;
            _originalVolume = _source.volume;
        }

        private void Start()
        {
            // Auto-start if not playing
            if (!_source.isPlaying && _source.clip != null)
                _source.Play();
        }

        private void OnEnable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += OnDeath;
        }

        private void OnDisable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= OnDeath;
        }

        private void OnDeath()
        {
            // "Power Down" Effect
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true);
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }

        public void ResetMusic()
        {
            _source.DOKill();
            _source.pitch = _originalPitch;
            _source.volume = _originalVolume;
        }

        public void SetVolume(float volume)
        {
            _source.volume = volume;
        }
    }
}
```

## 📄 `Assets\Scripts\Services\PaletteManager.cs`
- Lines: 136
- Size: 4.4 KB
- Modified: 2026-01-09 13:53

```csharp
using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Systems
{
    [ExecuteAlways]
    public class PaletteManager : MonoBehaviour
    {
        public static PaletteManager Instance;

        // --- NEW: Restore the Event ---
        public event Action OnPaletteChanged;

        [Header("Active Configuration")]
        public ColorPaletteSO activePalette;
        public string activeVariant = "";

        [Header("Material Bindings")]
        public List<SurfaceBinding> bindings;

        [System.Serializable]
        public struct SurfaceBinding
        {
            // Legacy (string-based) surface name. Kept for migration/backward compatibility.
            [HideInInspector] public string surfaceName;

            [FormerlySerializedAs("surfaceType")]
            public SurfaceType type;
            public MaterialCollectionSO collection;
        }

        [Header("Debug")]
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
                Instance = this;
            }
        }

        private void Start()
        {
            if (Application.isPlaying) ApplyPalette();
        }

        private void Update()
        {
            if (refreshNow)
            {
                ApplyPalette();
                refreshNow = false;
            }
        }

        public void SetVariant(string variantName)
        {
            activeVariant = variantName;
            ApplyPalette();
        }

        public void ApplyPalette()
        {
            if (activePalette == null) return;

            // 1. Apply Surfaces
            foreach (var binding in bindings)
            {

                GameLogger.Log(LogChannel.VFX, $"Applying Surface: {binding.type} to Collection: {binding.collection?.name}", gameObject);

                if (binding.collection == null) continue;

                // Pass the Enum
                SurfaceDefinition def = activePalette.GetSurface(binding.type, activeVariant);
                ApplyToCollection(binding.collection, def);
            }

            // 2. Apply Globals
            if (Camera.main != null)
            {
                // URP: This sets the "Background Type" to Solid Color
                Camera.main.clearFlags = CameraClearFlags.SolidColor;
                Camera.main.backgroundColor = activePalette.skyColor;
            }

            // 3. Apply Fog (The Infinite Void)
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.ExponentialSquared; // Best for "Void" look
            RenderSettings.fogColor = activePalette.skyColor;
            RenderSettings.fogDensity = activePalette.fogDensity;

            // 4. Notify Listeners (PaletteReceiver)
            OnPaletteChanged?.Invoke(); // <--- RESTORED

            GameLogger.Log(LogChannel.VFX, $"Palette Applied: {activePalette.name} [{activeVariant}]", gameObject);
        }

        private void ApplyToCollection(MaterialCollectionSO col, SurfaceDefinition def)
        {
            if (col.materials == null) return;

            foreach (Material mat in col.materials)
            {
                if (mat == null) continue;

                if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", def.mainColor);
                else if (mat.HasProperty("_Color")) mat.SetColor("_Color", def.mainColor);

                if (mat.HasProperty("_EmissionColor"))
                {
                    mat.SetColor("_EmissionColor", def.emissionColor);
                    mat.EnableKeyword("_EMISSION");
                }
                else if (mat.HasProperty("_GlowColor"))
                {
                    Color hdrGlow = def.emissionColor * Mathf.LinearToGammaSpace(def.emissionIntensity > 0 ? def.emissionIntensity : 1f);
                    mat.SetColor("_GlowColor", hdrGlow);
                }

                if (mat.HasProperty("_Smoothness")) mat.SetFloat("_Smoothness", def.smoothness);
                if (mat.HasProperty("_Metallic")) mat.SetFloat("_Metallic", def.metallic);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Services\PoolManager.cs`
- Lines: 169
- Size: 5.9 KB
- Modified: 2026-01-09 13:47

```csharp
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DarkTowerTron.Systems
{
    public class PoolManager : MonoBehaviour
    {
        // Dictionary mapping Prefab InstanceID -> Queue of inactive objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();

        // Dictionary mapping Spawned Object InstanceID -> Prefab InstanceID (to know where to return it)
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private Transform _poolRoot;

        private void Awake()
        {
            // Create a clean container so the Hierarchy doesn't get messy
            GameObject rootObj = new GameObject("Pool_Container");
            _poolRoot = rootObj.transform;
            DontDestroyOnLoad(rootObj);
        }

        private void OnEnable() => SceneManager.activeSceneChanged += OnSceneChanged;
        private void OnDisable() => SceneManager.activeSceneChanged -= OnSceneChanged;

        private void OnSceneChanged(Scene current, Scene next)
        {
            // Clear tracking lists, but logic dictates we should also clear the physical container
            // if we want a fresh start per scene (usually safer for references).
            ClearPools();
        }

        public void ClearPools()
        {
            _poolDictionary.Clear();
            _spawnedObjectsParentId.Clear();

            // Nuke the physical objects
            foreach (Transform child in _poolRoot)
            {
                Destroy(child.gameObject);
            }

            GameLogger.Log(LogChannel.System, "Pool memory flushed.", gameObject);
        }

        /// <summary>
        /// Call this during Loading Screens to prevent stutter during gameplay.
        /// </summary>
        public void Prewarm(GameObject prefab, int count)
        {
            if (prefab == null) return;

            int poolKey = prefab.GetInstanceID();

            // Initialize the queue if missing
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            for (int i = 0; i < count; i++)
            {
                GameObject obj = CreateNewInstance(prefab, poolKey);
                // Immediately disable and enqueue
                obj.SetActive(false);
                obj.transform.SetParent(_poolRoot);
                _poolDictionary[poolKey].Enqueue(obj);
            }
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            if (prefab == null) return null;

            int poolKey = prefab.GetInstanceID();

            // 1. Ensure Queue Exists
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objToSpawn = null;

            // 2. Try Dequeue (Find inactive)
            if (_poolDictionary[poolKey].Count > 0)
            {
                objToSpawn = _poolDictionary[poolKey].Dequeue();

                // Validation: Was it destroyed externally?
                while (objToSpawn == null && _poolDictionary[poolKey].Count > 0)
                {
                    objToSpawn = _poolDictionary[poolKey].Dequeue();
                }
            }

            // 3. If missing or null, Create New
            if (objToSpawn == null)
            {
                objToSpawn = CreateNewInstance(prefab, poolKey);
            }

            // 4. Setup
            objToSpawn.transform.SetPositionAndRotation(position, rotation);
            objToSpawn.SetActive(true);

            // NOTE: We don't unparent from _poolRoot. 
            // Keeping them organized under one parent is cleaner for the Hierarchy view,
            // though slightly (negligibly) more expensive for Transform updates.
            // For a solo dev, clean Hierarchy > Micro-optimization.

            // 5. Interface Call
            var poolables = objToSpawn.GetComponentsInChildren<IPoolable>();
            foreach (var p in poolables) p.OnSpawn();

            return objToSpawn;
        }

        public void Despawn(GameObject obj)
        {
            if (obj == null) return;
            if (!obj.scene.isLoaded) { Destroy(obj); return; }

            int instanceKey = obj.GetInstanceID();

            if (_spawnedObjectsParentId.TryGetValue(instanceKey, out int poolKey))
            {
                // Interface Call
                var poolables = obj.GetComponentsInChildren<IPoolable>();
                foreach (var p in poolables) p.OnDespawn();

                obj.SetActive(false);

                // Reparent to root to keep scene tidy
                if (obj.transform.parent != _poolRoot)
                    obj.transform.SetParent(_poolRoot);

                // Add back to queue
                if (!_poolDictionary.ContainsKey(poolKey))
                    _poolDictionary[poolKey] = new Queue<GameObject>();

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                // Wasn't pooled? Just destroy.
                Destroy(obj);
            }
        }

        // Helper to keep logic DRY
        private GameObject CreateNewInstance(GameObject prefab, int poolKey)
        {
            GameObject obj = Instantiate(prefab, _poolRoot); // Spawn directly in root
            int instanceKey = obj.GetInstanceID();

            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }
            return obj;
        }
    }
}
```

## 📄 `Assets\Scripts\Services\ScoreManager.cs`
- Lines: 98
- Size: 3.0 KB
- Modified: 2026-01-09 13:47

```csharp
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using UnityEngine;

namespace DarkTowerTron.Systems
{
    public class ScoreManager : MonoBehaviour
    {
        // Note: ScoreManager is likely registered in Bootloader or Scene Context via ServiceLocator
        // But internal logic remains MonoBehaviour-based for now.

        [Header("Broadcasting")]
        [SerializeField] private IntIntEventChannelSO _scoreEvent; // Replaces OnScoreChanged

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled
        [SerializeField] private VoidEventChannelSO _playerHitEvent; // Replaces OnPlayerHit

        [Header("Score Settings")]
        public int baseScorePerKill = 100;
        public int gloryKillBonus = 500;
        public int maxMultiplier = 5;

        public int currentMultiplier = 1;
        public int TotalScore { get; private set; }
        public float GameTime { get; private set; }

        private bool _isTracking = false;

        private void Start()
        {
            _isTracking = true;
            UpdateUI();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking) GameTime += Time.deltaTime;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            int scoreValue = (stats != null) ? stats.scoreValue : baseScorePerKill;
            AddScore(scoreValue * currentMultiplier);

            if (currentMultiplier < maxMultiplier)
            {
                currentMultiplier++;
                UpdateUI();
            }
        }

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
            GameLogger.Log(LogChannel.Combat, $"GLORY KILL! +{bonus}", gameObject);
            AddScore(bonus);
        }

        private void UpdateUI()
        {
            // NEW: Raise event via Channel
            _scoreEvent?.Raise(TotalScore, currentMultiplier);
        }
    }
}
```

## 📄 `Assets\Scripts\Services\VFXManager.cs`
- Lines: 63
- Size: 2.2 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW
using DarkTowerTron;

namespace DarkTowerTron.Systems
{
    public class VFXManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private Vector3EventChannelSO _enemySpawnedEvent; // NEW

        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab;
        public LayerMask groundLayer;

        private void Awake()
        {
            if (groundLayer == 0) groundLayer = GameConstants.MASK_PHYSICS_OBSTACLES;
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += PlayDeathVFX;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised += PlaySpawnVFX;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= PlayDeathVFX;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised -= PlaySpawnVFX;
        }

        private void PlayDeathVFX(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab && Global.Pool != null)
            {
                GameObject vfx = Global.Pool.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && Global.Pool != null)
            {
                Vector3 vfxPos = pos + Vector3.up * 0.1f;
                if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2f, Vector3.down, out RaycastHit hit, 10f, groundLayer))
                {
                    vfxPos = hit.point + Vector3.up * 0.1f;
                }

                GameObject vfx = Global.Pool.Spawn(spawnPrefab, vfxPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Systems\Narrative\NarrativeDirector.cs`
- Lines: 108
- Size: 4.2 KB
- Modified: 2026-01-09 14:37

```csharp
using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core;

namespace DarkTowerTron.Systems.Narrative
{
    public class NarrativeDirector : MonoBehaviour
    {
        [Header("Data")]
        public NarrativeLibrarySO library;
        [SerializeField] private NarrativeEventChannelSO _narrativeOutput;

        [Header("Triggers")]
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _waveCombatStartedEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        [Header("Settings")]
        [Tooltip("Minimum seconds between messages to avoid spam.")]
        public float spamCooldown = 3.0f;

        private float _lastMessageTime;
        private float _currentCorruption = 0f;

        private void Start()
        {
            CalculateCorruption();
        }

        private void OnEnable()
        {
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHurt;
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_waveCombatStartedEvent) _waveCombatStartedEvent.OnEventRaised += OnCombatStart;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised += OnPlayerDied;
        }

        private void OnDisable()
        {
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHurt;
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_waveCombatStartedEvent) _waveCombatStartedEvent.OnEventRaised -= OnCombatStart;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
        }

        private void CalculateCorruption()
        {
            // Logic: More Runs + More Deaths = Higher Corruption
            // Example: 10 deaths = 50% corruption
            if (Global.Score != null && Global.Score.gameObject.GetComponent<DarkTowerTron.Systems.Persistence.PersistenceManager>() != null)
            {
                // Accessing Persistence via Global shortcut or FindObject depending on your registration
                // Let's assume you added it to Global in Phase 3. If not, use FindObject for now.
                var data = FindObjectOfType<DarkTowerTron.Systems.Persistence.PersistenceManager>()?.CurrentData;

                if (data != null)
                {
                    // Formula: Each death adds 5% corruption. Each run adds 1%.
                    float deathFactor = data.totalDeaths * 0.05f;
                    float runFactor = data.totalRuns * 0.01f;

                    _currentCorruption = Mathf.Clamp01(deathFactor + runFactor);

                    Debug.Log($"[Narrative] Corruption Level: {_currentCorruption:P0}");
                }
            }
        }

        private void Publish(string rawText, float priorityBonus = 0f)
        {
            // Rate Limiting (unless priority is high)
            if (Time.time < _lastMessageTime + (spamCooldown - priorityBonus)) return;

            string finalString = TextCorruptor.Corrupt(rawText, _currentCorruption);

            _narrativeOutput?.Raise(finalString, 3.0f);
            _lastMessageTime = Time.time;
        }

        // --- HANDLERS ---

        private void OnCombatStart()
        {
            Publish(library.GetRandomLine(library.introLines), 10f); // High priority
        }

        private void OnPlayerHurt()
        {
            if (Random.value > 0.7f) // Don't talk every hit
                Publish(library.GetRandomLine(library.hurtLines));
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (reward && Random.value > 0.8f)
                Publish(library.GetRandomLine(library.killLines));
        }

        private void OnPlayerDied()
        {
            // Force message
            string text = TextCorruptor.Corrupt(library.GetRandomLine(library.deathLines), _currentCorruption + 0.2f);
            _narrativeOutput?.Raise(text, 5.0f);
        }
    }
}
```

## 📄 `Assets\Scripts\Systems\Narrative\NarrativeLibrarySO.cs`
- Lines: 22
- Size: 0.8 KB
- Modified: 2026-01-09 14:34

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Narrative
{
    [CreateAssetMenu(fileName = "Narrative_Default", menuName = "DarkTowerTron/Narrative/Library")]
    public class NarrativeLibrarySO : ScriptableObject
    {
        [Header("Contexts")]
        public List<string> introLines;      // Level Start
        public List<string> hurtLines;       // Player Hit
        public List<string> killLines;       // Enemy Killed
        public List<string> deathLines;      // Player Died
        public List<string> victoryLines;    // Level End

        public string GetRandomLine(List<string> source)
        {
            if (source == null || source.Count == 0) return "...";
            return source[Random.Range(0, source.Count)];
        }
    }
}
```

## 📄 `Assets\Scripts\Systems\Narrative\TextCorruptor.cs`
- Lines: 48
- Size: 1.6 KB
- Modified: 2026-01-09 14:36

```csharp
using System.Text;
using UnityEngine;

namespace DarkTowerTron.Systems.Narrative
{
    public static class TextCorruptor
    {
        private static char[] _glitchChars = new char[] { '$', '#', '%', '&', '!', '?', '0', '1', 'X' };

        public static string Corrupt(string input, float corruptionLevel)
        {
            if (string.IsNullOrEmpty(input)) return "";
            if (corruptionLevel <= 0) return input;

            StringBuilder sb = new StringBuilder(input);
            int length = sb.Length;

            // 1. Character Replacement (Light Corruption)
            int charsToReplace = Mathf.FloorToInt(length * corruptionLevel * 0.5f);
            for (int i = 0; i < charsToReplace; i++)
            {
                int index = Random.Range(0, length);
                if (sb[index] == ' ') continue; // Don't replace spaces usually
                sb[index] = _glitchChars[Random.Range(0, _glitchChars.Length)];
            }

            // 2. Redaction (Heavy Corruption)
            // If corruption is > 0.5, block out whole words
            if (corruptionLevel > 0.5f)
            {
                // Simple logic: insert [ERR] randomly
                if (Random.value < corruptionLevel)
                {
                    sb.Append(" [FATAL_ERR]");
                }
            }

            // 3. Zalgo/Hex (Extreme Corruption)
            if (corruptionLevel > 0.8f)
            {
                // Hex dump style
                return $"0x{Random.Range(1000, 9999)} // {sb.ToString()}";
            }

            return sb.ToString();
        }
    }
}
```

## 📄 `Assets\Scripts\Systems\Persistence\Editor\PersistenceManagerEditor.cs`
- Lines: 49
- Size: 1.4 KB
- Modified: 2026-01-09 14:22

```csharp
using UnityEngine;
using UnityEditor;
using System.Diagnostics; // For Process.Start

namespace DarkTowerTron.Systems.Persistence
{
    [CustomEditor(typeof(PersistenceManager))]
    public class PersistenceManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            // Draw the default Inspector (Script field, Current Slot Index)
            DrawDefaultInspector();

            PersistenceManager manager = (PersistenceManager)target;

            GUILayout.Space(10);

            // --- The Magic Button ---
            if (GUILayout.Button("📂 Open Save Folder", GUILayout.Height(30)))
            {
                OpenSaveFolder();
            }

            // --- Debug Controls ---
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Save Now"))
            {
                manager.Save();
            }
            if (GUILayout.Button("Load Now"))
            {
                manager.Load(manager.CurrentSlotIndex);
            }
            GUILayout.EndHorizontal();
        }

        private void OpenSaveFolder()
        {
            string path = Application.persistentDataPath;

            // Cross-platform open
            path = path.Replace(@"/", @"\"); // Windows friendly

            // Reveal in Explorer/Finder
            EditorUtility.RevealInFinder(path);
        }
    }
}
```

## 📄 `Assets\Scripts\Systems\Persistence\PersistenceManager.cs`
- Lines: 109
- Size: 3.5 KB
- Modified: 2026-01-09 14:21

```csharp
using UnityEngine;
using System.IO;
using DarkTowerTron.Core.Debug; // For Logger

namespace DarkTowerTron.Systems.Persistence
{
    public class PersistenceManager : MonoBehaviour
    {
        private const string SAVE_FILE_PREFIX = "save_slot_";
        private const string EXTENSION = ".json";

        public SaveData CurrentData { get; private set; }

        // Default to slot 0. We can change this via UI later.
        [SerializeField] private int _currentSlotIndex = 0;

        public int CurrentSlotIndex => _currentSlotIndex;

        private void Awake()
        {
            Load(_currentSlotIndex);
        }

        /// <summary>
        /// Switch to a different save slot and load it immediately.
        /// </summary>
        public void SetSaveSlot(int index)
        {
            if (index < 0) return;

            // Save previous slot state before switching?
            // Usually safer to just switch, assuming previous was saved on change.
            Save();

            _currentSlotIndex = index;
            Load(_currentSlotIndex);
        }

        public void Save()
        {
            if (CurrentData == null) CurrentData = new SaveData();
            CurrentData.lastPlayedDate = System.DateTime.Now.ToString();

            try
            {
                string path = GetPath(_currentSlotIndex);
                string json = JsonUtility.ToJson(CurrentData, true);
                File.WriteAllText(path, json);

                GameLogger.Log(LogChannel.System, $"Game Saved to Slot {_currentSlotIndex}", gameObject);
            }
            catch (System.Exception e)
            {
                GameLogger.LogError(LogChannel.System, $"Failed to save: {e.Message}", gameObject);
            }
        }

        public void Load(int slotIndex)
        {
            _currentSlotIndex = slotIndex;
            string path = GetPath(slotIndex);

            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);
                    CurrentData = JsonUtility.FromJson<SaveData>(json);
                    GameLogger.Log(LogChannel.System, $"Loaded Slot {slotIndex}", gameObject);
                }
                catch (System.Exception e)
                {
                    GameLogger.LogError(LogChannel.System, $"Slot {slotIndex} corrupted. Resetting. Error: {e.Message}", gameObject);
                    CreateNewSave();
                }
            }
            else
            {
                GameLogger.Log(LogChannel.System, $"Slot {slotIndex} not found. Creating new.", gameObject);
                CreateNewSave();
            }
        }

        [ContextMenu("Delete Current Save")]
        public void DeleteCurrentSave()
        {
            string path = GetPath(_currentSlotIndex);
            if (File.Exists(path))
            {
                File.Delete(path);
                GameLogger.Log(LogChannel.System, $"Deleted Save Slot {_currentSlotIndex}", gameObject);
                CreateNewSave();
            }
        }

        private void CreateNewSave()
        {
            CurrentData = new SaveData();
            Save();
        }

        private string GetPath(int index)
        {
            return Path.Combine(Application.persistentDataPath, $"{SAVE_FILE_PREFIX}{index}{EXTENSION}");
        }

        private void OnApplicationQuit() => Save();
    }
}
```

## 📄 `Assets\Scripts\Systems\Persistence\SaveData.cs`
- Lines: 37
- Size: 0.9 KB
- Modified: 2026-01-09 14:11

```csharp
using System;

namespace DarkTowerTron.Systems.Persistence
{
    [Serializable]
    public class SaveData
    {
        // --- Header ---
        public string lastPlayedDate;
        public string version = "0.1";

        // --- Narrative Stats (The "Corruption") ---
        public int totalRuns;
        public int totalDeaths;
        public int totalKills;
        public float totalDamageDealt;

        // --- Progression ---
        public int highestWaveReached;
        public bool hasSeenTutorial;

        // --- Settings (Optional for now) ---
        public float masterVolume = 1.0f;

        // Constructor sets defaults
        public SaveData()
        {
            lastPlayedDate = DateTime.Now.ToString();
            totalRuns = 0;
            totalDeaths = 0;
            totalKills = 0;
            totalDamageDealt = 0;
            highestWaveReached = 0;
            hasSeenTutorial = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Systems\Persistence\StatsTracker.cs`
- Lines: 71
- Size: 2.5 KB
- Modified: 2026-01-09 14:30

```csharp
using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Systems.Persistence
{
    /// <summary>
    /// Listens to gameplay events and updates the persistent SaveData.
    /// </summary>
    public class StatsTracker : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private PersistenceManager _persistence;

        [Header("Listening To")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private DamageTextEventChannelSO _damageEvent; // To track damage dealt

        private void Awake()
        {
            if (_persistence == null)
                _persistence = GetComponent<PersistenceManager>();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised += OnPlayerDied;
            if (_damageEvent) _damageEvent.OnEventRaised += OnDamageDealt;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
            if (_damageEvent) _damageEvent.OnEventRaised -= OnDamageDealt;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            // Respect the reward flag: if the enemy killed itself (suicide/contact),
            // don't count it as a player kill.
            if (!reward) return;

            if (_persistence.CurrentData != null)
            {
                _persistence.CurrentData.totalKills++;
            }
        }

        private void OnPlayerDied()
        {
            if (_persistence.CurrentData != null)
            {
                _persistence.CurrentData.totalDeaths++;
                _persistence.CurrentData.totalRuns++;
                _persistence.Save(); // Commit on death
            }
        }

        private void OnDamageDealt(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            // Only track health damage, not stagger (optional choice)
            if (!isStagger && _persistence.CurrentData != null)
            {
                _persistence.CurrentData.totalDamageDealt += amount;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\CountdownUI.cs`
- Lines: 72
- Size: 2.4 KB
- Modified: 2026-01-06 15:22

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.UI
{
    public class CountdownUI : MonoBehaviour
    {
        [Header("Listening")]
        [SerializeField] private IntEventChannelSO _announceEvent;
        [SerializeField] private StringEventChannelSO _countdownEvent;

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
            if (_announceEvent != null) _announceEvent.OnEventRaised += ShowWaveTitle;
            if (_countdownEvent != null) _countdownEvent.OnEventRaised += UpdateCountdown;
        }

        private void OnDisable()
        {
            if (_announceEvent != null) _announceEvent.OnEventRaised -= ShowWaveTitle;
            if (_countdownEvent != null) _countdownEvent.OnEventRaised -= UpdateCountdown;
        }

        private void ShowWaveTitle(int waveIndex)
        {
            if (waveTitleText)
            {
                waveTitleText.text = $"WAVE {waveIndex}";
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

## 📄 `Assets\Scripts\UI\DamageTextManager.cs`
- Lines: 97
- Size: 3.4 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Events;
using DarkTowerTron;

namespace DarkTowerTron.UI
{
    public class DamageTextManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private DamageTextEventChannelSO _damageEvent;
        [SerializeField] private PopupTextEventChannelSO _popupEvent;

        [Header("Setup")]
        public GameObject textPrefab;

        [Header("Damage Settings")]
        public Vector3 offset = new Vector3(0, 2f, 0);
        public Color healthColor = Color.white;
        public Color critColor = Color.yellow;
        public Color staggerColor = Color.cyan; // Distinct color for Stagger Damage

        [Header("Narrative Settings")]
        public Color narrativeColor = new Color(1f, 0.5f, 0f); // Orange
        [Tooltip("Words to inject via the Popup channel")]
        public List<string> barks = new List<string> { "WHAM!", "CRUNCH!", "ERROR", "VOID" };

        private void OnEnable()
        {
            if (_damageEvent != null) _damageEvent.OnEventRaised += ShowDamage;
            if (_popupEvent != null) _popupEvent.OnEventRaised += ShowPopup;
        }

        private void OnDisable()
        {
            if (_damageEvent != null) _damageEvent.OnEventRaised -= ShowDamage;
            if (_popupEvent != null) _popupEvent.OnEventRaised -= ShowPopup;
        }

        private void ShowDamage(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (textPrefab == null || Global.Pool == null) return;

            // 1. Determine Appearance
            Color finalColor;
            float finalScale;
            string text;
            bool isDramatic = isCrit;

            if (isStagger)
            {
                finalColor = staggerColor;
                finalScale = 0.8f; // Stagger numbers slightly smaller
                text = amount.ToString("N0"); // e.g. "5"
            }
            else
            {
                finalColor = isCrit ? critColor : healthColor;
                finalScale = isCrit ? 1.5f : 1.0f;
                text = amount.ToString("N0");
            }

            // 2. Spawn & Init
            SpawnText(pos, text, finalColor, finalScale, isDramatic);
        }

        private void ShowPopup(Vector3 pos, string message)
        {
            // If the message is a keyword like "BARK", pick a random narrative word
            if (message == "BARK" && barks.Count > 0)
            {
                message = barks[Random.Range(0, barks.Count)];
                SpawnText(pos, message, narrativeColor, 1.3f, true); // Dramatic!
            }
            else
            {
                // Standard Popup (e.g. "REFLECT", "ARMORED")
                SpawnText(pos, message, critColor, 1.2f, true);
            }
        }

        private void SpawnText(Vector3 pos, string text, Color color, float scale, bool dramatic)
        {
            if (textPrefab == null || Global.Pool == null) return;

            GameObject obj = Global.Pool.Spawn(textPrefab, pos + offset, Quaternion.identity);
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();

            if (floatingText)
            {
                floatingText.Initialize(text, color, scale, dramatic);
                // Billboarding
                obj.transform.forward = Camera.main.transform.forward;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\FloatingText.cs`
- Lines: 71
- Size: 2.1 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron;

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

        public void Initialize(string text, Color color, float sizeScale = 1f, bool isDramatic = false)
        {
            // 1. Setup Text
            textMesh.text = text;
            textMesh.color = color;
            textMesh.alpha = 1f;

            // 2. Narrative/Dramatic Polish (Fixing "Underwhelming 1")
            // If it's a Crit or Narrative word, make it Bold and punchier
            if (isDramatic)
            {
                textMesh.fontStyle = FontStyles.Bold;
                textMesh.outlineWidth = 0.2f; // Outline makes small numbers pop
            }
            else
            {
                textMesh.fontStyle = FontStyles.Normal;
                textMesh.outlineWidth = 0f;
            }

            // 3. Reset Transform
            transform.localScale = Vector3.one * sizeScale;

            // 4. Animate Move Up
            transform.DOMoveY(transform.position.y + floatDistance, duration)
                .SetEase(motionEase);

            // 5. Animate Fade Out
            textMesh.DOFade(0f, duration * 0.5f)
                .SetDelay(duration * 0.5f)
                .OnComplete(Despawn);

            // 6. Juice: Punch Scale
            // Dramatic text punches harder
            float punchAmount = isDramatic ? 0.8f : 0.5f;
            transform.DOPunchScale(Vector3.one * punchAmount, 0.2f);
        }

        private void Despawn()
        {
            // Safety Check for Scene Unload
            if (Global.Pool != null)
            {
                Global.Pool.Despawn(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\HUDManager.cs`
- Lines: 137
- Size: 4.7 KB
- Modified: 2026-01-09 13:54

```csharp
using System.Collections.Generic;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DarkTowerTron.UI
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Event Channels")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent;
        [SerializeField] private IntIntEventChannelSO _gritEvent;
        [SerializeField] private BoolEventChannelSO _hullEvent;
        [SerializeField] private IntIntEventChannelSO _scoreEvent;

        [Header("Focus (Energy)")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color fullFocusColor = new Color(1f, 0f, 1f);

        [Header("Grit (Health)")]
        public Transform gritContainer;
        public GameObject pipPrefab;
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f);

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
            if (_focusEvent != null) _focusEvent.OnEventRaised += UpdateFocus;
            if (_gritEvent != null) _gritEvent.OnEventRaised += UpdateGrit;
            if (_hullEvent != null) _hullEvent.OnEventRaised += UpdateHull;
            if (_scoreEvent != null) _scoreEvent.OnEventRaised += UpdateScoreUI;
        }

        private void OnDisable()
        {
            if (_focusEvent != null) _focusEvent.OnEventRaised -= UpdateFocus;
            if (_gritEvent != null) _gritEvent.OnEventRaised -= UpdateGrit;
            if (_hullEvent != null) _hullEvent.OnEventRaised -= UpdateHull;
            if (_scoreEvent != null) _scoreEvent.OnEventRaised -= UpdateScoreUI;
        }

        private void Update()
        {
            // CHANGE: Services -> Global
            if (timerText && Global.Score != null)
            {
                float t = Global.Score.GameTime;
                int minutes = Mathf.FloorToInt(t / 60f);
                int seconds = Mathf.FloorToInt(t % 60f);
                timerText.text = $"{minutes:00}:{seconds:00}";
            }
        }

        // --- EVENT HANDLERS ---

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider) focusSlider.value = current / max;

            if (focusFillImage)
            {
                bool isFull = current >= (max * 0.8f);
                focusFillImage.color = isFull ? fullFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit, int maxGrit)
        {
            if (_spawnedPips.Count != maxGrit)
            {
                RebuildGritLayout(maxGrit);
            }

            for (int i = 0; i < _spawnedPips.Count; i++)
            {
                if (_spawnedPips[i] == null) continue;
                _spawnedPips[i].color = (i < currentGrit) ? activePipColor : inactivePipColor;
            }
        }

        private void UpdateHull(bool hasHull)
        {
            // Kept logs for debugging, remove later if spammy
            GameLogger.Log(LogChannel.UI, $"[HUD] Hull Event: {hasHull}", gameObject);

            if (hullIcon)
            {
                hullIcon.color = hasHull ? hullActiveColor : hullBrokenColor;
            }
            else
            {
                GameLogger.LogError(LogChannel.UI, "[HUDManager] Hull Icon reference is missing!", gameObject);
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
            if (gritContainer == null || pipPrefab == null) return;

            foreach (Transform child in gritContainer) Destroy(child.gameObject);
            _spawnedPips.Clear();

            for (int i = 0; i < max; i++)
            {
                GameObject newPip = Instantiate(pipPrefab, gritContainer);
                Image img = newPip.GetComponent<Image>();
                if (img) _spawnedPips.Add(img);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\MenuController.cs`
- Lines: 30
- Size: 0.8 KB
- Modified: 2025-12-30 09:50

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

## 📄 `Assets\Scripts\UI\NarrativeUI.cs`
- Lines: 97
- Size: 3.1 KB
- Modified: 2026-01-09 14:47

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Collections;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core;

namespace DarkTowerTron.UI
{
    public class NarrativeUI : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private NarrativeEventChannelSO _inputChannel;

        [Header("Components")]
        [SerializeField] private TextMeshProUGUI _textMesh;
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private RectTransform _panelRoot;

        [Header("Settings")]
        public float typeSpeed = 0.03f; // Fast terminal speed
        public string prefix = "> SYS_OUT: ";
        public AudioClip typeSound;

        [Header("Glitch Settings")]
        public float shakeStrength = 10f;
        public Color normalColor = Color.white;
        public Color errorColor = Color.red;

        private Tween _fadeTween;
        private Coroutine _displayRoutine;

        private void Awake()
        {
            // Initial State: Hidden
            _canvasGroup.alpha = 0;
            _textMesh.text = "";
        }

        private void OnEnable()
        {
            if (_inputChannel != null)
                _inputChannel.OnEventRaised += OnMessageReceived;
        }

        private void OnDisable()
        {
            if (_inputChannel != null)
                _inputChannel.OnEventRaised -= OnMessageReceived;
        }

        private void OnMessageReceived(string message, float duration)
        {
            // 1. Interrupt existing messages
            if (_displayRoutine != null) StopCoroutine(_displayRoutine);
            if (_fadeTween != null) _fadeTween.Kill();
            _panelRoot.DOKill();

            // 2. Start new sequence
            _displayRoutine = StartCoroutine(TypewriterRoutine(message, duration));
        }

        private IEnumerator TypewriterRoutine(string message, float duration)
        {
            // A. Setup
            string fullText = prefix + message;
            _textMesh.text = fullText;
            _textMesh.maxVisibleCharacters = 0; // Hide all chars
            _textMesh.color = message.Contains("FATAL") ? errorColor : normalColor;

            // B. Visual "Boot" (Fade In + Jolt)
            _canvasGroup.alpha = 1;
            _panelRoot.DOPunchAnchorPos(Vector2.right * shakeStrength, 0.2f, 20, 1);

            // C. Typewriter Effect
            int totalChars = fullText.Length;
            for (int i = 0; i <= totalChars; i++)
            {
                _textMesh.maxVisibleCharacters = i;

                // Play sound every few chars to avoid machine-gun audio
                if (i % 3 == 0 && typeSound != null && Global.Audio != null)
                {
                    Global.Audio.PlaySound(typeSound, 0.2f, true);
                }

                yield return new WaitForSeconds(typeSpeed);
            }

            // D. Wait (Read time)
            yield return new WaitForSeconds(duration);

            // E. Fade Out
            _fadeTween = _canvasGroup.DOFade(0f, 0.5f);
        }
    }
}
```

## 📄 `Assets\Scripts\UI\ResultScreen.cs`
- Lines: 77
- Size: 2.3 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using TMPro;
using DarkTowerTron.Managers;
using DarkTowerTron;

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

        private void OnEnable()
        {
            // Note: Global.Score throws an error if missing (Hard Dependency), 
            // so we don't strictly need a null check here unless using TryGet.
            // We assume the Bootloader has run.

            // 1. Stop the Timer
            Global.Score.StopTracking();

            // 2. Get Stats
            int finalScore = Global.Score.TotalScore;
            float finalTime = Global.Score.GameTime;

            // 3. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                // Use FloorToInt for cleaner casting
                int minutes = Mathf.FloorToInt(finalTime / 60f);
                int seconds = Mathf.FloorToInt(finalTime % 60f);
                timeText.text = $"{minutes:00}:{seconds:00}";
            }

            // 4. Calculate Rank
            if (rankText)
            {
                CalculateRank(finalScore);
            }
        }

        private void CalculateRank(int score)
        {
            string rank = "C";
            Color rankColor = Color.grey; 
            // Note: In the future, these colors could come from a UIThemeSO or Palette

            if (score >= rankS_Threshold) 
            { 
                rank = "S"; 
                rankColor = Color.cyan; 
            }
            else if (score >= rankA_Threshold) 
            { 
                rank = "A"; 
                rankColor = Color.green; 
            }
            else if (score >= rankB_Threshold) 
            { 
                rank = "B"; 
                rankColor = Color.yellow; 
            }

            rankText.text = rank;
            rankText.color = rankColor;
        }
    }
}
```

## 📄 `Assets\Scripts\UI\UIManager.cs`
- Lines: 35
- Size: 1.3 KB
- Modified: 2026-01-06 10:37

```csharp
using UnityEngine;

namespace DarkTowerTron.UI
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

## 📄 `Assets\Scripts\UI\UIThemeReceiver.cs`
- Lines: 48
- Size: 1.6 KB
- Modified: 2025-12-30 09:50

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
- Modified: 2025-12-30 09:50

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
- Lines: 136
- Size: 4.6 KB
- Modified: 2026-01-09 13:53

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Systems;
using DarkTowerTron.Core.Services; // NEW: For ServiceLocator

namespace DarkTowerTron.Visuals
{
    [ExecuteAlways]
    public class PaletteReceiver : MonoBehaviour
    {
        public enum ActorType { Player, Enemy }

        [Header("Configuration")]
        public ActorType actorType = ActorType.Enemy;

        [Header("Override (Optional)")]
        [Tooltip("Leave empty to use Global Default.")]
        public ActorThemeSO themeOverride;

        [Header("Renderer Bindings")]
        public List<Renderer> primaryRenderers;
        public List<Renderer> secondaryRenderers;
        public List<Renderer> tertiaryRenderers;

        private MaterialPropertyBlock _propBlock;

        // --- LIFECYCLE ---

        private void OnEnable()
        {
            if (TryGetManager(out var pm))
                pm.OnPaletteChanged += ApplyTheme;
        }

        private void OnDisable()
        {
            // Safety check prevents errors on quit
            if (TryGetManager(out var pm))
                pm.OnPaletteChanged -= ApplyTheme;
        }

        private void Start()
        {
            ApplyTheme();
        }

        public void ManualRefresh() => ApplyTheme();

        // --- LOGIC ---

        private void ApplyTheme()
        {
            if (_propBlock == null) _propBlock = new MaterialPropertyBlock();

            // 1. CASE A: Use Local Override
            if (themeOverride != null)
            {
                ApplySurfaceToList(primaryRenderers, themeOverride.primary);
                ApplySurfaceToList(secondaryRenderers, themeOverride.secondary);
                ApplySurfaceToList(tertiaryRenderers, themeOverride.tertiary);
                return;
            }

            // 2. CASE B: Use Global Service
            // We use TryGetManager helper to handle both Runtime (Services) and Editor (Instance)
            if (!TryGetManager(out var pm) || pm.activePalette == null) return;

            var global = pm.activePalette;

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
                if (HasProp(r, "_EmissionColor")) 
                    _propBlock.SetColor("_EmissionColor", surf.emissionColor);

                // Set Physics
                if (HasProp(r, "_Smoothness")) _propBlock.SetFloat("_Smoothness", surf.smoothness);
                if (HasProp(r, "_Metallic")) _propBlock.SetFloat("_Metallic", surf.metallic);

                r.SetPropertyBlock(_propBlock);
            }
        }

        /// <summary>
        /// Helper to find the manager safely in both Play Mode and Editor Mode.
        /// </summary>
        private bool TryGetManager(out PaletteManager pm)
        {
            // 1. Runtime: Use Service Locator (Safe, no singleton dependency)
            if (ServiceLocator.TryGet(out pm)) return true;

            // 2. Editor Mode: Use the static Instance (Legacy support for ExecuteAlways)
            if (!Application.isPlaying)
            {
                pm = PaletteManager.Instance;
                return pm != null;
            }

            return false;
        }

        /// <summary>
        /// CRITICAL FIX: Actually checks the material properties.
        /// </summary>
        private bool HasProp(Renderer r, string name)
        {
            if (r.sharedMaterial == null) return false;
            return r.sharedMaterial.HasProperty(name);
        }
    }
}
```
