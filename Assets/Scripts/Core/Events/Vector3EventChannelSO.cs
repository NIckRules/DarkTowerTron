using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Vector3 Event Channel")]
    public class Vector3EventChannelSO : ScriptableObject
    {
        public UnityAction<Vector3> OnEventRaised;

        public void Raise(Vector3 value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Vector3 Event [{name}] was raised but nothing picked it up.");
        }
    }
}