using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Physics; // This causes the name collision

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    public class PlayerMovement : MonoBehaviour
    {

        public Vector3 MoveInput => _inputDir;

        [Header("Settings")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;
        public float deceleration = 40f;
        public float rotationSpeed = 25f;

        private KinematicMover _mover;
        private Camera _cam;
        
        private Vector3 _inputDir;
        private Vector3 _currentVelocity;
        private Vector3 _externalForce;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _cam = Camera.main;
        }

        public void SetMoveInput(Vector3 dir)
        {
            _inputDir = dir;
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _externalForce += force;
        }

        private void Update()
        {
            HandleVelocity();
        }

        private void HandleVelocity()
        {
            float dt = Time.deltaTime;

            // 1. Calculate Target
            Vector3 targetVel = _inputDir * moveSpeed;

            // 2. Accelerate/Decelerate
            if (_inputDir.magnitude > 0.1f)
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, acceleration * dt);
            }
            else
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, deceleration * dt);
                // Snap to zero to prevent float drift
                if (_currentVelocity.magnitude < 0.01f) _currentVelocity = Vector3.zero;
            }

            // 3. External Forces (Friction)
            if (_externalForce.magnitude > 0.1f)
            {
                _externalForce = Vector3.Lerp(_externalForce, Vector3.zero, 5f * dt);
            }
            else
            {
                _externalForce = Vector3.zero;
            }

            // 4. Move
            Vector3 finalMotion = (_currentVelocity + _externalForce) * dt;
            _mover.Move(finalMotion);
        }

        // Keep this for Mouse
        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, LayerMask.GetMask(GameConstants.LAYER_GROUND)))
            {
                Vector3 lookDir = hit.point - transform.position;
                LookAtDirection(lookDir); // Reuse the logic below
            }
        }

        // ADD THIS: Direct Vector rotation (for Gamepad)
        public void LookAtDirection(Vector3 direction)
        {
            direction.y = 0;
            if (direction.sqrMagnitude > 0.001f)
            {
                Quaternion targetRot = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
            }
        }
    }
}