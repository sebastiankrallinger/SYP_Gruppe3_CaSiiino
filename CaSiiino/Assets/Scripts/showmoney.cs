using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class showmoney : MonoBehaviour
{
    public TMP_Text moneyanzeige;
    // Start is called before the first frame update
    void Start()
    {
        //Zeigt das Geld im ersten Frame an
        moneyanzeige.text= File.ReadAllText("Assets/Scripts/roulette/geld.txt");
    }

    // Update is called once per frame
    void Update()
    {
        //updated den Geldbatrag jeden frame
        moneyanzeige.text = File.ReadAllText("Assets/Scripts/roulette/geld.txt");
    }
}
