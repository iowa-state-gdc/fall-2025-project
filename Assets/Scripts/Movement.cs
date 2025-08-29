
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 0.5f;
    
    private Vector2 input;
    private Rigidbody2D body;
    private InputSystem_Actions controls;

    void Awake()
    {
        controls = new InputSystem_Actions();
        controls.Enable();
    }

   

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        // Bind the input action
        controls.Player.Move.performed += ctx => input = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => input = Vector2.zero;
    }

    void FixedUpdate()
    {
        body.linearVelocity = input * speed;
    }
}
