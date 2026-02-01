using UnityEngine;

namespace DarkTowerTron.Core.AudioSystem
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Profiles/Static (Hallway)")]
    public class StaticMusicProfileSO : MusicProfileSO
    {
        [Header("Static Mix")]
        [Range(0f, 1f)] public float bassVolume = 1f;
        [Range(0f, 1f)] public float percussionVolume = 0f;
        [Range(0f, 1f)] public float melodyVolume = 0.8f;
        [Range(0f, 1f)] public float glitchVolume = 0f;

        public override float[] GetLayerVolumes(float intensity)
        {
            // Ignores intensity completely. Always returns the preset mix.
            return new float[] { bassVolume, percussionVolume, melodyVolume, glitchVolume };
        }
    }
}