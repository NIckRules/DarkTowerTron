using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    /// <summary>
    /// Base class for a single "Juice" action (e.g., Play Sound, Shake Camera).
    /// </summary>
    public abstract class FeedbackCommand : ScriptableObject
    {
        /// <summary>
        /// Executes the feedback.
        /// </summary>
        /// <param name="owner">The object causing the feedback (e.g. Player, Bullet).</param>
        /// <param name="position">Where the effect happens (e.g. Impact point).</param>
        public abstract void Execute(GameObject owner, Vector3 position);
    }
}