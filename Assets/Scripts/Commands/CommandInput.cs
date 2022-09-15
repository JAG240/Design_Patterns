using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInput : MonoBehaviour
{
    [SerializeField] CommandProcessor commandProcessor;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            commandProcessor.Undo();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            commandProcessor.Redo();
        }
    }
}
