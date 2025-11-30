using UnityEngine;
using System.Collections;
using DG.Tweening;

namespace DarkTowerTron.Combat
{
    public class EnemyStagger : MonoBehaviour
    {
        [Header("Settings")]
        public float staggerResistance = 1.0f;
        public float currentStagger = 0f;
        public float decayRate = 0.5f;
        public float decayDelay = 1.0f;
        public float staggerDuration = 1.5f;

        [Header("Knockback")]
        public float knockbackDistance = 3.0f; // Adjusted to 3m for better feel
        public float knockbackDuration = 0.2f; // Snappy slide
        
        [HideInInspector] public float decayMultiplier = 1.0f; 

        public bool isStaggered = false;
        public Renderer meshRenderer;
        
        // --- RESTORED PUBLIC VARIABLE ---
        public Color normalColor = Color.red; 
        // --------------------------------

        private Color staggerColor = Color.yellow;
        private Color flashColor = Color.white;
        
        private float lastHitTime = 0f;

        void Start()
        {
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            
            // Sync the script color with the actual material color at start
            if (meshRenderer != null) normalColor = meshRenderer.material.color;
        }

        void Update()
        {
            decayMultiplier = 1.0f;

            if (!isStaggered && currentStagger > 0)
            {
                if (Time.time > lastHitTime + decayDelay)
                {
                    float finalDecay = decayRate * decayMultiplier * Time.deltaTime;
                    currentStagger -= finalDecay;
                    if (currentStagger < 0) currentStagger = 0;
                }
            }
        }

        public void AddStagger(float amount)
        {
            if (isStaggered) return;

            lastHitTime = Time.time;
            currentStagger += amount;
            
            StopCoroutine("FlashFeedback"); 
            StartCoroutine("FlashFeedback");

            if (currentStagger >= staggerResistance)
            {
                EnterStagger();
            }
        }

        void EnterStagger()
        {
            isStaggered = true;
            StopCoroutine("FlashFeedback"); 
            
            if(meshRenderer) meshRenderer.material.color = staggerColor;

            // --- KNOCKBACK LOGIC ---
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                // Calculate direction AWAY from player
                Vector3 pushDir = (transform.position - player.transform.position).normalized;
                pushDir.y = 0; 

                // Target position
                Vector3 targetPos = transform.position + (pushDir * knockbackDistance);

                // Wall check
                if (Physics.Raycast(transform.position, pushDir, out RaycastHit hit, knockbackDistance))
                {
                    targetPos = hit.point - (pushDir * 0.5f);
                }

                transform.DOMove(targetPos, knockbackDuration).SetEase(Ease.OutCubic);
            }
            // -----------------------
            
            StartCoroutine(StaggerTimer());
        }

        System.Collections.IEnumerator StaggerTimer()
        {
            yield return new WaitForSeconds(staggerDuration);
            
            isStaggered = false;
            currentStagger = 0;
            if(meshRenderer) meshRenderer.material.color = normalColor;
        }

        System.Collections.IEnumerator FlashFeedback()
        {
            if(meshRenderer) meshRenderer.material.color = flashColor;
            yield return new WaitForSeconds(0.1f);
            
            if (!isStaggered && meshRenderer) 
            {
                meshRenderer.material.color = normalColor;
            }
        }
    }
}