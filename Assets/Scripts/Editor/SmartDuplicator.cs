using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace DarkTowerTron.EditorTools
{
    public class SmartDuplicator : Editor
    {
        [MenuItem("Edit/Smart Duplicate %#d")]
        public static void DuplicateWithNaming()
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            if (selectedObjects.Length == 0) return;

            Undo.IncrementCurrentGroup();
            int undoIndex = Undo.GetCurrentGroup();

            System.Collections.Generic.List<GameObject> newSelection = new System.Collections.Generic.List<GameObject>();

            foreach (GameObject original in selectedObjects)
            {
                // FIX: Use standard Instantiate. 
                // In the Editor, this preserves the Prefab connection (Blue Text) automatically.
                GameObject clone = Instantiate(original, original.transform.parent);

                // Register Undo so Ctrl+Z removes the object
                Undo.RegisterCreatedObjectUndo(clone, "Smart Duplicate");

                // Match Transform
                clone.transform.localPosition = original.transform.localPosition;
                clone.transform.localRotation = original.transform.localRotation;
                clone.transform.localScale = original.transform.localScale;

                // Calculate Name
                string newName = IncrementName(original.name);
                clone.name = newName;

                newSelection.Add(clone);
            }

            // Select the new objects
            Selection.objects = newSelection.ToArray();
            Undo.CollapseUndoOperations(undoIndex);
        }

        private static string IncrementName(string originalName)
        {
            // Regex to find a number at the end (e.g. "_01" or " 1")
            Match match = Regex.Match(originalName, @"^(.*?)(\d+)$");

            if (match.Success)
            {
                string prefix = match.Groups[1].Value;
                string numberStr = match.Groups[2].Value;

                if (int.TryParse(numberStr, out int number))
                {
                    number++;
                    // Keep the leading zeros format (01 -> 02)
                    string newNumberStr = number.ToString(new string('0', numberStr.Length));
                    return prefix + newNumberStr;
                }
            }

            // Fallback: If no number found, add "_1"
            return originalName + "_1";
        }
    }
}