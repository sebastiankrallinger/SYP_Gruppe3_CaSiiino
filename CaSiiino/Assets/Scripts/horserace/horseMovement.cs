using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Random = System.Random;

public class horseMovement : MonoBehaviour
{
    horseraceGame horseraceGame;
    public Transform finishTransform;
    public float x = 0.0f;
    public float delta = 0.0f;
    public int horseId = 0;

    private Vector2 horsePosition;
    private Vector2 finishPosition;

    public float minSpeed = 1.0f;
    public float maxSpeed = 3.0f;

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        horsePosition = transform.position;
        finishPosition = finishTransform.position;
        x = 1.25f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed += horseSpeed();
        var newPos = Vector2.Lerp(horsePosition, finishPosition, (speed / delta) * Time.deltaTime);
        transform.position = newPos;
        if(newPos == finishPosition)
        {
            if(horseId == horseraceGame.selectedHorseId)
            {
                Debug.Log("Du gewinnst!");
            }else
            {
                Debug.Log("Du verlierst!");
            }
        }
    }

    private float horseSpeed()
    {
        Random r = new Random();
        double min = 0.05;
        double max = 1.9;
        double range = max - min;

        double x = r.NextDouble();
        double s = (x * range) + min;
        return (float)s;

    }
}
    
