using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Core.Data;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Guardian
{
    public class GuardianState_Attack : State
    {
        private EnemyAgent_Guardian _agent;

        public GuardianState_Attack(EnemyAgent_Guardian agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // 1. Stop Moving
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>(); 
            
            // 2. Start Shooting Routine
            _agent.StartCoroutine(AttackRoutine());
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;

            // Keep facing player while shooting (Slowly!)
            Transform combatTarget = _agent.GetTarget();
            if (combatTarget != null)
            {
                _agent.GetMotor().FaceCombatTarget(combatTarget.position);
            }
        }

        private System.Collections.IEnumerator AttackRoutine()
        {
            // Debug check
            if (_agent.attackPatterns == null || _agent.attackPatterns.Count == 0)
            {
                Debug.LogWarning("Guardian has no Attack Patterns assigned!");
            }
            else
            {
                // Pick random pattern
                AttackPatternSO pattern = _agent.attackPatterns[Random.Range(0, _agent.attackPatterns.Count)];
                
                // Execute and Wait for it to finish
                yield return _agent.ExecutePattern(pattern);
            }
            
            // Cooldown after firing
            yield return new WaitForSeconds(1.5f);

            // Go back to moving
            _stateMachine.ChangeState(_agent.StateMove);
        }
    }
}