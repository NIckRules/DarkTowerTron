using UnityEngine;

namespace DarkTowerTron.AI.Pluggable.Core
{
    public abstract class AIDecision : ScriptableObject
    {
        public abstract bool Decide(PluggableAIController controller);
    }
}