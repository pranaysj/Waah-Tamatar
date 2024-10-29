using UnityEngine;

public class Roll :  PlayerManager
{
    public float moveSpeed = 5.0f;
    public float horizontalInput;

    public GameObject gameplayCanvas;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (shrink.isShrunk)
        {
            rb.velocity = new Vector2(horizontalInput * moveSpeed * 2, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        }

        if (horizontalInput != 0)
        {
            gameplayCanvas.SetActive(false);
        }

    }
}   