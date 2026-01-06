using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat; // For DamageReceiver
using DarkTowerTron.Core.Data;
using DarkTowerTron.Enemy.Visuals; // For EnemyVisuals
using DG.Tweening;
using UnityEngine.Scripting.APIUpdating;

namespace DarkTowerTron.Environment.Props
{
    [MovedFrom(true, "DarkTowerTron.Environment", "Assembly-CSharp", "Prop_Anchor")]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Anchor : MonoBehaviour
    {
        [Header("Anchor Settings")]
        public float respawnTime = 5.0f;
        public GameObject visualRoot; // Assign the mesh object
        public Collider mainCollider;

        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();

            if (visualRoot == null && transform.childCount > 0) visualRoot = transform.GetChild(0).gameObject;
            if (mainCollider == null) mainCollider = GetComponent<Collider>();
        }

        private void Start()
        {
            // Trigger the DamageReceiver to read the Inspector Overrides
            // We pass 'null' for stats because we are using overrides
            if (_receiver != null) _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            if (_receiver != null)
            {
                _receiver.OnDeathProcessed += HandleDeath;
                _receiver.OnHitProcessed += HandleHit;

                // Wire up Stagger Visuals
                if (_receiver.Stagger != null && _visuals != null)
                {
                    _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                    _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
                }
            }
        }

        private void OnDisable()
        {
            if (_receiver != null)
            {
                _receiver.OnDeathProcessed -= HandleDeath;
                _receiver.OnHitProcessed -= HandleHit;

                if (_receiver.Stagger != null && _visuals != null)
                {
                    _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                    _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
                }
            }
        }

        private void HandleHit(DarkTowerTron.Core.DamageInfo info)
        {
            // Trigger the Flash via the Visuals component
            if (_receiver != null && _visuals != null && !_receiver.IsStaggered)
            {
                _visuals.PlayHitFlash();
            }
        }

        private void HandleDeath(EnemyStatsSO stats, bool rewardPlayer)
        {
            // The PlayerExecution just triggered Kill().
            // Instead of destroying the object, we "Disable" it temporarily.
            StartCoroutine(RespawnRoutine());
        }

        private IEnumerator RespawnRoutine()
        {
            // 1. Hide
            if (visualRoot) visualRoot.SetActive(false);
            if (mainCollider) mainCollider.enabled = false;

            // 2. Wait
            yield return new WaitForSeconds(respawnTime);

            // 3. Reset Health
            // We need to revive the Vitality/Stagger modules manually
            if (_receiver != null)
            {
                if (_receiver.Vitality != null) _receiver.Vitality.Revive();
                if (_receiver.Stagger != null) _receiver.Stagger.ResetStagger();
            }

            if (_visuals != null) _visuals.ResetVisuals();

            // 4. Show (with Pop-in animation)
            if (visualRoot)
            {
                visualRoot.SetActive(true);
                visualRoot.transform.DOKill();
                visualRoot.transform.localScale = Vector3.zero;
                visualRoot.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
            }

            if (mainCollider) mainCollider.enabled = true;
        }
    }
}