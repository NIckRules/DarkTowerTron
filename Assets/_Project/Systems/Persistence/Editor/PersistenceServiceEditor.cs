using UnityEngine;
using UnityEditor;

namespace DarkTowerTron.Systems.Persistence
{
    [CustomEditor(typeof(PersistenceService))]
    public class PersistenceServiceEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            // Draw the default Inspector (Script field, Current Slot Index)
            DrawDefaultInspector();

            // Cast the target to the correct type
            PersistenceService manager = (PersistenceService)target; // Renamed variable to match your logic

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
                // We need access to the private field _currentSlotIndex logic via public API 
                // Since _currentSlotIndex is serialized, we can read it, or just reload current.
                // Assuming Load() handles internal state:

                // Hack: If you can't access CurrentSlotIndex property, 
                // you might need to make it public or SerializeField exposes it.
                // Assuming the serialized field is editable in inspector:
                SerializedProperty slotProp = serializedObject.FindProperty("_currentSlotIndex");
                manager.Load(slotProp.intValue);
            }
            GUILayout.EndHorizontal();
        }

        private void OpenSaveFolder()
        {
            string path = Application.persistentDataPath;
            path = path.Replace(@"/", @"\"); // Windows friendly
            EditorUtility.RevealInFinder(path);
        }
    }
}