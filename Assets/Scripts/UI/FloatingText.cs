using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron;

namespace DarkTowerTron.UI
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

            // 2. Narrative/Dramatic Polish (Fixing "Underwhelming 1")
            // If it's a Crit or Narrative word, make it Bold and punchier
            if (isDramatic)
            {
                textMesh.fontStyle = FontStyles.Bold;
                textMesh.outlineWidth = 0.2f; // Outline makes small numbers pop
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
            // Dramatic text punches harder
            float punchAmount = isDramatic ? 0.8f : 0.5f;
            transform.DOPunchScale(Vector3.one * punchAmount, 0.2f);
        }

        private void Despawn()
        {
            // Safety Check for Scene Unload
            if (Global.Pool != null)
            {
                Global.Pool.Despawn(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}