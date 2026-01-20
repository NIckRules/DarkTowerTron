using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Systems;
using DarkTowerTron.Systems.Stats;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IAudioService
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerLoadout))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerDodge : MonoBehaviour
    {
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
        private PlayerMotor _movement;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;

        // Service Dependencies
        private IAudioService _audioService;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMotor>();
            _loadout = GetComponent<PlayerLoadout>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            // Resolve Services
            _audioService = ServiceLocator.Get<IAudioService>();
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

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

            // 1. Gravity Suspension
            _movement.SuspendGravity(_stats.DashDuration + _stats.ActionHangTime);

            // 2. Audio (Service Locator)
            if (_audioService != null && dashClip)
                _audioService.PlaySound(dashClip, transform.position, 1f);

            // 3. Decoy Spawn
            if (_loadout && _loadout.currentDecoy)
                Instantiate(_loadout.currentDecoy, transform.position, transform.rotation);

            // 4. Direction Logic
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f)
                dashDir = _movement.MoveInput.normalized;
            else
                dashDir = transform.forward;

            // 5. Physics Loop
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
            // Reflection Ability Check
            if (_stats == null || !_stats.HasAbility(AbilityType.Dodge_Reflect)) return;

            int layerMask = 1 << GameConstants.LAYER_PROJECTILE;

            // Optimization Note: Consider using Physics.OverlapSphereNonAlloc for zero garbage generation here
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, layerMask);

            foreach (var hit in hits)
            {
                var pScript = hit.GetComponent<Projectile>();
                if (pScript != null && pScript.isHostile)
                {
                    // Weight check (cannot reflect Heavy/Unstoppable)
                    if (pScript.weight == ProjectileWeight.Heavy || pScript.weight == ProjectileWeight.Unstoppable)
                        continue;

                    // Redirect
                    pScript.Redirect(transform.forward, gameObject);

                    // Reward
                    if (_energy) _energy.AddFocus(20f);
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

            // Raycast to find stopping point against walls
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

            // Visual Feedback (Can we afford it?)
            if (indicatorRenderer && readyMat && notReadyMat)
            {
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