using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace DarkTowerTron.UI
{
    public class MenuController : MonoBehaviour
    {
        [Header("Navigation")]
        public GameObject firstSelectedObject;

        private void OnEnable()
        {
            // Wait one frame to ensure EventSystem is ready
            StartCoroutine(SelectButtonRoutine());
        }

        private System.Collections.IEnumerator SelectButtonRoutine()
        {
            yield return null;

            if (firstSelectedObject && EventSystem.current)
            {
                // Clear selection then set new one to force highlight update
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(firstSelectedObject);
            }
        }
    }
}