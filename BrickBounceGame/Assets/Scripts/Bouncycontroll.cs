using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bouncycontroll : MonoBehaviour
{
    AudioSource audioSource;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.CompareTag("plataform"))
        {
            rb.gravityScale = 0f;
        }
    }
}
