# STRIKER - Alpha Validation Checklist

**Usage:** Run this checklist in the `Scene_Gym` using the `DebugController`.
**Pass Condition:** A feature only passes if it works consistently **3 times in a row**.

---

## 1. LOCOMOTION & PHYSICS (The Foundation)
*Goal: Ensure the new `KinematicMover` handles world interaction flawlessly.*

- [ ] **The Gravity Drop**: Lift the Player and a Chaser 5 units in the air (Scene View). Press Play.
    - *Pass:* Both fall and snap to the floor immediately.
    - *Fail:* They float in mid-air.
- [ ] **The Orbiter Float**: Spawn an Orbiter.
    - *Pass:* It spawns at Y=0, then smoothly rises to Y=1.5 and hovers.
    - *Fail:* It stays on the ground or flies off into space.
- [ ] **The Corner Trap**: Dash (Spacebar) directly into a 90-degree corner.
    - *Pass:* Player stops instantly upon impact. No jitter, no passing through walls.
    - *Fail:* Player vibrates or clips through.
- [ ] **The Wall Rub**: Run diagonally (W+A) against a flat wall.
    - *Pass:* Player slides along the wall while maintaining forward momentum. "Wall Repulsion" pushes back slightly.
    - *Fail:* Player sticks/stops dead.

## 2. PLAYER COMBAT (The Arsenal)
*Goal: Ensure weapons feel responsive and resources manage correctly.*

- [ ] **Gun Fire**: Hold Right Click (or RT).
    - *Pass:* Projectiles spawn, travel straight, and despawn upon hitting walls.
    - *Fail:* Projectiles stick to walls or pass through enemies.
- [ ] **Beam Fire**: Click Left Click (or LT).
    - *Pass:* Beam snaps to target (if locked), recoil pushes player backward.
    - *Fail:* Beam fires downwards into floor.
- [ ] **Stagger Logic**: Shoot a Chaser 3-4 times.
    - *Pass:* Chaser flashes White -> Turns Yellow (Staggered) -> Stops moving.
    - *Fail:* Chaser dies instantly (Damage too high?) or never staggers.
- [ ] **Dodge (Movement)**: Press Spacebar with **No Target**.
    - *Pass:* Player dashes in movement direction. Focus decreases (-25).
    - *Fail:* Player teleports or Focus doesn't drop.
- [ ] **Glory Kill (Execution)**: Lock onto a **Staggered** enemy. Press E.
    - *Pass:* Player teleports to enemy. Enemy explodes. Focus Refills (+50). Grit Heals (+1).
    - *Fail:* "No Target" log, or Player dashes through enemy without killing.

## 3. ENEMY AI & NAVIGATION (The Threat)
*Goal: Ensure the new Context Steering and Tier logic works.*

- [ ] **The Swarm Test**: Spawn 20 Chasers (Spam NumPad 1). Stand still.
    - *Pass:* They surround the player in a natural circle/blob. They do **not** stack on top of each other.
    - *Fail:* They merge into a single "Super Enemy."
- [ ] **The Obstacle Test**: Spawn a Sentinel/Chaser behind a pillar.
    - *Pass:* It curves smoothly around the pillar to get to the player.
    - *Fail:* It walks straight into the pillar and gets stuck.
- [ ] **Sniper Behavior**: Approach a Sniper.
    - *Pass:* It teleports away before you can touch it.
    - *Fail:* It stays still, or teleports inside a wall.
- [ ] **Guardian Shield**: Shoot a Guardian from the front.
    - *Pass:* "BLOCKED" text appears. No damage taken.
    - *Fail:* Guardian dies from frontal fire.

## 4. SYSTEMS & FLOW (The Loop)
*Goal: Ensure the game manages resources and states correctly.*

- [ ] **Object Pooling**: Fire 100 bullets. Kill 10 enemies.
    - *Pass:* Check Hierarchy `[SYSTEM]`. Despawned objects are children of System. No `Destroy()` lag spikes.
    - *Fail:* Hierarchy is flooded with loose objects, or objects disappear forever.
- [ ] **Wave Logic (Anchor)**:
    - *Step 1:* Kill all "Essential" enemies (Guardians/Snipers).
    - *Step 2:* Verify "Reinforcements Stopped" (Grunts stop spawning).
    - *Step 3:* Kill remaining Grunts.
    - *Pass:* "WAVE CLEARED" appears only after the room is empty.
- [ ] **Pause System**: Press ESC during gameplay.
    - *Pass:* Game freezes. Menu appears. Clicking "Resume" snaps back instantly.
- [ ] **Victory Condition**: Clear the final wave.
    - *Pass:* Slow motion. "MISSION COMPLETE" screen. Rank calculated (S/A/B).

## 5. VISUALS & UI (The Polish)
*Goal: Ensure the game looks like a finished product.*

- [ ] **UI Scaling**: Change Game View resolution to 4K, then to 1024x768.
    - *Pass:* Score (Top Right) and Timer (Top Center) stay stuck to the edges. They do not float in the middle or get cut off.
- [ ] **Spawn VFX**: Enemy spawns.
    - *Pass:* Cyan digital ring appears on the floor (Y=0), Enemy scales up from 0 to 1.
- [ ] **Damage Numbers**: Hit an enemy.
    - *Pass:* White numbers float up. Yellow numbers for Crits. Cyan text for "STAGGER".
- [ ] **Post-Processing**:
    - *Pass:* Neon objects (Reticle, Projectiles) glow and bleed light (Bloom).

---

### 🛑 CRITICAL FAILURE PROTOCOL
If a test fails:
1.  **Do not fix it immediately.**
2.  Log it in a `BUGS.md` file.
3.  Finish the checklist (to see if it breaks other things).
4.  Then fix the code.