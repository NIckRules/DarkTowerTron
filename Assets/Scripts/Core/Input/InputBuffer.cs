using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Input
{
    /// <summary>
    /// queues inputs for a short time to allow "Early" presses to register.
    /// </summary>
    public class InputBuffer
    {
        private float _bufferTime;
        private Dictionary<string, float> _queuedActions = new Dictionary<string, float>();

        public InputBuffer(float bufferTime = 0.15f)
        {
            _bufferTime = bufferTime;
        }

        public void BufferAction(string actionID)
        {
            // Record the timestamp of the press
            _queuedActions[actionID] = Time.time;
        }

        public bool TryConsumeAction(string actionID)
        {
            if (_queuedActions.TryGetValue(actionID, out float timeStamp))
            {
                // Is the press recent enough?
                if (Time.time - timeStamp <= _bufferTime)
                {
                    _queuedActions.Remove(actionID); // Consume it
                    return true;
                }
            }
            return false;
        }

        public void Clear() => _queuedActions.Clear();
    }
}