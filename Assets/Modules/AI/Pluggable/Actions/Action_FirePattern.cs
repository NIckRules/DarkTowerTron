using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Core.Data; // For EnemyAttackSO & AttackPatternSO
using DarkTowerTron.Enemy;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Combat/Fire Pattern")]
    public class Action_FirePattern : AIAction
    {
        [Header("The Shape")]
        public AttackPatternSO pattern;

        [Header("The Payload")]
        public EnemyAttackSO attackStats; // <--- REPLACES 'projectilePrefab'

        public override void Act(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return;

            // 1. Face the Target
            if (controller.blackboard.Mover is EnemyMotor motor)
            {
                motor.FaceCombatTarget(controller.blackboard.Target.position);
            }

            // 2. Fire
            if (controller.blackboard.Weapon != null)
            {
                // Pass BOTH config objects to the weapon
                controller.blackboard.Weapon.Fire(pattern, attackStats, controller.blackboard.Target);
            }
        }
    }
}