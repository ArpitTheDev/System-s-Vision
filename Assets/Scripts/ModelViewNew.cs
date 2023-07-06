using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class ModelViewNew : MonoBehaviour
{
    public float rotationSpeed = 10f; // Rotation speed
    public float zoomSpeed = 2f; // Zoom speed
    private float zoomDistance = 0f; // Distance for zooming

    public float minZoomDistance;
    public float maxZoomDistance;
    private bool isRotating;

    public IInputStrategy input;

    float rotationX;
    float rotationY;



    void Update()
    {
        // Check for mouse button down
        if (input.isRightButtonPressed)
        {
            isRotating = true;
        }
         
        // Check for mouse button release
        if (!input.isRightButtonPressed)
        {
            isRotating = false;
        }

        // Rotate the model if the mouse button is held down
        if (isRotating)
        {
            rotationX -= input.rotationX * rotationSpeed * Time.deltaTime;
            rotationY -= input.rotationY * rotationSpeed * Time.deltaTime;

            // Apply rotation to the object
            transform.rotation = Quaternion.Euler(rotationY, rotationX, 0f);
        }

        float scroll;
        scroll = input.scroll;
        // Zoom in and out using the scroll wheel
        zoomDistance += scroll * zoomSpeed * Time.deltaTime;

        // Limit the zoom distance to prevent going too close or too far
        zoomDistance = Mathf.Clamp(zoomDistance, minZoomDistance, maxZoomDistance);

        // Apply the zoom distance to the object's position
        transform.localPosition = new Vector3(0f, 0f, zoomDistance);
    }
}
