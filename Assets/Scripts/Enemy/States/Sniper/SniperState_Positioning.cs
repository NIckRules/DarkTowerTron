using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Positioning : State
    {
        private EnemyAgent_Sniper _agent;
        private float _cooldownTimer;

        public SniperState_Positioning(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // OPTIMIZATION: Assign the pre-filled list reference. 
            // Zero Garbage Allocation.
            _agent.Brain.behaviors = _agent.positioningBehaviors;

            _cooldownTimer = 1.0f;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null) return;

            if (_cooldownTimer > 0) _cooldownTimer -= Time.deltaTime;

            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            // 1. Panic
            if (dist < _agent.panicDistance)
            {
                _stateMachine.ChangeState(_agent.StateTeleport);
                return;
            }

            // 2. Attack
            if (dist < _agent.attackRange && _cooldownTimer <= 0)
            {
                _stateMachine.ChangeState(_agent.StateAiming);
                return;
            }

            // 3. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetComponent<EnemyMotor>().Move(moveDir);
            _agent.GetComponent<EnemyMotor>().FaceTarget(_agent.GetTarget().position);
        }
    }
}