using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public IInputStrategy[] inputStrategies;
    public static int strategyIndex;

    public IInputStrategy currentInputStrategy;

    void Awake()
    {
        currentInputStrategy = inputStrategies[strategyIndex];

        currentInputStrategy.Activate();

        for (int i = 0; i < inputStrategies.Length; i++)
        {
            if (i != strategyIndex) 
            {
                inputStrategies[i].DeActivate();
            }
        }
    }
}
