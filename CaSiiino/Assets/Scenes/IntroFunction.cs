using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroFunction : MonoBehaviour
{
    float wait_time = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(goToMainMenu());
    }

    //Waittime go to Scene Mainmenu
    IEnumerator goToMainMenu()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene("Mainmenu");
    }
}
