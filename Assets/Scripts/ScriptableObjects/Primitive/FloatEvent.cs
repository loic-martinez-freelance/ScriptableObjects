using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class FloatEvent : ScriptableObject
{
    private List<FloatEventListener> listeners = new List<FloatEventListener>();

    public void Raise(float arg)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised(arg);
    }

    public void RegisterListener(FloatEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(FloatEventListener listener)
    {
        listeners.Remove(listener);
    }
}