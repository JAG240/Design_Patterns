using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    private List<Command> commands = new List<Command>();
    private int currentCommand;

    public void ExecuteCommand(Command command)
    {
        if (commands.Count - 1 > currentCommand)
            commands[currentCommand + 1] = command;
        else
            commands.Add(command);

        command.Execute();
        currentCommand = commands.Count - 1;
    }

    public void Undo()
    {
        if (currentCommand < 0)
            return;

        commands[currentCommand].Undo();
        currentCommand--;
    }

    public void Redo()
    {
        if (commands.Count  - 1 < currentCommand + 1)
            return;

        commands[currentCommand + 1].Execute();
        currentCommand++;
    }
}
