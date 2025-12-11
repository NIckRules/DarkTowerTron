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

            // --- CACHE ACTIONS ---
            // We look them up once. If they don't exist, these variables will be null.
            _moveAction = _controls.Gameplay.Move;
            _lookPadAction = _controls.Gameplay.LookGamepad;
            _lookMouseAction = _controls.Gameplay.LookMouse;

            // Safely find actions even if you renamed them slightly differently
            _fireBeamAction = _controls.asset.FindAction("Melee");
            _fireGunAction = _controls.asset.FindAction("Gun");

            // --- BINDINGS ---
            // 1. Dodge (Space / RB)
            // Use FindAction to be safe, or direct access if you are sure
            var dodgeAction = _controls.asset.FindAction("Blitz");
            if (dodgeAction != null) dodgeAction.performed += ctx => OnDodge();

            // 2. Glory Kill (E / LB)
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
            if (_beamWeapon != null && _fireBeamAction != null)
            {
                bool isBeam = _fireBeamAction.ReadValue<float>() > 0.5f;
                _beamWeapon.SetFiring(isBeam);
            }

            // 2. Handle GUN
            if (_gunWeapon != null && _fireGunAction != null)
            {
                bool isGun = _fireGunAction.ReadValue<float>() > 0.5f;
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