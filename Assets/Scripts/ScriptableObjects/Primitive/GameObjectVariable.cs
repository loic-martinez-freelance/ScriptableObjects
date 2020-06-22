using UnityEngine;
using System;

[CreateAssetMenu]
public class GameObjectVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public GameObject InitialValue;

    public GameObject RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}