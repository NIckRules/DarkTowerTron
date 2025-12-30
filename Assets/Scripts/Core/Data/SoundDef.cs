using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Sound Definition")]
    public class SoundDef : ScriptableObject
    {
        [Header("Clips")]
        [Tooltip("Randomly plays one of these clips.")]
        public AudioClip[] clips;

        [Header("Settings")]
        [Range(0f, 1f)] public float volume = 1f;
        [Range(0.1f, 3f)] public float pitch = 1f;

        [Header("Variation")]
        public bool randomizePitch = true;
        [Range(0f, 0.5f)] public float randomPitchRange = 0.1f;

        // Logic to pick a clip
        public AudioClip GetClip()
        {
            if (clips == null || clips.Length == 0) return null;
            return clips[Random.Range(0, clips.Length)];
        }

        public float GetPitch()
        {
            if (!randomizePitch) return pitch;
            return pitch + Random.Range(-randomPitchRange, randomPitchRange);
        }
    }
}