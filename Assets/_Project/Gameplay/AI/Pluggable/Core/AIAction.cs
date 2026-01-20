using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class AIAction : ScriptableObject
    {
        public abstract void Act(PluggableAIController controller);
    }
}