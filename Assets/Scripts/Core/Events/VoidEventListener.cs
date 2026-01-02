using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    public class VoidEventListener : MonoBehaviour
    {
        [Tooltip("The Event to listen to")]
        public VoidEventChannelSO channel;

        [Tooltip("What to do when the event triggers")]
        public UnityEvent response;

        private void OnEnable()
        {
            if (channel != null) channel.OnEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (channel != null) channel.OnEventRaised -= Respond;
        }

        private void Respond()
        {
            response?.Invoke();
        }
    }
}