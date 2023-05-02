// script for positioning the player every time the ball disappears
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;


    public void repositionPlayer()
    {
        player.transform.position = new Vector3(0, -3.89f, 0);
        
        
    }
}
