using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    MeshRenderer obRender;


    private void Start()
    {
        obRender = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            obRender.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
