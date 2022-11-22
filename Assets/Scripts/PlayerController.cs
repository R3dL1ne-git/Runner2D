using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float jumpVelocity = 0f;

    public GameManager gm;
    Rigidbody2D rb;
    Collider2D collider2d;

    public bool isGrounded;
    public LayerMask whatIsGround;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.collider.tag == "Obstacle")
        //{
        //    gm.EndGame();    
        //}
    }

    void Start()
    {
        gm = gameObject.AddComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(collider2d, whatIsGround);

        rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
