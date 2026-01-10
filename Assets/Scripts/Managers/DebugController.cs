using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Player.Controller;
using DarkTowerTron.Player.Stats;
using DarkTowerTron.Systems.Stats; // For PerkSO
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Workflow")]
        public bool autoStartGame = false;

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;

        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Visualization")]
        public bool showEnemyStats = true;

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn;

        [Header("Perk Testing")]
        public PerkSO testPerk1; // Assign Mirror Engine
        public PerkSO testPerk2; // Assign Kinetic Deflector
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;

        private IEnumerator Start()
        {
            // Wait for Bootloader and Scene Init
            yield return null;

            // 1. Auto-Start Logic
            if (autoStartGame)
            {
                // FIX: Use Service
                if (GameServices.Session != null)
                {
                    GameLogger.Log(LogChannel.System, "[DEBUG] Auto-Starting Game...", gameObject);
                    GameServices.Session.BeginGame();

                    // Force combat state active
                    _combatStartedEvent?.Raise();
                }
            }

            // 2. Locate Player (Robust Find)
            // (Already cached in Services)
            if (GameServices.Player != null)
            {
                var p = GameServices.Player;
                _energy = p.GetComponent<PlayerEnergy>();
                _health = p.GetComponent<PlayerHealth>();
                _loadout = p.GetComponent<PlayerLoadout>();
                _stats = p.GetComponent<PlayerStats>();
            }
        }

        private void Update()
        {
            // Safety check for Input System
            if (Keyboard.current == null) return;

            // Sync debug flag
            DamageReceiver.EnableDebugGizmos = showEnemyStats;

            // [TAB] Toggle Visuals
            if (Keyboard.current.tabKey.wasPressedThisFrame)
            {
                showEnemyStats = !showEnemyStats;
            }

            // [T] Time Control
            if (Keyboard.current.tKey.wasPressedThisFrame)
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f;
                GameLogger.Log(LogChannel.System, $"Time Scale: {Time.timeScale}");
            }

            // [K] Kill All Enemies
            if (Keyboard.current.kKey.wasPressedThisFrame)
            {
                var enemies = FindObjectsOfType<DarkTowerTron.Enemy.EnemyController>();
                foreach (var e in enemies) e.Kill(true);
                GameLogger.Log(LogChannel.Combat, "Nuke Triggered.");
            }

            // [R] Recharge Stats
            if (Keyboard.current.rKey.wasPressedThisFrame && _energy)
            {
                _energy.AddFocus(100f);
                if (_health) _health.HealGrit(2);
            }

            // [NumPad 1-4] Spawning
            if (Keyboard.current.numpad1Key.wasPressedThisFrame) Spawn(0);
            if (Keyboard.current.numpad2Key.wasPressedThisFrame) Spawn(1);
            if (Keyboard.current.numpad3Key.wasPressedThisFrame) Spawn(2);
            if (Keyboard.current.numpad4Key.wasPressedThisFrame) Spawn(3);

            // Cheats Application (Continuous)
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);

            // [H / J] Perk Testing
            if (Keyboard.current.hKey.wasPressedThisFrame && _loadout)
            {
                _loadout.EquipProjectile(homingPrefab);
                GameLogger.Log(LogChannel.Player, "Equipped Homing Projectile");
            }

            if (Keyboard.current.jKey.wasPressedThisFrame && _loadout)
            {
                _loadout.EquipDecoy(explosiveDecoyPrefab);
                GameLogger.Log(LogChannel.Player, "Equipped Explosive Decoy");
            }

            // [P / O] Apply Perks
            if (Keyboard.current.pKey.wasPressedThisFrame && _stats && testPerk1)
            {
                _stats.ApplyPerk(testPerk1);
                GameLogger.Log(LogChannel.System, $"Applied Perk: {testPerk1.perkName}");
            }

            if (Keyboard.current.oKey.wasPressedThisFrame && _stats && testPerk2)
            {
                _stats.ApplyPerk(testPerk2);
                GameLogger.Log(LogChannel.System, $"Applied Perk: {testPerk2.perkName}");
            }
        }

        private void Spawn(int index)
        {
            if (enemiesToSpawn == null || index < 0 || index >= enemiesToSpawn.Length) return;

            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0; // Reset height (Motors will handle hovering)

            if (Global.Pool != null)
                Global.Pool.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}