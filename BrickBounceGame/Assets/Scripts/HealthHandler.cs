// script for checking and performing actions when gameObjects fall off the camera view.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] HealthManager healthManager;
    [SerializeField] PositionPlayer positioner;
    [SerializeField] InstantiateBall instantiator;
    [SerializeField] GameOverScreen gameOverScreen;
    [SerializeField] Score score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            healthManager.health--;
            if(healthManager.health > 0)
            {
                // instantiate new ball in original position and reposition player
                instantiator.CreateBall();
                positioner.repositionPlayer();
            }
            else
            {
                // game over
                gameOverScreen.Setup(score.score);
            }
            
        }
    }
}
