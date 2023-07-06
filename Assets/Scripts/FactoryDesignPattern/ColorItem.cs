using System;
using UnityEngine;

[Serializable]
public class ColorItem 
{
    public string color;
    public int index;

    public ColorItem(string c, int i) 
    {
        color = c;
        index = i;
    }
}
