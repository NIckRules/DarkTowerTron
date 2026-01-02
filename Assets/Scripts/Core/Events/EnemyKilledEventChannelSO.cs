using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core.Data; // For EnemyStatsSO

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Enemy Killed Channel")]
    public class EnemyKilledEventChannelSO : ScriptableObject
    {
        // The action signature matches your old GameEvents logic
        public UnityAction<Vector3, EnemyStatsSO, bool> OnEventRaised;

        public void Raise(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            OnEventRaised?.Invoke(position, stats, rewardPlayer);
        }
    }
}