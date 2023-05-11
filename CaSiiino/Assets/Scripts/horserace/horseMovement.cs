using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Random = System.Random;

public class horseMovement : MonoBehaviour
{
    public Transform finishTransform;
    public float speed = 0.0f;
    public float delta = 0.0f;

    private Vector2 horsePosition;
    private Vector2 finishPosition;

    // Start is called before the first frame update
    void Start()
    {
        horsePosition = transform.position;
        finishPosition = finishTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed += Time.deltaTime;
        //speed += Time.deltaTime;
        //var newPos = Vector2.Lerp(horsePosition, finishPosition, Mathf.SmoothStep(0, 1, speed / horseSpeed()));
        var newPos = Vector2.Lerp(horsePosition, finishPosition, speed / delta);
        transform.position = newPos;
    }

    private float horseSpeed(float speed)
    {
        Random r = new Random();
        float s = 0.0f;
        do {
            s = r.Next(20, 100 + 1);
        } while (speed < speed / s);
        return s;
    }
}
