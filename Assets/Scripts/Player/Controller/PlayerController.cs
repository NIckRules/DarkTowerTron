using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Combat;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Player.Movement;

namespace DarkTowerTron.Player.Controller
{
    [RequireComponent(typeof(PlayerInputHandler))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerExecution))]
    [RequireComponent(typeof(PlayerWeaponController))]
    public class PlayerController : MonoBehaviour
    {
        // --- Dependencies ---
        private PlayerInputHandler _input;
        private PlayerMovement _movement;
        private PlayerDodge _dodge;
        private PlayerExecution _execution;
        private PlayerWeaponController _weapons;
        private TargetScanner _scanner;

        private void Awake()
        {
            // 1. Get Components
            _input = GetComponent<PlayerInputHandler>();
            _movement = GetComponent<PlayerMovement>();
            _dodge = GetComponent<PlayerDodge>();
            _execution = GetComponent<PlayerExecution>();
            _weapons = GetComponent<PlayerWeaponController>();
            _scanner = GetComponent<TargetScanner>();

            // 2. Bind Input Events
            // Note: Continuous inputs (Move/Look) are polled in Update
            // One-shots (Dash/Kill) are events
            _input.OnDash += PerformDodge;
            _input.OnGloryKill += PerformGloryKill;

            // 3. Register Service
            GameServices.RegisterPlayer(this);
        }

        private void OnDestroy()
        {
            if (_input)
            {
                _input.OnDash -= PerformDodge;
                _input.OnGloryKill -= PerformGloryKill;
            }
        }

        private void Update()
        {
            // 1. Movement
            // Convert Input(Vector2) to 3D Plane (X, 0, Y)
            Vector3 moveDir = new Vector3(_input.MoveInput.x, 0, _input.MoveInput.y).normalized;
            _movement.SetMoveInput(moveDir);

            // 2. Looking / Aiming
            Vector3 aimDir = _input.LookDirection;
            if (aimDir == Vector3.zero) aimDir = transform.forward; // Safety
            
            _movement.LookAtDirection(aimDir);
            if (_scanner) _scanner.UpdateScanner(aimDir);

            // 3. Weapons
            _weapons.SetPrimaryFire(_input.FirePrimary);
            _weapons.SetSecondaryFire(_input.FireSecondary);
        }

        // --- ACTION HANDLERS ---

        private void PerformDodge()
        {
            if (_dodge) _dodge.PerformDodge();
        }

        private void PerformGloryKill()
        {
            if (_execution) _execution.PerformGloryKill();
        }

        // --- PUBLIC API (Used by GameSession) ---

        public void ToggleInput(bool state)
        {
            if (_input) _input.ToggleInput(state);
            if (!state)
            {
                _movement.SetMoveInput(Vector3.zero);
                _weapons.StopAll();
            }
        }
    }
}