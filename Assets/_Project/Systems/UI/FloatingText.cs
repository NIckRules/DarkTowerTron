using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Systems.UI
{
    public class FloatingText : MonoBehaviour
    {
        public TextMeshPro textMesh;
        public float floatDistance = 2f;
        public float duration = 0.8f;
        public Ease motionEase = Ease.OutCubic;

        private void Awake()
        {
            if (textMesh == null) textMesh = GetComponent<TextMeshPro>();
        }

        public void Initialize(string text, Color color, float sizeScale = 1f, bool isDramatic = false)
        {
            // 1. Setup Text
            textMesh.text = text;
            textMesh.color = color;
            textMesh.alpha = 1f;

            // 2. Narrative/Dramatic Polish
            if (isDramatic)
            {
                textMesh.fontStyle = FontStyles.Bold;
                textMesh.outlineWidth = 0.2f;
            }
            else
            {
                textMesh.fontStyle = FontStyles.Normal;
                textMesh.outlineWidth = 0f;
            }

            // 3. Reset Transform
            transform.localScale = Vector3.one * sizeScale;

            // 4. Animate Move Up
            transform.DOMoveY(transform.position.y + floatDistance, duration)
                .SetEase(motionEase);

            // 5. Animate Fade Out
            textMesh.DOFade(0f, duration * 0.5f)
                .SetDelay(duration * 0.5f)
                .OnComplete(Despawn);

            // 6. Juice: Punch Scale
            float punchAmount = isDramatic ? 0.8f : 0.5f;
            transform.DOPunchScale(Vector3.one * punchAmount, 0.2f);
        }

        private void Despawn()
        {
            // Get Pool Service via Locator
            var pool = ServiceLocator.Get<IPoolService>();

            if (pool != null)
            {
                pool.Despawn(gameObject);
            }
            else
            {
                // Fallback if scene is unloading or pool service is missing
                Destroy(gameObject);
            }
        }
    }
}