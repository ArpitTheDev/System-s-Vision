using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCInput : IInputStrategy
{


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isLeftButtonPressed = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isLeftButtonPressed = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            isRightButtonPressed = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            isRightButtonPressed = false;
        }

        if (isRightButtonPressed)
        {
            rotationX = Input.GetAxis("Mouse X");
            rotationY = Input.GetAxis("Mouse Y");
        }

        scroll = Input.GetAxis("Mouse ScrollWheel");
        inputPosition = Input.mousePosition;
    }
}
