using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    private PlayerInput playerInput;

    private static InputController instance;

    private Vector2 moveDirection = Vector2.zero;
    private bool interactPressed = false;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Input Controller in the scene");
        }
        instance = this;
        playerInput = GetComponent<PlayerInput>();
    }

    public static InputController GetInstance()
    {
        return instance;
    }

    public void MovePressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            moveDirection = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            moveDirection = context.ReadValue<Vector2>();
        }
    }

    public void InteractPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactPressed = true;
        }else if (context.canceled)
        {
            interactPressed = false;
        }
    }

    public bool GetInteract()
    {
        bool result = interactPressed;
        interactPressed = false;
        return result;
    }

    public Vector2 GetMoveDirection()
    {
        return moveDirection;
    }

}
