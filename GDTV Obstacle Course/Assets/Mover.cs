using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xVal, 0, zVal);
    }
}
