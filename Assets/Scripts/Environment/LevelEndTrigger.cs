using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using UnityEngine;

namespace DarkTowerTron.Environment
{
    public class LevelEndTrigger : MonoBehaviour
    {
        [Header("Broadcasting")]
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                GameLogger.Log(LogChannel.System, "LEVEL COMPLETE", gameObject);

                // Trigger Victory Logic
                _gameVictoryEvent?.Raise();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 1, 0, 0.3f); // Semi-transparent Green
            Gizmos.DrawCube(transform.position, transform.localScale);
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}