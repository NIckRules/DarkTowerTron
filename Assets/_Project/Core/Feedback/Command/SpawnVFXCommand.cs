using UnityEngine;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Spawn VFX")]
    public class SpawnVFXCommand : FeedbackCommand
    {
        public GameObject prefab;
        public bool attachToParent = false;

        [Tooltip("Offset relative to the position rotation.")]
        public Vector3 offset = Vector3.zero;

        public override void Execute(GameObject owner, Vector3 position)
        {
            // 1. Get Service
            var pool = ServiceLocator.Get<IPoolService>();

            if (prefab == null || pool == null) return;

            // 2. Calculate rotation
            Quaternion rot = Quaternion.identity;
            if (owner != null) rot = owner.transform.rotation;

            // 3. Spawn
            GameObject instance = pool.Spawn(prefab, position + (rot * offset), rot);

            // 4. Logic
            if (attachToParent && owner != null)
            {
                instance.transform.SetParent(owner.transform);
            }

            // 5. Auto-Play Particle if it exists
            var ps = instance.GetComponent<ParticleSystem>();
            if (ps) ps.Play();
        }
    }
}