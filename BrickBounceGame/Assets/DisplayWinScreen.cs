// script for displaying win screen when player has won
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DisplayWinScreen : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public void Setup(int finalScore)
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        scoreText.text = "Final Score is " + finalScore;

    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
