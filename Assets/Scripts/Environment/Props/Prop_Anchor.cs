using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class Prop_Anchor : CombatProp
    {
        [Header("Anchor Settings")]
        public float respawnTime = 3.0f;
        public bool keepPlayerInAir = true; // True for traversal

        private Collider _col;

        protected override void Awake()
        {
            base.Awake();
            _col = GetComponent<Collider>();
        }

        // Override: Anchors don't die from damage
        public override bool TakeDamage(DamageInfo info)
        {
            // Only take stagger, ignore health damage
            if (!IsStaggered)
            {
                // We barely invoke base just for the Flash/Stagger logic
                // We hack the info to deal 0 health damage
                info.damageAmount = 0;
                base.TakeDamage(info);
            }
            return true;
        }

        protected override void Die() 
        {
            // Impossible state, but handle gracefully
            StartCoroutine(RespawnRoutine());
        }

        public override void OnExecutionHit()
        {
            // When player teleports here:
            // 1. Visual Bounce
            transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            
            // 2. Hide (Respawn)
            StartCoroutine(RespawnRoutine());
        }

        private IEnumerator RespawnRoutine()
        {
            // Hide
            if (meshRenderer) meshRenderer.enabled = false;
            if (_col) _col.enabled = false;
            
            // Reset internal state
            OnSpawn(); 

            yield return new WaitForSeconds(respawnTime);

            // Show
            if (meshRenderer) meshRenderer.enabled = true;
            if (_col) _col.enabled = true;
            
            // Juice
            transform.localScale = Vector3.zero;
            transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
        }

        // ICombatTarget Override
        public override bool KeepPlayerGrounded => !keepPlayerInAir;
    }
}