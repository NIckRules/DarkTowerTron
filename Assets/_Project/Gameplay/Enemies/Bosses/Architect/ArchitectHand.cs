using UnityEngine;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Systems;
using DG.Tweening;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Gameplay.Enemies
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class ArchitectHand : MonoBehaviour
    {
        [Header("Visual Components")]
        public Transform visualRoot;    // The object that slides In/Out
        public Transform meshPivot;     // The object that rotates 90 degrees
        public GameObject wallObject;   // The Laser Hazard (Child)
        public Transform firePoint;     // Where bullets spawn

        [Header("Combat Configuration")]
        public GameObject projectilePrefab;
        public GameObject deathExplosionEffect; 

        [Header("Animation")]
        public float slideDuration = 1.0f;
        public float rotateDuration = 0.5f;

        // Dependencies
        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;
        private bool _isDead = false;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();

            if (wallObject) wallObject.SetActive(false);
        }

        private void Start()
        {
            // Initialize DamageReceiver (No Stats SO needed, uses Inspector overrides)
            _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            _receiver.OnDeathProcessed += HandleDeath;
            _receiver.OnHitProcessed += HandleHit;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
            }
        }

        private void OnDisable()
        {
            _receiver.OnDeathProcessed -= HandleDeath;
            _receiver.OnHitProcessed -= HandleHit;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
            }
        }

        public bool IsAlive() => !_isDead;

        // --- HANDLERS ---

        private void HandleHit(DamageInfo info)
        {
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            if (_isDead) return;
            Die();
        }

        // --- MOVEMENT ---

        public void MoveToDistance(float localZ)
        {
            if (_isDead) return;
            visualRoot.DOLocalMoveZ(localZ, slideDuration).SetEase(Ease.InOutQuad);
        }

        // --- COMBAT ACTIONS ---

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

            // Service Access
            var pool = ServiceLocator.Get<IPoolService>();
            if (pool == null) return;

            Vector3 dir;
            if (useForward)
                dir = firePoint.forward; // Spiral / Radial aim
            else
                dir = (targetPos - firePoint.position).normalized; // Tracking aim

            // Spawn from Pool
            GameObject p = pool.Spawn(projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
            p.transform.localScale = Vector3.one * scale;

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = 15f;
                // CRITICAL: Set Source so the bullet ignores the HandCollider immediately
                proj.SetSource(gameObject);
                proj.Initialize(dir);
            }
        }

        // --- STATE MANAGEMENT ---

        private void Die()
        {
            _isDead = true;
            SetWall(false);

            // 1. VFX
            var pool = ServiceLocator.Get<IPoolService>();
            if (deathExplosionEffect && pool != null)
            {
                pool.Spawn(deathExplosionEffect, transform.position, Quaternion.identity);
            }

            // 2. Visual Shutdown (Shrink)
            if (meshPivot) meshPivot.DOKill();
            visualRoot.DOKill();
            visualRoot.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);

            // 3. Disable Collider
            var col = GetComponent<Collider>();
            if (col) col.enabled = false;
        }

        public void Revive()
        {
            _isDead = false;

            _receiver.Vitality.Revive();
            _receiver.Stagger.ResetStagger();
            _visuals.ResetVisuals();

            var col = GetComponent<Collider>();
            if (col) col.enabled = true;

            gameObject.SetActive(true);
            visualRoot.localScale = Vector3.zero;
            visualRoot.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);

            if (meshPivot) meshPivot.localRotation = Quaternion.identity;
        }
    }
}