using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onFieldClick : MonoBehaviour
{
    public GameObject Button;
    public GameObject Canvas;
    public GameObject Canvas1;
    // Start is called before the first frame update
    void Start()
    {
        //am anfang den canvas immer unsichtbar machen
        //Canvas.SetActive(false);
    }

    public void setMoneysetVisible()
    {
        //Moneyset sichbar machen
        Canvas.SetActive(true);
    }
    public void setMoneysetInvisible()
    {
        //Moneyset unsichbar machen
        Canvas.SetActive(false);
    }

    public void setWarnPanelVisible()
    {
        //geldwarnung sichbar machen
        Canvas1.SetActive(true);
    }
    public void setWarnPanelInvisible()
    {
        //geldwarnung unsichbar machen
        Canvas1.SetActive(false);
    }

    public void getIntoRouletteTable()
    {
        //zu roulettetable scene wechseln
        SceneManager.LoadScene("RouletteTable");
    }
    public void getIntoRouletteScene()
    {
        //zu roulettescene scene wechseln und scheibe anfangen zu drehen
        SceneManager.LoadScene("RouletteScene");
        File.WriteAllText("Assets/Scripts/roulette/wheelspin.txt", "spin");
    }
    public void goBacktoMainMenu()
    {
        //zurück ins hauptmenü scene wechseln
        SceneManager.LoadScene("Mainmenu");
    }
}
