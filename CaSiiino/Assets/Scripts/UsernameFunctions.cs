using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UsernameFunctions : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TMP_InputField input = null;
    public GameObject user;

    //Set Username
    public void setUsername()
    {
        //get Text from inputField
        if (input.text != "") 
        {
            username.text = input.text;
            user.SetActive(false);
        }
    }
}
