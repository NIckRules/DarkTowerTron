using UnityEngine;
using System.IO;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Services; // Access ServiceLocator

namespace DarkTowerTron.Systems.Persistence
{
    public class PersistenceService : MonoBehaviour, IPersistenceService
    {
        private const string SAVE_FILE_PREFIX = "save_slot_";
        private const string EXTENSION = ".json";

        public SaveData CurrentData { get; private set; }

        // We can expose this if we want a UI to change slots later
        [SerializeField] private int _currentSlotIndex = 0;

        private void Awake()
        {
            ServiceLocator.Register<IPersistenceService>(this);
            Load(_currentSlotIndex);
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IPersistenceService>(this);
            Save();
        }

        private void OnApplicationQuit() => Save();

        private void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus) Save();
        }

        // --- IPersistenceService Implementation ---

        public void Load(int slotIndex)
        {
            _currentSlotIndex = slotIndex;
            string path = GetPath(slotIndex);

            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);
                    CurrentData = JsonUtility.FromJson<SaveData>(json);
                    GameLogger.Log(LogChannel.System, $"[Persistence] Loaded Slot {slotIndex}", gameObject);
                }
                catch (System.Exception e)
                {
                    GameLogger.LogError(LogChannel.System, $"[Persistence] Slot {slotIndex} corrupted. Resetting. Error: {e.Message}", gameObject);
                    CreateNewSave();
                }
            }
            else
            {
                GameLogger.Log(LogChannel.System, $"[Persistence] Slot {slotIndex} not found. Creating new.", gameObject);
                CreateNewSave();
            }
        }

        public void Save()
        {
            if (CurrentData == null) CurrentData = new SaveData();
            CurrentData.lastPlayedDate = System.DateTime.Now.ToString();

            try
            {
                string path = GetPath(_currentSlotIndex);
                string json = JsonUtility.ToJson(CurrentData, true);
                File.WriteAllText(path, json);

#if UNITY_EDITOR
                // Reduce spam in Editor
                // GameLogger.Log(LogChannel.System, $"Saved to Slot {_currentSlotIndex}", gameObject);
#endif
            }
            catch (System.Exception e)
            {
                GameLogger.LogError(LogChannel.System, $"[Persistence] Failed to save: {e.Message}", gameObject);
            }
        }

        public void DeleteSave()
        {
            string path = GetPath(_currentSlotIndex);
            if (File.Exists(path))
            {
                File.Delete(path);
                GameLogger.Log(LogChannel.System, $"[Persistence] Deleted Slot {_currentSlotIndex}", gameObject);
                CreateNewSave();
            }
        }

        public void RecordRunStart()
        {
            if (CurrentData != null)
            {
                CurrentData.totalRuns++;
                Save();
            }
        }

        public void RecordDeath()
        {
            if (CurrentData != null)
            {
                CurrentData.totalDeaths++;
                Save();
            }
        }

        // --- Helpers ---

        private void CreateNewSave()
        {
            CurrentData = new SaveData();
            Save();
        }

        private string GetPath(int index)
        {
            return Path.Combine(Application.persistentDataPath, $"{SAVE_FILE_PREFIX}{index}{EXTENSION}");
        }
    }
}