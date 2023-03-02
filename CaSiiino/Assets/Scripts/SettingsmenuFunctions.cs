using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsmenuFunctions : MonoBehaviour
{
    //set Volume of mainmenu music
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    //need later
    public void setLevel(int levelIndex)
    {

    }
}
