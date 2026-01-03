using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat.Strategies
{
    public class SineWaveMovement : IMovementStrategy
    {
        private float _speed;
        private Vector3 _forward;
        private Vector3 _right;
        private float _frequency = 5f;
        private float _amplitude = 2f;
        private float _timeAlive;

        // You could pass config in a Constructor if you weren't using simple interfaces
        // For now, hardcoded or set via property setters
        public SineWaveMovement(float freq, float amp)
        {
            _frequency = freq;
            _amplitude = amp;
        }

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _forward = direction.normalized;
            _right = Vector3.Cross(_forward, Vector3.up); // Calculate "Right" relative to bullet
            _timeAlive = 0f;
            
            transform.rotation = Quaternion.LookRotation(_forward);
        }

        public void Move(Transform transform, float deltaTime)
        {
            _timeAlive += deltaTime;

            // 1. Move Forward
            Vector3 forwardMove = _forward * _speed * deltaTime;

            // 2. Calculate Sine Offset (Mathf.Sin)
            // We apply velocity to the "Right" based on the derivative of Sine, 
            // OR simpler: just offset position (which interacts weirdly with Physics Raycasts).
            
            // Better approach for Raycast-based projectiles: 
            // Calculate current velocity vector and move along it.
            
            // For simplicity in this demo: We will just mutate direction slightly
            float wave = Mathf.Cos(_timeAlive * _frequency) * _amplitude;
            Vector3 finalMove = forwardMove + (_right * wave * deltaTime);

            transform.Translate(finalMove, Space.World);
        }
    }
}