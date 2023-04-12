using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.SceneManagement;

public class Script_11m : MonoBehaviour
{
    public Slider sliderHorizontal;
    public Slider sliderVertical;
    public Slider sliderPower;



    void Start()
    {
        sliderHorizontal.value = 0;
        sliderVertical.value = 0;
        sliderPower.value = 0;
    }

    void Update()
    {
        for (int i = 0; i <= 100; i++)
        {          
            increaseSlider(sliderHorizontal, i);
        }
        for(int i = 0; i >= 1; i++)
        {
            decreaseSlider(sliderHorizontal, i);
        }


        for (int i = 0; i <= 100; i++)
        {
            increaseSlider(sliderVertical, i);
        }
        for (int i = 0; i >= 1; i++)
        {
            decreaseSlider(sliderVertical, i);
        }


        for (int i = 0; i <= 100; i++)
        {
            increaseSlider(sliderPower, i);
        }
        for (int i = 0; i >= 1; i++)
        {
            decreaseSlider(sliderPower, i);
        }
    }

    public void increaseSlider(Slider s, int i) { s.value = i; }
    public void decreaseSlider(Slider s, int i) { s.value = i; }
    public void goToMain()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
