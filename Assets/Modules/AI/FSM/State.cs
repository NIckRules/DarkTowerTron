namespace DarkTowerTron.AI.FSM
{
    public abstract class State
    {
        protected StateMachine _stateMachine;

        public void Initialize(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public virtual void Enter() { }
        public virtual void LogicUpdate() { } // Run every Update
        public virtual void PhysicsUpdate() { } // Run every FixedUpdate
        public virtual void Exit() { }
    }
}