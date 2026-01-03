using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Combat;

namespace DarkTowerTron.Combat
{
    public class HomingMissile : MonoBehaviour
    {
        public float turnSpeed = 5f;

        private Transform _target;
        private Projectile _projectile;

        private void OnEnable()
        {
            _projectile = GetComponent<Projectile>();

            // Find Target from Player's Scanner
            var player = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (player)
            {
                var scanner = player.GetComponent<TargetScanner>();
                if (scanner && scanner.CurrentTarget != null)
                {
                    // Target the collider center or transform
                    _target = scanner.CurrentTarget.transform;
                }
            }
        }

        private void Update()
        {
            if (_target == null || _projectile == null) return;

            Vector3 dirToTarget = (_target.position - transform.position).normalized;

            // Smoothly rotate towards target
            // The Projectile script moves 'Forward', so this curves the flight path
            Vector3 newDir = Vector3.RotateTowards(transform.forward, dirToTarget, turnSpeed * Time.deltaTime, 0.0f);

            transform.rotation = Quaternion.LookRotation(newDir);

            // Update the Projectile's internal direction vector so it doesn't fight us
            // (Only needed if Projectile uses a cached vector instead of transform.forward)
            // Our Projectile.cs uses a cached `_direction`. We need to update it.
            _projectile.Initialize(newDir);
        }
    }
}