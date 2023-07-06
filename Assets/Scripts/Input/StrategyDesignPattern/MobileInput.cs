using UnityEngine;

public class MobileInput : IInputStrategy
{

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch phase is "Began"
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width * 0.5f)
                {
                    isLeftButtonPressed = true;
                }
                else
                {
                    isRightButtonPressed = true;
                }
            }

            // Check if the touch phase is "Ended"
            if (touch.phase == TouchPhase.Ended)
            {
                if (touch.position.x < Screen.width * 0.5f)
                {
                    isLeftButtonPressed = false;
                }
                else
                {
                    isRightButtonPressed = false;
                }
            }

            // Rotate the model if the right touch is active
            if (isRightButtonPressed)
            {
                rotationX -= touch.deltaPosition.x;
                rotationY -= touch.deltaPosition.y;
            }
        }

        // Zoom in and out using pinch gesture
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;
            Vector2 touch2PrevPos = touch2.position - touch2.deltaPosition;

            float prevTouchDeltaMag = (touch1PrevPos - touch2PrevPos).magnitude;
            float touchDeltaMag = (touch1.position - touch2.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            scroll += deltaMagnitudeDiff;

        }
    }
}
