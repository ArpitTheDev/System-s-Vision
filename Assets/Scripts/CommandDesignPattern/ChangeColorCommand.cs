using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCommand : ICommand
{
    private Material part;
    private Color oldColor;
    private Color newColor;

    public ChangeColorCommand(Material part, Color color)
    {
        this.part = part;
        oldColor = part.color;
        newColor = color;
    }

    public void Execute()
    {
        part.color = newColor;
    }

    public void Undo()
    {
        part.color = oldColor;
    }
}