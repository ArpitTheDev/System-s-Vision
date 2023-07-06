using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Implemented as a example to showcase command design pattern but currently not used anywehere in project
public class ChangeTextureCommand : ICommand
{
    private Material part;
    private Texture oldTexture;
    private Texture newTexture;

    public ChangeTextureCommand(Material part, Texture texture)
    {
        this.part = part;
        oldTexture = part.mainTexture;
        newTexture = texture;
    }

    public void Execute()
    {
        part.mainTexture = newTexture;
    }

    public void Undo()
    {
        part.mainTexture = oldTexture;
    }
}
