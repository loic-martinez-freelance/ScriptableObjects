using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class StringEvent : ScriptableObject
{
    private List<StringEventListener> listeners = new List<StringEventListener>();

    public void Raise(string arg)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised(arg);
    }

    public void RegisterListener(StringEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(StringEventListener listener)
    {
        listeners.Remove(listener);
    }
}