using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sentinel
{
    public class SentinelState_Hunt : State
    {
        private EnemyAgent_Sentinel _agent;

        public SentinelState_Hunt(EnemyAgent_Sentinel agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Load "Seek" Profile
            _agent.Brain.behaviors = _agent.huntBehaviors;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;
            if (_agent.GetTarget() == null) return;

            // 1. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // Face movement
            if (moveDir.sqrMagnitude > 0.1f)
                _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);

            // 2. Transition Check
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            if (dist <= _agent.combatRange)
            {
                _stateMachine.ChangeState(_agent.StateCombat);
            }
        }
    }
}