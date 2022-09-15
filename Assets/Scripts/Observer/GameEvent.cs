using System.Collections.Generic;
using UnityEngine;

//Makes this an object that can be created in unity like any other object
[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)]

public class GameEvent : ScriptableObject
{
    //Hash Set of all listeners to call out for an event 
    private HashSet<GameEventListeners> listeners = new HashSet<GameEventListeners>();

    //This is any  method or event that you want to happpen
    public void Walk(Vector3 pos)
    {
        foreach(var GameObjListener in listeners)
        {
            GameObjListener.OnEventWalk(pos);
        }
    }

    //Register the game object as a listener 
    public void Register(GameEventListeners gameEventListeners) => listeners.Add(gameEventListeners);

    //Deregister the game obeject as a listener
    public void Deregister(GameEventListeners gameEventListeners) => listeners.Remove(gameEventListeners);
}