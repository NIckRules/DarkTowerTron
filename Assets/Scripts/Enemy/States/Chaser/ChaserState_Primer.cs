using UnityEngine;
using DarkTowerTron.AI.FSM;
using System.Collections.Generic;
using DG.Tweening;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Chaser
{
    public class ChaserState_Priming : State
    {
        private EnemyAgent_Chaser _agent;
        private float _timer;

        public ChaserState_Priming(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.fuseDuration;

            // 1. VISUAL WARNING (The Fix)
            // Use the Visuals component via the Controller
            if (_agent.GetController() != null && _agent.GetController().Visuals != null)
            {
                _agent.GetController().Visuals.StartPrimingEffect();
            }

            // 2. PHYSICAL WARNING (Shake)
            _agent.transform.DOShakeScale(_agent.fuseDuration, 0.5f, 20, 90);
        }

        public override void LogicUpdate()
        {
            _timer -= Time.deltaTime;

            // Lock rotation to target
            if (_agent.GetTarget() != null)
            {
                _agent.GetMotor().FaceTarget(_agent.GetTarget().position);
            }

            if (_timer <= 0)
            {
                _agent.DeployMine();
            }
        }

        public override void Exit()
        {
            // Cleanup tweens
            _agent.transform.DOKill();
            
            // Reset Color (The Fix)
            if (_agent.GetController() != null && _agent.GetController().Visuals != null)
            {
                _agent.GetController().Visuals.StopPrimingEffect();
            }
        }
    }
}