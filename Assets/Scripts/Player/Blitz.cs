using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMovement))]
    public class Blitz : MonoBehaviour
    {
        [Header("Dodge Settings")]
        public float dodgeCost = 25f;
        public float dashDistance = 8f;
        public float dashDuration = 0.15f;

        [Header("Glory Kill Settings")]
        public float killRewardFocus = 50f;

        [Header("References")]
        public LayerMask projectileLayer;
        public LayerMask wallLayer;
        public GameObject afterImagePrefab;

        // Indicator refs
        public Transform indicatorRef;
        public bool showIndicator = true;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;

        public bool IsInvulnerable { get; private set; }

        private KinematicMover _mover;
        private PlayerEnergy _energy;
        private PlayerMovement _movement;
        private TargetScanner _scanner;
        private bool _isActionBusy; // Locks both Dodge and Kill

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMovement>();
            _scanner = GetComponent<TargetScanner>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        private void Update()
        {
            HandleIndicator();
        }

        // --- ACTION 1: DODGE (Survival) ---
        public void PerformDodge()
        {
            if (_isActionBusy) return;

            // Dodge costs Focus
            if (_energy.SpendFocus(dodgeCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        // --- ACTION 2: GLORY KILL (Execution) ---
        public void PerformGloryKill()
        {
            if (_isActionBusy) return;

            // Logic Check: Do we have a valid target?
            if (_scanner != null && _scanner.CurrentTarget != null && _scanner.CurrentTarget.IsStaggered)
            {
                StartCoroutine(GloryKillRoutine(_scanner.CurrentTarget));
            }
            else
            {
                // Feedback: Failed execution (Sound or Shake?)
                Debug.Log("No valid target for Glory Kill!");
            }
        }

        private IEnumerator DodgeRoutine()
        {
            _isActionBusy = true;
            IsInvulnerable = true;
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // Visuals
            if (afterImagePrefab) Instantiate(afterImagePrefab, transform.position, transform.rotation);

            // Direction Logic
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dashDir = _movement.MoveInput.normalized;
            else dashDir = transform.forward;

            // Physics Loop
            float speed = dashDistance / dashDuration;
            float timer = 0f;
            while (timer < dashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;
                _mover.Move(dashDir * speed * dt);
                CatchProjectiles();
                yield return null;
            }

            yield return new WaitForSeconds(0.05f); // Recovery frame

            IsInvulnerable = false;
            _isActionBusy = false;
        }

        private IEnumerator GloryKillRoutine(DarkTowerTron.Enemy.EnemyController target)
        {
            _isActionBusy = true;
            IsInvulnerable = true; // Invuln during animation

            // 1. Teleport
            Vector3 enemyPos = target.transform.position;
            // Land slightly in front of them (based on look direction)
            Vector3 attackPos = enemyPos - (transform.forward * 1.0f);
            transform.position = attackPos;

            // 2. Kill
            target.Kill(false);

            // 3. Reward
            _energy.AddFocus(killRewardFocus);
            var health = GetComponent<PlayerHealth>();
            if (health) health.HealGrit();

            // 4. Juice
            if (GameFeel.Instance)
            {
                GameFeel.Instance.HitStop(0.2f);
                GameFeel.Instance.CameraShake(0.3f, 0.8f);
            }

            // Brief pause to sell the impact
            yield return new WaitForSeconds(0.15f);

            IsInvulnerable = false;
            _isActionBusy = false;
        }

        private void HandleIndicator()
        {
            // Indicator logic remains mostly the same, 
            // but now it specifically visualizes the DODGE capability.
            if (!indicatorRef) return;

            if (!showIndicator || _isActionBusy)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, dashDistance, wallLayer))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * dashDistance);
            }

            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            if (indicatorRenderer && readyMat && notReadyMat)
            {
                bool canAfford = _energy.HasFocus(dodgeCost);
                Material targetMat = canAfford ? readyMat : notReadyMat;
                if (indicatorRenderer.sharedMaterial != targetMat)
                {
                    indicatorRenderer.sharedMaterial = targetMat;
                }
            }
        }

        private void CatchProjectiles()
        {
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, projectileLayer);
            foreach (var hit in hits)
            {
                IReflectable proj = hit.GetComponent<IReflectable>();
                var pScript = hit.GetComponent<DarkTowerTron.Combat.Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    proj.Redirect(transform.forward, gameObject);
                    _energy.AddFocus(20f);
                }
            }
        }
    }
}