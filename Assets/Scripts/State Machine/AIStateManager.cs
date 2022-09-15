using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AIStateManager : MonoBehaviour
{
    [SerializeField] AIClass aiClass;
    private Material[] materials;
    AIBaseState currentState;
    public AIIdelState idleState = new AIIdelState();
    public AIWaitState waitState = new AIWaitState();
    public AIWalkState walkState = new AIWalkState();

    private Entity entity;

    void Start()
    {
        materials = aiClass.materials;
        entity = GetComponent<Entity>();
        currentState = idleState;

        currentState.EnterState(this, materials);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnMouseDown()
    {
        currentState.Selected(this);
    }

    public void SwitchState(AIBaseState newState)
    {
        currentState = newState;
        currentState.EnterState(this, materials);
    }

    public void SwitchState(AIBaseState newState, Vector3 pos, Entity entity)
    {
        currentState = newState;
        currentState.EnterState(this, materials);
        currentState.SetDestination(this, pos, entity);
    }

    public void SetDestination(Vector3 pos)
    {
        currentState.SetDestination(this, pos, entity);
    }
}
