using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class horseMovement : MonoBehaviour
{
    horseraceGame horseraceGame;
    horse horse;
    Filehandling file;
    CalculatewinAmount winAmount;
    private new CameraMovement camera;
    public Transform finishTransform;
    public float x = 0.0f;
    public float delta = 0.0f;
    private int interrupt = 0;
    private int id;
    private static bool win;

    private Vector2 horsePosition;
    private Vector2 finishPosition;

    public float minSpeed = 1.0f;
    public float maxSpeed = 3.0f;

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        horse = FindAnyObjectByType<horse>();
        horseraceGame = FindAnyObjectByType<horseraceGame>();
        camera = FindAnyObjectByType<CameraMovement>();
        file = FindAnyObjectByType<Filehandling>();
        winAmount = FindAnyObjectByType<CalculatewinAmount>();
        horsePosition = transform.position;
        finishPosition = finishTransform.position;
        x = 1.25f;
        id = horse.setId();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (horseraceGame.start != false)
        {
            speed += horseSpeed();
            var newPos = Vector2.Lerp(horsePosition, finishPosition, (speed / delta) * Time.deltaTime);
            transform.position = newPos;
            if (newPos == finishPosition)
            {
                while (interrupt != 1)
                {
                    if (id == horseraceGame.selectedHorseId)
                    {
                        camera.stop();
                        camera.finish = true;
                        Debug.Log("Du gewinnst!");
                        win = true;
                        winAmount = FindAnyObjectByType<CalculatewinAmount>();
                        interrupt = 1;
                        SceneManager.LoadScene("HorseWin");
                        //winAmount.setCalculate(true);
                    }
                    else
                    {
                        camera.stop();
                        camera.finish = true;
                        Debug.Log("Du verlierst!");
                        win = false;
                        winAmount = FindAnyObjectByType<CalculatewinAmount>();
                        interrupt = 1;
                        SceneManager.LoadScene("HorseLose");
                        //winAmount.setCalculate(false);

                    }
                }

            }
        }
    }

    public bool getWin()
    {
        return win;
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
    
