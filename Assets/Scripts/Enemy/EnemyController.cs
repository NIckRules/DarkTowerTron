using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public float maxStagger = 1.0f;
        public float staggerDecay = 0.5f;

        [Header("Defenses")]
        public bool hasFrontalShield = false; // TURRET: Set this to TRUE
        [Range(0f, 1f)] public float shieldAngle = 0.5f; // 0.5 = 90 degree protection arc

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.red;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        private EnemyMotor _motor;
        private float _currentStagger;
        private float _lastHitTime;
        public bool IsStaggered { get; private set; }

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            if (meshRenderer) normalColor = meshRenderer.material.color;
        }

        private void Update()
        {
            // Decay stagger
            if (!IsStaggered && _currentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f)
                {
                    _currentStagger -= staggerDecay * Time.deltaTime;
                    if (_currentStagger < 0) _currentStagger = 0;
                }
            }
        }

        public bool TakeDamage(DamageInfo info)
        {
            _lastHitTime = Time.time;

            // 1. Redirected Projectiles pierce everything (Reward for Blitz)
            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            // 2. Shield Logic (Math-based)
            if (hasFrontalShield && !IsStaggered)
            {
                // Dot Product: 1 = Hit front, -1 = Hit back
                // info.pushDirection is usually the direction the bullet traveled (towards enemy)
                // transform.forward is enemy facing
                // If they oppose each other, it's a frontal hit.

                Vector3 incomingDir = info.pushDirection.normalized;
                float impactAngle = Vector3.Dot(transform.forward, -incomingDir);

                if (impactAngle > shieldAngle)
                {
                    // BLOCKED!
                    Debug.Log("SHIELD BLOCKED!");
                    // Optional: Play "Clang" sound
                    // Optional: Visual feedback (Shield flash)
                    return false; // Damage ignored
                }
            }

            // 3. Apply Knockback
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            // 4. Stagger / Kill
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
            if (_currentStagger >= maxStagger)
            {
                EnterStaggerState();
            }
        }

        private void EnterStaggerState()
        {
            IsStaggered = true;
            if (meshRenderer) meshRenderer.material.color = staggerColor;
            DOVirtual.DelayedCall(2.0f, ExitStaggerState);
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;
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

            // --- EDITOR FIX START ---
            // If we are in the Unity Editor and this object is selected, deselect it.
            // This prevents the "SerializedObjectNotCreatableException" errors.
#if UNITY_EDITOR
            if (UnityEditor.Selection.activeGameObject == gameObject)
            {
                UnityEditor.Selection.activeGameObject = null;
            }
#endif
            // --- EDITOR FIX END ---

            // Destroy with a tiny delay (0 frame) to allow the frame to finish cleanly
            Destroy(gameObject);
        }
    }
}