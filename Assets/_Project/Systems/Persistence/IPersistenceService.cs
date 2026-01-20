using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Persistence
{
    public interface IPersistenceService : IGameService
    {
        SaveData CurrentData { get; }

        void Save();
        void Load(int slotIndex);
        void DeleteSave();

        // Helper to modify data easily
        void RecordRunStart();
        void RecordDeath();
    }
}