using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Data_Loader : AbstractDataLoader
{
    public override Dictionary<int, string> LoadData()
    {
        return LoadTextData();
    }

    public Dictionary<int, string> LoadTextData() 
    {
        string[] lines = System.IO.File.ReadAllLines(Application.dataPath + "/Data/MenuData/Text/textMenuData.txt");
        //
        menuData = new ColorData();
        //
        foreach (string line in lines)
        {
            string[] currentLineArray = line.Split(',');

            menuData.MenuItem.Add(new ColorItem(currentLineArray[0], int.Parse(currentLineArray[1])));
        }

        return GetData();

    }
}
