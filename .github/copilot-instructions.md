# DarkTowerTron - Copilot Instructions

## Project Overview
Unity arena shooter using URP. Fast-paced DOOM-inspired combat with wave-based progression, stagger/execution mechanics, and context-steering AI.

## Architecture

### Namespace Structure
```
DarkTowerTron.Core       → Interfaces, GameEvents, GameConstants, Data (ScriptableObjects)
DarkTowerTron.Player     → PlayerController, PlayerHealth, PlayerEnergy, weapons
DarkTowerTron.Enemy      → EnemyController, EnemyMotor, agent variants (Chaser/Sentinel/Guardian/Sniper)
DarkTowerTron.Managers   → GameSession, WaveDirector, PoolManager, GameFeel (singleton managers)
DarkTowerTron.AI.Core    → ContextSolver, AIData, SteeringBehavior (context-steering AI system)
DarkTowerTron.AI.FSM     → StateMachine, State (finite state machine for enemy behaviors)
DarkTowerTron.Combat     → Projectile, HazardZone
DarkTowerTron.Physics    → KinematicMover (custom physics)
```

### Core Patterns

**Event-Driven Communication** - Use `GameEvents` static class for decoupled messaging:
```csharp
// Subscribe in OnEnable/Start, unsubscribe in OnDisable/OnDestroy
GameEvents.OnEnemyKilled += OnEnemyKilled;  // Signature: (Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
GameEvents.OnPlayerHit += OnPlayerHit;
// CRITICAL: Call GameEvents.Cleanup() when unloading scenes
```

**Object Pooling** - Never use `Destroy()` for frequently spawned objects:
```csharp
// Spawn via pool
GameObject obj = PoolManager.Instance.Spawn(prefab, position, rotation);
// Return to pool (calls IPoolable.OnDespawn)
PoolManager.Instance.Despawn(obj);
// Implement IPoolable for initialization/cleanup
```

**Damage System** - Use `IDamageable` interface with `DamageInfo` struct:
```csharp
DamageInfo info = new DamageInfo {
    damageAmount = 10f,
    staggerAmount = 0.4f,
    pushDirection = direction,
    pushForce = 10f,
    source = gameObject,
    isRedirected = false  // True for reflected projectiles (instant kill)
};
target.TakeDamage(info);
```

**ScriptableObject Data** - Enemy stats and wave configs are in `Assets/Data/`:
- `EnemyStatsSO`: movement, stagger thresholds, rewards, shield settings
- `WaveDefinitionSO`: wave composition, grunt reinforcement rules
- `AttackPatternSO`: attack behaviors for ranged enemies

### Enemy AI System

**Context Steering** (`Assets/Modules/AI/Core/`):
- `AIData`: Holds detected targets and obstacles
- `ContextSolver`: Combines 8-direction interest/danger maps from behaviors
- `SteeringBehavior`: Base class for seek/flee/obstacle avoidance

**Enemy Agents** follow this structure:
1. `EnemyMotor` handles movement via `KinematicMover`
2. `EnemyController` manages health, stagger state, damage
3. `EnemyAgent_*` (Chaser/Sentinel/Guardian/Sniper) contains AI logic + FSM states

**FSM States** are in `Assets/Scripts/Enemy/States/{AgentType}/`:
```csharp
public class ChaserState_Chase : State {
    public override void Enter() { }
    public override void LogicUpdate() { }  // Called every Update
    public override void PhysicsUpdate() { }  // Called every FixedUpdate
    public override void Exit() { }
}
```

### Physics System

Custom `KinematicMover` replaces Rigidbody for precise control:
- Handles collision resolution, ground snapping, slope handling
- Supports distance culling for performance (`useCulling`, `cullingDistance`)
- Use `Move(velocity)` in Update, not FixedUpdate

### Player Systems

- **Input**: Uses Unity Input System (`GameControls` generated class)
- **Resources**: `PlayerEnergy` (Focus meter decays during combat), `PlayerHealth` (Grit + Hull)
- **Combat**: `PlayerAttack` (beam weapon), `PlayerGun` (projectile), `PlayerDodge`, `PlayerExecution`

## Key Files
- [GameEvents.cs](Assets/Scripts/Core/GameEvents.cs) - All game-wide events
- [Interfaces.cs](Assets/Scripts/Core/Interfaces.cs) - `IDamageable`, `IPoolable`, `IReflectable`, `IWeapon`
- [PoolManager.cs](Assets/Scripts/Managers/PoolManager.cs) - Object pooling singleton
- [WaveDirector.cs](Assets/Scripts/Managers/WaveDirector.cs) - Wave spawning and progression
- [EnemyController.cs](Assets/Scripts/Enemy/EnemyController.cs) - Enemy damage/stagger logic

## Conventions

- Layers/tags defined in `GameConstants` - use these instead of magic strings
- Use `MaterialPropertyBlock` for color changes (avoid material instancing)
- DOTween for visual feedback - always `DOKill()` tweens in `OnDespawn()`
- Comments with `FIX-###` mark critical bug fixes - don't remove without understanding context

## Testing
Manual test checklist in [Tests/Tests.md](Tests/Tests.md). Use `DebugController` in `Scene_Gym` for spawning test enemies.
