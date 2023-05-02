using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameCompleted : MonoBehaviour
{
    public Block[] blocks;
    [SerializeField] Score score;
    [SerializeField] DisplayWinScreen winScreen;
    // Start is called before the first frame update
    void Start()
    {
        blocks = FindObjectsByType<Block>(FindObjectsSortMode.None);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCleared())
        {
            winScreen.Setup(score.score);
        }
    }

    private bool isCleared()
    {
        for(int i = 0; i < blocks.Length; i++)
        {
            if(blocks[i].gameObject.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }
}
