using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Core
{
    /// <summary>
    /// Connects a Global Event (SO) to a Local Component (UnityEvent).
    /// Put this on the Gate GameObject.
    /// </summary>
    public class GameEventListener : MonoBehaviour
    {
        [Header("Trigger")]
        [SerializeField] private VoidEventChannelSO _eventToListenFor;

        [Header("Response")]
        public UnityEvent OnEventRaised;

        private void OnEnable()
        {
            if (_eventToListenFor) _eventToListenFor.OnEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (_eventToListenFor) _eventToListenFor.OnEventRaised -= Respond;
        }

        private void Respond()
        {
            OnEventRaised?.Invoke();
        }
    }
}