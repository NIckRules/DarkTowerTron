using UnityEngine;

namespace DarkTowerTron.Core.AudioSystem
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Profiles/Dynamic (Combat)")]
    public class DynamicMusicProfileSO : MusicProfileSO
    {
        [Header("Dynamic Mix Curves")]
        [Tooltip("X axis = Game Intensity (0-1), Y axis = Volume (0-1)")]
        public AnimationCurve bassCurve = AnimationCurve.Constant(0, 1, 1f); // Always on
        public AnimationCurve percussionCurve = AnimationCurve.Linear(0, 0, 1, 1); // Ramps up
        public AnimationCurve melodyCurve = AnimationCurve.Constant(0, 1, 0.7f); // Background
        public AnimationCurve glitchCurve = AnimationCurve.Linear(0.5f, 0, 1, 1); // Only at high intensity

        public override float[] GetLayerVolumes(float intensity)
        {
            return new float[]
            {
                bassCurve.Evaluate(intensity),
                percussionCurve.Evaluate(intensity),
                melodyCurve.Evaluate(intensity),
                glitchCurve.Evaluate(intensity)
            };
        }
    }
}