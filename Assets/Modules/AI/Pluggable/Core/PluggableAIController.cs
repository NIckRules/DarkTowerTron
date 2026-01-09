using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.Paths;
using DarkTowerTron.Enemy; // For EnemyController

namespace DarkTowerTron.AI.Pluggable.Core
{
    [RequireComponent(typeof(IMover))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(EnemyController))]
    public class PluggableAIController : MonoBehaviour
    {
        [Header("Configuration")]
        public AIState currentState;
        public AIState remainState; // Special "Do Nothing" state marker

        [Header("Setup")]
        [Tooltip("Optional. If empty, auto-searches for a PatternExecutor on self/children.")]
        public PatternExecutor specificWeapon;

        [Header("Debug")]
        public bool aiActive = true;
        public AIBlackboard blackboard; // Exposed for Inspector debugging

        private void Awake()
        {
            blackboard ??= new AIBlackboard();

            // The AI needs a mover. EnemyMotor is the preferred component for full AI behavior.
            // A fallback to other movers might result in simplified or incorrect behavior.
            var motor = GetComponent<EnemyMotor>();
            if (motor != null)
            {
                blackboard.Mover = motor;
            }
            else
            {
                // Fallback to any IMover, which is guaranteed by [RequireComponent]
                var mover = GetComponent<IMover>();
                blackboard.Mover = mover;
                Debug.LogWarning($"[AI Setup] {name} is using a fallback mover '{mover.GetType().Name}'. " +
                                 "This may cause unintended behavior. Consider adding an 'EnemyMotor' component for full AI capabilities.", gameObject);
            }

            blackboard.ContextSolver = GetComponent<ContextSolver>();
            blackboard.Health = GetComponent<DamageReceiver>();
            blackboard.Controller = GetComponent<EnemyController>();

            // --- WEAPON SETUP ---
            if (specificWeapon != null)
            {
                blackboard.Weapon = specificWeapon;
            }
            else
            {
                blackboard.Weapon = GetComponent<PatternExecutor>();
                if (blackboard.Weapon == null)
                {
                    // Auto-add if missing (Fire and Forget)
                    blackboard.Weapon = gameObject.AddComponent<PatternExecutor>();
                    // PatternExecutor requires FirePointRegistry; Unity will add it due to [RequireComponent]
                }
            }
        }

        private void Start()
        {
            // Find Player (using Service Locator logic ideally, or global find for now)
            if (DarkTowerTron.Core.GameServices.Player != null)
                blackboard.Target = DarkTowerTron.Core.GameServices.Player.transform;

            // Setup ContextSolver target
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

                // --- NEW: Execute OnEnter Actions ---
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

        // Add this helper so you can assign the path in the Prefab/Scene
        public void SetPatrolPath(PatrolPath path)
        {
            if (blackboard == null)
            {
                blackboard = new AIBlackboard();
            }

            blackboard.patrolPath = path;
        }

        // Draw Gizmos to see current state in Scene View
        private void OnDrawGizmos()
        {
            if (currentState != null)
            {
                Gizmos.color = Color.green;
                UnityEditor.Handles.Label(transform.position + Vector3.up * 2.5f, $"State: {currentState.name}");
            }
        }
    }
}