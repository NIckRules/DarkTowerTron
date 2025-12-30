using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.FSM; // State Machine System
using DarkTowerTron.Managers; // VFX & Pool
using DG.Tweening;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    [RequireComponent(typeof(StateMachine))]
    public class ArchitectController : MonoBehaviour, IDamageable, ICombatTarget
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
        public float radiusOuter = 2.5f; // Local distance for "Outer" position
        public float radiusInner = 0.8f; // Local distance for "Inner" position
        public float patternInterval = 2.0f; // Time between patterns

        [Header("Patterns")]
        public List<ArchitectPatternSO> phase1Patterns;

        [Header("Debug")]
        public bool autoStartCombat = false;

        public bool KeepPlayerGrounded => true;

        // State
        private bool _isCombatActive = false;
        private bool _isVulnerable = false;
        private Transform _player;
        private float _currentRotationSpeed;
        private int _currentPatternIndex = 0;

        // Components
        private StateMachine _fsm;

        // NEW: Idle State reference
        public ArchitectState_Idle StateIdle { get; private set; }

        private void Awake()
        {
            _fsm = GetComponent<StateMachine>();
            StateIdle = new ArchitectState_Idle(); // Initialize it
        }

        private void Start()
        {
            // Find Player
            GameObject p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p) _player = p.transform;

            // Setup
            SetShield(true);
            _currentRotationSpeed = rotationSpeedIdle;

            if (autoStartCombat)
            {
                Invoke(nameof(ActivateBoss), 1.0f);
            }
        }

        private void Update()
        {
            // 1. Constant Rotation
            if (rotationRig)
            {
                rotationRig.Rotate(Vector3.up, _currentRotationSpeed * Time.deltaTime);
            }

            if (!_isCombatActive) return;

            // 2. Check Hands (Phase Transition)
            if (!_isVulnerable)
            {
                int livingHands = 0;
                foreach (var h in hands)
                {
                    if (h != null && h.IsAlive()) livingHands++;
                }

                if (livingHands == 0)
                {
                    StartCoroutine(EnterVulnerablePhase());
                }
            }
        }

        // --- COMBAT FLOW ---

        public void ActivateBoss()
        {
            if (_isCombatActive) return;

            _isCombatActive = true;
            _currentRotationSpeed = rotationSpeedCombat;

            // Start the first pattern
            StartNextPattern();

            // UI / Audio Juice
            GameEvents.OnWaveAnnounce?.Invoke(666); // Custom ID for Boss
            GameEvents.OnWaveCombatStarted?.Invoke();
        }

        public void StartNextPattern()
        {
            if (_isVulnerable) return; // Stop patterns if phase 2
            if (phase1Patterns == null || phase1Patterns.Count == 0) return;

            // Pick pattern
            ArchitectPatternSO pattern = phase1Patterns[_currentPatternIndex];

            // Increment index loop
            _currentPatternIndex = (_currentPatternIndex + 1) % phase1Patterns.Count;

            // Change State (Creates a new state instance for the specific pattern)
            _fsm.ChangeState(new ArchitectState_Pattern(this, pattern));
        }

        /// <summary>
        /// Called by the State when it finishes its duration.
        /// </summary>
        public void OnPatternFinished()
        {
            if (_isVulnerable) return;
            // Switch to Idle immediately to cleanup the old pattern state
            _fsm.ChangeState(StateIdle);

            // Start the delay timer
            StartCoroutine(WaitAndNextPattern());
        }

        private IEnumerator WaitAndNextPattern()
        {
            // Reset to neutral rotation speed or idle behavior?
            // _currentRotationSpeed = rotationSpeedCombat; 

            yield return new WaitForSeconds(patternInterval);
            StartNextPattern();
        }

        // --- HELPER METHODS FOR STATES ---

        public void SetRotationSpeed(float speed)
        {
            _currentRotationSpeed = speed;
        }

        // 1. Move Hands (Inner vs Outer)
        public void MoveHands(bool[] extendConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;

                // Check config, default to Inner (false) if array is short
                bool extend = (extendConfig != null && i < extendConfig.Length) ? extendConfig[i] : false;
                
                float targetDist = extend ? radiusOuter : radiusInner;
                hands[i].MoveToDistance(targetDist);
            }
        }

        // 2. Telegraph Walls (Rotate)
        public void TelegraphWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].PrepareWall(active);
            }
        }

        // 3. Activate Walls (Laser On)
        public void ActivateWalls(bool[] wallConfig)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                if (hands[i] == null) continue;
                bool active = (wallConfig != null && i < wallConfig.Length) ? wallConfig[i] : false;
                hands[i].SetWall(active);
            }
        }

        // 4. Reset All (Cleanup)
        public void ResetHands()
        {
            foreach (var h in hands)
            {
                if (h == null) continue;
                h.MoveToDistance(radiusInner); // Retract
                h.SetWall(false);              // Off
                h.PrepareWall(false);          // Rotate Flat
            }
        }

        public Transform GetTarget()
        {
            if (_player == null)
            {
                // Re-acquire if lost
                var p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
                if (p) _player = p.transform;
            }
            return _player;
        }

        // --- PHASE LOGIC ---

        private IEnumerator EnterVulnerablePhase()
        {
            _isVulnerable = true;
            SetShield(false);

            // Stop FSM patterns
            _fsm.ChangeState(null); // Or switch to a VulnerableState if you want complex logic

            _currentRotationSpeed = 60f; // Panic Spin

            GameEvents.OnPopupText?.Invoke(transform.position, "SHIELD DOWN");

            yield return null;
        }

        private void SetShield(bool state)
        {
            if (shieldVisual) shieldVisual.SetActive(state);
        }

        // --- IDAMAGEABLE (THE CORE) ---

        public bool TakeDamage(DamageInfo info)
        {
            if (!_isVulnerable)
            {
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
                return false;
            }

            coreHealth -= info.damageAmount;

            // Show Damage Numbers
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, true); // true = Critical visual

            if (coreHealth <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            _isCombatActive = false;
            _currentRotationSpeed = 0;

            // Spawn BIG explosion
            if (VFXManager.Instance && VFXManager.Instance.explosionPrefab)
            {
                // Spawn a few explosions for effect
                PoolManager.Instance.Spawn(VFXManager.Instance.explosionPrefab, transform.position, Quaternion.identity);
            }

            // Win Game
            GameEvents.OnGameVictory?.Invoke();

            Destroy(gameObject, 0.5f);
        }

        // --- ICOMBATTARGET (EXECUTION) ---

        public bool IsStaggered => false; // Boss Core doesn't stagger via normal means

        public void OnExecutionHit()
        {
            if (_isVulnerable)
            {
                DamageInfo info = new DamageInfo { damageAmount = 50f };
                TakeDamage(info);
            }
            else
            {
                // Optional: Push player back if they try to teleport to shield
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
            }
        }
    }
}