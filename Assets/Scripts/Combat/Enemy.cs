using UnityEngine;
using System.Collections;

using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    // Add RequireComponent so we don't forget the debris script
    [RequireComponent(typeof(DebrisSpawner))]
    public class Enemy : MonoBehaviour
    {
        [Header("Health Stats")]
        public float currentHP = 100f;

        [Header("Stagger Stats")]
        public float maxStagger = 100f;
        public float currentStagger = 0f;
        public float staggerDuration = 3f;
        public bool isStaggered = false;

        [Header("Shields")]
        public bool isShielded = false; // Check this TRUE for Turrets in Inspector

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.red;
        public Color staggerColor = Color.yellow;

        private DebrisSpawner debris;

        void Start()
        {
            debris = GetComponent<DebrisSpawner>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            meshRenderer.material.color = normalColor;
        }

        public void TakeHit(float damage, float staggerAmt, Vector3 knockback)
        {
            // 1. If already staggered, ANY hit is an Execution
            if (isStaggered)
            {
                Execute();
                return;
            }

            // NEW: Shield Logic
            if (isShielded)
            {
                Debug.Log("<color=cyan>BLOCKED BY SHIELD!</color>");
                // Optional: Play a "Clang" sound or spark
                return;
            }

            // 2. Take Damage
            currentHP -= damage;

            // 3. Add Stagger
            currentStagger += staggerAmt;
            if (currentStagger >= maxStagger)
            {
                StartCoroutine(EnterStaggerState());
            }
            else
            {
                // Normal Hit Feedback (Flash White)
                StartCoroutine(FlashColor(Color.white, 0.1f));

                // Apply Knockback
                if (knockback != Vector3.zero)
                {
                    GetComponent<Rigidbody>().AddForce(knockback * 10f, ForceMode.Impulse);
                }
            }

            if (currentHP <= 0) Die();
        }

        IEnumerator EnterStaggerState()
        {
            isStaggered = true;
            currentStagger = 0; // Reset meter
            Debug.Log("ENEMY STAGGERED! FINISH HIM!");

            float timer = 0;
            while (timer < staggerDuration)
            {
                // Pulse/Glitch Color
                meshRenderer.material.color = Color.Lerp(staggerColor, Color.black, Mathf.PingPong(Time.time * 15, 1));
                timer += Time.deltaTime;
                yield return null;
            }

            // Recovery
            isStaggered = false;
            meshRenderer.material.color = normalColor;
        }

        void Execute()
        {
            Debug.Log("EXECUTION!");

            // 1. Find Player and give reward
            // (In a real game, cache this. For prototype, FindWithTag is fine)
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                PlayerStats stats = player.GetComponent<PlayerStats>();
                if (stats != null)
                {
                    stats.OnGloryKill();
                }
            }

            Die();
        }

        void Die()
        {
            debris.SpawnDebris();
            Destroy(gameObject);
        }

        IEnumerator FlashColor(Color color, float time)
        {
            if (isStaggered) yield break; // Don't override stagger flash
            meshRenderer.material.color = color;
            yield return new WaitForSeconds(time);
            meshRenderer.material.color = normalColor;
        }
    }
}