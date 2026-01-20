using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "Visuals_Default", menuName = "DarkTowerTron/Visuals/Enemy Visual Profile")]
    public class EnemyVisualProfileSO : ScriptableObject
    {
        [Header("Impact Feel")]
        [Tooltip("How long the white flash lasts on impact.")]
        public float hitFlashDuration = 0.1f;

        [Header("Status Effects")]
        [Tooltip("Time for one full pulse (Stagger -> Danger -> Stagger).")]
        public float staggerPulseDuration = 0.4f;
        
        [Tooltip("Color to pulse to during stagger (usually Red for danger).")]
        [ColorUsage(true, true)] 
        public Color dangerPulseColor = Color.red; 
    }
}