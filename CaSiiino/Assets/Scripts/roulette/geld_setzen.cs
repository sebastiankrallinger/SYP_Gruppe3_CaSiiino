using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class geld_setzen : MonoBehaviour
{
    // wenn auf ein feld geklickt wird scene öffnen
    public void GoToMoneySetScene()
    {
        SceneManager.LoadScene("MoneySetScene");
    }
}
