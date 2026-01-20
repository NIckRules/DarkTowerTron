using UnityEngine;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Gameplay.Player; // ADDED: Needed for PlayerController

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Gameplay.AI
{
    [RequireComponent(typeof(IMover))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(EnemyController))]
    public class PluggableAIController : MonoBehaviour
    {
        [Header("Configuration")]
        public AIState currentState;
        public AIState remainState;

        [Header("Setup")]
        public PatternExecutor specificWeapon;

        [Header("Debug")]
        public bool aiActive = true;
        public AIBlackboard blackboard;

        private void Awake()
        {
            blackboard ??= new AIBlackboard();

            var motor = GetComponent<EnemyMotor>();
            if (motor != null)
            {
                blackboard.Mover = motor;
            }
            else
            {
                var mover = GetComponent<IMover>();
                blackboard.Mover = mover;
                Debug.LogWarning($"[AI Setup] {name} is using fallback mover '{mover.GetType().Name}'.", gameObject);
            }

            blackboard.ContextSolver = GetComponent<ContextSolver>();
            blackboard.Health = GetComponent<DamageReceiver>();
            blackboard.Controller = GetComponent<EnemyController>();

            if (specificWeapon != null)
            {
                blackboard.Weapon = specificWeapon;
            }
            else
            {
                blackboard.Weapon = GetComponent<PatternExecutor>();
                if (blackboard.Weapon == null)
                {
                    blackboard.Weapon = gameObject.AddComponent<PatternExecutor>();
                }
            }
        }

        private void Start()
        {
            // FIX: Replaced GameServices.Player with PlayerController.Instance
            if (PlayerController.Instance != null)
                blackboard.Target = PlayerController.Instance.transform;

            if (blackboard.ContextSolver != null)
            {
                var aiData = GetComponent<AIData>();
                if (aiData) aiData.currentTarget = blackboard.Target;
            }

            if (currentState != null)
            {
                blackboard.StateTimeElapsed = 0f;
                currentState.EnterState(this);
            }
        }

        private void Update()
        {
            if (!aiActive || blackboard.Controller.IsStaggered) return;

            blackboard.StateTimeElapsed += Time.deltaTime;
            if (currentState != null)
            {
                currentState.UpdateState(this);
            }
        }

        public void TransitionToState(AIState nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
                blackboard.StateTimeElapsed = 0f;

                if (currentState != null && currentState.onEnterActions != null)
                {
                    for (int i = 0; i < currentState.onEnterActions.Count; i++)
                    {
                        var action = currentState.onEnterActions[i];
                        if (action == null) continue;
                        action.Act(this);
                    }
                }
            }
        }

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (currentState != null)
            {
                Gizmos.color = Color.green;
                Handles.Label(transform.position + Vector3.up * 2.5f, $"State: {currentState.name}");
            }
        }
#endif
    }
}