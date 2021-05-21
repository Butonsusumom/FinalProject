using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPosition : MonoBehaviour
{
    public float xRange = 49;
    public float z1Range = 42;
    public float z2Range = 54;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -z2Range)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -z2Range);
        }

        if (transform.position.z > z1Range)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, z1Range);
        }

    }
}
