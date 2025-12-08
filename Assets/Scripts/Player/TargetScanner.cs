using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Enemy;

namespace DarkTowerTron.Player
{
    public class TargetScanner : MonoBehaviour
    {
        [Header("Settings")]
        public float scanRange = 15f;
        public float scanRadius = 1.5f;
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public Transform reticlePrefab; // Assign a 3D Mesh (Quad/Cylinder)
        public Vector3 reticleOffset = new Vector3(0, 0.1f, 0);

        public EnemyController CurrentTarget { get; private set; }

        private Transform _reticleInstance;

        private void Start()
        {
            if (reticlePrefab)
            {
                _reticleInstance = Instantiate(reticlePrefab, Vector3.zero, Quaternion.identity);
                _reticleInstance.gameObject.SetActive(false);
            }
        }

        // Called by PlayerController every frame
        public void UpdateScanner(Vector3 aimDirection)
        {
            // FIX: Lift origin up by 1.0f (Chest height)
            Vector3 origin = transform.position + Vector3.up * 1.0f;

            // 1. SphereCast along the Aim Direction
            // Note: We scan for 'scanRange', but we might need to mask out Walls so we don't target through them
            if (UnityEngine.Physics.SphereCast(origin, scanRadius, aimDirection, out RaycastHit hit, scanRange, enemyLayer))
            {
                EnemyController enemy = hit.collider.GetComponentInParent<EnemyController>();
                if (enemy != null)
                {
                    CurrentTarget = enemy;
                }
                else
                {
                    CurrentTarget = null;
                }
            }
            else
            {
                CurrentTarget = null;
            }

            UpdateReticle();
        }

        private void UpdateReticle()
        {
            if (_reticleInstance == null) return;

            if (CurrentTarget != null)
            {
                _reticleInstance.gameObject.SetActive(true);
                _reticleInstance.position = CurrentTarget.transform.position + reticleOffset;
                // Spin effect
                _reticleInstance.Rotate(Vector3.up * 200 * Time.deltaTime);
            }
            else
            {
                _reticleInstance.gameObject.SetActive(false);
            }
        }
    }
}