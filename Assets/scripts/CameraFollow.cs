
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// you need to change the class name to your code file name

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(2, 2, 2);
    public Camera mainCamera;
    float y1;
    void Start()
    {
        offset = mainCamera.transform.position - player.transform.position;
    }

    void Update()
    { 
        mainCamera.transform.position = player.transform.position + offset;
        
    }
}