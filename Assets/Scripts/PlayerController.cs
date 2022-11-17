using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float jumpForce = 0f;

    Rigidbody2D rb;
    Collider2D collider2d;

    public bool isGrounded;
    public LayerMask whatIsGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(collider2d, whatIsGround);

        rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
