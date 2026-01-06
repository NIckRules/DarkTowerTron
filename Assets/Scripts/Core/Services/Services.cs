using DarkTowerTron.Services;

namespace DarkTowerTron.Core.Services
{
    public static class Services
    {
        public static AudioManager Audio => ServiceLocator.Get<AudioManager>();
        public static PoolManager Pool => ServiceLocator.Get<PoolManager>();
        public static VFXManager VFX => ServiceLocator.Get<VFXManager>();
        public static ScoreManager Score => ServiceLocator.Get<ScoreManager>();
        public static PaletteManager Palette => ServiceLocator.Get<PaletteManager>();
    }
}