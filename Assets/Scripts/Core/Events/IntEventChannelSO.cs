using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Event Channel")]
    public class IntEventChannelSO : ScriptableObject
    {
        public UnityAction<int> OnEventRaised;

        public void Raise(int value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Int Event [{name}] was raised but nothing picked it up.");
        }
    }
}