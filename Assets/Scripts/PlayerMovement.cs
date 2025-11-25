using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 200;
    //private float moveInput = 0;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveInputx = Input.GetAxis("Horizontal");
        float moveInputy = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveInputx * moveSpeed * Time.fixedDeltaTime, moveInputy * moveSpeed * Time.fixedDeltaTime);

        if (moveInputx < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(moveInput * moveSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
