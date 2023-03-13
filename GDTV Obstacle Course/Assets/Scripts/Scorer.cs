using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {

        if (!collision.collider.CompareTag("Ground"))
        {
            hits++;
            Debug.Log("You've collided into things " + hits + " times!");
        }
 
        
    }
}
