using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Chaser
{
    public class ChaserState_Chase : State
    {
        private EnemyAgent_Chaser _agent;

        public ChaserState_Chase(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            _agent.Brain.behaviors = _agent.chaseBehaviors;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null) return;

            // 1. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            if (moveDir.sqrMagnitude > 0.1f)
                _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);

            // 2. Transition
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            if (dist <= _agent.attackRange)
            {
                // DELEGATE DECISION TO AGENT
                _agent.TriggerAttack();
            }
        }
    }
}