
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 10f;        
    [SerializeField] private float acceleration = 10f;   
    [SerializeField] private float deceleration = 1f;   
    private Rigidbody2D body;
    private Vector2 currentInput;
    private Vector2 velocity;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Target velocity based on input
        Vector2 targetVelocity = currentInput * maxSpeed;
        float rate = (currentInput.magnitude > 0) ? acceleration : deceleration;
        velocity = Vector2.MoveTowards(velocity, targetVelocity, rate * Time.fixedDeltaTime);
        body.linearVelocity = velocity;
    }

    private void OnMove(InputValue value)
    {
        currentInput = value.Get<Vector2>().normalized;
    }
}
