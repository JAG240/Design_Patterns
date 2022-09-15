using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListeners : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
    //[SerializeField] private UnityEvent response;

    private void OnEnable() => gameEvent.Register(this);

    private void OnDisable() => gameEvent.Deregister(this);

    public void OnEventWalk(Vector3 pos)
    {
        GetComponent<AIStateManager>().SetDestination(pos);
    }
}