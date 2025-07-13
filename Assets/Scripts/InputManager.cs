using UnityEngine;

public class InputManager
{
    private static InputManager instance;
    public static InputManager Instance => instance ??= new();

    public static MyInputActions InputActions => Instance.inputActions;

    private readonly MyInputActions inputActions;


    public InputManager()
    {
        inputActions = new();
        inputActions.Enable();
    }
}
