using UnityEngine;
using DarkTowerTron.Environment; // Access to Prop_Explosive
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    // dependency on the new Prop system
    [RequireComponent(typeof(Prop_Explosive))]
    public class ArchitectHand : MonoBehaviour
    {
        [Header("Visual Components")]
        public Transform visualRoot;    // The object that slides In/Out
        public Transform meshPivot;     // The object that rotates 90 degrees (Telegraph)
        public GameObject wallObject;   // The Laser Hazard (Child)
        public Transform firePoint;     // Where bullets spawn

        [Header("Combat")]
        public GameObject projectilePrefab;
        public float slideDuration = 1.0f;
        public float rotateDuration = 0.5f;

        private Prop_Explosive _prop;
        private bool _isDead = false;

        private void Awake()
        {
            _prop = GetComponent<Prop_Explosive>();

            // Ensure wall is off by default
            if (wallObject) wallObject.SetActive(false);
        }

        private void Update()
        {
            // Check if the Prop took enough damage to "Die"
            // Note: Prop_Explosive handles the explosion VFX internally via its own Die() method,
            // but we need to handle the visual shutdown of the hand here.
            if (!_isDead && _prop.health <= 0)
            {
                Die();
            }
        }

        public bool IsAlive() => !_isDead;

        // --- MOVEMENT ---

        public void MoveToDistance(float localZ)
        {
            if (_isDead) return;
            // Slide along local Z axis relative to the Pivot Parent
            visualRoot.DOLocalMoveZ(localZ, slideDuration).SetEase(Ease.InOutQuad);
        }

        // --- COMBAT ACTIONS ---

        /// <summary>
        /// Telegraphs the wall attack by rotating the hand 90 degrees.
        /// </summary>
        public void PrepareWall(bool willBeActive)
        {
            if (_isDead || meshPivot == null) return;

            // Rotate 90 on Z for Vertical (Wall Mode), 0 for Flat (Gun Mode)
            float targetZ = willBeActive ? 90f : 0f;

            meshPivot.DOLocalRotate(new Vector3(0, 0, targetZ), rotateDuration)
                .SetEase(Ease.OutBack);
        }

        public void SetWall(bool active)
        {
            if (_isDead) active = false;
            if (wallObject) wallObject.SetActive(active);
        }

        public void Shoot(Vector3 targetPos, bool useForward, float scale)
        {
            if (_isDead || !projectilePrefab) return;

            Vector3 dir;
            if (useForward)
            {
                dir = firePoint.forward; // Spiral / Radial aim
            }
            else
            {
                dir = (targetPos - firePoint.position).normalized; // Tracking aim
            }

            // Spawn from Pool
            GameObject p = PoolManager.Instance.Spawn(projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
            p.transform.localScale = Vector3.one * scale;

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = 15f;
                // Ignore the hand itself to prevent instant self-collision
                proj.SetSource(gameObject);
                proj.Initialize(dir);
            }
        }

        // --- STATE MANAGEMENT ---

        private void Die()
        {
            _isDead = true;
            SetWall(false);

            // Visual Shutdown
            if (meshPivot) meshPivot.DOKill();
            visualRoot.DOKill();
            visualRoot.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        public void Revive()
        {
            _isDead = false;
            _prop.OnSpawn(); // Reset Health in the prop component

            // Hard reset visuals
            gameObject.SetActive(true);
            visualRoot.localScale = Vector3.one;
            if (meshPivot) meshPivot.localRotation = Quaternion.identity;
        }
    }
}