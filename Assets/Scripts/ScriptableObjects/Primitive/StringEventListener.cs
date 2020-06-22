using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventString : UnityEvent<string> { }

public class StringEventListener : MonoBehaviour
{
    public StringEvent Event;
    public UnityEventString Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(string arg)
    {
        Response.Invoke(arg);
    }
}