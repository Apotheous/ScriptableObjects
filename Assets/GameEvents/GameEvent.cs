using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventsListener> listeners = new List<GameEventsListener>();


    public void RegisterListener(GameEventsListener listener)
    {
        listeners.Add(listener);
    }  
    public void UnRegisterListener(GameEventsListener listener)
    {
        listeners.Remove(listener);
    }

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }
}
