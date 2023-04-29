// script for controlling the ball movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyControl : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plataform"))
        {
            rb.gravityScale = 0f;
        }
    }
}
