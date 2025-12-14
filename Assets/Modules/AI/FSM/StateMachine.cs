using UnityEngine;

namespace DarkTowerTron.AI.FSM
{
    public class StateMachine : MonoBehaviour
    {
        public State CurrentState { get; private set; }

        public void Initialize(State startingState)
        {
            CurrentState = startingState;
            CurrentState.Initialize(this);
            CurrentState.Enter();
        }

        public void ChangeState(State newState)
        {
            if (CurrentState != null)
                CurrentState.Exit();

            CurrentState = newState;
            CurrentState.Initialize(this);
            CurrentState.Enter();
        }

        private void Update()
        {
            if (CurrentState != null) CurrentState.LogicUpdate();
        }

        private void FixedUpdate()
        {
            if (CurrentState != null) CurrentState.PhysicsUpdate();
        }
    }
}