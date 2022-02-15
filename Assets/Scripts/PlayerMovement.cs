using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public GameObject BowlingBallPrefab;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void LateUpdate()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (GameObject.Find("Bowling Ball(Clone)") == null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(BowlingBallPrefab, transform.position + new Vector3(1, 1, 1), BowlingBallPrefab.transform.rotation);
            }
        }

    }
}

