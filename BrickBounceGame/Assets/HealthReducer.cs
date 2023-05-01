// script for reducing player health
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthReducer : MonoBehaviour
{
    [SerializeField] HealthManager healthManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            healthManager.health--;

        }
    }
}
