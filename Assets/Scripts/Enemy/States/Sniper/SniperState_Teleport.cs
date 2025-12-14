using UnityEngine;
using DarkTowerTron.AI.FSM;
using DG.Tweening;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper

{
    public class SniperState_Teleport : State
    {
        private EnemyAgent_Sniper _agent;
        private bool _isTeleporting;

        public SniperState_Teleport(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            _isTeleporting = true;
            _agent.transform.DOScale(Vector3.zero, 0.2f).OnComplete(PerformJump);
        }

        private void PerformJump()
        {
            if (_agent == null) return;

            Vector3 dirAway = (_agent.transform.position - _agent.GetTarget().position).normalized;

            // CONFIGURABLE DISTANCE
            float dist = _agent.teleportDistance;
            Vector3 dest = _agent.transform.position + (dirAway * dist);

            // Wall Check
            if (UnityEngine.Physics.Raycast(_agent.transform.position, dirAway, out RaycastHit hit, dist, _agent.wallLayer))
            {
                dest = hit.point - (dirAway * 2f);
            }

            dest.y = 0;
            _agent.transform.position = dest;

            // Reset Velocity
            _agent.GetComponent<EnemyMotor>().OnSpawn();

            _agent.transform.DOScale(Vector3.one, 0.2f).OnComplete(() =>
            {
                _isTeleporting = false;
            });
        }

        public override void LogicUpdate()
        {
            if (!_isTeleporting)
            {
                _stateMachine.ChangeState(_agent.StatePositioning);
            }
        }
    }
}