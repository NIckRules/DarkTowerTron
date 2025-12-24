using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable, IPoolable, ICombatTarget
    {
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public ColorPaletteSO palette;

        // Cache colors
        private Color _normalColor;
        private Color _staggerColor;
        private Color _flashColor = Color.white;

        [Header("Audio")]
        public AudioClip staggerClip;

        private EnemyMotor _motor;
        private float _currentStagger;
        private float _lastHitTime;
        public bool IsStaggered { get; private set; }

        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween;
        private int _colorPropID;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();

            _propBlock = new MaterialPropertyBlock();
            _colorPropID = Shader.PropertyToID("_BaseColor");

            // Load defaults
            _normalColor = Color.red;
            _staggerColor = Color.yellow;

            if (palette != null)
            {
                _normalColor = palette.enemyPrimary.mainColor;
                _staggerColor = palette.staggerColor;
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            ResetState();
        }

        public void OnDespawn()
        {
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_normalColor);
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;
            SetColor(_normalColor);
        }

        private void ResetState()
        {
            IsStaggered = false;
            _currentStagger = 0;
            SetColor(_normalColor);
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
            if (_currentStagger >= _stats.maxStagger) EnterStaggerState();
        }

        private void EnterStaggerState()
        {
            IsStaggered = true;
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (Managers.AudioManager.Instance && staggerClip)
                Managers.AudioManager.Instance.PlaySound(staggerClip, 1f, true);

            if (_flashTween != null) _flashTween.Kill();

            float flashLerp = 0f;
            _flashTween = DOTween.To(() => flashLerp, x => flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });

            DOVirtual.DelayedCall(2.0f, ExitStaggerState).SetId(gameObject);
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;
            if (_flashTween != null) _flashTween.Kill();
            _currentStagger = 0;
            SetColor(_normalColor);
        }

        private void Flash()
        {
            if (!IsStaggered)
            {
                if (_flashTween != null) _flashTween.Kill();

                SetColor(_flashColor);
                _flashTween = DOVirtual.DelayedCall(0.1f, () =>
                {
                    if (!IsStaggered) SetColor(_normalColor);
                }).SetId(gameObject);
            }
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                // Also set Emission to match for the glow effect
                _propBlock.SetColor("_EmissionColor", c);
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }

        public void Kill(bool instant)
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, true);
            SafeDestroy();
        }

        public void SelfDestruct()
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, false);
            SafeDestroy();
        }

        private void SafeDestroy()
        {
#if UNITY_EDITOR
            if (UnityEditor.Selection.activeGameObject == gameObject) 
                UnityEditor.Selection.activeGameObject = null;
#endif
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }

        public void OnExecutionHit()
        {
            Kill(false);
        }
    }
}