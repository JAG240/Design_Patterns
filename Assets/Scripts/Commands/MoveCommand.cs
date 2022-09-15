using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private Vector3 pos;
    private Vector3 undoPos;

    public MoveCommand(IEntity entity, Vector3 pos) : base(entity)
    {
        this.pos = pos;
    }

    public override void Execute()
    {
        undoPos = new Vector3(entity.transform.position.x, entity.transform.position.y, entity.transform.position.z);
        entity.MoveTo(pos);
    }

    public override void Undo()
    {
        entity.MoveTo(undoPos);
    }
}