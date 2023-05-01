// script for controlling the ball movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyControl : MonoBehaviour
{
    AudioSource audioSource;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.gravityScale = 0f;
        } 
        else if  (collision.gameObject.CompareTag("Block"))
        {
            rb.gravityScale = 0.8f;
        }
    }
}