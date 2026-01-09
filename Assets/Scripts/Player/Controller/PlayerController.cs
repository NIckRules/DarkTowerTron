using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Combat;   // Ensure these match your folders
using DarkTowerTron.Player.Movement;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Controller
{
    [RequireComponent(typeof(PlayerInputHandler))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerExecution))]
    [RequireComponent(typeof(PlayerWeaponController))]
    public class PlayerController : MonoBehaviour
    {
        // --- Dependencies ---
        private PlayerInputHandler _input;
        private PlayerMotor _movement;
        private PlayerDodge _dodge;
        private PlayerExecution _execution;
        private PlayerWeaponController _weapons;
        private TargetScanner _scanner;

        private void Awake()
        {
            // 1. Get Components
            _input = GetComponent<PlayerInputHandler>();
            _movement = GetComponent<PlayerMotor>();
            _dodge = GetComponent<PlayerDodge>();
            _execution = GetComponent<PlayerExecution>();
            _weapons = GetComponent<PlayerWeaponController>();
            _scanner = GetComponent<TargetScanner>();

            // 2. Bind Input Events
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
            // We read from the Handler. If Handler is crashing (null refs), this returns (0,0)
            Vector3 moveDir = new Vector3(_input.MoveInput.x, 0, _input.MoveInput.y).normalized;
            _movement.SetMoveInput(moveDir);

            // 2. Looking / Aiming
            Vector3 aimDir = _input.LookDirection;
            if (aimDir == Vector3.zero) aimDir = transform.forward; 
            
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

        // --- PUBLIC API ---

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