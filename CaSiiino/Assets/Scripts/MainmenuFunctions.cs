using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainmenuFunctions : MonoBehaviour
{
    UsernameFunctions functions;
    Filehandling file;
    public GameObject Username;
    private static int zugriffe = 0;

    // Start is called before the first frame update
    void Start()
    {
       functions = FindAnyObjectByType<UsernameFunctions>();
       file = FindAnyObjectByType<Filehandling>();
       if(zugriffe == 0)
       {
            Username.SetActive(true);
            zugriffe++;
       }
       else
       {
            Username.SetActive(false);
            functions.username.text = file.getUser();
            functions.coinsField.text = file.getCoins();
        }
    }

    //Go to Roulette Scene
    public void goToRouletteScene()
    {
        SceneManager.LoadScene("RouletteScene");
    }
    //Go to UNO Scene
    public void goToUnoScene()
    {
        SceneManager.LoadScene("UnoScene");
    }
    //Go to Horserace Scene
    public void goToHorseraceScene()
    {
        SceneManager.LoadScene("HorseraceScene");
    }
    //Go to 11m Scene
    public void goTo11mScene()
    {
        SceneManager.LoadScene("11mScene");
    }
    //Exit Game
    public void extiGame()
    {
        Application.Quit();
    }
}
