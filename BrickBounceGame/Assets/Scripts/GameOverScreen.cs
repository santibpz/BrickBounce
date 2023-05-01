// script for displaying the game over screen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public void Setup(int finalScore)
    {
        gameObject.SetActive(true);
        scoreText.text = "Score: " + finalScore;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
