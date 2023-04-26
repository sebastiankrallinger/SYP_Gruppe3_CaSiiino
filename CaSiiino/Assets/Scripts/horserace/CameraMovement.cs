using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public float cameraSpeed ;
    // Update is called once per frame
    void FixedUpdate()
    {
        Time.fixedDeltaTime = 5;
        transform.position += new Vector3(Random.Range((float)0.01, 10) * Time.deltaTime, 0, 0);   
    }
}
