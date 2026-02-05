using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public InputActionReference action;

    public Transform insidePoint;
    public Transform outsidePoint;

    private bool isOutside = false;

    void Start()
    {
        action.action.Enable();

        action.action.performed += (ctx) =>
        {
            if (isOutside)
            {
                transform.position = insidePoint.position;
                transform.rotation = insidePoint.rotation;
            }
            else
            {
                transform.position = outsidePoint.position;
                transform.rotation = outsidePoint.rotation;
            }

            isOutside = !isOutside;
        };
    }
}
