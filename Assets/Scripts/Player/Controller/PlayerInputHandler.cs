using UnityEngine;
using UnityEngine.InputSystem;
using System;

namespace DarkTowerTron.Player.Controller
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [Header("Settings")]
        public float inputSafetyBuffer = 0.2f; // Delay after enabling inputs

        // --- PUBLIC DATA ---
        public Vector2 MoveInput { get; private set; }
        public Vector3 LookDirection { get; private set; } // World Space
        public bool FirePrimary { get; private set; }   // Beam/Melee
        public bool FireSecondary { get; private set; } // Gun

        // --- EVENTS ---
        public event Action OnDash;
        public event Action OnGloryKill;

        // --- INTERNAL ---
        private GameControls _controls;
        private bool _inputEnabled = true;
        private float _safetyTimer = 0f;
        private Camera _cam;

        private void Awake()
        {
            _controls = new GameControls();
            _cam = Camera.main;

            // Bind One-Shots
            _controls.Gameplay.Blitz.performed += ctx => TryAction(OnDash);
            _controls.Gameplay.GloryKill.performed += ctx => TryAction(OnGloryKill);
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

            // Safety Timer (Prevents clicking UI from shooting immediately)
            if (_safetyTimer > 0)
            {
                _safetyTimer -= Time.deltaTime;
                ClearInputs();
                return;
            }

            ProcessContinuousInputs();
        }

        private void ProcessContinuousInputs()
        {
            // 1. Movement
            MoveInput = _controls.Gameplay.Move.ReadValue<Vector2>();

            // 2. Aiming (Hybrid: Mouse or Gamepad)
            HandleAiming();

            // 3. Weapons
            // Note: Using "Melee" for Beam (Primary) and "Gun" for Secondary
            FirePrimary = _controls.asset.FindAction("Melee").ReadValue<float>() > 0.5f;
            FireSecondary = _controls.asset.FindAction("Gun").ReadValue<float>() > 0.5f;
        }

        private void HandleAiming()
        {
            // A. Gamepad Stick
            Vector2 stick = _controls.Gameplay.LookGamepad.ReadValue<Vector2>();
            if (stick.sqrMagnitude > 0.05f)
            {
                LookDirection = new Vector3(stick.x, 0, stick.y).normalized;
                return; // Stick overrides mouse
            }

            // B. Mouse Position (Raycast to Floor)
            Vector2 mousePos = _controls.Gameplay.LookMouse.ReadValue<Vector2>();
            Ray ray = _cam.ScreenPointToRay(mousePos);
            Plane ground = new Plane(Vector3.up, Vector3.zero);

            if (ground.Raycast(ray, out float enter))
            {
                Vector3 worldPoint = ray.GetPoint(enter);
                Vector3 dir = (worldPoint - transform.position);
                dir.y = 0;
                
                if (dir.sqrMagnitude > 0.001f)
                    LookDirection = dir.normalized;
                // If aiming exactly at feet, keep previous direction
            }
        }

        private void TryAction(Action action)
        {
            if (_inputEnabled && _safetyTimer <= 0)
            {
                action?.Invoke();
            }
        }

        private void ClearInputs()
        {
            MoveInput = Vector2.zero;
            FirePrimary = false;
            FireSecondary = false;
            // LookDirection keeps last known value
        }

        // --- API ---
        public void ToggleInput(bool state)
        {
            _inputEnabled = state;
            if (state)
            {
                _controls.Enable();
                _safetyTimer = inputSafetyBuffer;
            }
            else
            {
                _controls.Disable();
                ClearInputs();
            }
        }
    }
}