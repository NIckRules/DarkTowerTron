using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public UnityAction OnEventRaised;

        public void Raise()
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke();
            else
                GameLogger.LogWarning(LogChannel.System, $"Void Event [{name}] was raised but nothing picked it up.");
        }
    }
}