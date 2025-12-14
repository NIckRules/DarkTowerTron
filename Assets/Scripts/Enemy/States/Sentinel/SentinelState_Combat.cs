using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sentinel
{
    public class SentinelState_Combat : State
    {
        private EnemyAgent_Sentinel _agent;
        private float _fireTimer;

        public SentinelState_Combat(EnemyAgent_Sentinel agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Load "Orbit + Flee" Profile
            _agent.Brain.behaviors = _agent.combatBehaviors;

            // Randomize first shot
            _fireTimer = Random.Range(0.5f, _agent.fireRate);
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;
            if (_agent.GetTarget() == null) return;

            // 1. Move (Orbit/Strafe)
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // 2. Aim (Always lock on target)
            _agent.GetMotor().FaceTarget(_agent.GetTarget().position);

            // 3. Fire
            _fireTimer -= Time.deltaTime;
            if (_fireTimer <= 0)
            {
                _agent.HelperFireProjectile();
                _fireTimer = _agent.fireRate;
            }

            // 4. Transition Check
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            // Use "HuntRange" (hysteresis) to prevent flickering
            if (dist > _agent.huntRange)
            {
                _stateMachine.ChangeState(_agent.StateHunt);
            }
        }
    }
}