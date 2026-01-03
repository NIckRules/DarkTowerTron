using UnityEngine;
using UnityEngine.InputSystem;
using System;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Input; // Namespace for Buffer

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
                GameLogger.LogError(DarkTowerTron.Core.LogChannel.Player,
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