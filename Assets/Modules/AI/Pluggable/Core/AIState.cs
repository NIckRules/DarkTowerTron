using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.AI.Pluggable.Core
{
    [CreateAssetMenu(menuName = "AI/Pluggable/State")]
    public class AIState : ScriptableObject
    {
        [Header("Run Once (On Enter)")]
        public List<AIAction> onEnterActions;

        [Header("Run Every Frame")]
        public List<AIAction> actions;
        public List<Transition> transitions;

        public void EnterState(PluggableAIController controller)
        {
            if (onEnterActions == null || onEnterActions.Count == 0) return;

            for (int i = 0; i < onEnterActions.Count; i++)
            {
                var action = onEnterActions[i];
                if (action == null) continue;
                action.Act(controller);
            }
        }

        public void UpdateState(PluggableAIController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }

        private void DoActions(PluggableAIController controller)
        {
            if (actions == null || actions.Count == 0) return;

            for (int i = 0; i < actions.Count; i++)
            {
                var action = actions[i];
                if (action == null) continue;
                action.Act(controller);
            }
        }

        private void CheckTransitions(PluggableAIController controller)
        {
            if (transitions == null || transitions.Count == 0) return;

            for (int i = 0; i < transitions.Count; i++)
            {
                var transition = transitions[i];
                if (transition.decision == null) continue;

                bool decisionSucceeded = transition.decision.Decide(controller);

                if (decisionSucceeded)
                {
                    controller.TransitionToState(transition.trueState);
                }
                else
                {
                    controller.TransitionToState(transition.falseState);
                }
            }
        }
    }

    [System.Serializable]
    public struct Transition
    {
        public AIDecision decision;
        public AIState trueState;
        public AIState falseState; // Usually "RemainState"
    }
}