using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Slider sliderHorizontal;
    public Slider sliderVertical;
    public Slider sliderPower;

    public float seite;
    public float hoehe;
    public float power;


    // Start is called before the first frame update
    void Start()
    {
        seite = sliderHorizontal.value;
        hoehe = sliderVertical.value;
        power = sliderPower.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
