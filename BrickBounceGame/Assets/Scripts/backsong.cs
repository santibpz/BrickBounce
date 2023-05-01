using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backsong : MonoBehaviour
{
    AudioSource songs;
    // Start is called before the first frame update
    void Start()
    {
        songs = GetComponent<AudioSource>();
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}