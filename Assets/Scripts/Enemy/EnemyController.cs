using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable, IPoolable
    {
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.red;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        [Header("Audio")]
        public AudioClip staggerClip;

        private EnemyMotor _motor;
        private float _currentStagger;
        private float _lastHitTime;
        public bool IsStaggered { get; private set; }

        // OPTIMIZATION: Property Block to avoid Material Instancing
        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween;
        private int _colorPropID;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();

            // Setup Property Block
            _propBlock = new MaterialPropertyBlock();
            // URP usually uses "_BaseColor", Built-in uses "_Color"
            _colorPropID = Shader.PropertyToID("_BaseColor");
        }

        // --- IPoolable Implementation ---
        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            ResetState();
        }

        public void OnDespawn()
        {
            // Kill tweens safely
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();

            // Reset color immediately so it doesn't spawn flashing next time
            SetColor(normalColor);
        }
        // --------------------------------

        private void Start()
        {
            // Initial color set
            SetColor(normalColor);

            // Fallback for non-pooled usage
            if (_motor != null && _stats == null) _stats = _motor.stats;
        }

        private void ResetState()
        {
            IsStaggered = false;
            _currentStagger = 0;
            SetColor(normalColor);
        }

        private void Update()
        {
            if (_stats == null) return;

            if (!IsStaggered && _currentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f)
                {
                    _currentStagger -= _stats.staggerDecay * Time.deltaTime;
                    if (_currentStagger < 0) _currentStagger = 0;
                }
            }
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_stats == null) return false;

            _lastHitTime = Time.time;

            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            if (_stats.hasFrontalShield && !IsStaggered)
            {
                Vector3 incomingDir = info.pushDirection.normalized;
                float impactAngle = Vector3.Dot(transform.forward, -incomingDir);

                if (impactAngle > _stats.shieldAngle)
                {
                    GameEvents.OnPopupText?.Invoke(transform.position, "BLOCKED");
                    return false;
                }
            }

            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            bool isBigHit = info.isRedirected || IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isBigHit);

            if (IsStaggered)
            {
                if (info.damageAmount > 0) Kill(false);
            }
            else
            {
                AddStagger(info.staggerAmount);
                Flash();
            }

            return true;
        }

        private void AddStagger(float amount)
        {
            _currentStagger += amount;
            if (_currentStagger >= _stats.maxStagger)
            {
                EnterStaggerState();
            }
        }

        private void EnterStaggerState()
        {
            IsStaggered = true;
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (GameFeel.Instance && staggerClip)
                GameFeel.Instance.PlaySound(staggerClip, 1f, true);

            // Start Flashing via Tween that updates PropertyBlock
            if (_flashTween != null) _flashTween.Kill();

            // We tween a dummy value to drive the update loop
            float flashLerp = 0f;
            _flashTween = DOTween.To(() => flashLerp, x => flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    // Manually Lerp color and apply block
                    Color c = Color.Lerp(staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });

            DOVirtual.DelayedCall(2.0f, ExitStaggerState).SetId(gameObject); // ID for DOKill
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;

            if (_flashTween != null) _flashTween.Kill();
            _currentStagger = 0;
            SetColor(normalColor);
        }

        private void Flash()
        {
            // Simple 1-shot flash
            if (!IsStaggered)
            {
                if (_flashTween != null) _flashTween.Kill();

                SetColor(flashColor);
                _flashTween = DOVirtual.DelayedCall(0.1f, () =>
                {
                    if (!IsStaggered) SetColor(normalColor);
                }).SetId(gameObject);
            }
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }

        public void Kill(bool instant)
        {
            // --- FIXED: Pass the stats so the Event System knows what died ---
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats);
            // ---------------------------------------------------------------

            // CRITICAL FIX: Use Pool instead of Destroy
            if (PoolManager.Instance)
            {
                PoolManager.Instance.Despawn(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}