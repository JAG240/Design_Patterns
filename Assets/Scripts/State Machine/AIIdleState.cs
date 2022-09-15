using UnityEngine;
using UnityEngine.AI;

public class AIIdelState : AIBaseState
{
    NavMeshAgent navMeshAgent;

    public override void EnterState(AIStateManager AI, Material[] materials)
    {
        AI.GetComponent<MeshRenderer>().material = materials[0];
        navMeshAgent = AI.GetComponent<NavMeshAgent>();
    }

    public override void UpdateState(AIStateManager AI)
    {
        if(navMeshAgent.hasPath)
            AI.SwitchState(AI.walkState);
    }

    public override void Selected(AIStateManager AI)
    {
        AI.SwitchState(AI.waitState);
    }
    public override void SetDestination(AIStateManager AI, Vector3 pos, Entity entity)
    {
        //do nothing
    }
}
