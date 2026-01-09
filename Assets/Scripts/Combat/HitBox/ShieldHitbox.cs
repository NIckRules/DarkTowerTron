using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DG.Tweening;
using UnityEngine;
using DarkTowerTron;

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
        [ColorUsage(true, true)] public Color hotColor = new Color(1f, 0.3f, 0f);

        [Header("Feedback")]
        [SerializeField] private PopupTextEventChannelSO _popupEvent;
        public AudioClip breakClip;

        private float _currentHeat;
        private float _lastHitTime;

        // Optimization: Property Block
        private MaterialPropertyBlock _propBlock;
        private int _baseColorID;
        private int _emissionColorID;

        protected override void Awake()
        {
            base.Awake(); // Sets up _damageableParent

            _propBlock = new MaterialPropertyBlock();
            _baseColorID = Shader.PropertyToID("_BaseColor");
            _emissionColorID = Shader.PropertyToID("_EmissionColor");
        }

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
            // FIX: Use the Interface reference from BaseHitbox
            if (_damageableParent == null) return false;

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

                        // CRITICAL FIX: Claim ownership so the bullet doesn't hit us again instantly
                        proj.SetSource(this.gameObject);

                        _popupEvent?.Raise(transform.position, "REFLECT");
                        return true;
                    }
                }

                _popupEvent?.Raise(transform.position, "DEFLECT");
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
                    _popupEvent?.Raise(transform.position, "ARMORED");
                    return false;
                }
            }

            return base.TakeDamage(info);
        }

        private void BreakShield()
        {
            isBroken = true;
            if (shieldRenderer) shieldRenderer.enabled = false;

            _popupEvent?.Raise(transform.position, "SHATTERED");

            if (Global.Audio != null && breakClip)
                Global.Audio.PlaySound(breakClip, 1.0f);
        }

        private void UpdateVisuals()
        {
            if (shieldRenderer)
            {
                float t = Mathf.Clamp01(_currentHeat / maxHeat);
                Color c = Color.Lerp(coldColor, hotColor, t);
                Color e = Color.Lerp(coldColor, hotColor, t) * (1 + t * 2);

                // Use Property Block to avoid creating Material Instances
                shieldRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_baseColorID, c);
                _propBlock.SetColor(_emissionColorID, e);
                shieldRenderer.SetPropertyBlock(_propBlock);
            }
        }
    }
}