namespace DarkTowerTron.Gameplay.Environment
{
    /// <summary>
    /// Contract for anything that can block or allow passage 
    /// (Gates, Forcefields, Bridges, Doors).
    /// </summary>
    public interface ILockable
    {
        void Lock();   // Close/Block
        void Unlock(); // Open/Allow
        bool IsLocked { get; }
    }
}