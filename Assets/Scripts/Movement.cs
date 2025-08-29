
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody2D body;
    private Vector2 currentInput;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        body.linearVelocity = moveSpeed * currentInput * Time.fixedDeltaTime;
    }

    private void OnMove(InputValue value)
    {
        Vector2 playerInput = new Vector2(value.Get<Vector2>().x, value.Get<Vector2>().y);
        currentInput = playerInput;
    }
}
