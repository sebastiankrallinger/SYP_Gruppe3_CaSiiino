using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject camera;
    // Update is called once per frame
    
    private void Update()
    {
        if(camera.transform.position.x < 7.45)
        {
            camera.transform.position += new Vector3(((float)0.165 * Time.deltaTime), 0, 0);
        }
    }
}
