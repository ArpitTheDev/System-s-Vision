using UnityEngine;

public class ModelPainter : MonoBehaviour
{
    RaycastHit hitInfo;
    Renderer currentRenderer;
    //
    public IInputStrategy input;
    public UserInteractions userInteractions;

    private void Update()
    {

        if (input.isLeftButtonPressed)
        {
            input.isLeftButtonPressed = false;
            // Cast a ray from the mouse position
            if (Physics.Raycast(Camera.main.ScreenPointToRay(input.inputPosition), out hitInfo))
            {
                // Get the renderer component of the object being painted on
                currentRenderer = hitInfo.collider.GetComponent<Renderer>();

                // Check if the object has a renderer and a texture
                if (currentRenderer != null)
                {
                    userInteractions.ExecuteCommand(new ChangeColorCommand(currentRenderer.material, input.currentSelectedColor));
                        //currentRenderer.material.color = input.currentInputStrategy.currentSelectedColor;

                }
            }
        }

    }

   

    private void OnEnable()
    {
        // Reset the current renderer and original texture
        currentRenderer = null;
    }
}
