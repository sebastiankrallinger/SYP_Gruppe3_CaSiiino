using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class Script_11m : MonoBehaviour
{
    public Slider sliderHorizontal;
    public bool horizontal;
    public float valueH;
    public Slider sliderVertical;
    public bool vertical;
    public float valueV;
    public Slider sliderPower;
    public bool power;
    public float valueP;

    public bool ID = false;

    private Animator ronaldo;

    void Start()
    {
        sliderHorizontal.value = 0;
        sliderVertical.value = 0;
        sliderPower.value = 0;
        horizontal = false;
        vertical = false;
        power = false;
    }

    void Update()
    {
        if(horizontal == false)
        {
            sliderPendeln(sliderHorizontal);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                setHorizontal();
            }
        }
        else if (vertical == false)
        {
            sliderPendeln(sliderVertical);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                setVertical();
            }
        }
        else if (power == false)
        {
            sliderPendeln(sliderPower);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                setPower();
            }
        }

        if (horizontal == true && vertical == true && power == true)
        {
            shootPenalty();
        }
    }


    public void increaseSlider(Slider s, int i) { s.value = i; }
    public void decreaseSlider(Slider s, int i) { s.value = i; }

    public void shootPenalty()
    {

    }

    public void sliderPendeln(Slider s)
    {
        if (ID == false) { increaseSlider(s); }
        if (ID == true) { decreaseSlider(s); }
        if (s.value == 100) { ID = true; }
        if (s.value == 0) { ID = false; }
    }
    public void increaseSlider(Slider s) { s.value ++; }
    public void decreaseSlider(Slider s) { s.value --; }
    public void setHorizontal()
    {
        horizontal = true;
        valueH = sliderHorizontal.value;
        vertical = false;
        ID = false;
        System.Threading.Thread.Sleep(500);
    }
    public void setVertical()
    {
        vertical = true;
        valueV = sliderVertical.value;
        power = false;
        ID = false;
        System.Threading.Thread.Sleep(500);
    }
    public void setPower()
    {
        power = true;
        valueP = sliderPower.value;
        ID = false;
    }
}
