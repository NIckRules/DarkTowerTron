using UnityEngine;
using System.Collections; // Required for IEnumerator
using DarkTowerTron.Core;
using DarkTowerTron.Player;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Workflow")]
        public bool autoStartGame = false; // Check this to skip Main Menu

        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

		[Header("Visualization")]
		public bool showEnemyStats = true; // Toggle this in Inspector

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn;

        [Header("Perk Testing")]
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;

        // Changed void to IEnumerator to allow waiting
        private IEnumerator Start()
        {
            // Wait one frame so core systems (GameSession, GameServices) can boot
            yield return null; 

            // 1. Auto-Start Logic
            if (autoStartGame)
            {
                var session = FindObjectOfType<GameSession>();
                if (session)
                {
                    Debug.Log("<color=yellow>[DEBUG] Auto-Starting Game...</color>");
                    session.BeginGame();

                    // Force combat state so focus decay and combat systems are active while testing
                    GameEvents.OnWaveCombatStarted?.Invoke();
                }
            }

            // 2. Locate player via GameServices
            if (GameServices.Player != null)
            {
                _energy = GameServices.Player.GetComponent<PlayerEnergy>();
                _health = GameServices.Player.GetComponent<PlayerHealth>();
                _loadout = GameServices.Player.GetComponent<PlayerLoadout>();
            }
        }

        private void Update()
        {
            // Sync the static flag for enemy debug gizmos
            DarkTowerTron.Combat.DamageReceiver.EnableDebugGizmos = showEnemyStats;

            // Keyboard Shortcut (e.g. Tab) to toggle
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                showEnemyStats = !showEnemyStats;
            }

            // 1. Time Control
            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f;
            }

            // 2. Kill All
            if (Input.GetKeyDown(KeyCode.K))
            {
                var enemies = FindObjectsOfType<DarkTowerTron.Enemy.EnemyController>();
                foreach (var e in enemies) e.Kill(true);
            }

            // 3. Recharge
            if (Input.GetKeyDown(KeyCode.R) && _energy)
            {
                _energy.AddFocus(100f);
                if (_health) _health.HealGrit(2);
            }

            // 4. Manual Spawning (NumPad 1-4)
            if (Input.GetKeyDown(KeyCode.Keypad1)) Spawn(0);
            if (Input.GetKeyDown(KeyCode.Keypad2)) Spawn(1);
            if (Input.GetKeyDown(KeyCode.Keypad3)) Spawn(2);
            if (Input.GetKeyDown(KeyCode.Keypad4)) Spawn(3);

            // 5. Cheats Application
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);

            // 6. Perk Toggles
            if (Input.GetKeyDown(KeyCode.H) && _loadout) _loadout.EquipProjectile(homingPrefab);
            if (Input.GetKeyDown(KeyCode.J) && _loadout) _loadout.EquipDecoy(explosiveDecoyPrefab);
        }

        private void Spawn(int index)
        {
            if (index < 0 || index >= enemiesToSpawn.Length) return;
            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0;
            PoolManager.Instance.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}