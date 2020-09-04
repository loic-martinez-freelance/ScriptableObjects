using UnityEngine;
using System;

[CreateAssetMenu]
public class Vector3Variable : ScriptableObject, ISerializationCallbackReceiver
{
    public Vector3 InitialValue;

    public Vector3 RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}