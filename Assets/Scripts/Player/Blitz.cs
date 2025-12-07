using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(GritAndFocus))]
    [RequireComponent(typeof(PlayerMovement))]
    public class Blitz : MonoBehaviour
    {
        [Header("Settings")]
        public float focusCost = 25f;
        public float dashDistance = 8f; // This is your variable distance!
        public float dashDuration = 0.15f;
        public LayerMask projectileLayer;

        [Header("Visuals")]
        public GameObject afterImagePrefab;
        public Transform indicatorRef;
        public bool showIndicator = true;
        public LayerMask wallLayer;

        [Header("Indicator Feedback")]
        public Renderer indicatorRenderer; // Assign the Cylinder's MeshRenderer here
        public Material readyMat;    // Cyan/Solid
        public Material notReadyMat; // Red/Transparent/Grey

        public bool IsInvulnerable { get; private set; }

        private KinematicMover _mover;
        private GritAndFocus _stats;
        private PlayerMovement _movement;
        private bool _isDashing;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _stats = GetComponent<GritAndFocus>();
            _movement = GetComponent<PlayerMovement>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        private void Update()
        {
            HandleIndicator();
            // REMOVED: Input check
        }

        // Called by PlayerController via Event
        public void TryBlitz()
        {
            if (_isDashing) return;

            if (_stats.SpendFocus(focusCost))
            {
                StartCoroutine(DoBlitz());
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            // Hide if dashing or disabled
            if (!showIndicator || _isDashing)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            // 1. Calculate Direction
            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            // 2. Raycast using 'dashDistance' variable
            Vector3 targetPos;
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, dashDistance, wallLayer))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * dashDistance);
            }

            // 3. Position Visuals
            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            // 4. Material Swapping (Visual Feedback)
            if (indicatorRenderer && readyMat && notReadyMat)
            {
                bool canAfford = _stats.HasFocus(focusCost);
                // Only swap if changed to prevent overhead (optimization)
                Material targetMat = canAfford ? readyMat : notReadyMat;
                if (indicatorRenderer.sharedMaterial != targetMat)
                {
                    indicatorRenderer.sharedMaterial = targetMat;
                }
            }
        }

        private IEnumerator DoBlitz()
        {
            _isDashing = true;
            IsInvulnerable = true;
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            if (afterImagePrefab) Instantiate(afterImagePrefab, transform.position, transform.rotation);

            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dashDir = _movement.MoveInput.normalized;
            else dashDir = transform.forward;

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

            yield return new WaitForSeconds(0.05f);

            IsInvulnerable = false;
            _isDashing = false;
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
                    _stats.AddFocus(20f);
                }
            }
        }
    }
}