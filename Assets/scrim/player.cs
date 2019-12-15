
using UnityEngine;

public class player : MonoBehaviour
{
    
    public float moveSpeed = 0.01f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
     void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed);
    }
}
