// script for instantiating the ball object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public void RepositionBall()
    {
        ball.transform.position = new Vector3(0f, -1.42f, 0f);
      

    }
}
