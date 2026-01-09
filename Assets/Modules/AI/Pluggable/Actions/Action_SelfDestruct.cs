using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Core; // For DamageInfo/GameConstants
using DarkTowerTron.Core.Feedback; // For Juice

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Combat/Self Destruct")]
    public class Action_SelfDestruct : AIAction
    {
        [Header("Explosion Stats")]
        public float radius = 2.0f;
        public float damage = 10f;
        public float knockback = 20f;

        [Header("Juice")]
        public FeedbackConfigurationSO explosionFeedback;

        public override void Act(PluggableAIController controller)
        {
            // 1. Play Feedback (Sound/VFX)
            if (explosionFeedback)
                explosionFeedback.Play(null, controller.transform.position);

            // 2. Find Targets
            // We use OverlapSphere to hit player OR other enemies (if friendly fire)
            int mask = LayerMask.GetMask("Player"); // Or use GameConstants
            Collider[] hits = UnityEngine.Physics.OverlapSphere(controller.transform.position, radius, mask);

            foreach (var hit in hits)
            {
                IDamageable target = hit.GetComponentInParent<IDamageable>();
                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = (hit.transform.position - controller.transform.position).normalized,
                        pushForce = knockback,
                        source = controller.gameObject,
                        damageType = DamageType.Explosion
                    };
                    target.TakeDamage(info);
                }
            }

            // 3. Die (No Reward, because it exploded itself)
            controller.blackboard.Controller.SelfDestruct();
        }
    }
}