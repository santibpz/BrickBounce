// Destroyer script for block prefabs on collision with the ball
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Block"))
        {
            Destroy(other.gameObject);
        }
        
    }
}
