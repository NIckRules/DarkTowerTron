using UnityEngine;

namespace DarkTowerTron.Core.AudioSystem
{
    [System.Serializable]
    public struct LayerDefinition
    {
        public AudioClip clip;
        [Range(0f, 1f)] public float baseVolume; // Mix balance (e.g. Bass is 1.0, Glitch is 0.5)
        public bool mute; // Quick testing toggle
    }
}
