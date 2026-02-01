using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.AudioSystem;
using DarkTowerTron.Core;

namespace DarkTowerTron.Gameplay.Environment
{
    [System.Serializable]
    public struct WallDefinition
    {
        public SocketCategory category;
        public GameObject prefab;
    }

    // NEW: Force a Rigidbody so child colliders report to this script
    [RequireComponent(typeof(Rigidbody))]
    public class Zone : MonoBehaviour
    {
        [Header("Zone Identity")]
        public string zoneID;
        public PaletteDefinitionSO palette;

        [Header("Ambience")]
        public MusicProfileSO zoneMusicProfile;

        [Header("Building Blocks")]
        public float tileSize = 5f;
        [Tooltip("Define which prefab spawns for each socket type.")]
        public List<WallDefinition> wallSet = new List<WallDefinition>();

        [Header("Connections")]
        [SerializeField] private Transform _entryPoint;
        [SerializeField] private Transform _exitPoint;
        [SerializeField] private Bounds _bounds = new Bounds(Vector3.zero, new Vector3(25, 10, 25));

        public Transform EntryPoint => _entryPoint;
        public Transform ExitPoint => _exitPoint;
        public Bounds Bounds => _bounds;

        private void Awake()
        {
            // Auto-configure the Rigidbody for static compound usage
            var rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;
            rb.useGravity = false;
        }

        // --- AUDIO TRIGGER (Fires when Player hits ANY child collider) ---
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(GameConstants.TAG_PLAYER) && zoneMusicProfile != null)
            {
                var audio = ServiceLocator.Get<IAudioService>();
                if (audio != null)
                {
                    audio.PlayMusicProfile(zoneMusicProfile);
                }
            }
        }

        // ... GetWallPrefab, SnapTiles, OnDrawGizmos remain the same ...
        public GameObject GetWallPrefab(SocketCategory category)
        {
            foreach (var def in wallSet)
            {
                if (def.category == category) return def.prefab;
            }
            if (category != SocketCategory.Wall_Straight_5x5)
                return GetWallPrefab(SocketCategory.Wall_Straight_5x5);
            return null;
        }

        [ContextMenu("Snap Child Tiles")]
        public void SnapTiles()
        {
            var tileComponents = GetComponentsInChildren<TileInfo>();
            foreach (var tile in tileComponents)
            {
                Transform t = tile.transform;
                Vector3 localPos = t.localPosition;
                localPos.x = Mathf.Round(localPos.x / tileSize) * tileSize;
                localPos.z = Mathf.Round(localPos.z / tileSize) * tileSize;
                localPos.y = 0;
                t.localPosition = localPos;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 1, 0, 0.3f);
            Gizmos.DrawWireCube(transform.position + _bounds.center, _bounds.size);
        }
    }
}