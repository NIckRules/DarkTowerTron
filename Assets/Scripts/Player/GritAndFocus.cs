using UnityEngine;
using UnityEngine.UI;

namespace DarkTowerTron.Player
{
    public class GritAndFocus : MonoBehaviour
    {
        [Header("Grit (Health)")]
        public int currentGrit = 2;
        public int maxGrit = 2;
        public bool hasWound = false;

        [Header("Focus (Energy)")]
        public float currentFocus = 100f;
        public float maxFocus = 100f;
        public float focusDecayRate = 5f;
        
        // NEW: Fairness toggle
        public bool isCombatActive = false; 

        [Header("UI Bindings")]
        public Slider focusSlider;
        public Image[] gritPips; 
        public Image woundIcon; 

        void Start()
        {
            currentFocus = 100f;
            currentGrit = maxGrit;
            UpdateUI();
        }

        void Update()
        {
            // NEW: Only decay if combat is ON
            if (isCombatActive && currentFocus > 0)
            {
                float decay = focusDecayRate * Time.deltaTime;
                currentFocus -= decay;
                if (currentFocus < 0) currentFocus = 0;
                
                // Update slider every frame during decay for smoothness
                if(focusSlider) focusSlider.value = currentFocus;
            }
        }

        // Called by WaveManager
        public void SetCombatState(bool state)
        {
            isCombatActive = state;
        }

        // ... (Keep TakeDamage, HealGrit, AddFocus, SpendFocus, Die as they were) ...
        // If you need me to repost those methods, let me know, otherwise keep existing logic.
        
        public void TakeDamage() 
        {
             // Use the "Logic Check" version from our previous fix
             if (currentGrit > 0) currentGrit--;
             else if (!hasWound) hasWound = true;
             else Die();
             UpdateUI();
        }
        
        public void HealGrit()
            {
                if(!hasWound) currentGrit = Mathf.Min(currentGrit + 1, maxGrit);
                
                // REWARD BUFF:
                // Old: +20 Focus (Not even 1 dash)
                // New: +40 Focus (Almost 2 dashes)
                // This encourages "Dash -> Kill -> Dash" loops.
                AddFocus(40f); 
                
                UpdateUI();
            }
            
        public void AddFocus(float amount)
        {
            currentFocus += amount;
            // Clamp (Future: Trigger Overheat here)
            if (currentFocus > maxFocus) currentFocus = maxFocus;
            UpdateUI();
        }

        public bool SpendFocus(float amount)
        {
            if (currentFocus >= amount)
            {
                currentFocus -= amount;
                UpdateUI();
                return true;
            }
            return false;
        }

        void Die()
        {
            Debug.Log("<color=red>PLAYER DIED</color>");
            
            // Find the session manager and trigger game over
            var session = FindObjectOfType<DarkTowerTron.Utils.GameSession>();
            if (session != null)
            {
                session.TriggerGameOver();
            }
        }

        void UpdateUI()
        {
            if (gritPips != null)
            {
                Color active = Color.white;
                Color inactive = new Color(0.2f, 0.2f, 0.2f, 0.5f);
                
                if (gritPips.Length > 0) gritPips[0].color = (currentGrit >= 1) ? active : inactive;
                if (gritPips.Length > 1) gritPips[1].color = (currentGrit >= 2) ? active : inactive;
            }
            if (woundIcon) woundIcon.gameObject.SetActive(hasWound);
            if (focusSlider) focusSlider.value = currentFocus;
        }
    }
}