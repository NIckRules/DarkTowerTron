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

            // 2. Transition (Distance Check)
            // FIX: Flatten positions to ignore height (Y-Axis)
            Vector3 myPos = _agent.transform.position;
            myPos.y = 0;

            Vector3 targetPos = _agent.GetTarget().position;
            targetPos.y = 0;

            float dist = Vector3.Distance(myPos, targetPos);

            // Debug to verify
            // Debug.Log($"Chaser Distance: {dist} / Range: {_agent.attackRange}");

            if (dist <= _agent.attackRange)
            {
                // DELEGATE DECISION TO AGENT
                _agent.TriggerAttack();
            }
        }
    }
}