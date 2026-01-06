
This is the **Constitution of the Codebase**.

It defines the rules we established during the refactor. Whenever you start a new chat session, you can paste the **"AI Primer"** section at the bottom to ensure the AI immediately understands the architecture without needing to read 100 files.

---

# 📜 DarkTowerTron Coding Standards & Architecture

## 1. Architectural Patterns

### **A. Dependency Injection (Service Locator)**
*   **Rule:** No Static Singletons (`public static T Instance`).
*   **Pattern:** Use the `ServiceLocator` via the `Services` helper.
*   **Usage:**
    *   ✅ `Services.Audio.PlaySound(...)`
    *   ✅ `Services.Pool.Spawn(...)`
    *   ❌ `AudioManager.Instance.PlaySound(...)`
*   **Registration:** All Managers must be registered in the `SystemBootloader` prefab using `GameBootstrap`.

### **B. Event System (ScriptableObjects)**
*   **Rule:** No static C# events (`public static Action OnHit`).
*   **Pattern:** Use **Event Channel ScriptableObjects**.
*   **Naming:** `Event_[Subject]_[Verb]` (e.g., `Event_Player_Hit`, `Event_Enemy_Killed`).
*   **Usage:**
    *   **Broadcasters:** Expose a `[SerializeField]` channel and call `.Raise()`.
    *   **Listeners:** Subscribe via `OnEventRaised` in code (Managers) or `VoidEventListener` component (UI/VFX).

### **C. Logic Separation (Humble Object)**
*   **Rule:** Heavy logic does not belong in MonoBehaviours if it can be pure C#.
*   **Pattern:** Strategy Pattern & Logic Classes.
*   **Example:** `Projectile.cs` (View) delegates movement to `IMovementStrategy` (Logic).
*   **Example:** `PlayerController.cs` (View) delegates input to `PlayerInputHandler` (Logic).

---

## 2. Coding Standards

### **A. Naming Conventions**
*   **Namespaces:** `DarkTowerTron.[Feature].[SubFeature]` (e.g., `DarkTowerTron.Player.Combat`).
*   **Classes:** `PascalCase` (e.g., `EnemyController`).
*   **Interfaces:** `I` prefix + `PascalCase` (e.g., `IDamageable`, `IMovementStrategy`).
*   **Private Fields:** `_camelCase` (e.g., `_currentHealth`, `_inputVector`).
*   **Public/Serialized Fields:** `camelCase` (e.g., `moveSpeed`, `firePoint`).
    *   *Note:* Unity standard is camelCase for Inspector fields.
*   **Constants:** `UPPER_SNAKE_CASE` (e.g., `TAG_PLAYER`, `MASK_GROUND`).

### **B. Hygiene & Safety**
*   **Magic Strings:** **FORBIDDEN.** Use `GameConstants.TAG_PLAYER` or `GameConstants.LAYER_ENEMY`.
*   **Magic Numbers:** **FORBIDDEN** for gameplay values. Use `PlayerStatsSO` or `BalanceConfigSO`.
*   **Null Checks:**
    *   Use `[RequireComponent]` for sibling dependencies.
    *   Check critical references in `Awake`. If missing, log error and `enabled = false`.
*   **Logging:** Use `GameLogger.Log(LogChannel.X, ...)` instead of `Debug.Log`.

### **C. Physics & Game Loop**
*   **Movement:** Physics calculations (Forces, Raycasts for movement) **MUST** occur in `FixedUpdate`.
*   **Input:** Input polling **MUST** occur in `Update` (via `InputHandler`).
*   **Loops:** Any `while` loop inside a collision check/raycast algorithm must have a **Safety Valve** (max iterations) to prevent infinite freezes.

### **D. Asset Naming (Project View)**
*   **Data:** `[Type]_[Entity]_[Variant]`
    *   ✅ `Stats_Player_Default`
    *   ✅ `Wave_Level1_01`
    *   ✅ `Event_Player_Hit`
*   **Prefabs:** `[Entity]_[Variant]`
    *   ✅ `Enemy_Chaser`
    *   ✅ `Projectile_Plasma`

---

## 3. Folder Structure (Domain Driven)

```text
Assets/
├── Data/                  <-- ScriptableObjects Only
│   ├── Events/
│   ├── Player/
│   ├── Enemies/
│   └── Waves/
├── Scripts/
│   ├── Core/              <-- Agnostic Engine Code
│   │   ├── Services/      (Locator, Bootloader)
│   │   ├── Events/        (Channel Definitions)
│   │   ├── Interfaces/    (IDamageable, IWeapon)
│   │   └── Data/          (SO Class Definitions)
│   ├── Services/          <-- The "Big 3" Implementations
│   │   ├── Audio/
│   │   ├── Pooling/
│   │   └── VFX/
│   ├── Player/            <-- Domain: Player
│   │   ├── Combat/
│   │   ├── Movement/
│   │   └── Controller/
│   ├── Enemy/             <-- Domain: Enemy
│   ├── Managers/          <-- Gameplay Logic (Director, Score)
│   └── UI/
└── Resources/
    └── SystemBootloader   <-- The Auto-Boot Prefab