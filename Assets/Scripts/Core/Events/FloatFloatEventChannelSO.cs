using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Float Float Event Channel")]
    public class FloatFloatEventChannelSO : ScriptableObject
    {
        public UnityAction<float, float> OnEventRaised;

        public void Raise(float current, float max)
        {
            OnEventRaised?.Invoke(current, max);
        }
    }
}
