using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/Material Collection")]
    public class MaterialCollectionSO : ScriptableObject
    {
        [Tooltip("All materials in this list will share the same color palette.")]
        public List<Material> materials;
    }
}