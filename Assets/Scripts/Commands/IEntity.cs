using UnityEngine;
using UnityEngine.AI;

public interface IEntity
{
    Transform transform { get; }
    GameObject gameObject { get; }
    void MoveTo( Vector3 pos);
}
