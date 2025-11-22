using UnityEngine;

namespace DarkTowerTron.Player
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Health (Hearts)")]
        public int maxHealth = 3;
        public int currentHealth;

        [Header("Voltage (Energy)")]
        public float maxEnergy = 100f;
        public float currentEnergy = 0f;
        public float energyDecayRate = 5f; // Drops 5 per second
        public float energyGainPerKill = 30f;

        [Header("Status")]
        public bool isInvincible = false; // NEW

        void Start()
        {
            currentHealth = maxHealth;
        }

        void Update()
        {
            // Energy Decay (The timer ticking down)
            if (currentEnergy > 0)
            {
                currentEnergy -= energyDecayRate * Time.deltaTime;
                // Clamp to 0
                if (currentEnergy < 0) currentEnergy = 0;
            }
        }

        // Called by Enemy when Executed
        public void OnGloryKill()
        {
            if (currentHealth < maxHealth)
            {
                currentHealth++;
                Debug.Log($"<color=green>HEALED! HP: {currentHealth}</color>");
            }
            else
            {
                currentEnergy += energyGainPerKill;
                if (currentEnergy > maxEnergy) currentEnergy = maxEnergy;
                Debug.Log($"<color=cyan>OVERCHARGE! Voltage: {currentEnergy}</color>");
            }
        }

        public void TakeDamage(int dmg)
        {
            // NEW: Ignore damage if invincible
            if (isInvincible) return;

            currentHealth -= dmg;
            Debug.Log($"<color=red>OUCH! HP: {currentHealth}</color>");

            if (currentHealth <= 0) Die();
        }

        void Die()
        {
            Debug.Log("SYSTEM FAILURE - GAME OVER");
            // For prototype, just reload scene or pause
            Time.timeScale = 0;
        }

        // Simple Debug GUI to see stats without building UI yet
        void OnGUI()
        {
            GUI.color = Color.white;
            GUI.Label(new Rect(10, 10, 200, 20), $"HP: {currentHealth} / {maxHealth}");
            GUI.Label(new Rect(10, 30, 200, 20), $"VOLTAGE: {currentEnergy:F1}");
        }
    }
}