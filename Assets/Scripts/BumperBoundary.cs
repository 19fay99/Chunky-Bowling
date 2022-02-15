using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBoundary : MonoBehaviour
{

    public float xRange = 8.0f;
    public float zMin = 22.5f;
    public float zMax = 34.0f;
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

        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMax);
        }
    }
}
