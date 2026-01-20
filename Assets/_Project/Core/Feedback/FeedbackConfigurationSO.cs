using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(fileName = "Feedback_New", menuName = "DarkTowerTron/Feedback/Configuration Package")]
    public class FeedbackConfigurationSO : ScriptableObject
    {
        [Header("Juice List")]
        public List<FeedbackCommand> commands = new List<FeedbackCommand>();

        /// <summary>
        /// Runs every command in the package.
        /// </summary>
        public void Play(GameObject owner, Vector3 position)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i] != null)
                {
                    commands[i].Execute(owner, position);
                }
            }
        }

        // Overload for simple usage (uses owner's position)
        public void Play(GameObject owner)
        {
            if (owner != null) Play(owner, owner.transform.position);
        }
    }
}