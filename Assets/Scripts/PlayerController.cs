using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MyInputActions inputActions;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions = new();
        inputActions.Player.Move.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)inputActions.Player.Move.ReadValue<Vector2>() * Time.deltaTime;
    }
}
