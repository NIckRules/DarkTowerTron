using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/String Event Channel")]
    public class StringEventChannelSO : ScriptableObject
    {
        public UnityAction<string> OnEventRaised;

        public void Raise(string value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"String Event [{name}] was raised but nothing picked it up.");
        }
    }
}