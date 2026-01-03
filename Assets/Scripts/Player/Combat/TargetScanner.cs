using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerStats))]
    public class TargetScanner : MonoBehaviour
    {
        [Header("Settings")]
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public Transform reticlePrefab; 
        public Vector3 reticleOffset = new Vector3(0, 0.1f, 0);
        
        // NEW: Visual Feedback settings
        public Color lockedColor = Color.cyan;
        public Color executionColor = Color.yellow; // or Red

        public ICombatTarget CurrentTarget { get; private set; }

        private Transform _reticleInstance;
        private LineRenderer _reticleLine; // Assuming we use the LineRenderer reticle
        private PlayerStats _stats;

        private void Awake()
        {
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            if (reticlePrefab)
            {
                _reticleInstance = Instantiate(reticlePrefab, Vector3.zero, Quaternion.identity);
                _reticleLine = _reticleInstance.GetComponent<LineRenderer>();
                _reticleInstance.gameObject.SetActive(false);
            }
        }

        public void UpdateScanner(Vector3 aimDirection)
        {
            // Lift origin slightly to avoid floor clipping
            Vector3 origin = transform.position + Vector3.up * 1.0f;

            int layerMask = 1 << GameConstants.LAYER_ENEMY;

            float range = _stats ? _stats.ScanRange : 25f;
            float radius = _stats ? _stats.ScanRadius : 2f;

            if (UnityEngine.Physics.SphereCast(origin, radius, aimDirection, out RaycastHit hit, range, layerMask))
            {
                // FIX: Look for Interface instead of EnemyController
                ICombatTarget target = hit.collider.GetComponentInParent<ICombatTarget>();
                
                if (target != null)
                {
                    CurrentTarget = target;
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
                _reticleInstance.Rotate(Vector3.up * 200 * Time.deltaTime);

                // --- NEW: COLOR LOGIC ---
                if (_reticleLine)
                {
                    // If Staggered -> Show Execution Color (Yellow/Red)
                    // If Healthy -> Show Lock Color (Cyan)
                    Color targetColor = CurrentTarget.IsStaggered ? executionColor : lockedColor;
                    
                    // Simple property block or direct material color change
                    _reticleLine.startColor = targetColor;
                    _reticleLine.endColor = targetColor;
                    // Also update material color for emission glow
                    _reticleLine.material.color = targetColor;
                }
            }
            else
            {
                _reticleInstance.gameObject.SetActive(false);
            }
        }
        
        // Gizmos remain same...
    }
}