using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject camera;
    //[SerializeField] Transform target;
    //public float cameraSpeed ;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Time.fixedDeltaTime = 1;
        //camera.transform.position += new Vector3(Random.Range((float)0.01, 1) * Time.deltaTime, 0, 0);
        /*var pos = transform.position;
        pos.x = target.position.x;
        transform.position = pos;*/
    }
    private void Update()
    {
        if(camera.transform.position.x < 7.45)
        {
            camera.transform.position += new Vector3(((float)0.21 * Time.deltaTime), 0, 0);
        }
    }
}
