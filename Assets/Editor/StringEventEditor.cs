using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StringEvent))]
public class StringEventEditor : Editor
{
    string arg = "";
    public override void OnInspectorGUI()
    {
        arg = EditorGUILayout.TextField("String argument", arg);
        if (GUILayout.Button("Raise event"))
        {
            (target as StringEvent).Raise(arg);
        }
    }
}