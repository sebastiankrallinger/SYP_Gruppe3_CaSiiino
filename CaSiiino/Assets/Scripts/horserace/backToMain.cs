using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMain : MonoBehaviour
{
    public void goToMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");

    }
}
