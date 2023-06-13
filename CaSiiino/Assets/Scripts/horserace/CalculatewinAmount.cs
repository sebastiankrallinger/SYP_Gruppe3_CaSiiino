using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalculatewinAmount : MonoBehaviour
{
    public GameObject manager;
    Filehandling file;
    horseraceGame horseraceGame;
    horseMovement horseMovement;
    private int amount = 0;
    private int quote;
    public TextMeshProUGUI winAmount;

    private void OnEnable()
    {
        horseraceGame = FindAnyObjectByType<horseraceGame>();
        file = FindAnyObjectByType<Filehandling>();
        horseMovement = FindAnyObjectByType<horseMovement>();
        Debug.Log("loaded");
        setCalculate(horseMovement.getWin());
    }
    public void setCalculate(bool win)
    {
        //horseraceGame = manager.FindObjectOfType<horseraceGame>();
        quote = 4;
        if (win == true)
        {
            calculateWinAmount(win);
        }
        else if(win == false)
        {
            calculateLoseAmount(win);
        }
    }
    
    private void calculateWinAmount(bool win)
    {
        int input = horseraceGame.testInput;
        amount = amount + (input * quote);
        winAmount.text = Convert.ToString(amount);
        if (file != null)
        {
            file.updateCoins(amount.ToString(), win);
        }
        else
        {
            file = FindAnyObjectByType<Filehandling>();
            file.updateCoins(amount.ToString(), win);
        }
    }
    private void calculateLoseAmount(bool win)
    {
        int input = horseraceGame.testInput;
        amount = input;
        if (file != null)
        {
            file.updateCoins(amount.ToString(), win);
        }
        else
        {
            file = FindAnyObjectByType<Filehandling>();
            file.updateCoins(amount.ToString(), win);
        }
    }
}
