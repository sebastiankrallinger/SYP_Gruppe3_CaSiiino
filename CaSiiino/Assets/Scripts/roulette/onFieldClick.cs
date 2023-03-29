using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFieldClick : MonoBehaviour
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
    public void setMoneysetVisible()
    {
        Canvas.SetActive(true);
    }
    public void setMoneysetInvisible()
    {
        Canvas.SetActive(false);
    }


}
