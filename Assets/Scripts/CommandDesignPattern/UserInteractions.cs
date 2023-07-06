using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInteractions : MonoBehaviour
{
    private Stack<ICommand> executedCommands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
       /* if (executedCommands.Count > 0 && executedCommands.Peek(). == command)
            return;*/

        command.Execute();
        executedCommands.Push(command);
    }
    public void Undo()
    {
        if (executedCommands.Count > 0)
        {
            ICommand command = executedCommands.Pop();
            command.Undo();
        }
    }
}