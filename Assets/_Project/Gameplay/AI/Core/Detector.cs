using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class Detector : MonoBehaviour
    {
        public abstract void Detect(AIData aiData);
    }
}