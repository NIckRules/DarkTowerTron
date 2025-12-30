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
        // Reference to the Data Asset (Speed, Health, Shield info)
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public ColorPaletteSO palette; // Reference to Global Theme

        // Cache colors locally to avoid constant SO lookups
        private Color _normalColor;
        private Color _staggerColor;
        private Color _flashColor = Color.white;

        [Header("Audio")]
        public AudioClip staggerClip;

        public bool KeepPlayerGrounded => true;

        // Components
        private EnemyMotor _motor;

        // State
        private float _currentStagger;
        private float _currentHealth; // NEW
        private float _lastHitTime;
        public bool IsStaggered { get; private set; }

        // Optimization: Property Block to avoid Material Instancing
        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween;
        private int _colorPropID;
        private int _emissionPropID;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();

            // Initialize Property Block
            _propBlock = new MaterialPropertyBlock();
            // Store IDs for performance
            _colorPropID = Shader.PropertyToID("_BaseColor");
            _emissionPropID = Shader.PropertyToID("_EmissionColor");

            LoadColors();
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;
            // Apply initial color
            SetColor(_normalColor);
        }

        // --- IPoolable Implementation ---
        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            // NEW: Reset Health
            if (_stats != null) _currentHealth = _stats.maxHealth;
            else _currentHealth = 10f;

            ResetState();
            // Refresh colors in case Palette changed while in pool
            LoadColors();
            SetColor(_normalColor);
        }

        public void OnDespawn()
        {
            // Kill any active tweens to prevent errors on despawned objects
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();

            // Reset to default color
            SetColor(_normalColor);
        }
        // --------------------------------

        private void ResetState()
        {
            IsStaggered = false;
            _currentStagger = 0;
        }

        private void Update()
        {
            if (_stats == null) return;

            // Decay Stagger Meter if not full
            if (!IsStaggered && _currentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f)
                {
                    _currentStagger -= _stats.staggerDecay * Time.deltaTime;
                    if (_currentStagger < 0) _currentStagger = 0;
                }
            }
        }

        // --- IDamageable Implementation ---
        public bool TakeDamage(DamageInfo info)
        {
            if (_stats == null) return false;
            _lastHitTime = Time.time;

            // 1. Redirected Projectile (Insta-Kill)
            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            // 2. Shield Logic
            if (_stats.hasFrontalShield && !IsStaggered)
            {
                Vector3 incomingDir = info.pushDirection.normalized;
                // Dot Product > Threshold means hit form front
                float impactAngle = Vector3.Dot(transform.forward, -incomingDir);

                if (impactAngle > _stats.shieldAngle)
                {
                    // Blocked!
                    GameEvents.OnPopupText?.Invoke(transform.position, "BLOCKED");
                    return false;
                }
            }

            // 3. Apply Physics Knockback
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            // 4. HEALTH LOGIC (NEW)
            // Apply damage. Note: Player Gun usually deals 0 damage, so this won't kill.
            // Player Beam deals 10 damage.
            _currentHealth -= info.damageAmount;

            // Show Numbers
            bool isBigHit = info.isRedirected || IsStaggered || _currentHealth <= 0;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isBigHit);

            // Check Death
            if (_currentHealth <= 0)
            {
                Kill(false);
                return true; // Stop processing
            }

            // 5. Stagger Logic (Existing)
            if (IsStaggered)
            {
                // Execution Hit (Double Damage was applied above, kill check happened above)
                // If we are here, it means we took damage but are NOT dead yet (HP > 0).
                // Do we force kill on Stagger hit?
                // DESIGN CHOICE:
                // Option A: Staggered + Hit = INSTANT DEATH (Current Design)
                // Option B: Staggered + Hit = Double Damage (RPG Design)
                
                // Let's stick to Option A for "Glass Cannon" feel, but only if damage > 0
                if (info.damageAmount > 0) Kill(false);
            }
            else
            {
                AddStagger(info.staggerAmount);
                Flash();
            }
            return true;
        }

        // --- ICombatTarget Implementation ---
        // Called by Player Execution / Glory Kill
        public void OnExecutionHit()
        {
            Kill(false);
        }
        // ------------------------------------

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

            // Audio Feedback
            if (AudioManager.Instance && staggerClip)
                AudioManager.Instance.PlaySound(staggerClip, 1f, true);

            // Visual Pulse (Red <-> Yellow)
            if (_flashTween != null) _flashTween.Kill();

            // Use a dummy value tween to update color every frame
            float flashLerp = 0f;
            _flashTween = DOTween.To(() => flashLerp, x => flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });

            // Auto-recover after 2 seconds
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
            // Simple White Flash on hit
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

        // --- Visual Helpers ---

        private void LoadColors()
        {
            // Defaults
            _normalColor = Color.red;
            _staggerColor = Color.yellow;

            if (palette != null)
            {
                // Access via SurfaceDefinition struct
                // Note: Ensure your ColorPaletteSO uses the new structure
                if (palette.enemyPrimary.mainColor != Color.clear)
                    _normalColor = palette.enemyPrimary.mainColor;

                // Stagger might still be a direct color, or we can use Tertiary
                _staggerColor = palette.staggerColor;
            }
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                _propBlock.SetColor(_emissionPropID, c); // Ensure glow matches color
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }

        // --- Death Logic ---

        // Called when Player Kills (Rewards given)
        public void Kill(bool instant)
        {
            // true = Reward Player
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, true);
            SafeDespawn();
        }

        // Called when Enemy dies naturally/suicides (No Rewards)
        public void SelfDestruct()
        {
            // false = No Reward
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, false);
            SafeDespawn();
        }

        private void SafeDespawn()
        {
#if UNITY_EDITOR
            // Deselect to prevent Inspector crash errors
            if (UnityEditor.Selection.activeGameObject == gameObject) 
                UnityEditor.Selection.activeGameObject = null;
#endif
            if (PoolManager.Instance)
                PoolManager.Instance.Despawn(gameObject);
            else
                Destroy(gameObject);
        }
    }
}