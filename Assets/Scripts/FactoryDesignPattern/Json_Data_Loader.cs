using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Json_Data_Loader : AbstractDataLoader
{
    public override Dictionary<int, string> LoadData()
    {
        return LoadJsonData();
    }

    public Dictionary<int, string> LoadJsonData()
    {
        using (StreamReader r = new StreamReader(Application.dataPath + "/Data/MenuData/Json/jsonMenuData.json"))
        {
            string json = r.ReadToEnd();
            //
            menuData = JsonUtility.FromJson<ColorData>(json);
        }

        return GetData();
    }
}
