using UnityEngine;
using System.Collections;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Gameplay.Combat; // Access to DamageInfo and DamageReceiver

namespace DarkTowerTron.Gameplay.Enemies.Bosses
{
    // REFACTOR: Removed IDamageable interface. This class now LISTENS to damage, instead of BEING damageable.
    [RequireComponent(typeof(DamageReceiver))]
    public class ArchitectController : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private DamageReceiver _damageReceiver;
        // [SerializeField] private RotatorRig _rotator; // Example of other components

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _onBossEngaged;
        [SerializeField] private VoidEventChannelSO _onBossDefeated;
        [SerializeField] private VoidEventChannelSO _onPhaseChange;

        [Header("Settings")]
        [SerializeField] private float _phase2Threshold = 0.5f; // 50% HP

        private bool _isPhase2 = false;

        private void Awake()
        {
            if (_damageReceiver == null)
                _damageReceiver = GetComponent<DamageReceiver>();
        }

        private void Start()
        {
            // --- THE "AA" PATTERN: SUBSCRIBE TO COMPONENTS ---
            if (_damageReceiver != null)
            {
                _damageReceiver.OnTakeDamage += HandleDamageReceived;
                _damageReceiver.OnDeath += HandleDeath;
            }

            // Engage logic (could be triggered by a trigger volume elsewhere)
            if (_onBossEngaged != null) _onBossEngaged.RaiseEvent();
        }

        private void OnDestroy()
        {
            // Always unsubscribe to prevent memory leaks
            if (_damageReceiver != null)
            {
                _damageReceiver.OnTakeDamage -= HandleDamageReceived;
                _damageReceiver.OnDeath -= HandleDeath;
            }
        }

        // --- EVENT HANDLERS ---

        private void HandleDamageReceived(DamageInfo info)
        {
            // Logic: Check for Phase Transition
            if (!_isPhase2 && _damageReceiver.CurrentHealth <= (_damageReceiver.MaxHealth * _phase2Threshold))
            {
                TriggerPhase2();
            }

            // Example: Boss flinch logic could go here
            // if (info.damageAmount > 50) PlayStaggerAnimation();
        }

        private void HandleDeath()
        {
            // Logic: Boss Died
            Defeat();
        }

        // --- BOSS BEHAVIOR ---

        private void TriggerPhase2()
        {
            _isPhase2 = true;
            Debug.Log("[Architect] Entering Phase 2!");

            if (_onPhaseChange != null) _onPhaseChange.RaiseEvent();

            // Add Logic: Increase rotation speed, enable new weapons, etc.
        }

        private void Defeat()
        {
            Debug.Log("[Architect] Defeated!");

            if (_onBossDefeated != null) _onBossDefeated.RaiseEvent();

            // Disable behaviors, play cinematic death, etc.
            enabled = false;
        }
    }
}