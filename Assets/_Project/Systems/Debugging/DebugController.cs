using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Core.Patterns; // For IPoolService
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Gameplay.Player; // For PlayerController.Instance
//using DarkTowerTron.Gameplay.Player;
//using DarkTowerTron.Gameplay.Player; // For PlayerLoadout
using DarkTowerTron.Systems.Stats; // For PerkSO
using DarkTowerTron.Systems.GameModes; // For GameSession

namespace DarkTowerTron.Systems.Debugging
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

        // Cached References
        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;
        private IPoolService _poolService;
        private GameSession _session;

        private IEnumerator Start()
        {
            // Wait a frame for Bootstrapper and Scene Init
            yield return null;

            _poolService = ServiceLocator.Get<IPoolService>();
            _session = FindObjectOfType<GameSession>();

            // 1. Auto-Start Logic
            if (autoStartGame && _session != null)
            {
                GameLogger.Log(LogChannel.System, "[DEBUG] Auto-Starting Game...", gameObject);
                _session.BeginGame();
                _combatStartedEvent?.RaiseEvent();
            }

            // 2. Locate Player Logic
            // We use the Singleton Instance we setup earlier
            if (PlayerController.Instance != null)
            {
                var p = PlayerController.Instance;
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

            // Sync debug flag (Ensure DamageReceiver has this static property, or remove this line)
            DamageReceiver.EnableDebugGizmos = showEnemyStats;

            HandleInput();
            ApplyCheats();
        }

        private void HandleInput()
        {
            // [TAB] Toggle Visuals
            if (Keyboard.current.tabKey.wasPressedThisFrame)
            {
                showEnemyStats = !showEnemyStats;
                Debug.Log($"Debug Stats: {showEnemyStats}");
            }

            // [T] Time Control
            if (Keyboard.current.tKey.wasPressedThisFrame)
            {
                Time.timeScale = (Time.timeScale >= 0.9f) ? 0.1f : 1f;
                GameLogger.Log(LogChannel.System, $"Time Scale: {Time.timeScale}");
            }

            // [K] Kill All Enemies
            if (Keyboard.current.kKey.wasPressedThisFrame)
            {
                var enemies = FindObjectsOfType<EnemyController>();
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

        private void ApplyCheats()
        {
            if (infiniteFocus && _energy) _energy.AddFocus(100f * Time.deltaTime);
            if (godMode && _health) _health.HealGrit(100); // Constant heal
        }

        private void Spawn(int index)
        {
            if (enemiesToSpawn == null || index < 0 || index >= enemiesToSpawn.Length) return;
            if (_poolService == null) return;

            // Simple random spawn around player (or zero if no player)
            Vector3 center = PlayerController.Instance ? PlayerController.Instance.transform.position : Vector3.zero;
            Vector3 spawnPos = center + Random.insideUnitSphere * 5f;
            spawnPos.y = 0; // Reset height (Motors will handle hovering)

            _poolService.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}