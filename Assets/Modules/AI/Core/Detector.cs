using UnityEngine;

namespace DarkTowerTron.AI.Core
{
    public abstract class Detector : MonoBehaviour
    {
        public abstract void Detect(AIData aiData);
    }
}