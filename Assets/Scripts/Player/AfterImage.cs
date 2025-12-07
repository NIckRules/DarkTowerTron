using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    public class AfterImage : MonoBehaviour
    {
        public float lifetime = 1.0f; // Decoy lasts 1 second (longer than dash)

        private void Start()
        {
            // 1. Notify Enemies: "Look at me!"
            GameEvents.OnDecoySpawned?.Invoke(transform);

            // 2. Visual Fade
            Renderer rend = GetComponentInChildren<Renderer>();
            if (rend)
            {
                // Fade alpha to 0
                rend.material.DOFade(0f, lifetime).SetEase(Ease.Linear);
            }

            // 3. Self Destruct
            Destroy(gameObject, lifetime);
        }

        private void OnDestroy()
        {
            // 4. Notify Enemies: "I'm dead, look at Player!"
            GameEvents.OnDecoyExpired?.Invoke();
        }
    }
}