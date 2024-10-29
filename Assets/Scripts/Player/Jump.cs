using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : PlayerManager
{
    public float jumpForce = 10.0f;
    public float fallMultiplier = 2.0f;
   
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

        if (rb.velocity.y < 0 || rb.velocity.y > 0)
        {
            rb.velocity += Vector2.down * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
