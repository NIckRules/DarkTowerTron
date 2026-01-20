# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2026-01-20 07:34
- **Files:** 86
- **Total LOC:** 2023
- **Estimated tokens:** 13977

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
          State_Guardian_Attack_Heavy.asset
          State_Guardian_Patrol.asset
          State_Guardian_Patrol_Heavy.asset
        Sentinel
          State_Sentinel_Engage.asset
      AttackPattern
        Attack_Guardian_Basic.asset
        Attack_Guardian_Heavy.asset
        Attack_Sentinel_Basic.asset
    AttackPatterns
      Bosses
        Architect
          ARC_Straight.asset
      Fodder
        Guardian
          Guardian_Attack_Basic.asset
          Guardian_Attack_Heavy.asset
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
        Attack_Guardian_Heavy.asset
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
      Narrative
        Event_Narrative_Log.asset
      System
        Event_Game_Victory.asset
        Event_Player_Died.asset
        Event_Room_Cleared.asset
      UI
        Event_Countdown.asset
        Event_Popup.asset
        Event_Tooltip.asset
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
    Perks
      Perk_Parry.asset
      Perk_ReflectiveDash.asset
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
        Collection_Projectiles_Hostile_Heavy.asset
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
```

## 📄 `Assets\Data\AI\Agents\Chaser\State_Chaser_Detonate.asset`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\AI\Agents\Guardian\State_Guardian_Attack_Heavy.asset`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

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
  m_Name: State_Guardian_Attack_Heavy
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: 36cfc62a452537f42be258e29c563f0b, type: 2}
  transitions:
  - decision: {fileID: 11400000, guid: e9ef885431e6ee64cad1a462cf223266, type: 2}
    trueState: {fileID: 11400000}
    falseState: {fileID: 11400000, guid: 5c8e00c250c6c7a428bb704077954631, type: 2}
```

## 📄 `Assets\Data\AI\Agents\Guardian\State_Guardian_Patrol.asset`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\AI\Agents\Guardian\State_Guardian_Patrol_Heavy.asset`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

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
  m_Name: State_Guardian_Patrol_Heavy
  m_EditorClassIdentifier: 
  onEnterActions: []
  actions:
  - {fileID: 11400000, guid: a4deedcacb40c5d4daa644286f11362a, type: 2}
  transitions:
  - decision: {fileID: 11400000, guid: e9ef885431e6ee64cad1a462cf223266, type: 2}
    trueState: {fileID: 11400000, guid: b71f7716aae2bea468211f17020d9bef, type: 2}
    falseState: {fileID: 11400000}
```

## 📄 `Assets\Data\AI\Agents\Sentinel\State_Sentinel_Engage.asset`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\AI\AttackPattern\Attack_Guardian_Heavy.asset`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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
  m_Name: Attack_Guardian_Heavy
  m_EditorClassIdentifier: 
  pattern: {fileID: 11400000, guid: 761d4be4f2a229e4e938e26ca45bb71a, type: 2}
  attackStats: {fileID: 11400000, guid: 96e50b0f87316b84ebb14d928c0eac51, type: 2}
```

## 📄 `Assets\Data\AI\AttackPattern\Attack_Sentinel_Basic.asset`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\AttackPatterns\Fodder\Guardian\Guardian_Attack_Basic.asset`
- Lines: 26
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\AttackPatterns\Fodder\Guardian\Guardian_Attack_Heavy.asset`
- Lines: 26
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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
  m_Name: Guardian_Attack_Heavy
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
  delayBetweenShots: 0.4
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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Size: 0.8 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\Enemies\Guardian\Attack_Guardian_Heavy.asset`
- Lines: 22
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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
  m_Name: Attack_Guardian_Heavy
  m_EditorClassIdentifier: 
  damage: 1
  stagger: 0
  projectilePrefab: {fileID: 4816501585111597516, guid: cadc7654bed398440990c2a7e33fc589,
    type: 3}
  projectileSpeed: 12
  lifetime: 7
  spreadAngle: 0
```

## 📄 `Assets\Data\Enemies\Guardian\Stats_Guardian.asset`
- Lines: 33
- Size: 0.8 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Size: 0.8 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\Events\Narrative\Event_Narrative_Log.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-10 16:07

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
  m_Script: {fileID: 11500000, guid: 4e047233161950544a9ef93a411e1ee5, type: 3}
  m_Name: Event_Narrative_Log
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\System\Event_Game_Victory.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\Events\UI\Event_Tooltip.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-10 16:07

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
  m_Script: {fileID: 11500000, guid: 64d4e7a0f851b5b469a2b4892b9fdcc4, type: 3}
  m_Name: Event_Tooltip
  m_EditorClassIdentifier:
```

## 📄 `Assets\Data\Events\UI\Event_Wave_Announce.asset`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\Perks\Perk_Parry.asset`
- Lines: 20
- Size: 0.5 KB
- Modified: 2026-01-10 16:07

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
  m_Script: {fileID: 11500000, guid: 882ce89d9efe4db4fa3fecf5648c2fc0, type: 3}
  m_Name: Perk_Parry
  m_EditorClassIdentifier: 
  perkName: BEAM - Deflector
  description: 
  icon: {fileID: 0}
  statModifiers: []
  abilitiesToUnlock: 03000000
```

## 📄 `Assets\Data\Perks\Perk_ReflectiveDash.asset`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

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
  m_Script: {fileID: 11500000, guid: 882ce89d9efe4db4fa3fecf5648c2fc0, type: 3}
  m_Name: Perk_ReflectiveDash
  m_EditorClassIdentifier: 
  perkName: BLITZ - MIrror
  description: Dashing into LIGHT projectiles reflects them.
  icon: {fileID: 0}
  statModifiers: []
  abilitiesToUnlock: 01000000
```

## 📄 `Assets\Data\Player\Stats_Player_Default.asset`
- Lines: 41
- Size: 0.9 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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

## 📄 `Assets\Data\Visuals\Collections\Collection_Projectiles_Hostile_Heavy.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-10 16:07

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
  m_Name: Collection_Projectiles_Hostile_Heavy
  m_EditorClassIdentifier: 
  materials:
  - {fileID: 2100000, guid: de1c382c26a6f1a4bbeb3c060af46a57, type: 2}
```

## 📄 `Assets\Data\Visuals\Collections\Collection_Void.asset`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
- Modified: 2026-01-10 16:07

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
