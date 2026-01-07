using UnityEngine;

using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Core.Feedback.Commands
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
            if (prefab == null || Global.Pool == null) return;

            // Calculate rotation
            Quaternion rot = Quaternion.identity;
            if (owner != null) rot = owner.transform.rotation;

            // Spawn
            GameObject instance = Global.Pool.Spawn(prefab, position + (rot * offset), rot);
            // Logic
            if (attachToParent && owner != null)
            {
                instance.transform.SetParent(owner.transform);
            }

            // Auto-Play Particle if it exists
            var ps = instance.GetComponent<ParticleSystem>();
            if (ps) ps.Play();
        }
    }
}