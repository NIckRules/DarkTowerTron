using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    // This line forces Unity to add PlayerStats if you add PlayerParry
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerParry : MonoBehaviour
    {
        [Header("Setup")]
        public GameObject parryShieldObj;

        [Header("Stats")]
        public float parryWindow = 0.25f;
        public float cooldown = 0.5f;

        private bool isParrying = false;
        private float cooldownTimer = 0;
        private PlayerStats stats; // Cache it!

        void Start()
        {
            stats = GetComponent<PlayerStats>();
        }

        void Update()
        {
            if (cooldownTimer > 0) cooldownTimer -= Time.deltaTime;

            if (Input.GetMouseButtonDown(1) && !isParrying && cooldownTimer <= 0)
            {
                StartCoroutine(PerformParry());
            }
        }

        System.Collections.IEnumerator PerformParry()
        {
            isParrying = true;
            parryShieldObj.SetActive(true);
            Debug.Log("<color=cyan>PARRY ACTIVE</color>");

            yield return new WaitForSeconds(parryWindow);

            parryShieldObj.SetActive(false);
            isParrying = false;
            cooldownTimer = cooldown;
        }

        public void OnSuccessfulParry()
        {
            Debug.Log("<color=green>PARRY SUCCESS!</color>");
            // Safely add energy
            if (stats != null)
            {
                stats.currentEnergy += 10f;
                // Clamp it just in case
                if (stats.currentEnergy > stats.maxEnergy) stats.currentEnergy = stats.maxEnergy;
            }
        }
    }
}