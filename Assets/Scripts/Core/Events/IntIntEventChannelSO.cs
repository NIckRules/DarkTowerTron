using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Int Event Channel")]
    public class IntIntEventChannelSO : ScriptableObject
    {
        public UnityAction<int, int> OnEventRaised;

        public void Raise(int current, int max)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(current, max);
            else
                GameLogger.LogWarning(LogChannel.System, $"IntInt Event [{name}] was raised but nothing picked it up.");
        }
    }
}
