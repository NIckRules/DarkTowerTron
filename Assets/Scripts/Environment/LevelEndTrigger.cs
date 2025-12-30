using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Environment
{
    public class LevelEndTrigger : MonoBehaviour
    {
        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                Debug.Log("LEVEL COMPLETE");

                // Trigger Victory Logic
                GameEvents.OnGameVictory?.Invoke();
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