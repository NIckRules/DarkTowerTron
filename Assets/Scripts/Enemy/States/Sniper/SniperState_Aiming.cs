using UnityEngine;
using DarkTowerTron.AI.FSM;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Aiming : State
    {
        private EnemyAgent_Sniper _agent;
        private float _timer;

        public SniperState_Aiming(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING (Clear behaviors or set empty list)
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.aimDuration;
            if (_agent.laserSight) _agent.laserSight.enabled = true;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null)
            {
                _stateMachine.ChangeState(_agent.StatePositioning);
                return;
            }

            _timer -= Time.deltaTime;

            // 1. Visuals
            if (_agent.laserSight)
            {
                Vector3 start = _agent.firePoint ? _agent.firePoint.position : _agent.transform.position;
                // Aim at chest
                Vector3 end = _agent.GetTarget().position + Vector3.up * 1.0f;
                _agent.laserSight.SetPosition(0, start);
                _agent.laserSight.SetPosition(1, end);
            }

            // 2. Tracking (Stop tracking in last 0.2s for fairness)
            if (_timer > 0.2f)
            {
                _agent.GetComponent<EnemyMotor>().FaceTarget(_agent.GetTarget().position);
            }

            // 3. Transition
            if (_timer <= 0)
            {
                _stateMachine.ChangeState(_agent.StateFiring);
            }
        }

        public override void Exit()
        {
            if (_agent.laserSight) _agent.laserSight.enabled = false;
        }
    }
}