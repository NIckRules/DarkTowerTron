using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Combat
{
    public class EnemyStagger : MonoBehaviour
    {
        [Header("Settings")]
        public float staggerResistance = 1.0f; // Max meter value (usually 1)
        public float currentStagger = 0f;
        public float decayRate = 2.0f; // How fast meter drops (Design: 2/s)
        public float staggerDuration = 1.5f; // How long they stay vulnerable

        [Header("State")]
        public bool isStaggered = false;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.red;
        public Color staggerColor = Color.cyan; // Design: Cyan pulse

        private Coroutine staggerCoroutine;

        void Start()
        {
            // Cache components and set initial color.
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            if (meshRenderer != null)
            {
                meshRenderer.material.color = normalColor;
            }
        }

        void Update()
        {
            // Handle decay.
            // 1. If isStaggered is true, do nothing (handled by coroutine).
            if (isStaggered) return;

            // 2. If isStaggered is false AND currentStagger > 0:
            if (currentStagger > 0)
            {
                // Subtract decayRate * deltaTime.
                currentStagger -= decayRate * Time.deltaTime;

                // Clamp to 0.
                if (currentStagger < 0) currentStagger = 0;
            }
        }

        public void AddStagger(float amount)
        {
            // 1. If already isStaggered, return (don't add to full meter).
            if (isStaggered) return;

            // 2. Add amount to currentStagger.
            currentStagger += amount;

            // 3. Flash white for feedback (optional).
            if (meshRenderer != null)
            {
                StartCoroutine(FlashFeedback());
            }

            // 4. If currentStagger >= staggerResistance:
            if (currentStagger >= staggerResistance)
            {
                EnterStaggerState();
            }
        }

        void EnterStaggerState()
        {
            // 1. Set isStaggered = true.
            isStaggered = true;
            currentStagger = staggerResistance; // Cap it visually

            // 2. Change color to staggerColor.
            if (meshRenderer != null)
            {
                meshRenderer.material.color = staggerColor;
            }

            Debug.Log($"<color=cyan>STAGGERED! {name} is vulnerable!</color>");

            // 3. StartCoroutine(StaggerTimer()).
            if (staggerCoroutine != null) StopCoroutine(staggerCoroutine);
            staggerCoroutine = StartCoroutine(StaggerTimer());
        }

        IEnumerator StaggerTimer()
        {
            // 1. Yield wait for staggerDuration.
            yield return new WaitForSeconds(staggerDuration);

            // 2. Set isStaggered = false.
            isStaggered = false;

            // 3. currentStagger = 0.
            currentStagger = 0;

            // 4. Reset color to normalColor.
            if (meshRenderer != null)
            {
                meshRenderer.material.color = normalColor;
            }
            
            Debug.Log($"<color=grey>{name} recovered from stagger.</color>");
        }

        IEnumerator FlashFeedback()
        {
            if (meshRenderer == null) yield break;
            
            Color prevColor = meshRenderer.material.color;
            meshRenderer.material.color = Color.white;
            yield return new WaitForSeconds(0.1f);
            
            // Only revert if we haven't entered stagger state during the flash
            if (!isStaggered)
            {
                meshRenderer.material.color = prevColor;
            }
            else
            {
                meshRenderer.material.color = staggerColor;
            }
        }
    }
}