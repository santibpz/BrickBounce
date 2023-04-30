using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    [SerializeField] int health;
    [SerializeField] Image[] hearts;
    [SerializeField] Sprite fullHeart;
    [SerializeField] Sprite emptyHeart;

    private void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emptyHeart;
        }

        for(int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }
}
