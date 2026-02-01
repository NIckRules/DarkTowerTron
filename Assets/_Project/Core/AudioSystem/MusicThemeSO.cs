using UnityEngine;

namespace DarkTowerTron.Core.AudioSystem
{
    [CreateAssetMenu(fileName = "NewMusicTheme", menuName = "DarkTowerTron/Audio/Music Theme (Stems)")]
    public class MusicThemeSO : ScriptableObject
    {
        [Header("Track Info")]
        public string themeName;
        public float bpm = 120f;

        [Header("The Stems")]
        // Fixed array of 4 to match the Enum MusicLayer: 0=Bass, 1=Perc, 2=Melody, 3=Glitch
        [Tooltip("Order: Bass, Percussion, Melody, Glitch")]
        public LayerDefinition[] layers = new LayerDefinition[4];

        private void OnValidate()
        {
            if (layers.Length != 4) System.Array.Resize(ref layers, 4);
            
            // Set defaults to avoid silence on new assets
            for (int i = 0; i < 4; i++)
                if (layers[i].baseVolume == 0) layers[i].baseVolume = 1f;
        }

        public AudioClip GetClip(int index) => (index < layers.Length) ? layers[index].clip : null;
        public float GetVolume(int index) => (index < layers.Length) ? layers[index].baseVolume : 1f;
        public bool IsMuted(int index) => (index < layers.Length) && layers[index].mute;
    }
}