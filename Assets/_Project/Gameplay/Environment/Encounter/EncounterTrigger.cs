using UnityEngine;
using DarkTowerTron.Core; // For GameConstants

namespace DarkTowerTron.Gameplay.Environment
{
    [RequireComponent(typeof(BoxCollider))]
    public class EncounterTrigger : MonoBehaviour
    {
        [Header("Target")]
        [Tooltip("The controller that manages this room's logic.")]
        [SerializeField] private ArenaController _controller;

        [Header("Settings")]
        [SerializeField] private bool _oneShot = true;

        private bool _hasTriggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_hasTriggered && _oneShot) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                if (_controller != null)
                {
                    _hasTriggered = true;
                    _controller.BeginEncounter();

                    if (_oneShot) GetComponent<Collider>().enabled = false;
                }
                else
                {
                    Debug.LogError($"[EncounterTrigger] No ArenaController assigned on {gameObject.name}!");
                }
            }
        }
    }
}