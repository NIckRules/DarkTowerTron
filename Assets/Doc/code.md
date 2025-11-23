# STRIKER – CLASS ATLAS
Markdown-only reference for Visual Studio Code + Copilot.  
Paste this into a `.md` file beside your Scripts folder; Copilot will auto-suggest signatures & doc-comments.

---

## PLAYER FOLDER

### PlayerMovement
| Method | Purpose |
|--------|---------|
| `Move(Vector2 input)` | Instant 6 u/s velocity, no accel, camera-relative |
| `GetMouseWorldDirection()` | Returns Vector3 ray from camera through mouse |
| `GetMouseWorldPoint()` | Returns ground-plane hit for aim visuals |

### PlayerAttack
| Method | Purpose |
|--------|---------|
| `Attack()` | Raycast 2u forward, triggers enemy.TakeHit(), 0.3s CD |
| `SpawnSpearPhantom()` | 0.1s cyan capsule VFX (no collision) |
| `OnAttackCooldown()` | Bool for UI or audio |

### GritAndFocus
| Method | Purpose |
|--------|---------|
| `TakeDamage()` | Drops 1 Grit, grants Wound if zero, calls Death() |
| `HealGrit()` | +1 Grit (max 2) and +20 Focus |
| `AddFocus(int amt)` | Clamped 0-100, triggers Overheat at 100 |
| `Overheat()` | AoE stagger, drop to 1 Grit, reset Focus |
| `Death()` | Logs metrics, reloads scene |

### Blitz
| Method | Purpose |
|--------|---------|
| `PerformBlitz(Vector3 dir)` | Teleport 3u, 0.2s invuln, spawn AfterImage |
| `OnPerfectDodge(Collider projectile)` | +30 Focus, plays cue |

### AfterImage
| Method | Purpose |
|--------|---------|
| `Initialize(Vector3 pos, Quaternion rot)` | 1s decoy, shrinks & fades, attracts projectiles |

---

## ENEMY FOLDER

### EnemyStagger
| Method | Purpose |
|--------|---------|
| `TakeHit(float amt = 0.4f)` | Adds to meter, triggers stagger when &gt;= 1 |
| `EnterStagger()` | 1.5s window, cyan pulse, sets `isStaggered` |
| `ExitStagger()` | Returns to normal, logs waste if no kill |
| `Die()` | Heals player Grit, spawns pickup, destroys self |

### EnemyHealth
| Method | Purpose |
|--------|---------|
| `OnStaggered()` | Visual/audio cue, starts 1.5s kill window |
| `TakeStaggerKill()` | Called by player during window → Die() |

### EnemyAttack (base)
| Abstract | Purpose |
|----------|---------|
| `BeginTelegraph()` | Scale/tint/laser begin |
| `Fire()` | Spawn projectile(s) |
| `EndTelegraph()` | Return to idle |

### PebbleAttack : EnemyAttack
| Method | Purpose |
|--------|---------|
| `Fire()` | Single sphere, 8 u/s toward player |

### SniperAttack : EnemyAttack
| Method | Purpose |
|--------|---------|
| `DrawLaser()` | LineRenderer from enemy to predicted point |
| `Fire()` | Single fast sphere, 25 u/s |

### GatlingAttack : EnemyAttack
| Method | Purpose |
|--------|---------|
| `FireBurst()` | Coroutine: 3 bullets/s × 1.5s, fixed cone |
| `DecayModifier()` | -50% stagger decay while firing |

---

## PROJECTILE FOLDER

### Projectile
| Method | Purpose |
|--------|---------|
| `Launch(Vector3 velocity)` | Sets rigidbody velocity |
| `OnTriggerEnter(Collider c)` | If Player & not invuln → player.TakeDamage() |

### SpearProjectile (special only)
| Method | Purpose |
|--------|---------|
| `Initialize(Vector3 dir)` | Sets speed, lifetime, pierce count |
| `OnTriggerEnter(Collider c)` | Deals hit, handles pierce, optional damage mult |
| `SelfDestruct()` | Fade trail, destroy |

---

## UTILITIES FOLDER

### WaveManager
| Method | Purpose |
|--------|---------|
| `StartWave(int id)` | Instantiates predefined enemy list |
| `OnEnemyDeath()` | Decrement alive count, start next wave when 0 |
| `LogMetrics()` | Outputs TTFD, FDE, SWR on player death |

### MetricsLogger
| Method | Purpose |
|--------|---------|
| `AppendDeathLog(...)` | Builds single-line console output |
| `ResetSession()` | Clears static counters (staggerWasted, etc.) |

---

## EXTENSION HOOKS (commented stubs)
- `IStaggerModifier` – apply ×n decay under special conditions (Gatling uses this).  
- `IParryable` – tag for projectiles that can trigger perfect dodge (already on Projectile).  
- `IPierceDamage` – interface for spear specials that scale per hit.

---

## COPILOT PROMPT EXAMPLES
Type inside any class: