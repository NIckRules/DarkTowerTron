using UnityEngine;

namespace DarkTowerTron.AI.Pluggable.Core
{
    public abstract class AIAction : ScriptableObject
    {
        public abstract void Act(PluggableAIController controller);
    }
}