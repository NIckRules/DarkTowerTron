using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Combat; // Need this to see Enemy script

namespace DarkTowerTron.Combat // Namespace update
{
    public class SpearWeapon : MonoBehaviour
    {
        [Header("References")]
        public Transform spearVisuals; // The container

        [Header("Combat Stats")]
        public float damageWeak = 2f;
        public float damageCrit = 10f;
        public float critDistanceMin = 2.0f; // How far away to trigger Crit
        public float attackRange = 3.5f;     // Total hitbox length
        public float attackWidth = 1.0f;

        [Header("Animation")]
        public float thrustDist = 2.5f;
        public float thrustDuration = 0.05f;
        public float recoveryDuration = 0.15f;

        private bool isAttacking = false;
        private Vector3 originalScale;
        private Vector3 originalPos;

        void Start()
        {
            originalScale = spearVisuals.localScale;
            originalPos = spearVisuals.localPosition;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0) && !isAttacking)
            {
                Attack();
            }
        }

        void Attack()
        {
            isAttacking = true;
            spearVisuals.DOKill();
            spearVisuals.localScale = originalScale;
            spearVisuals.localPosition = originalPos;

            Sequence stab = DOTween.Sequence();

            // Thrust & Stretch
            stab.Append(spearVisuals.DOLocalMoveZ(thrustDist, thrustDuration).SetEase(Ease.OutQuad));
            stab.Join(spearVisuals.DOScaleZ(originalScale.z * 1.5f, thrustDuration));

            // CHECK HIT at the exact moment of extension
            stab.AppendCallback(CheckHit);

            stab.AppendInterval(0.05f); // Impact Freeze

            // Recover
            stab.Append(spearVisuals.DOLocalMoveZ(originalPos.z, recoveryDuration).SetEase(Ease.OutQuad));
            stab.Join(spearVisuals.DOScaleZ(originalScale.z, recoveryDuration));

            stab.OnComplete(() => isAttacking = false);
        }

        void CheckHit()
        {
            // OLD: Vector3 center = transform.position + (transform.forward * (attackRange / 2));
            // OLD: Vector3 size = new Vector3(attackWidth, 1, attackRange);

            // NEW: TALL HITBOX
            // 1. Center the hit vertically at Y=1 (Chest height) regardless of where the player pivot is
            Vector3 center = transform.position + (transform.forward * (attackRange / 2));
            center.y = 1.0f;

            // 2. Make it 4 meters tall so it hits low rollers and high flyers
            Vector3 size = new Vector3(attackWidth, 4f, attackRange);

            // Debug Draw to confirm size
            // ExtDebug.DrawBox(center, size / 2, transform.rotation, Color.red, 1f);

            Collider[] hits = Physics.OverlapBox(center, size / 2, transform.rotation);

            foreach (Collider hit in hits)
            {
                // FIX: Use GetComponentInParent just in case the Collider is on a child mesh
                Enemy enemy = hit.GetComponentInParent<Enemy>();

                if (enemy != null)
                {
                    // ... Rest of the logic stays the same ...
                    float distance = Vector3.Distance(transform.position, enemy.transform.position);
                    bool isTipHit = distance >= critDistanceMin;

                    if (isTipHit)
                    {
                        enemy.TakeHit(damageCrit, 100f, Vector3.zero);
                    }
                    else
                    {
                        Vector3 pushDir = (enemy.transform.position - transform.position).normalized;
                        enemy.TakeHit(damageWeak, 20f, pushDir);
                    }
                }
            }
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            // Match the logic above
            Vector3 center = transform.position + (transform.forward * (attackRange / 2));
            center.y = 1.0f;
            Vector3 size = new Vector3(attackWidth, 4f, attackRange);

            Gizmos.matrix = Matrix4x4.TRS(center, transform.rotation, size);
            Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
        }
    }
}