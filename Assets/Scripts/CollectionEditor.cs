using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObjectCollection))]
public class CollectionEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Draw the default
        base.OnInspectorGUI();

        // Place the button at the bottom
        ObjectCollection myScript = (ObjectCollection)target;
        if (GUILayout.Button("Update Collection"))
        {
            myScript.UpdateCollection();
        }
    }
}

