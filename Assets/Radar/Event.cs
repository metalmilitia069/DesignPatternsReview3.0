using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;


[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    private List<Listener> eventListeners = new List<Listener>();

    public void Register(Listener listener)
    {
        eventListeners.Add(listener);
    }

    public void Unregister(Listener listener)
    {
        eventListeners.Remove(listener);
    }

    public void Occurred(GameObject gameObject)
    {
        for (int i = 0; i < eventListeners.Count; i++)
        {
            eventListeners[i].OnEventOccurs(gameObject);
        }
    }
}
