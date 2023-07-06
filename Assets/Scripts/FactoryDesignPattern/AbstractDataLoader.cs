using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractDataLoader
{
    public ColorData menuData;

    public Dictionary<int, string> dicColor = new Dictionary<int, string>();
    public abstract Dictionary<int, string> LoadData();

    public Dictionary<int, string> GetData()
    {
        dicColor.Clear();

        foreach (ColorItem mt in menuData.MenuItem)
        {
              //Debug.Log(mt.color);
              //Debug.Log(mt.index);
            dicColor.Add(mt.index, mt.color);
        }

        return dicColor;
    }
}