using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DG.Tweening;
using DarkTowerTron;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    // REMOVED: [RequireComponent(typeof(StateMachine))] <-- Old FSM deleted
    public class ArchitectController : MonoBehaviour, IDamageable, ICombatTarget, IAimTarget
    {
        [Header("Parts")]
        public Transform rotationRig;
        public List<ArchitectHand> hands;
        public GameObject shieldVisual;

        [Header("Stats")]
        public float coreHealth = 50f;
        public float rotationSpeedIdle = 10f;
        public float rotationSpeedCombat = 30f;

        [Header("Configuration")]
        public float radiusOuter = 2.5f;
        public float radiusInner = 0.8f;

        // We keep the data, but we aren't using it automatically right now
        [Header("Patterns")]
        public List<ArchitectPatternSO> phase1Patterns;

        [Header("Event Wiring")]
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;
        [SerializeField] private IntEventChannelSO _waveAnnounceEvent; // Updated type
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;
        [SerializeField] private PopupTextEventChannelSO _popupEvent;
        [SerializeField] private DamageTextEventChannelSO _damageTextEvent;

        [Header("Aiming")]
        [SerializeField] private float _aimOffset = 0f;
        [SerializeField] private float _coreRadius = 1.5f;

        // Interfaces
        public bool KeepPlayerGrounded => true;
        public Vector3 AimPoint => transform.position + (Vector3.up * _aimOffset);
        public float TargetRadius => _coreRadius;
        public bool IsStaggered => false;

        // Internal State
        private bool _isVulnerable = false;
        private float _currentRotationSpeed;
        private Transform _player;

        // REMOVED: StateMachine _fsm;
        // REMOVED: ArchitectState_Idle, ArchitectState_Pattern variables

        private void Start()
        {
            if (DarkTowerTron.Core.GameServices.Player != null)
                _player = DarkTowerTron.Core.GameServices.Player.transform;

            SetShield(true);
            _currentRotationSpeed = rotationSpeedIdle;
        }

        private void Update()
        {
            if (rotationRig)
                rotationRig.Rotate(Vector3.up, _currentRotationSpeed * Time.deltaTime);

            // Phase Logic (Simplified for now)
            if (!_isVulnerable)
            {
                bool anyHandAlive = false;
                foreach (var h in hands)
                {
                    if (h != null && h.IsAlive())
                    {
                        anyHandAlive = true;
                        break;
                    }
                }

                if (!anyHandAlive)
                {
                    StartCoroutine(EnterVulnerablePhase());
                }
            }
        }

        // --- PUBLIC API (The "Body" Commands) ---
        // These will be called by the Pluggable AI Action later

        public void SetRotationSpeed(float speed) => _currentRotationSpeed = speed;

        public void ActivateBoss()
        {
            _currentRotationSpeed = rotationSpeedCombat;
            _waveAnnounceEvent?.Raise(666);
            _combatStartedEvent?.Raise();

            // Temporary: Just run the first pattern manually to prove it works
            // In future, the Pluggable AI will call RunPattern()
            if (phase1Patterns.Count > 0) StartCoroutine(RunPatternSequence(phase1Patterns[0]));
        }

        // Adapted from the old State logic into a standalone Coroutine
        public IEnumerator RunPatternSequence(ArchitectPatternSO pattern)
        {
            if (_isVulnerable) yield break;

            SetRotationSpeed(pattern.rotationSpeed);

            // 1. Setup
            MoveHands(pattern.extendHands);
            TelegraphWalls(pattern.activateWalls);

            yield return new WaitForSeconds(pattern.startDelay);

            // 2. Active
            ActivateWalls(pattern.activateWalls);

            float timer = 0f;
            float duration = pattern.activeDuration - pattern.startDelay;
            float shotCooldown = 0f;
            bool hasGun = pattern.shootingPattern != null;

            while (timer < duration)
            {
                if (_isVulnerable) break;

                float dt = Time.deltaTime;
                timer += dt;

                if (hasGun)
                {
                    shotCooldown -= dt;
                    if (shotCooldown <= 0)
                    {
                        FireProjectiles(pattern);
                        shotCooldown = pattern.shootingPattern.delayBetweenShots;
                    }
                }
                yield return null;
            }

            // 3. Cleanup
            ResetHands();
        }

        // --- HELPER METHODS ---

        private void FireProjectiles(ArchitectPatternSO pattern)
        {
            if (pattern.shootingPattern == null) return;
            bool useForward = pattern.shootingPattern.aimMode == AimType.ForwardRadial;
            float scale = pattern.shootingPattern.scaleMultiplier;

            for (int i = 0; i < hands.Count; i++)
            {
                var hand = hands[i];
                if (hand == null || !hand.IsAlive()) continue;

                // Check Config Array safety
                if (pattern.activeGuns != null && i < pattern.activeGuns.Length && pattern.activeGuns[i])
                {
                    Vector3 targetPos = (_player != null) ? _player.position : Vector3.zero;
                    hand.Shoot(targetPos, useForward, scale);
                }
            }
        }

        public void MoveHands(bool[] extendConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool extend = (extendConfig != null && i < extendConfig.Length) ? extendConfig[i] : false;
                hands[i].MoveToDistance(extend ? radiusOuter : radiusInner);
            }
        }

        public void TelegraphWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].PrepareWall(active);
            }
        }

        public void ActivateWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].SetWall(active);
            }
        }

        public void ResetHands()
        {
            foreach (var h in hands)
            {
                if (h == null) continue;
                h.MoveToDistance(radiusInner);
                h.SetWall(false);
                h.PrepareWall(false);
            }
        }

        // --- PHASE LOGIC ---

        private IEnumerator EnterVulnerablePhase()
        {
            _isVulnerable = true;
            SetShield(false);
            _currentRotationSpeed = 60f;
            _popupEvent?.Raise(transform.position, "SHIELD DOWN");
            yield return null;
        }

        private void SetShield(bool state)
        {
            if (shieldVisual) shieldVisual.SetActive(state);
        }

        // --- IDAMAGEABLE ---

        public bool TakeDamage(DamageInfo info)
        {
            if (!_isVulnerable)
            {
                _popupEvent?.Raise(transform.position, "SHIELDED");
                return false;
            }

            coreHealth -= info.damageAmount;
            _damageTextEvent?.Raise(transform.position, info.damageAmount, true, false);

            if (coreHealth <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            _gameVictoryEvent?.Raise();
            if (Global.VFX != null && Global.VFX.explosionPrefab)
                Global.Pool?.Spawn(Global.VFX.explosionPrefab, transform.position, Quaternion.identity);

            Destroy(gameObject, 0.5f);
        }

        public void OnExecutionHit()
        {
            if (_isVulnerable)
            {
                TakeDamage(new DamageInfo { damageAmount = 50f });
            }
            else
            {
                _popupEvent?.Raise(transform.position, "SHIELDED");
            }
        }
    }
}