using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    //private float moveInput = 0;

    private Vector2 move;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    private Animator animator;

    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    private const string IdleVertical = "IdleVertical";
    private const string IdleHorizontal = "IdleHorizontal";
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //float moveInputx = Input.GetAxis("Horizontal");
        //float moveInputy = Input.GetAxis("Vertical");
        //rb.velocity = new Vector2(moveInputx * moveSpeed * Time.fixedDeltaTime, moveInputy * moveSpeed * Time.fixedDeltaTime);

        move.Set(INPUTManager.Movement.x, INPUTManager.Movement.y);
        rb.velocity = move * moveSpeed;

        animator.SetFloat(horizontal, move.x);
        animator.SetFloat(vertical, move.y);

        if (move != Vector2.zero)
        {
            animator.SetFloat(IdleHorizontal, move.x);
            animator.SetFloat(IdleVertical, move.y);
        }
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(moveInput * moveSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
