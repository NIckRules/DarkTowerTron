using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Movement
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

        [Header("Traversal (Gravity Control)")]
        [Tooltip("How long to suspend gravity AFTER the dash ends (Coyote Time).")]
        public float hangTime = 0.2f;

        [Header("Interaction Settings")]
        public LayerMask projectileLayer;
        public LayerMask wallLayer;

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

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMovement>();
            _loadout = GetComponent<PlayerLoadout>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", "Wall");
        }

        private void Update()
        {
            HandleIndicator();
        }

        /// <summary>
        /// Called by PlayerController when Spacebar/Dash button is pressed.
        /// </summary>
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
            IsInvulnerable = true;

            // Hide indicator during movement
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // --- 1. GRAVITY SUSPENSION ---
            // We tell movement to ignore gravity for the dash duration + hang time.
            // This allows "Air Dashing" without falling immediately.
            _movement.SuspendGravity(dashDuration + hangTime);

            // --- 2. AUDIO & VISUALS ---
            if (Services.Audio != null && dashClip)
                Services.Audio.PlaySound(dashClip, 1f, true);

            // Spawn Decoy from Loadout (Standard or Explosive)
            if (_loadout && _loadout.currentDecoy)
                Instantiate(_loadout.currentDecoy, transform.position, transform.rotation);

            // --- 3. DIRECTION LOGIC ---
            Vector3 dashDir;
            // If moving input exists, dash that way. Otherwise dash forward.
            if (_movement.MoveInput.sqrMagnitude > 0.1f)
                dashDir = _movement.MoveInput.normalized;
            else
                dashDir = transform.forward;

            // --- 4. PHYSICS LOOP ---
            float speed = dashDistance / dashDuration;
            float timer = 0f;

            while (timer < dashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;

                // Move via Motor (Pass Velocity)
                _mover.Move(dashDir * speed);

                // Active Intercept
                CatchProjectiles();

                yield return null;
            }

            // Small recovery frame before state resets
            yield return new WaitForSeconds(0.05f);

            IsInvulnerable = false;
            IsDashing = false;

            // Note: Gravity remains suspended for the duration of 'hangTime' 
            // handled by PlayerMovement timer.
        }

        private void CatchProjectiles()
        {
            // Detect hostile bullets in close range
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, projectileLayer);

            foreach (var hit in hits)
            {
                IReflectable proj = hit.GetComponent<IReflectable>();
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    // Redirect in the direction we are dashing
                    proj.Redirect(transform.forward, gameObject);

                    // Reward for technical play
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

            // Calculate Destination based on Input
            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;

            // Raycast to stop indicator at walls
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

            // Visual Feedback (Can we afford it?)
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