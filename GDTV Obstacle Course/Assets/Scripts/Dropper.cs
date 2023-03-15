using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer dropRender;

    Rigidbody dropRig;

    [SerializeField] float timeToWait = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        dropRender = GetComponent<MeshRenderer>();
        dropRig = GetComponent<Rigidbody>();

        dropRender.enabled = false;
        dropRig.useGravity = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            dropRender.enabled = true;
            dropRig.useGravity = true;
        }
    }
}