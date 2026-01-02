using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DarkTowerTron.Combat;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(DamageReceiver))]
    public class EnemyController : MonoBehaviour, IPoolable, ICombatTarget
    {
        private DamageReceiver _receiver;
        private EnemyMotor _motor;
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public ColorPaletteSO palette;
        [Header("Audio")]
        public AudioClip staggerClip;

        // Visual State
        private Color _normalColor;
        private Color _staggerColor;
        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween; 
        private int _colorPropID;
        private int _emissionPropID;

        // Facade Property
        public bool IsStaggered => _receiver != null && _receiver.IsStaggered;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _receiver = GetComponent<DamageReceiver>(); 
            
            if(meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            
            _propBlock = new MaterialPropertyBlock();
            _colorPropID = Shader.PropertyToID("_BaseColor"); 
            _emissionPropID = Shader.PropertyToID("_EmissionColor");

            LoadColors();
        }

        private void Start()
        {
            // 1. Get stats reference from Motor (if not already set)
            if (_motor != null) _stats = _motor.stats;
			
            // 2. SELF-INITIALIZATION (The Fix)
            // If we were placed in the scene manually, OnSpawn() was never called.
            // We check if the Receiver has 0 Health (uninitialized) to decide.
            // Or simpler: Just initialize. It's safe to call twice (it just resets HP to max).
            if (_receiver != null && _stats != null)
            {
                // DamageReceiver.CurrentHealth defaults to 0 before initialization.
                if (_receiver.CurrentHealth <= 0)
                {
                    _receiver.Initialize(_stats);
                }
            }
			
            // 3. Visuals
            LoadColors();
            SetColor(_normalColor);
        }

        private void OnEnable()
        {
            if (_receiver == null) _receiver = GetComponent<DamageReceiver>();

            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;
            
            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover += HandleStaggerExit;
            }
        }
        
        private void OnDisable()
        {
            if (_receiver != null)
            {
                _receiver.OnHitProcessed -= HandleHit;
                _receiver.OnDeathProcessed -= HandleDeath;
                if (_receiver.Stagger != null)
                {
                    _receiver.Stagger.OnStaggerBreak -= HandleStaggerEnter;
                    _receiver.Stagger.OnStaggerRecover -= HandleStaggerExit;
                }
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            
            // Initialize the Receiver (which inits Vitality/Stagger)
            _receiver.Initialize(_stats);
            
            LoadColors();
            SetColor(_normalColor);
        }

        public void OnDespawn()
        {
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_normalColor);
        }

        // --- IDamageable Proxy ---
        public bool TakeDamage(DamageInfo info)
        {
            // FIX: DamageReceiver implements IDamageable, so the method is TakeDamage, not ApplyDamage
            return _receiver.TakeDamage(info);
        }

        public void Kill(bool instant) => _receiver.Kill(true); 
        public void SelfDestruct() => _receiver.Kill(false);    

        // --- ICombatTarget ---
        public void OnExecutionHit()
        {
            _receiver.Kill(true); 
        }
        
        // Proxy property
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
        
        // FIX: Removed 'public Transform transform => base.transform' to fix warning CS0108.
        // MonoBehaviour already satisfies this interface requirement.

        // --- HANDLERS ---
        
        private void HandleHit(DamageInfo info)
        {
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);
            if (!IsStaggered) Flash();
            
            bool isCrit = IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isCrit);
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position, stats, reward);
            
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }

        private void HandleStaggerEnter()
        {
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (AudioManager.Instance && staggerClip)
                AudioManager.Instance.PlaySound(staggerClip, 1f, true);

            if (_flashTween != null) _flashTween.Kill();
            
            float flashLerp = 0f;
            _flashTween = DOTween.To(()=> flashLerp, x=> flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() => {
                    Color c = Color.Lerp(_staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });
        }

        private void HandleStaggerExit()
        {
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_normalColor);
        }

        private void Flash()
        {
            if (_flashTween != null) _flashTween.Kill();
            SetColor(Color.white);
            _flashTween = DOVirtual.DelayedCall(0.1f, () => SetColor(_normalColor)).SetId(gameObject);
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                _propBlock.SetColor(_emissionPropID, c);
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }
        
        private void LoadColors()
        {
            _normalColor = Color.red;
            _staggerColor = Color.yellow;

            if (palette != null)
            {
                // FIX: Access flattened properties directly
                // (We previously removed the nested 'defaultEnemyTheme' object)
                if (palette.enemyPrimary.mainColor != Color.clear)
                {
                     _normalColor = palette.enemyPrimary.mainColor;
                }
                
                _staggerColor = palette.staggerColor; 
            }
        }
    }
}