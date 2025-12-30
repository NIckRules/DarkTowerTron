using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // For PerkBaseSO
using DarkTowerTron.Player;
using DarkTowerTron.Managers; // For PoolManager

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Workflow")]
        public bool autoStartGame = false; // Check this to skip Main Menu

        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Spawn Keys (NumPad)")]
        [Tooltip("Assign Enemy Prefabs here to spawn with Keypad 1-4")]
        public GameObject[] enemiesToSpawn;

        [Header("Perk Testing")]
        public PerkBaseSO cheatPerk1; // H Key (e.g. Homing)
        public PerkBaseSO cheatPerk2; // J Key (e.g. Explosive Decoy)
        public PerkBaseSO cheatPerk3; // K Key (e.g. Stats)

        // Cache player references for cheats
        private PlayerEnergy _energy;
        private PlayerHealth _health;

        private IEnumerator Start()
        {
            // Wait one frame to ensure GameServices and GameSession have initialized
            yield return null;

            // 1. Auto-Start Logic
            if (autoStartGame)
            {
                var session = FindObjectOfType<GameSession>();
                if (session)
                {
                    Debug.Log("<color=yellow>[DEBUG] Auto-Starting Game...</color>");
                    session.BeginGame();
                }
            }

            // 2. Locate Player via Service Locator (More robust than FindTag)
            // Note: We might need to wait a few frames if Player spawns dynamically
            // But usually Player is in scene.
            if (GameServices.Player != null)
            {
                _energy = GameServices.Player.GetComponent<PlayerEnergy>();
                _health = GameServices.Player.GetComponent<PlayerHealth>();
            }
        }

        private void Update()
        {
            // 1. Time Control (T)
            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f;
                Debug.Log($"[DEBUG] Time Scale: {Time.timeScale}");
            }

            // 2. Kill All Enemies (K)
            // Note: Shift+K to avoid conflict with Perk K
            if (Input.GetKeyDown(KeyCode.K) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
            {
                var enemies = FindObjectsOfType<DarkTowerTron.Enemy.EnemyController>();
                foreach (var e in enemies) e.Kill(true);
                Debug.Log("[DEBUG] Nuke Triggered");
            }

            // 3. Recharge Resources (R)
            if (Input.GetKeyDown(KeyCode.R))
            {
                RefillStats();
            }

            // 4. Manual Spawning (NumPad 1-4)
            if (Input.GetKeyDown(KeyCode.Keypad1)) Spawn(0);
            if (Input.GetKeyDown(KeyCode.Keypad2)) Spawn(1);
            if (Input.GetKeyDown(KeyCode.Keypad3)) Spawn(2);
            if (Input.GetKeyDown(KeyCode.Keypad4)) Spawn(3);

            // 5. Continuous Cheats
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(10);

            // 6. Perk Injection (H, J, K)
            if (Input.GetKeyDown(KeyCode.H)) GrantCheatPerk(cheatPerk1);
            if (Input.GetKeyDown(KeyCode.J)) GrantCheatPerk(cheatPerk2);
            if (Input.GetKeyDown(KeyCode.K) && !Input.GetKey(KeyCode.LeftShift)) GrantCheatPerk(cheatPerk3);
        }

        private void RefillStats()
        {
            // Re-fetch in case player died/respawned
            if (_energy == null && GameServices.Player) _energy = GameServices.Player.GetComponent<PlayerEnergy>();
            if (_health == null && GameServices.Player) _health = GameServices.Player.GetComponent<PlayerHealth>();

            if (_energy) _energy.AddFocus(100f);
            if (_health) _health.HealGrit(10);
            Debug.Log("[DEBUG] Stats Refilled");
        }

        private void Spawn(int index)
        {
            if (enemiesToSpawn == null || index < 0 || index >= enemiesToSpawn.Length) return;

            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 8f;
            spawnPos.y = 0; // Snap to floor

            PoolManager.Instance.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }

        private void GrantCheatPerk(PerkBaseSO perk)
        {
            if (perk != null && PerkManager.Instance != null)
            {
                PerkManager.Instance.GrantPerk(perk);
            }
            else
            {
                Debug.LogWarning("[DEBUG] Cannot grant perk. Missing Perk Asset or PerkManager.");
            }
        }
    }
}