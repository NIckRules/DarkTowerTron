using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(GritAndFocus))]
    [RequireComponent(typeof(Rigidbody))]
    public class Blitz : MonoBehaviour
    {
        [Header("Settings")]
        public float blitzCost = 50f;
        public float blitzDistance = 3f;
        public float invulnDuration = 0.2f;

        [Header("Components")]
        private GritAndFocus resource;
        private Rigidbody rb;
        private bool isInvuln = false;

        void Start()
        {
            resource = GetComponent<GritAndFocus>();
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            // 1. If Input GetButtonDown("Jump") (Spacebar).
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump"))
            {
                AttemptBlitz();
            }
        }

        void AttemptBlitz()
        {
            // 1. Check if resource.SpendFocus(blitzCost) is true.
            if (resource.SpendFocus(blitzCost))
            {
                // Determine direction: Input direction if moving, else Model forward
                float x = Input.GetAxisRaw("Horizontal");
                float z = Input.GetAxisRaw("Vertical");
                Vector3 inputDir = new Vector3(x, 0, z).normalized;

                // If no input, use current facing direction
                Vector3 blinkDir = inputDir.sqrMagnitude > 0.1f ? inputDir : transform.forward;

                // 2. Calculate blink position
                Vector3 blinkPos = transform.position + (blinkDir * blitzDistance);

                // MovePosition(blinkPos).
                // Using transform.position for instant teleport feel.
                transform.position = blinkPos;

                // 3. StartCoroutine(InvulnWindow()).
                StartCoroutine(InvulnWindow());

                // Optional: Leave AfterImage (we'll add this later).
                Debug.Log("<color=cyan>BLITZ!</color>");
            }
            else
            {
                // Feedback for failed blitz
                Debug.Log("<color=grey>Not enough Focus for Blitz!</color>");
            }
        }

        public bool IsInvulnerable()
        {
            return isInvuln;
        }

        IEnumerator InvulnWindow()
        {
            // 1. isInvuln = true;
            isInvuln = true;

            // 2. Wait for invulnDuration.
            yield return new WaitForSeconds(invulnDuration);

            // 3. isInvuln = false;
            isInvuln = false;
        }

        /// <summary>
        /// Called when a projectile hits us during invulnerability (or specific parry window).
        /// </summary>
        public void OnPerfectDodge()
        {
            // +30 Focus reward
            if (resource != null)
            {
                resource.AddFocus(30f);
                Debug.Log("<color=green>PERFECT DODGE! +30 Focus</color>");
            }
        }
    }
}