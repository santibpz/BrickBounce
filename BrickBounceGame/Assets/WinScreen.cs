// script for displaying win screen when player has won
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayWinScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);

    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
