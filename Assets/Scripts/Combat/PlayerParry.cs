using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerParry : MonoBehaviour
    {
        [Header("Setup")]
        public GameObject parryCollider; // The invisible hitbox (Cube)
        public Transform weaponPivot;    // The parent of the spear visuals

        [Header("Stats")]
        public float parryDuration = 0.2f;
        public float parryCooldown = 0.6f;

        private bool isParrying = false;
        private float cooldownTimer = 0;
        private PlayerStats stats;
        private Quaternion originalRotation;

        void Start()
        {
            stats = GetComponent<PlayerStats>();
            if (weaponPivot) originalRotation = weaponPivot.localRotation;

            // Ensure hitbox is off at start
            if (parryCollider) parryCollider.SetActive(false);
        }

        void Update()
        {
            if (cooldownTimer > 0) cooldownTimer -= Time.deltaTime;

            // Parry Input
            if (Input.GetMouseButtonDown(1) && !isParrying && cooldownTimer <= 0)
            {
                PerformParrySwipe();
            }
        }

        void PerformParrySwipe()
        {
            isParrying = true;
            if (parryCollider) parryCollider.SetActive(true);

            // 1. ANIMATION: The "Bat Swing"
            // Rotate from -60 to +60 degrees
            if (weaponPivot)
            {
                weaponPivot.localRotation = Quaternion.Euler(0, -60, 0);
                weaponPivot.DOLocalRotate(new Vector3(0, 60, 0), parryDuration)
                    .SetEase(Ease.OutCubic)
                    .OnComplete(FinishParry);
            }
            else
            {
                // Fallback if no pivot assigned
                Invoke(nameof(FinishParry), parryDuration);
            }
        }

        void FinishParry()
        {
            // Reset rotation
            if (weaponPivot) weaponPivot.localRotation = originalRotation;

            if (parryCollider) parryCollider.SetActive(false);
            isParrying = false;
            cooldownTimer = parryCooldown;
        }

        // --- THIS WAS MISSING ---
        public void OnSuccessfulParry()
        {
            Debug.Log("<color=green>PROJECTILE REFLECTED!</color>");

            // Reward Energy
            if (stats != null)
            {
                stats.currentEnergy += 15f; // Reward for timing
                if (stats.currentEnergy > stats.maxEnergy) stats.currentEnergy = stats.maxEnergy;
            }

            // Juice: Small Time Freeze?
            // Camera Shake?
        }
    }
}