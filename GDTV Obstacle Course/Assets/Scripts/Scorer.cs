using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've collided into things " + hits + " times!");
        }
 
        
    }
}
