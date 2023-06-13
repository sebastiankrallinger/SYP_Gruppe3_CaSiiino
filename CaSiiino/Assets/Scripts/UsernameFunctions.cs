using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UsernameFunctions : MonoBehaviour
{
    Filehandling file;
    public TextMeshProUGUI username = null;
    public TextMeshProUGUI coinsField = null;
    public int coins = 0;
    public TMP_InputField input = null;
    public GameObject user;

    private void Start()
    {
        file = FindAnyObjectByType<Filehandling>();
    }
    //Set Username
    public void setUsername()
    {
        //get Text from inputField
        if (input.text != "") 
        {
            username.text = input.text;
            coinsField.text = coins.ToString();
            user.SetActive(false);
            file.write();
        }
    }
}
