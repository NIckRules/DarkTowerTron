using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Narrative Text Channel")]
    public class NarrativeEventChannelSO : ScriptableObject
    {
        // String = Text, Float = Duration
        public UnityAction<string, float> OnEventRaised;

        public void Raise(string text, float duration = 3f)
        {
            OnEventRaised?.Invoke(text, duration);
        }
    }
}