using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Int Event Channel")]
    public class IntIntEventChannelSO : ScriptableObject
    {
        public UnityAction<int, int> OnEventRaised;

        public void Raise(int current, int max)
        {
            OnEventRaised?.Invoke(current, max);
        }
    }
}
