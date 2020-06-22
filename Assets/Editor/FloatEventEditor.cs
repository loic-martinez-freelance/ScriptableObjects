using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FloatEvent))]
public class FloatEventEditor : Editor
{
    int arg = 0;
    public override void OnInspectorGUI()
    {
        arg = EditorGUILayout.IntField("Float argument", arg);
        if (GUILayout.Button("Raise event"))
        {
            (target as FloatEvent).Raise(arg);
        }
    }
}