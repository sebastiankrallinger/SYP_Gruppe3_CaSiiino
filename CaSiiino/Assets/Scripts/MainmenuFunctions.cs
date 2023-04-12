using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainmenuFunctions : MonoBehaviour
{
    public GameObject Username;

    // Start is called before the first frame update
    void Start()
    {
       Username.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
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
