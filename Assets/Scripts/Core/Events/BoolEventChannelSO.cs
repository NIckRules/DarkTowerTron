using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Bool Event Channel")]
    public class BoolEventChannelSO : ScriptableObject
    {
        public UnityAction<bool> OnEventRaised;

        public void Raise(bool value)
        {
            OnEventRaised?.Invoke(value);
        }
    }
}
