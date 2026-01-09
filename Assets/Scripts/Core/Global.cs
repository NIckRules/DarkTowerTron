using UnityEngine;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Systems;       // NEW Namespace for Managers (see Step 2)

namespace DarkTowerTron
{
    /// <summary>
    /// Global Access Point for all Game Systems.
    /// Replaces "Services" class to avoid namespace conflicts.
    /// </summary>
    public static class Global
    {
        // Core Systems
        public static AudioManager Audio => ServiceLocator.Get<AudioManager>();
        public static MusicManager Music => ServiceLocator.Get<MusicManager>();
        public static PaletteManager Palette => ServiceLocator.Get<PaletteManager>();
        public static PoolManager Pool => ServiceLocator.Get<PoolManager>();
        public static ScoreManager Score => ServiceLocator.Get<ScoreManager>();
        public static VFXManager VFX => ServiceLocator.Get<VFXManager>();
        public static GameTime Time => ServiceLocator.Get<GameTime>();

        // Dynamic Systems
        public static DarkTowerTron.Player.Controller.PlayerController Player
            => DarkTowerTron.Core.GameServices.Player;

        public static DarkTowerTron.Core.CameraRig Camera
            => DarkTowerTron.Core.GameServices.CameraRig;

        public static DarkTowerTron.Managers.GameSession Session
            => DarkTowerTron.Core.GameServices.Session;
    }
}