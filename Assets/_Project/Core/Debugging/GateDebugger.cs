using UnityEngine;
using DarkTowerTron.Gameplay.Environment;

namespace DarkTowerTron.Core.Debugging
{
    [RequireComponent(typeof(ArenaGate))]
    public class GateDebugger : MonoBehaviour
    {
        private ArenaGate _gate;

        private void Awake()
        {
            _gate = GetComponent<ArenaGate>();
        }

        private void OnGUI()
        {
            // Draw a button next to the object in World Space (projected to screen)
            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

            // Only draw if visible
            if (screenPos.z > 0)
            {
                // Invert Y for GUI coordinates
                screenPos.y = Screen.height - screenPos.y;

                Rect rect = new Rect(screenPos.x, screenPos.y, 100, 30);

                string btnText = _gate.IsLocked ? "Unlock" : "Lock";

                if (GUI.Button(rect, btnText))
                {
                    if (_gate.IsLocked) _gate.Unlock();
                    else _gate.Lock();
                }
            }
        }
    }
}