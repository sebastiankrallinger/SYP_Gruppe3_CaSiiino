using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;

public class RouletteWheel : MonoBehaviour
{
    public GameObject Button;
    public GameObject Image;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //das sich das roulette image dreht
        if ("spin" == File.ReadAllText("Assets/Scripts/roulette/wheelspin.txt"))
        {
            Image.transform.Rotate(Vector3.forward * 5);
        }
    }
    public void setRouletteWheelBtnInvisible()
    {
        //stop in die datei schreiben das sich die scheibe nicht mehr dreht
        File.WriteAllText("Assets/Scripts/roulette/wheelspin.txt", "stop");
        Thread.Sleep(1000);

        //gewinnausgabe
        Button.SetActive(false);
        Canvas.SetActive(true);
    }
}
