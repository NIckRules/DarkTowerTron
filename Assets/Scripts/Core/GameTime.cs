using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Systems
{
    public class GameTime : MonoBehaviour
    {
        private bool _isFrozen = false;

        public void HitStop(float duration)
        {
            if (_isFrozen) return;
            if (duration <= 0) return;
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