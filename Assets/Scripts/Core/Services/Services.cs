using DarkTowerTron.Core.Services; 
using DarkTowerTron.Managers; 

namespace DarkTowerTron.Core.Services
{
    public static class Services
    {
        public static AudioManager Audio => ServiceLocator.Get<AudioManager>();
        public static PoolManager Pool => ServiceLocator.Get<PoolManager>();
        public static VFXManager VFX => ServiceLocator.Get<VFXManager>();
        public static ScoreManager Score => ServiceLocator.Get<ScoreManager>();
    }
}