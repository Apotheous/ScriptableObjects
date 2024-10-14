using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GameEventsListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }  
    private void OnDisable()
    {
        Event.UnRegisterListener(this);
    }
    public void OnEventRaised()
    {
        response.Invoke();
    }
}
