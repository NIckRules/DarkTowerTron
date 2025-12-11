using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Access Data namespace
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable
    {
        // Reference the SAME stats object from Motor to keep things synced
        // Or expose it here if Motor is hidden.
        // Better yet: Get it from the Motor to ensure they share the same brain.
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.red;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        [Header("Audio")]
        public AudioClip staggerClip; // NEW: Drag your sound here

        private EnemyMotor _motor;
        private float _currentStagger;
        private float _lastHitTime;
        private Tween _flashTween; // Store reference to stop it later
        public bool IsStaggered { get; private set; }

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            if (meshRenderer) normalColor = meshRenderer.material.color;
        }

        private void Start()
        {
            // Pull stats from Motor so we don't need to assign it twice in Inspector
            if (_motor != null) _stats = _motor.stats;

            if (_stats == null) Debug.LogError($"{name} is missing EnemyStatsSO on EnemyMotor!");
        }

        private void Update()
        {
            if (_stats == null) return;

            // Decay
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

            // 1. Redirected Kill
            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            // 3. Shield Logic
            if (_stats.hasFrontalShield && !IsStaggered)
            {
                Vector3 incomingDir = info.pushDirection.normalized;
                float impactAngle = Vector3.Dot(transform.forward, -incomingDir);

                if (impactAngle > _stats.shieldAngle)
                {
                    // FIRE EVENT: BLOCKED
                    GameEvents.OnPopupText?.Invoke(transform.position, "BLOCKED");
                    return false; 
                }
            }

            // 3. Knockback
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            // FIRE EVENT: DAMAGE
            // Check if it's a kill shot (optional logic for Crit) or just Redirected
            bool isBigHit = info.isRedirected || IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isBigHit);

            // 4. Stagger Logic
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
            
            // FIRE EVENT: STAGGER
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            // --- AUDIO FEEDBACK ---
            if (GameFeel.Instance && staggerClip)
            {
                // Play with random pitch so groups don't sound robotic
                GameFeel.Instance.PlaySound(staggerClip, 1f, true);
            }
            // ----------------------

            if (meshRenderer) 
            {
                // Kill any previous tween on this material
                meshRenderer.material.DOKill();

                // Start Yellow -> Red -> Yellow Pulse
                // Loops infinitely (-1), Yoyo style, fast (0.2s)
                _flashTween = meshRenderer.material.DOColor(Color.red, 0.2f)
                    .From(staggerColor)
                    .SetLoops(-1, LoopType.Yoyo)
                    .SetEase(Ease.Linear);
            }
            
            DOVirtual.DelayedCall(2.0f, ExitStaggerState);
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;
            
            // Stop Flashing
            if (_flashTween != null) _flashTween.Kill();
            meshRenderer.material.DOKill(); 

            _currentStagger = 0;
            if (meshRenderer) meshRenderer.material.color = normalColor;
        }

        private void Flash()
        {
            if (meshRenderer)
            {
                meshRenderer.material.DOColor(flashColor, 0.1f).OnComplete(() =>
                {
                    if (this != null) meshRenderer.material.color = IsStaggered ? staggerColor : normalColor;
                });
            }
        }

        public void Kill(bool instant)
        {
            GameEvents.OnEnemyKilled?.Invoke(transform.position);
#if UNITY_EDITOR
            if (UnityEditor.Selection.activeGameObject == gameObject) UnityEditor.Selection.activeGameObject = null;
#endif
            Destroy(gameObject);
        }
    }
}