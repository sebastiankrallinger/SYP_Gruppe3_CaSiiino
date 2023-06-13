using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class horseraceGame : MonoBehaviour
{
    [SerializeField] BuoyancyEffector2D effector;
    [SerializeField] float speed;
    Filehandling file;
    public Canvas canvasStart;
    public TMP_InputField inputField = null;
    public Sprite selectedImg1;
    public Sprite selectedImg2;
    public Sprite selectedImg3;
    public Sprite selectedImg4;
    public Sprite Img1;
    public Sprite Img2;
    public Sprite Img3;
    public Sprite Img4;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public static int testInput;
    public int selectedHorseId;
    private bool testSelectedHorse = false;
    public bool start = false;

    private void Start()
    {
        file = FindAnyObjectByType<Filehandling>();
    }

    public void onHorse1Click() 
    { 
        testSelectedHorse = true;
        selectedHorseId = 2;
        btn1.image.sprite = selectedImg1;
        btn2.image.sprite = Img2;
        btn3.image.sprite = Img3;
        btn4.image.sprite = Img4;
    }
    public void onHorse2Click()
    {
        testSelectedHorse = true;
        selectedHorseId = 3;
        btn2.image.sprite = selectedImg2;
        btn1.image.sprite = Img1;
        btn3.image.sprite = Img3;
        btn4.image.sprite = Img4;
    }
    public void onHorse3Click()
    {
        testSelectedHorse = true;
        selectedHorseId = 1;
        btn3.image.sprite = selectedImg3;
        btn2.image.sprite = Img2;
        btn1.image.sprite = Img1;
        btn4.image.sprite = Img4;
    }
    public void onHorse4Click()
    {
        testSelectedHorse = true;
        selectedHorseId = 4;
        btn4.image.sprite = selectedImg4;
        btn2.image.sprite = Img2;
        btn3.image.sprite = Img3;
        btn1.image.sprite = Img1;
    }
    public void startPanelOff()
    {
        testInput = int.Parse(inputField.text);
        if (inputField != null && testInput > 0 && testSelectedHorse != false)
        {
            if (Convert.ToInt32(testInput) <= file.coins())
            {
                canvasStart.gameObject.SetActive(false);
                start = true;
            }
            
            
        } 
    }
    public void play()
    {
        effector.flowMagnitude = horseSpeed();
    }
    public float horseSpeed()
    {
        float speed = 0;
        return speed;
    }
}
