using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerLoadout))]
    public class PlayerDodge : MonoBehaviour
    {
        [Header("Dodge Settings")]
        public float focusCost = 25f;
        public float dashDistance = 8f;
        public float dashDuration = 0.15f;
        public LayerMask projectileLayer;
        public AudioClip dashClip; // Assign in Inspector

        [Header("Visuals")]
        public Transform indicatorRef;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;
        public LayerMask wallLayer;

        public bool IsInvulnerable { get; private set; }
        public bool IsDashing { get; private set; }

        private KinematicMover _mover;
        private PlayerEnergy _energy;
        private PlayerMovement _movement;
        private PlayerLoadout _loadout;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMovement>();
            _loadout = GetComponent<PlayerLoadout>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

            if (_energy.SpendFocus(focusCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        private IEnumerator DodgeRoutine()
        {
            IsDashing = true;

            // PLAY SOUND
            if (GameFeel.Instance && dashClip) 
                GameFeel.Instance.PlaySound(dashClip, 1f, true);

            IsInvulnerable = true;
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // Spawn decoy from loadout
            GameObject decoyToSpawn = _loadout.currentDecoy;
            if (decoyToSpawn) Instantiate(decoyToSpawn, transform.position, transform.rotation);

            // Direction Logic
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dashDir = _movement.MoveInput.normalized;
            else dashDir = transform.forward;

            // Physics Loop
            // Speed in meters/second
            float speed = dashDistance / dashDuration;
            float timer = 0f;

            while (timer < dashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;
                // Do not multiply by dt here.
                // KinematicMover.Move(Velocity) applies (Velocity * dt) internally.
                _mover.Move(dashDir * speed);
                CatchProjectiles();
                yield return null;
            }

            yield return new WaitForSeconds(0.05f); // Recovery frame

            IsInvulnerable = false;
            IsDashing = false;
        }

        private void CatchProjectiles()
        {
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, projectileLayer);
            foreach (var hit in hits)
            {
                IReflectable proj = hit.GetComponent<IReflectable>();
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    proj.Redirect(transform.forward, gameObject);
                    _energy.AddFocus(20f);
                }
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            if (IsDashing)
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
                bool canAfford = _energy.HasFocus(focusCost);
                Material targetMat = canAfford ? readyMat : notReadyMat;
                if (indicatorRenderer.sharedMaterial != targetMat)
                {
                    indicatorRenderer.sharedMaterial = targetMat;
                }
            }
        }
    }
}