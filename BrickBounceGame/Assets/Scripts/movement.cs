using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] float limit;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Vertical");

        if (transform.position.x < -limit && move.x < 0){
            move.x = 0;
        } else if (transform.position.x > limit && move.x > 0){
            move.x = 0;
        }

        transform.Translate(move *speed * Time.deltaTime);
    }
}

