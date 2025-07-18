using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = InputManager.InputActions.Player.Move.ReadValue<Vector2>();
        transform.position += (Vector3)moveInput * Time.deltaTime;
    }
}
