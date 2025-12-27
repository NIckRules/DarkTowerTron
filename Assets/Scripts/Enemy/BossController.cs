using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Environment;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    public class BossController : MonoBehaviour, IDamageable
    {
        [Header("Parts")]
        public Transform coreRotationRoot; // The object that spins
        public List<DamageableProp> hands; // The 4 Hands
        public GameObject shieldVisual;    // The Barrier around the core

        [Header("Settings")]
        public float rotationSpeedIdle = 10f;
        public float rotationSpeedCombat = 30f;
        public float health = 100f;

        private bool _isCombatActive = false;
        private bool _isVulnerable = false;

        private void Start()
        {
            // Boss is invincible until hands are dead
            if (shieldVisual) shieldVisual.SetActive(true);
        }

        private void Update()
        {
            // 1. Rotation Logic
            float currentSpeed = _isCombatActive ? rotationSpeedCombat : rotationSpeedIdle;
            if (coreRotationRoot)
            {
                coreRotationRoot.Rotate(Vector3.up, currentSpeed * Time.deltaTime);
            }

            // 2. Check Hands (Simple Phase Logic)
            if (_isCombatActive && !_isVulnerable)
            {
                int aliveHands = 0;
                foreach (var hand in hands)
                {
                    if (hand.gameObject.activeSelf) aliveHands++;
                }

                if (aliveHands == 0)
                {
                    EnterVulnerablePhase();
                }
            }
        }

        // Called by WaveTrigger or Timeline
        public void ActivateBoss()
        {
            _isCombatActive = true;
            // Optional: Roar sound / Camera Shake
        }

        private void EnterVulnerablePhase()
        {
            _isVulnerable = true;
            if (shieldVisual) shieldVisual.SetActive(false); // Drop Shield

            // Juice
            GameEvents.OnPopupText?.Invoke(transform.position, "SHIELD DOWN");
            // Slow rotation to make hitting easier?
            rotationSpeedCombat = 5f;
        }

        // --- IDamageable (The Core) ---
        public bool TakeDamage(DamageInfo info)
        {
            if (!_isVulnerable)
            {
                GameEvents.OnPopupText?.Invoke(transform.position, "SHIELDED");
                return false;
            }

            health -= info.damageAmount;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, true);

            if (health <= 0) Kill(true);
            return true;
        }

        public void Kill(bool instant)
        {
            // BOSS DEATH
            GameEvents.OnGameVictory?.Invoke(); // Win the game!
            Destroy(gameObject);
        }
    }
}