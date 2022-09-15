using UnityEngine;

public abstract class AIBaseState
{
    public abstract void EnterState(AIStateManager AI, Material[] materials);
    public abstract void UpdateState(AIStateManager AI);
    public abstract void Selected(AIStateManager AI);
    public abstract void SetDestination(AIStateManager AI, Vector3 pos, Entity entity);
}