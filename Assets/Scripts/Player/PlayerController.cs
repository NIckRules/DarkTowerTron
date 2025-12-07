using UnityEngine;
using UnityEngine.InputSystem; // Required for InputAction types

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerAttack))]
    [RequireComponent(typeof(Blitz))]
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement _movement;
        private PlayerAttack _attack;
        private Blitz _blitz;

        // This is the class generated from your asset
        private GameControls _controls;
        private bool _inputEnabled = true;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            _attack = GetComponent<PlayerAttack>();
            _blitz = GetComponent<Blitz>();

            // Initialize the generated class
            _controls = new GameControls();

            // Subscribe to One-Shot events (Blitz)
            // Note: Ensure your Action is named 'Blitz' in the asset, or change this line
            _controls.Gameplay.Blitz.performed += ctx => OnBlitz();
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
            HandleAiming();
            HandleFiring();
        }

        private void HandleMovement()
        {
            // Reads WASD or Left Stick
            Vector2 input = _controls.Gameplay.Move.ReadValue<Vector2>();
            Vector3 dir = new Vector3(input.x, 0, input.y).normalized;

            _movement.SetMoveInput(dir);
        }

        private void HandleAiming()
        {
            // 1. Check Right Stick (Gamepad)
            // Ensure you named the action "LookGamepad" in your input asset
            Vector2 stickInput = _controls.Gameplay.LookGamepad.ReadValue<Vector2>();

            // If stick is moving, it overrides mouse
            if (stickInput.sqrMagnitude > 0.05f)
            {
                Vector3 lookDir = new Vector3(stickInput.x, 0, stickInput.y);
                _movement.LookAtDirection(lookDir);
            }
            // 2. Fallback to Mouse
            else
            {
                // Ensure you named the action "LookMouse" in your input asset
                Vector2 mouseScreenPos = _controls.Gameplay.LookMouse.ReadValue<Vector2>();
                _movement.LookAtMouse(mouseScreenPos);
            }
        }

        private void HandleFiring()
        {
            // Reads "Fire" button (Mouse Left or Right Trigger)
            // Using ReadValue<float>() handles Triggers (0 to 1) and Buttons (0 or 1)
            bool isFiring = _controls.Gameplay.Fire.ReadValue<float>() > 0.5f;
            _attack.SetFiring(isFiring);
        }

        private void OnBlitz()
        {
            if (_inputEnabled) _blitz.TryBlitz();
        }

        public void ToggleInput(bool state)
        {
            _inputEnabled = state;
            if (state) _controls.Enable();
            else _controls.Disable();

            if (!state)
            {
                _movement.SetMoveInput(Vector3.zero);
                _attack.SetFiring(false);
            }
        }
    }
}