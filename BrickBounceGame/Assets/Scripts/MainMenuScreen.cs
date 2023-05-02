using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    public void PlayGame()
    {
        if(Time.timeScale==0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene("Game");
    }
}
