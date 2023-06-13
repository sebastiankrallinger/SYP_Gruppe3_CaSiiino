using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public new GameObject camera;
    horseraceGame horseraceGame;
    public bool finish = false;

    void Start()
    {
        horseraceGame = FindAnyObjectByType<horseraceGame>();
    }
    // Update is called once per frame
    public void Update()
    {
        if (finish == true)
        {
            enabled = true;
        }
        else if (finish != true && horseraceGame != null)
        {
            if (horseraceGame.start != false)
            {
                if (camera.transform.position.x < 7.45)
                {
                    camera.transform.position += new Vector3(((float)0.1643 * Time.deltaTime), 0, 0);
                }
            }
        }
    }

    public void stop()
    {
        horseraceGame.start = false;
    }
}
