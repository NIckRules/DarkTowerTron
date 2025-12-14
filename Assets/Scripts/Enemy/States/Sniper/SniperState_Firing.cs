using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Firing : State
    {
        private EnemyAgent_Sniper _agent;

        public SniperState_Firing(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Shoot
            _agent.HelperFireProjectile(35f); // Fast bullet

            // Immediately return to positioning
            _stateMachine.ChangeState(_agent.StatePositioning);
        }
    }
}