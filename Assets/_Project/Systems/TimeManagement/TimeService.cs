using UnityEngine;
using System.Collections;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.TimeManagement
{
    public class TimeService : MonoBehaviour, ITimeService
    {
        private Coroutine _hitStopCoroutine;

        public void SetTimeScale(float scale)
        {
            Time.timeScale = scale;
        }

        public void HitStop(float duration)
        {
            // Prevent HitStop if game is totally paused via Menu
            if (Time.timeScale == 0) return;

            if (_hitStopCoroutine != null) StopCoroutine(_hitStopCoroutine);
            _hitStopCoroutine = StartCoroutine(HitStopRoutine(duration));
        }

        private IEnumerator HitStopRoutine(float duration)
        {
            float originalScale = Time.timeScale;
            Time.timeScale = 0.001f; // Almost zero (better than 0 for some physics calculations)
            
            yield return new WaitForSecondsRealtime(duration);

            Time.timeScale = originalScale;
            _hitStopCoroutine = null;
        }
    }
}