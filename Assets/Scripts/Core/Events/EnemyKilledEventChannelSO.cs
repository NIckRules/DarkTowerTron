using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Enemy Killed Channel")]
    public class EnemyKilledEventChannelSO : ScriptableObject
    {
        // The action signature matches your old GameEvents logic
        public UnityAction<Vector3, EnemyStatsSO, bool> OnEventRaised;

        public void Raise(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(position, stats, rewardPlayer);
            else
                GameLogger.LogWarning(LogChannel.Combat, $"EnemyKilled Event [{name}] was raised but nothing picked it up.");
        }
    }
}