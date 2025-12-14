using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.AI.Core; // For AIData
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Guardian
{
    public class GuardianState_Move : State
    {
        private EnemyAgent_Guardian _agent;

        public GuardianState_Move(EnemyAgent_Guardian agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // 1. Set Steering to "Move Profile"
            _agent.Brain.behaviors = _agent.moveBehaviors;

            // 2. Tell the Brain to Seek the Waypoint
            // We must update AIData so ContextSolver knows where to go
            var aiData = _agent.GetComponent<AIData>();
            if (aiData != null)
            {
                aiData.currentTarget = _agent.GetCurrentWaypoint();
            }
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;

            Transform wp = _agent.GetCurrentWaypoint();

            // Safety: If path is broken/missing, switch to attack in place
            if (wp == null)
            {
                _stateMachine.ChangeState(_agent.StateAttack);
                return;
            }

            // --- MOVEMENT ---
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // --- ROTATION (Use SLOW Combat Speed when looking at player) ---
            Transform combatTarget = _agent.GetTarget();

            if (combatTarget != null)
            {
                // Use the slow rotation method for aiming at player
                _agent.GetMotor().FaceCombatTarget(combatTarget.position);
            }
            else
            {
                // Fallback: Face movement direction using normal speed
                if (moveDir.sqrMagnitude > 0.1f)
                    _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);
            }

            // --- TRANSITION ---
            // Check distance to Waypoint (flat check to ignore height diff)
            Vector3 toWaypoint = wp.position - _agent.transform.position;
            toWaypoint.y = 0;

            if (toWaypoint.magnitude < _agent.waypointTolerance)
            {
                _agent.AdvanceWaypoint(); // Select next point for NEXT time
                _stateMachine.ChangeState(_agent.StateAttack);
            }
        }
    }
}