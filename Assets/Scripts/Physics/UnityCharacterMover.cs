using UnityEngine;

namespace DarkTowerTron.Physics
{
    [RequireComponent(typeof(CharacterController))]
    public class UnityCharacterMover : MonoBehaviour, IMover
    {
        private CharacterController _cc;

        // We calculate velocity manually because _cc.velocity is sometimes 
        // strictly based on movement, not external forces we want to track.
        public Vector3 Velocity { get; private set; }

        public bool IsGrounded => _cc.isGrounded;

        private void Awake()
        {
            _cc = GetComponent<CharacterController>();
        }

        public void Move(Vector3 velocity)
        {
            if (!_cc.enabled) return;

            float dt = Time.deltaTime;

            // 1. Apply Movement
            // CC.Move takes Displacement (Velocity * Time)
            _cc.Move(velocity * dt);

            // 2. Update Public Velocity
            // We store what was passed in, so other scripts (Animation/Sound) know how fast we intend to go
            Velocity = velocity;
        }

        public void Teleport(Vector3 position)
        {
            // Critical: CC overrides transform.position. 
            // You must disable it, move, then re-enable.
            bool wasEnabled = _cc.enabled;
            _cc.enabled = false;
            transform.position = position;
            _cc.enabled = wasEnabled;

            Velocity = Vector3.zero;
        }

        public void SetEnabled(bool state)
        {
            this.enabled = state;
            if (_cc) _cc.enabled = state;
        }
    }
}