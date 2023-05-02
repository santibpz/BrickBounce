// script for controlling the ball movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyControl : MonoBehaviour
{
    AudioSource audioSource;
    public Rigidbody2D rb;
    public float speed;
    Vector2 force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        Invoke("setRandomTrajectory", 2);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            audioSource.Play();
            
        } else if(collision.gameObject.CompareTag("Block"))
        {
            setRandomTrajectory();
        }
        
    }
    public void setRandomTrajectory()
    {
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1f;
        rb.AddForce(force * speed);
    }
}