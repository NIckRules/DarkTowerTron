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
        public float currentFocus = 100f;
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
            if (this.woundIcon == null) Debug.LogWarning("WoundIcon is not assigned in GritAndFocus!");

            // Initialize UI. Hide Wound icon. Update visual pips.
            if (this.focusSlider != null) this.focusSlider.maxValue = this.maxFocus;
            UpdateUI();
        }

        void Update()
        {
            // Handle Focus decay. 
            if (this.currentFocus > 0)
            {
                this.currentFocus -= this.focusDecayRate * Time.deltaTime;
                if (this.currentFocus < 0) this.currentFocus = 0;

                if (this.focusSlider != null)
                    this.focusSlider.value = this.currentFocus;
            }
        }

        public void TakeDamage()
        {

            Debug.Log("PLAYER HIT!");

            // 1. If Grit > 0, decrement Grit.
            if (this.currentGrit > 0)
            {
                Debug.Log($"Grit lost! Remaining: {this.currentGrit - 1}");

                this.currentGrit--;
            }
            // 2. If Grit == 0 (and no wound), grant Wound (set wound=1)
            else if (this.wound == 0)
            {
                this.wound = 1;
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
            if (this.wound == 0)
            {
                // 2. Else, increment Grit (max 2).
                if (this.currentGrit < this.maxGrit)
                {
                    this.currentGrit++;
                }
            }

            // 3. Always add +20 Focus (reward).
            AddFocus(20f);

            UpdateUI();
        }

        public void AddFocus(float amount)
        {
            // 1. Add amount.
            this.currentFocus += amount;

            // 2. If Focus >= 100, trigger Overheat().
            if (this.currentFocus >= this.maxFocus)
            {
                this.currentFocus = this.maxFocus;
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
            if (this.currentFocus >= amount)
            {
                this.currentFocus -= amount;
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
            this.currentFocus = 0f;

            // 2. Set Grit to 1 (if currently 2). Punishment for greed!
            if (this.currentGrit > 1)
            {
                this.currentGrit = 1;
            }

            // 3. Invoke OnOverheat event (for explosion VFX).
            this.OnOverheat.Invoke();

            // 4. UpdateUI().
            UpdateUI();
        }

        void Die()
        {
            Debug.Log("PLAYER DIED");
            this.OnDeath.Invoke();
            // Disable player control?
            gameObject.SetActive(false);
        }

        void UpdateUI()
        {

            Debug.Log("Updating Grit and Focus UI");

            // 1. Loop through gritPips: enable/disable based on currentGrit.
            if (this.gritPips != null)
            {
                for (int i = 0; i < this.gritPips.Length; i++)
                {
                    if (this.gritPips[i] != null)
                    {
                        this.gritPips[i].enabled = (i < this.currentGrit);
                    }
                }
            }

            // 2. Enable woundIcon if wound > 0.
            if (this.woundIcon != null)
            {
                // Use SetActive to ensure visibility even if the GameObject was disabled
                this.woundIcon.gameObject.SetActive(this.wound > 0);
            }

            // 3. Update Slider.
            if (this.focusSlider != null)
            {
                this.focusSlider.value = this.currentFocus;
            }
        }
    }
}