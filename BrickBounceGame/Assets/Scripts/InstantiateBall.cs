// script for instantiating the ball object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public void CreateBall()
    {
        Vector3 initialPosition = new Vector3(0f, -1.42f, 0f);
        // Create a copy of the ball prefab
        Instantiate(ball, initialPosition, Quaternion.identity); // quaternion for rotation

    }
}
