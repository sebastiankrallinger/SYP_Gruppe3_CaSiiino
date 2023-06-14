using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using TMPro;
using UnityEngine;

public class showmoney : MonoBehaviour
{
    public TMP_Text moneyanzeige;
    Filehandling file;
    // Start is called before the first frame update
    void Start()
    {
        file = FindAnyObjectByType<Filehandling>();
        //Zeigt das Geld im ersten Frame an
        moneyanzeige.text= file.getCoins();
    }

    // Update is called once per frame
    void Update()
    {
        //updated den Geldbatrag jeden frame
        moneyanzeige.text = file.getCoins();
    }
}
