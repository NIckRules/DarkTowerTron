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
        private Tween _shakeTween;

        public ChaserState_Priming(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.fuseDuration;

            // VISUAL WARNING: Shake the mesh
            // (Assumes Art is a child, so we shake the child or local rotation)
            // A simple scale punch or color flash works too.
            // Let's do a Color Flash + Scale Shake

            if (_agent.GetController().meshRenderer)
            {
                _agent.GetController().meshRenderer.material.DOColor(Color.red, 0.1f).SetLoops(-1, LoopType.Yoyo);
            }
            _agent.transform.DOShakeScale(_agent.fuseDuration, 0.5f, 20, 90);
        }

        public override void LogicUpdate()
        {
            _timer -= Time.deltaTime;

            // Lock rotation to target so it looks aggressive
            if (_agent.GetTarget() != null)
            {
                _agent.GetMotor().FaceTarget(_agent.GetTarget().position);
            }

            if (_timer <= 0)
            {
                _agent.Detonate();
            }
        }

        public override void Exit()
        {
            // Cleanup tweens if we get stunned/killed during priming
            _agent.transform.DOKill();
            if (_agent.GetController().meshRenderer)
                _agent.GetController().meshRenderer.material.DOKill();
        }
    }
}