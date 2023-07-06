using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void SetColor(Color color);

    public static event SetColor SetInputColor;

    public static void TriggerSetInputColor(Color color)
    {
        if (SetInputColor != null)
        {
            SetInputColor(color);
        }
    }

    
}
