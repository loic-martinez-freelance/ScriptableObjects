using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventFloat : UnityEvent<float> { }

public class FloatEventListener : MonoBehaviour
{
    public FloatEvent Event;
    public UnityEventFloat Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(float arg)
    {
        Response.Invoke(arg);
    }
}