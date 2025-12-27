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
        private PlayerAttack _beamWeapon; // Left Trigger / LMB
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

            _beamWeapon = GetComponent<PlayerAttack>();
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