// script for instantiating the ball object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] BouncyControl bouncyControl;

public void ResetBall()
    {
        ball.transform.position = new Vector3(-0.08f, -1.42f, 0f);
        bouncyControl.rb.velocity = new Vector2(0f, 0f);
        Invoke("placeBall", 2);
    }
    private void placeBall()
    {
        
        bouncyControl.setRandomTrajectory();
        
    }
}
