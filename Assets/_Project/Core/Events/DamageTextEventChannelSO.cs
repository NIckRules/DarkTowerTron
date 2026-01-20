using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Damage Text Channel")]
    public class DamageTextEventChannelSO : ScriptableObject
    {
        // Added 'isStagger' bool to the signature
        public UnityAction<Vector3, float, bool, bool> OnEventRaised;

        public void RaiseEvent(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(pos, amount, isCrit, isStagger);
            else
                GameLogger.LogWarning(LogChannel.UI, $"DamageText Event [{name}] was raised but nothing picked it up.");
        }
    }
}