using UnityEngine;
using UnityEditor;
using System.Diagnostics; // For Process.Start

namespace DarkTowerTron.Systems.Persistence
{
    [CustomEditor(typeof(PersistenceManager))]
    public class PersistenceManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            // Draw the default Inspector (Script field, Current Slot Index)
            DrawDefaultInspector();

            PersistenceManager manager = (PersistenceManager)target;

            GUILayout.Space(10);

            // --- The Magic Button ---
            if (GUILayout.Button("📂 Open Save Folder", GUILayout.Height(30)))
            {
                OpenSaveFolder();
            }

            // --- Debug Controls ---
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Save Now"))
            {
                manager.Save();
            }
            if (GUILayout.Button("Load Now"))
            {
                manager.Load(manager.CurrentSlotIndex);
            }
            GUILayout.EndHorizontal();
        }

        private void OpenSaveFolder()
        {
            string path = Application.persistentDataPath;

            // Cross-platform open
            path = path.Replace(@"/", @"\"); // Windows friendly

            // Reveal in Explorer/Finder
            EditorUtility.RevealInFinder(path);
        }
    }
}