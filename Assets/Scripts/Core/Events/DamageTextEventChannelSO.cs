using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Damage Text Channel")]
    public class DamageTextEventChannelSO : ScriptableObject
    {
        // Added 'isStagger' bool to the signature
        public UnityAction<Vector3, float, bool, bool> OnEventRaised;

        public void Raise(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(pos, amount, isCrit, isStagger);
            else
                GameLogger.LogWarning(LogChannel.UI, $"DamageText Event [{name}] was raised but nothing picked it up.");
        }
    }

    [CreateAssetMenu(menuName = "Events/Popup Text Channel")]
    public class PopupTextEventChannelSO : ScriptableObject
    {
        public UnityAction<Vector3, string> OnEventRaised;

        public void Raise(Vector3 pos, string message)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(pos, message);
            else
                GameLogger.LogWarning(LogChannel.UI, $"PopupText Event [{name}] was raised but nothing picked it up.");
        }
    }
}