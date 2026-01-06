using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Transform Event Channel")]
    public class TransformEventChannelSO : ScriptableObject
    {
        public UnityAction<Transform> OnEventRaised;

        public void Raise(Transform value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Transform Event [{name}] was raised but nothing picked it up.");
        }
    }
}