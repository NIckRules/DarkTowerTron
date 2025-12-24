using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn; // Assign prefabs in Inspector

        [Header("Perk Testing")]
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;

        private void Start()
        {
            // Find player components safely
            var p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p)
            {
                _energy = p.GetComponent<PlayerEnergy>();
                _health = p.GetComponent<PlayerHealth>();
                _loadout = p.GetComponent<PlayerLoadout>();
            }
        }

        private void Update()
        {
            // 1. Time Control
            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f; // Slow motion toggle
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
            if (Input.GetKeyDown(KeyCode.Keypad1)) Spawn(0); // Grunt
            if (Input.GetKeyDown(KeyCode.Keypad2)) Spawn(1); // Sniper
            if (Input.GetKeyDown(KeyCode.Keypad3)) Spawn(2); // Orbiter
            if (Input.GetKeyDown(KeyCode.Keypad4)) Spawn(3); // Guardian

            // 5. Cheats Application
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);

            // 6. Toggle Perks
            if (Input.GetKeyDown(KeyCode.H)) // Homing
            {
                Debug.Log("Cheat: Equipped Homing Missiles");
                if (_loadout) _loadout.EquipProjectile(homingPrefab);
            }

            if (Input.GetKeyDown(KeyCode.J)) // Juke (Decoy)
            {
                Debug.Log("Cheat: Equipped Explosive Decoy");
                if (_loadout) _loadout.EquipDecoy(explosiveDecoyPrefab);
            }
        }

        private void Spawn(int index)
        {
            if (index < 0 || index >= enemiesToSpawn.Length) return;

            // Spawn at cursor logic or random offset
            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0;

            PoolManager.Instance.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}