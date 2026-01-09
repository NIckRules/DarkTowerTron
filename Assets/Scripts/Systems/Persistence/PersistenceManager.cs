using UnityEngine;
using System.IO;
using DarkTowerTron.Core.Debug; // For Logger

namespace DarkTowerTron.Systems.Persistence
{
    public class PersistenceManager : MonoBehaviour
    {
        private const string SAVE_FILE_PREFIX = "save_slot_";
        private const string EXTENSION = ".json";

        public SaveData CurrentData { get; private set; }

        // Default to slot 0. We can change this via UI later.
        [SerializeField] private int _currentSlotIndex = 0;

        public int CurrentSlotIndex => _currentSlotIndex;

        private void Awake()
        {
            Load(_currentSlotIndex);
        }

        /// <summary>
        /// Switch to a different save slot and load it immediately.
        /// </summary>
        public void SetSaveSlot(int index)
        {
            if (index < 0) return;

            // Save previous slot state before switching?
            // Usually safer to just switch, assuming previous was saved on change.
            Save();

            _currentSlotIndex = index;
            Load(_currentSlotIndex);
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

                GameLogger.Log(LogChannel.System, $"Game Saved to Slot {_currentSlotIndex}", gameObject);
            }
            catch (System.Exception e)
            {
                GameLogger.LogError(LogChannel.System, $"Failed to save: {e.Message}", gameObject);
            }
        }

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
                    GameLogger.Log(LogChannel.System, $"Loaded Slot {slotIndex}", gameObject);
                }
                catch (System.Exception e)
                {
                    GameLogger.LogError(LogChannel.System, $"Slot {slotIndex} corrupted. Resetting. Error: {e.Message}", gameObject);
                    CreateNewSave();
                }
            }
            else
            {
                GameLogger.Log(LogChannel.System, $"Slot {slotIndex} not found. Creating new.", gameObject);
                CreateNewSave();
            }
        }

        [ContextMenu("Delete Current Save")]
        public void DeleteCurrentSave()
        {
            string path = GetPath(_currentSlotIndex);
            if (File.Exists(path))
            {
                File.Delete(path);
                GameLogger.Log(LogChannel.System, $"Deleted Save Slot {_currentSlotIndex}", gameObject);
                CreateNewSave();
            }
        }

        private void CreateNewSave()
        {
            CurrentData = new SaveData();
            Save();
        }

        private string GetPath(int index)
        {
            return Path.Combine(Application.persistentDataPath, $"{SAVE_FILE_PREFIX}{index}{EXTENSION}");
        }

        private void OnApplicationQuit() => Save();
    }
}