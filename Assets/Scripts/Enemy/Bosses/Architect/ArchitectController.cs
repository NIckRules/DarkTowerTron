using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Events
using DarkTowerTron.Core.Services;
using DarkTowerTron.AI.FSM;
using DG.Tweening;

using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    [RequireComponent(typeof(StateMachine))]
    public class ArchitectController : MonoBehaviour, IDamageable, ICombatTarget, IAimTarget // NEW: IAimTarget
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
        public float patternInterval = 2.0f;

        [Header("Patterns")]
        public List<ArchitectPatternSO> phase1Patterns;

        [Header("Debug")]
        public bool autoStartCombat = false;

        [Header("Events (Wiring)")]
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;
        [SerializeField] private IntIntEventChannelSO _waveAnnounceEvent; // For "Wave 666"
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;
        // Note: Popup/Damage text might still be static or you can inject a channel if you have one.
        // Assuming GameEvents.OnPopupText is still static for now as per previous sessions.

        [Header("Aiming")]
        [SerializeField] private float _aimOffset = 0f;
        [SerializeField] private float _coreRadius = 1.5f;

        public bool KeepPlayerGrounded => true;

        // IAimTarget Implementation
        public Vector3 AimPoint => transform.position + (Vector3.up * _aimOffset);
        public float TargetRadius => _coreRadius;

        // State
        private bool _isCombatActive = false;
        private bool _isVulnerable = false;
        private Transform _player;
        private float _currentRotationSpeed;
        private int _currentPatternIndex = 0;

        // Components
        private StateMachine _fsm;

        // State Cache (No more GC allocation)
        public ArchitectState_Idle StateIdle { get; private set; }
        private List<ArchitectState_Pattern> _patternStates = new List<ArchitectState_Pattern>();

        private void Awake()
        {
            _fsm = GetComponent<StateMachine>();
            StateIdle = new ArchitectState_Idle();
        }

        private void Start()
        {
            if (GameServices.Player != null)
                _player = GameServices.Player.transform;

            // Pre-allocate Pattern States
            foreach (var pattern in phase1Patterns)
            {
                _patternStates.Add(new ArchitectState_Pattern(this, pattern));
            }

            SetShield(true);
            _currentRotationSpeed = rotationSpeedIdle;

            if (autoStartCombat)
                Invoke(nameof(ActivateBoss), 1.0f);
        }

        private void Update()
        {
            if (rotationRig)
                rotationRig.Rotate(Vector3.up, _currentRotationSpeed * Time.deltaTime);

            if (!_isCombatActive) return;

            // Phase Transition Check
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

        // --- COMBAT FLOW ---

        public void ActivateBoss()
        {
            if (_isCombatActive) return;

            _isCombatActive = true;
            _currentRotationSpeed = rotationSpeedCombat;

            StartNextPattern();

            // Juice
            _waveAnnounceEvent?.Raise(666, 0); // Custom ID for Boss
            _combatStartedEvent?.Raise();
        }

        public void StartNextPattern()
        {
            if (_isVulnerable) return;
            if (_patternStates.Count == 0) return;

            // Pick pre-cached state
            ArchitectState_Pattern nextState = _patternStates[_currentPatternIndex];

            // Increment loop
            _currentPatternIndex = (_currentPatternIndex + 1) % _patternStates.Count;

            _fsm.ChangeState(nextState);
        }

        public void OnPatternFinished()
        {
            if (_isVulnerable) return;
            _fsm.ChangeState(StateIdle);
            StartCoroutine(WaitAndNextPattern());
        }

        private IEnumerator WaitAndNextPattern()
        {
            yield return new WaitForSeconds(patternInterval);
            StartNextPattern();
        }

        // --- HELPER METHODS ---

        public void SetRotationSpeed(float speed) => _currentRotationSpeed = speed;

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

        public Transform GetTarget()
        {
            if (_player == null && GameServices.Player != null)
                _player = GameServices.Player.transform;
            return _player;
        }

        // --- PHASE LOGIC ---

        private IEnumerator EnterVulnerablePhase()
        {
            _isVulnerable = true;
            SetShield(false);
            _fsm.ChangeState(null); // Stop AI
            _currentRotationSpeed = 60f; // Panic

            GameEvents.OnPopupText?.Invoke(transform.position, "SHIELD DOWN"); // Legacy Event
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
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
                return false;
            }

            coreHealth -= info.damageAmount;

            // Legacy Events for text
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, true);

            if (coreHealth <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            _isCombatActive = false;
            _currentRotationSpeed = 0;

            if (Global.VFX != null && Global.VFX.explosionPrefab)
            {
                Global.Pool?.Spawn(Global.VFX.explosionPrefab, transform.position, Quaternion.identity);
            }

            _gameVictoryEvent?.Raise(); // Updated

            Destroy(gameObject, 0.5f);
        }

        // --- ICOMBATTARGET ---

        public bool IsStaggered => false;

        public void OnExecutionHit()
        {
            if (_isVulnerable)
            {
                DamageInfo info = new DamageInfo { damageAmount = 50f };
                TakeDamage(info);
            }
            else
            {
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
            }
        }
    }
}