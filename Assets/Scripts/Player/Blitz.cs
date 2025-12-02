using UnityEngine;
using DG.Tweening; // Needed for the slide
using DarkTowerTron.Player;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(GritAndFocus))]
    [RequireComponent(typeof(Rigidbody))]
    public class Blitz : MonoBehaviour
    {
        [Header("Settings")]
        public float blitzCost = 25f;
        public float blitzDistance = 6f; 
        public float blitzFocusGain = 20f; 

        [Header("Feel")]
        public float chargeTime = 0.08f; // The "Anticipation" freeze
        public float dashDuration = 0.15f; // The "Slide" speed
        
        [Header("Visuals")]
        public Transform blitzGhost; // The target indicator
        public GameObject blitzCatcher; // The Big Hitbox
        public TrailRenderer dashTrail; // Drag the trail here

        private GritAndFocus resource;
        private Rigidbody rb;
        private Camera cam;
        private bool isInvuln = false;
        private bool isDashing = false; // Prevents double input
        private Vector3 targetPosition;

        void Start()
        {
            resource = GetComponent<GritAndFocus>();
            rb = GetComponent<Rigidbody>();
            cam = Camera.main;
            
            // Ensure Catcher is off
            if(blitzCatcher) blitzCatcher.SetActive(false);
            if(dashTrail) dashTrail.emitting = false;
        }

        void Update()
        {
            if (isDashing)
            {
                ActiveIntercept();
                return; 
            }

            HandleGhost();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                AttemptBlitz();
            }
        }

        void HandleGhost()
        {
            if (blitzGhost == null) return;

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayDistance;

            if (groundPlane.Raycast(ray, out rayDistance))
            {
                Vector3 mousePoint = ray.GetPoint(rayDistance);
                Vector3 dir = (mousePoint - transform.position).normalized;
                dir.y = 0;

                // Raycast check to stop ghost going through walls
                if (Physics.Raycast(transform.position + Vector3.up, dir, out RaycastHit hit, blitzDistance))
                {
                    targetPosition = hit.point - (dir * 0.5f); // Stop before wall
                }
                else
                {
                    targetPosition = transform.position + (dir * blitzDistance);
                }
                
                targetPosition.y = 0.1f; 
                blitzGhost.position = targetPosition;
                
                bool canAfford = resource.currentFocus >= blitzCost;
                blitzGhost.gameObject.SetActive(canAfford);
            }
        }

        void AttemptBlitz()
        {
            if (isDashing) return;

            if (resource.SpendFocus(blitzCost))
            {
                StartCoroutine(BlitzSequence());
            }
        }

        System.Collections.IEnumerator BlitzSequence()
        {
            isDashing = true;
            isInvuln = true; // Invuln starts during charge
            
            // 1. CHARGE PHASE (Anticipation)
            // Squash the player slightly?
            transform.localScale = new Vector3(1.2f, 0.8f, 1.2f);
            
            yield return new WaitForSeconds(chargeTime);

            // 2. DASH PHASE (Movement)
            transform.localScale = Vector3.one; // Reset shape
            if(blitzCatcher) blitzCatcher.SetActive(true); // Activate Big Hitbox
            if(dashTrail) dashTrail.emitting = true;

            // Use Rigidbody DOMove for physics-safe sliding
            Vector3 finalPos = targetPosition;
            finalPos.y = rb.position.y;
            
            // DOTween handles the velocity curve
            rb.DOMove(finalPos, dashDuration).SetEase(Ease.OutExpo);
            
            // Audio Juice
            Debug.Log("<color=cyan>BLITZ!</color>");
            if(GameFeel.instance) GameFeel.instance.CameraShake(0.1f, 0.1f);

            yield return new WaitForSeconds(dashDuration);

            // 3. RECOVERY
            if(blitzCatcher) blitzCatcher.SetActive(false);
            if(dashTrail) dashTrail.emitting = false;
            
            // Keep invuln for a tiny split second after stopping
            yield return new WaitForSeconds(0.05f);
            
            isInvuln = false;
            isDashing = false;
        }

        public bool IsInvulnerable()
        {
            return isInvuln;
        }

        public void OnPerfectDodge()
        {
            Debug.Log("<color=cyan>PERFECT DODGE! +" + this.blitzFocusGain + " Focus</color>");
            resource.AddFocus(this.blitzFocusGain);
            if (GameFeel.instance) GameFeel.instance.HitStop(0.1f);
        }

        // Call this inside the Update loop ONLY when dashing
        void ActiveIntercept()
        {
            if (!isDashing) return;

            Vector3 center = transform.position;
            float radius = 2.0f; 
            
            Collider[] hits = Physics.OverlapSphere(center, radius);
            
            foreach (Collider hit in hits)
            {
                // Check for Projectile
                DarkTowerTron.Combat.Projectile proj = hit.GetComponent<DarkTowerTron.Combat.Projectile>();
                
                // Only redirect if it's currently HOSTILE (don't redirect your own bullets repeatedly)
                if (proj != null && proj.isHostile)
                {
                    Debug.Log("<color=cyan>REDIRECTING!</color>");
                    
                    // 1. Reward Focus
                    OnPerfectDodge(); 
                    
                    // 2. Redirect in DASH DIRECTION
                    // We use the Rigidbody velocity or Transform forward to determine where we are going
                    Vector3 dashDir = rb.velocity.normalized;
                    if (dashDir == Vector3.zero) dashDir = transform.forward;

                    proj.Redirect(dashDir);
                }
            }
        }
    }
}