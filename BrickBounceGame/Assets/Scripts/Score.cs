// script for controlling the score logic of the game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Block"))
        {
            score += 1;
            scoreText.text = "Score: " + score;
        } 
    }
}
