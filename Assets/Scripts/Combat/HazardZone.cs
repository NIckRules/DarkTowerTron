using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class HazardZone : MonoBehaviour
    {
        [Header("Settings")]
        public float duration = 3.0f;
        public float damage = 1f;
        public float knockbackForce = 15f;
        public LayerMask targetLayer; // Player

        [Header("Visuals")]
        public Transform visualRing; // Assign a cylinder/sprite

        // Tween references so we can safely kill them if the zone is stopped early
        private Tween _scaleTween;
        private Tween _fadeTween;
        private Tween _delayedCallTween;
        private Coroutine _destroyCoroutine;

        private void Start()
        {
            Transform target = visualRing != null ? visualRing : transform;

            // 1. Expand Visuals (Juice)
            target.localScale = Vector3.zero;
            _scaleTween = target.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);

            // 2. Schedule Destruction
            // Fade out shortly before destroying
            _delayedCallTween = DOVirtual.DelayedCall(Mathf.Max(0f, duration - 0.5f), FadeOut);
            _destroyCoroutine = StartCoroutine(AutoDestroyCoroutine());
        }

        private void OnDisable()
        {
            _scaleTween?.Kill();
            _fadeTween?.Kill();
            _delayedCallTween?.Kill();

            if (_destroyCoroutine != null)
            {
                try { StopCoroutine(_destroyCoroutine); } catch { }
                _destroyCoroutine = null;
            }
        }

        private System.Collections.IEnumerator AutoDestroyCoroutine()
        {
            yield return new WaitForSeconds(duration);
            Destroy(gameObject);
        }

        private void FadeOut()
        {
            Transform target = visualRing != null ? visualRing : transform;
            _fadeTween = target.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check Layer
            if ((targetLayer.value & (1 << other.gameObject.layer)) != 0)
            {
                IDamageable target = other.GetComponentInParent<IDamageable>();
                if (target != null)
                {
                    // Calculate push direction (Away from center of zone)
                    Vector3 dir = (other.transform.position - transform.position).normalized;
                    dir.y = 0;

                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = dir,
                        pushForce = knockbackForce,
                        source = gameObject
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}