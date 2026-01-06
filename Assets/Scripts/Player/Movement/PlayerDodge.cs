using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.Player.Stats;

// ALIAS: Resolves Services conflict
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Player.Movement
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerLoadout))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerDodge : MonoBehaviour
    {
        // REMOVED: public float focusCost, dashDistance, dashDuration 
        // (Moved to PlayerStatsSO)

        // REMOVED: public LayerMask projectileLayer, wallLayer
        // (Moved to GameConstants)

        [Header("Audio")]
        public AudioClip dashClip;

        [Header("Visual Indicator")]
        public Transform indicatorRef;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;
        public bool showIndicator = true;

        // State Properties
        public bool IsInvulnerable { get; private set; }
        public bool IsDashing { get; private set; }

        // Dependencies
        private KinematicMover _mover;
        private PlayerEnergy _energy;
        private PlayerMovement _movement;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMovement>();
            _loadout = GetComponent<PlayerLoadout>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

            // CHANGE: Use Stats
            if (_energy.SpendFocus(_stats.DashCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        private IEnumerator DodgeRoutine()
        {
            IsDashing = true;
            IsInvulnerable = true;

            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // 1. Gravity Suspension (Stats)
            _movement.SuspendGravity(_stats.DashDuration + _stats.ActionHangTime);

            // 2. Audio (Service Locator)
            if (Global.Audio != null && dashClip)
                Global.Audio.PlaySound(dashClip, 1f, true);

            // 3. Decoy
            if (_loadout && _loadout.currentDecoy)
                Instantiate(_loadout.currentDecoy, transform.position, transform.rotation);

            // 4. Direction
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f)
                dashDir = _movement.MoveInput.normalized;
            else
                dashDir = transform.forward;

            // 5. Physics Loop (Stats)
            float speed = _stats.DashDistance / _stats.DashDuration;
            float timer = 0f;

            while (timer < _stats.DashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;

                _mover.Move(dashDir * speed);
                CatchProjectiles();

                yield return null;
            }

            yield return new WaitForSeconds(0.05f);

            IsInvulnerable = false;
            IsDashing = false;
        }

        private void CatchProjectiles()
        {
            // CHANGE: Use GameConstants
            int layerMask = 1 << GameConstants.LAYER_PROJECTILE;
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, layerMask);

            foreach (var hit in hits)
            {
                // Check Interface via Component
                IReflectable proj = hit.GetComponent<IReflectable>();

                // Check Projectile specific implementation for hostility
                // (Ideally IReflectable should have IsHostile, but for now we cast to concrete)
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    // Redirect
                    proj.Redirect(transform.forward, gameObject);

                    // Reward
                    _energy.AddFocus(20f);
                }
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            if (!showIndicator || IsDashing)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;

            // CHANGE: Use GameConstants and Stats
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, _stats.DashDistance, GameConstants.MASK_WALLS))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * _stats.DashDistance);
            }

            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            // Visual Feedback
            if (indicatorRenderer && readyMat && notReadyMat)
            {
                // CHANGE: Use Stats
                bool canAfford = _energy.HasFocus(_stats.DashCost);
                Material targetMat = canAfford ? readyMat : notReadyMat;
                if (indicatorRenderer.sharedMaterial != targetMat)
                {
                    indicatorRenderer.sharedMaterial = targetMat;
                }
            }
        }
    }
}