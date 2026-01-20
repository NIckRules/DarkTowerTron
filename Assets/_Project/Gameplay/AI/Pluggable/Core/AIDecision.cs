using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class AIDecision : ScriptableObject
    {
        public abstract bool Decide(PluggableAIController controller);
    }
}