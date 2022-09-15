using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Entity : MonoBehaviour, IEntity
{
    private NavMeshAgent navMeshAgent;
    public CommandProcessor commandProcessor;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 pos)
    {
        navMeshAgent.SetDestination(pos);
    }
}
