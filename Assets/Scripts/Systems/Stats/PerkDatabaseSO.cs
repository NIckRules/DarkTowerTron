using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Stats
{
    [CreateAssetMenu(fileName = "DB_AllPerks", menuName = "DarkTowerTron/Stats/Perk Database")]
    public class PerkDatabaseSO : ScriptableObject
    {
        public List<PerkSO> commonPerks;
        public List<PerkSO> rarePerks;

        // Helper to get random cards
        public List<PerkSO> GetRandomHand(int count)
        {
            List<PerkSO> hand = new List<PerkSO>();
            List<PerkSO> pool = new List<PerkSO>(commonPerks);

            // Simple logic: Add rares if lucky (50% chance to include rares in the pool)
            if (Random.value > 0.5f) pool.AddRange(rarePerks);

            for (int i = 0; i < count; i++)
            {
                if (pool.Count == 0) break;

                int idx = Random.Range(0, pool.Count);
                hand.Add(pool[idx]);
                pool.RemoveAt(idx); // Prevent duplicates in same hand
            }
            return hand;
        }
    }
}