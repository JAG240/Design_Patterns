using UnityEngine;

public class AIWaitState : AIBaseState
{
    public override void EnterState(AIStateManager AI, Material[] materials)
    {
        AI.GetComponent<MeshRenderer>().material = materials[1];
    }

    public override void UpdateState(AIStateManager AI)
    {
        //do nothing
    }

    public override void Selected(AIStateManager AI)
    {
        AI.SwitchState(AI.idleState);
    }
    public override void SetDestination(AIStateManager AI, Vector3 pos, Entity entity)
    {
        AI.SwitchState(AI.walkState, pos, entity);
    }
}
