using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class horseraceGame : MonoBehaviour
{
    public GameObject horseManager;
    public Canvas canvasStart;
    public TMP_InputField inputField = null;
    private int input;
    private int testInput = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void placeBet()
    {

    }
    public void startPanelOff()
    {
        int.TryParse(inputField.text, out testInput);
        if (inputField != null && testInput > 0)
        {
            input = testInput;
            canvasStart.gameObject.SetActive(false);
            horseManager.SetActive(true);
        }
    }
    public void goToMain()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
