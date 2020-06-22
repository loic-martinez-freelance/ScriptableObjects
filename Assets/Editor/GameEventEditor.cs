using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Raise event"))
        {
            (target as GameEvent).Raise();
        }
    }
}