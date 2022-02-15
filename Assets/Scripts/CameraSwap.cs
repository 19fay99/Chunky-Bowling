using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    Camera MainCamera;
    Camera SecondaryCamera;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        SecondaryCamera = GameObject.Find("Secondary Camera").GetComponent<Camera>();
        MainCamera.enabled = true;
        SecondaryCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            MainCamera.enabled = !MainCamera.enabled;
            SecondaryCamera.enabled = !SecondaryCamera.enabled;
        }
    }
}
