using UnityEngine;

namespace DarkTowerTron.Core.AudioSystem
{
    public abstract class MusicProfileSO : ScriptableObject
    {
        [Header("Track Info")]
        public string themeName;
        public float bpm = 120f;

        [Header("The Stems")]
        // 0=Bass, 1=Perc, 2=Melody, 3=Glitch
        public AudioClip[] stems = new AudioClip[4];

        /// <summary>
        /// The Core Logic: Given the current game intensity (0.0 to 1.0), 
        /// what should the volume of each layer be?
        /// </summary>
        public abstract float[] GetLayerVolumes(float intensity);

        // Helper to get clip safely
        public AudioClip GetClip(int index) => (index < stems.Length) ? stems[index] : null;
    }
}