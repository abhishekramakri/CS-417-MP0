using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;

    private Light pointLight;
    private bool isWhite = true;

    void Start()
    {
        pointLight = GetComponent<Light>();
        action.action.Enable();

        action.action.performed += (ctx) =>
        {
            if (isWhite)
                pointLight.color = Color.red;
            else
                pointLight.color = Color.white;

            isWhite = !isWhite;
        };
    }
}
