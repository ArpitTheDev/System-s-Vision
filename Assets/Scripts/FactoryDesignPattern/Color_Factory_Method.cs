using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Factory_Method
{
    public AbstractDataLoader GenerateData(string fileSystemToUse)
    {
        AbstractDataLoader dataLoader;

        switch (fileSystemToUse)
        {
            case "JsonData":
                dataLoader = new Json_Data_Loader();
                break;

            case "TextData":
                dataLoader = new Text_Data_Loader();
                break;
            
            // using Json as default as its the best if we are planning to use web services in future
            // json is mostly used as its light weight and easy to organise data

            default:
                dataLoader = new Json_Data_Loader();
                break;

        }

        return dataLoader;
    }

}
