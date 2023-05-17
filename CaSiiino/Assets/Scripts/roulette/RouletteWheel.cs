using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteWheel : MonoBehaviour
{
    public GameObject Button;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setRouletteWheelBtnInvisible()
    {
        Button.SetActive(false);
        Canvas.SetActive(true);
    }
}
