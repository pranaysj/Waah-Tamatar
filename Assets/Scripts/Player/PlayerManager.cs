using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    protected bool isGrounded = true;

    protected Rigidbody2D rb;

    protected Shrink shrink;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shrink = gameObject.GetComponent<Shrink>();
    }

}
