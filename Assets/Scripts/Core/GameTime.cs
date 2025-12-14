using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Core
{
    public class GameTime : MonoBehaviour
    {
        public static GameTime Instance;
        private bool _isFrozen = false;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public void HitStop(float duration)
        {
            if (_isFrozen) return;
            StartCoroutine(DoHitStop(duration));
        }

        private IEnumerator DoHitStop(float duration)
        {
            _isFrozen = true;
            float originalScale = Time.timeScale;

            Time.timeScale = 0.0f;
            yield return new WaitForSecondsRealtime(duration);

            Time.timeScale = originalScale;
            _isFrozen = false;
        }
    }
}