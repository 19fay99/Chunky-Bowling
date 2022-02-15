using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{
    private float ybound = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If an object falls below the vertical point -5 it is destroyed.
        if (transform.position.y < ybound)
        {
            Destroy(gameObject);
        }
        
    }
}
