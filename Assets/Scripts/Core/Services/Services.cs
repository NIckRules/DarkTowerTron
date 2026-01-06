using DarkTowerTron.Services;

namespace DarkTowerTron.Core.Services
{
    public static class Services
    {
        public static AudioManager Audio => ServiceLocator.Get<AudioManager>();
        public static MusicManager Music => ServiceLocator.Get<MusicManager>();
        public static PaletteManager Palette => ServiceLocator.Get<PaletteManager>();
        public static PoolManager Pool => ServiceLocator.Get<PoolManager>();
        public static ScoreManager Score => ServiceLocator.Get<ScoreManager>();
        public static GameTime Time => ServiceLocator.Get<GameTime>();
        public static VFXManager VFX => ServiceLocator.Get<VFXManager>();
    }
}