using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboards : MonoBehaviour
{
    public Image i1_1;
    public Image i1_2;
    public Image i2_1;
    public Image i2_2;



    void Start()
    {
        Sprite x = Resources.Load<Sprite>("x");
        Sprite checkmark = Resources.Load<Sprite>("checkmark");

        i1_1.sprite = x;
        i1_2.sprite = checkmark;
    }

    void Update()
    {
        
    }
}
