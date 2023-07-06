using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IInputStrategy : MonoBehaviour
{
    public bool isLeftButtonPressed;
    public bool isRightButtonPressed;
    public float rotationX;
    public float rotationY;
    public float scroll;
    public Vector2 inputPosition;

    public Color currentSelectedColor = Color.white;

    private void OnEnable()
    {
        EventManager.SetInputColor += SetInputColor;
    }

    private void OnDisable()
    {
        EventManager.SetInputColor -= SetInputColor;
    }

    void SetInputColor(Color color) 
    {
        currentSelectedColor = color;
    } 

    public void Activate() 
    {
        gameObject.SetActive(true);
    }

    public void DeActivate()
    {
        gameObject.SetActive(false);
    }
}
