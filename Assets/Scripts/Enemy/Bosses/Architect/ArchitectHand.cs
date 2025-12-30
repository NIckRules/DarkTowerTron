using UnityEngine;
using DarkTowerTron.Environment; 
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    [RequireComponent(typeof(DamageableProp))]
    public class ArchitectHand : MonoBehaviour
    {
        [Header("Components")]
        public Transform visualRoot;    // Moves In/Out
        public Transform meshPivot;     // NEW: Rotates 90 degrees (Wrist+Palm parent)
        public GameObject wallObject;   // The Laser Hazard
        public Transform firePoint;
        public GameObject projectilePrefab;

        [Header("Movement")]
        public float slideDuration = 1.0f;
        public float rotateDuration = 0.5f; // Time to turn vertical

        private DamageableProp _prop;
        private bool _isDead = false;

        private void Awake()
        {
            _prop = GetComponent<DamageableProp>();
            if (wallObject) wallObject.SetActive(false);
        }

        private void Update()
        {
            if (!_isDead && _prop.health <= 0)
            {
                _isDead = true;
                SetWall(false);
                if (meshPivot) meshPivot.DOKill();
                visualRoot.DOScale(Vector3.zero, 0.5f); 
            }
        }

        public bool IsAlive() => !_isDead;

        public void MoveToDistance(float localZ)
        {
            if (_isDead) return;
            visualRoot.DOLocalMoveZ(localZ, slideDuration).SetEase(Ease.InOutQuad);
        }

        // 1. TELEGRAPH: Rotate the hand
        public void PrepareWall(bool willBeActive)
        {
            if (_isDead || meshPivot == null) return;

            // If active = Rotate to 90 (Vertical)
            // If false = Rotate to 0 (Flat)
            float targetZ = willBeActive ? 90f : 0f;
            
            meshPivot.DOLocalRotate(new Vector3(0, 0, targetZ), rotateDuration)
                .SetEase(Ease.OutBack);
        }

        // 2. EXECUTE: Turn on the hazard
        public void SetWall(bool active)
        {
            if (_isDead) active = false;
            if (wallObject) wallObject.SetActive(active);
        }

        public void Shoot(Vector3 targetPos, bool useForward, float scale)
        {
            if (_isDead || !projectilePrefab) return;

            Vector3 dir;
            if (useForward) dir = firePoint.forward;
            else dir = (targetPos - firePoint.position).normalized;

            GameObject p = PoolManager.Instance.Spawn(projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
            p.transform.localScale = Vector3.one * scale;

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = 15f;
                proj.SetSource(gameObject);
                proj.Initialize(dir);
            }
        }
    }
}