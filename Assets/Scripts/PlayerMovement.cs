using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from arrow keys or WASD
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize(); // Ensures consistent speed in diagonal movement
    }

    void FixedUpdate()
    {
        // Move the character using Rigidbody2D
        rb.velocity = movement * moveSpeed;
    }
}
