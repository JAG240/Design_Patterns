using UnityEngine;
using UnityEngine.AI;

public class AIWalkState : AIBaseState
{
    NavMeshAgent navMeshAgent;

    public override void EnterState(AIStateManager AI, Material[] materials)
    {
        AI.GetComponent<MeshRenderer>().material = materials[2];
        navMeshAgent = AI.GetComponent<NavMeshAgent>();
    }

    public override void UpdateState(AIStateManager AI)
    {
        if(navMeshAgent.hasPath)
        {
            if(navMeshAgent.remainingDistance < 0.5)
            {
                navMeshAgent.isStopped = true;
                navMeshAgent.ResetPath();
                AI.SwitchState(AI.idleState);
            }
        }
    }

    public override void Selected(AIStateManager AI)
    {
        //do nothing 
    }
    public override void SetDestination(AIStateManager AI, Vector3 pos, Entity entity)
    {
        if(!navMeshAgent.hasPath)
        {
            MoveCommand command = new MoveCommand(entity, pos);
            entity.commandProcessor.ExecuteCommand(command);
        }
    }
}
