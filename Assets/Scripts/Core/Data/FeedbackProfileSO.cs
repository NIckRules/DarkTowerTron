using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Feedback Profile")]
    public class FeedbackProfileSO : ScriptableObject
    {
        [Header("Camera Shake")]
        public float shakeDuration = 0.2f;
        public float shakeStrength = 0.5f;

        [Header("Time Freeze")]
        public float hitStopDuration = 0.1f;

        [Header("Audio")]
        public SoundDef sound; // Reuses your SoundDef system!
    }
}