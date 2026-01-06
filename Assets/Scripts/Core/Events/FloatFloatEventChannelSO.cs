using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Float Float Event Channel")]
    public class FloatFloatEventChannelSO : ScriptableObject
    {
        public UnityAction<float, float> OnEventRaised;

        public void Raise(float current, float max)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(current, max);
            else
                GameLogger.LogWarning(LogChannel.System, $"FloatFloat Event [{name}] was raised but nothing picked it up.");
        }
    }
}
