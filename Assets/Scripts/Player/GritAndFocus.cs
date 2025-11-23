using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace DarkTowerTron.Player
{
    public class GritAndFocus : MonoBehaviour
    {
        [Header("Grit (Health)")]
        // 0-2 pips. Lost on hit. Healed ONLY by killing Staggered enemy.
        public int currentGrit = 2;
        public int maxGrit = 2;
        // 0-1. Gained when Grit reaches -1. Unhealable. Next hit = Death.
        public int wound = 0;

        [Header("Focus (Energy)")]
        // 0-100. Decays over time. Spent on Blitz.
        public float currentFocus = 0f;
        public float maxFocus = 100f;
        public float focusDecayRate = 5f;

        [Header("UI Bindings")]
        public Slider focusSlider;
        public Image[] gritPips; // Array of 2 images
        public Image woundIcon;  // The red skull

        [Header("Events")]
        public UnityEvent OnDeath; // Hook for WaveManager
        public UnityEvent OnOverheat; // Hook for AoE explosion

        void Start()
        {
            // Initialize UI. Hide Wound icon. Update visual pips.
            if (focusSlider != null) focusSlider.maxValue = maxFocus;
            UpdateUI();
        }

        void Update()
        {
            // Handle Focus decay. 
            if (currentFocus > 0)
            {
                currentFocus -= focusDecayRate * Time.deltaTime;
                if (currentFocus < 0) currentFocus = 0;

                if (focusSlider != null)
                    focusSlider.value = currentFocus;
            }
        }

        public void TakeDamage()
        {
            // 1. If Grit > 0, decrement Grit.
            if (currentGrit > 0)
            {
                currentGrit--;
            }
            // 2. If Grit == 0 (and no wound), grant Wound (set wound=1)
            else if (wound == 0)
            {
                wound = 1;
                Debug.Log("<color=red>WOUNDED! Next hit is fatal.</color>");
            }
            // 3. If Grit == 0 (and HAS wound), call Die().
            else
            {
                Die();
            }

            UpdateUI();
        }

        public void HealGrit()
        {
            // 1. If Wound is active, do NOT heal Grit (Wounds are permanent).
            if (wound == 0)
            {
                // 2. Else, increment Grit (max 2).
                if (currentGrit < maxGrit)
                {
                    currentGrit++;
                }
            }

            // 3. Always add +20 Focus (reward).
            AddFocus(20f);

            UpdateUI();
        }

        public void AddFocus(float amount)
        {
            // 1. Add amount.
            currentFocus += amount;

            // 2. If Focus >= 100, trigger Overheat().
            if (currentFocus >= maxFocus)
            {
                currentFocus = maxFocus;
                Overheat();
            }
            else
            {
                UpdateUI();
            }
        }

        public bool SpendFocus(float amount)
        {
            // 1. If current >= amount, subtract and return true.
            if (currentFocus >= amount)
            {
                currentFocus -= amount;
                UpdateUI();
                return true;
            }

            // 2. Else return false.
            return false;
        }

        void Overheat()
        {
            Debug.Log("<color=orange>OVERHEAT! Focus Reset. Grit Damaged.</color>");

            // 1. Reset Focus to 0.
            currentFocus = 0f;

            // 2. Set Grit to 1 (if currently 2). Punishment for greed!
            if (currentGrit > 1)
            {
                currentGrit = 1;
            }

            // 3. Invoke OnOverheat event (for explosion VFX).
            OnOverheat.Invoke();

            // 4. UpdateUI().
            UpdateUI();
        }

        void Die()
        {
            Debug.Log("PLAYER DIED");
            OnDeath.Invoke();
            // Disable player control?
            gameObject.SetActive(false);
        }

        void UpdateUI()
        {
            // 1. Loop through gritPips: enable/disable based on currentGrit.
            if (gritPips != null)
            {
                for (int i = 0; i < gritPips.Length; i++)
                {
                    if (gritPips[i] != null)
                    {
                        gritPips[i].enabled = (i < currentGrit);
                    }
                }
            }

            // 2. Enable woundIcon if wound > 0.
            if (woundIcon != null)
            {
                woundIcon.enabled = (wound > 0);
            }

            // 3. Update Slider.
            if (focusSlider != null)
            {
                focusSlider.value = currentFocus;
            }
        }
    }
}