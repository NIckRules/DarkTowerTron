using UnityEngine;
using System;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class StaggerModule : MonoBehaviour
    {
        public event Action OnStaggerBreak;
        public event Action OnStaggerRecover;

        public float CurrentStagger { get; private set; }
        public float MaxStagger { get; private set; }
        public bool IsStaggered { get; private set; }

        private float _decayRate;
        private float _lastHitTime;
        private Tween _recoveryTween;

        public void Initialize(float maxStagger, float decayRate)
        {
            MaxStagger = maxStagger;
            _decayRate = decayRate;
            ResetStagger();
        }

        public void ResetStagger()
        {
            IsStaggered = false;
            CurrentStagger = 0;
            if (_recoveryTween != null) _recoveryTween.Kill();
        }

        private void Update()
        {
            // Passive Decay logic
            if (!IsStaggered && CurrentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f) // Wait 1s before decaying
                {
                    CurrentStagger -= _decayRate * Time.deltaTime;
                    if (CurrentStagger < 0) CurrentStagger = 0;
                }
            }
        }

        public void AddStagger(float amount)
        {
            if (IsStaggered) return; // Already broken

            _lastHitTime = Time.time;
            CurrentStagger += amount;

            if (CurrentStagger >= MaxStagger)
            {
                BreakStagger();
            }
        }

        private void BreakStagger()
        {
            IsStaggered = true;
            OnStaggerBreak?.Invoke();

            // Auto-Recover after 2.0s
            // We use DOTween delay for consistency with visuals
            if (_recoveryTween != null) _recoveryTween.Kill();
            _recoveryTween = DOVirtual.DelayedCall(2.0f, Recover).SetId(gameObject);
        }

        private void Recover()
        {
            if (this == null) return;
            IsStaggered = false;
            CurrentStagger = 0;
            OnStaggerRecover?.Invoke();
        }
    }
}