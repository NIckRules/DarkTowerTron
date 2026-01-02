using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class ShieldHitbox : BaseHitbox
    {
        [Header("Heat Mechanics")]
        public float maxHeat = 10f;
        public float coolDownRate = 2f;
        public float staggerToHeatMultiplier = 10f; 
        
        public bool isBroken = false;
        
        [Header("Advanced Mechanics")]
        public bool reflectProjectiles = false; 

        [Header("Visuals")]
        public Renderer shieldRenderer;
        public Color coldColor = Color.grey;
        public Color hotColor = new Color(1f, 0.3f, 0f); 

        [Header("Audio")]
        public AudioClip breakClip;

        private float _currentHeat;
        private float _lastHitTime;

        private void OnEnable()
        {
            _currentHeat = 0;
            isBroken = false;
            if (shieldRenderer) shieldRenderer.enabled = true;
            UpdateVisuals();
        }

        private void Update()
        {
            if (isBroken) return;

            if (_currentHeat > 0 && Time.time > _lastHitTime + 1.0f)
            {
                _currentHeat -= coolDownRate * Time.deltaTime;
                UpdateVisuals();
            }
        }

        public override bool TakeDamage(DamageInfo info)
        {
            // CHANGED: Use _receiver
            if (_receiver == null) return false;
            
            if (isBroken) return base.TakeDamage(info);

            _lastHitTime = Time.time;

            if (info.isRedirected)
            {
                BreakShield();
                return true; 
            }

            if (info.damageType == DamageType.Projectile || info.damageType == DamageType.Generic)
            {
                float heatAdded = info.damageAmount + (info.staggerAmount * staggerToHeatMultiplier);
                _currentHeat += heatAdded;
                
                if (shieldRenderer) shieldRenderer.transform.DOPunchScale(Vector3.one * 0.05f, 0.1f);
                UpdateVisuals();

                if (reflectProjectiles && info.source != null)
                {
                    var proj = info.source.GetComponent<Projectile>();
                    if (proj != null)
                    {
                        proj.DeflectByEnemy(transform.forward);
                        GameEvents.OnPopupText?.Invoke(transform.position, "REFLECT");
                        return true; 
                    }
                }

                GameEvents.OnPopupText?.Invoke(transform.position, "DEFLECT");
                return true; 
            }
            
            else if (info.damageType == DamageType.Melee)
            {
                if (_currentHeat >= maxHeat)
                {
                    BreakShield();
                    return true; 
                }
                else
                {
                    GameEvents.OnPopupText?.Invoke(transform.position, "ARMORED");
                    return false; 
                }
            }

            return base.TakeDamage(info);
        }

        private void BreakShield()
        {
            isBroken = true;
            if (shieldRenderer) shieldRenderer.enabled = false;
            
            GameEvents.OnPopupText?.Invoke(transform.position, "SHATTERED");
            
            if (AudioManager.Instance && breakClip)
                 AudioManager.Instance.PlaySound(breakClip, 1.0f);
                 
            // TODO: Spawn AOE Explosion Hazard here if you want the "Exploding Shield" perk
        }

        private void UpdateVisuals()
        {
            if (shieldRenderer)
            {
                float t = Mathf.Clamp01(_currentHeat / maxHeat);
                shieldRenderer.material.color = Color.Lerp(coldColor, hotColor, t);
                shieldRenderer.material.SetColor("_EmissionColor", Color.Lerp(coldColor, hotColor, t) * (1 + t * 2)); 
            }
        }
    }
}