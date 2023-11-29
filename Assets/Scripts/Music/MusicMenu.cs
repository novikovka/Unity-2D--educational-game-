
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {       
        AudioManagerMenu.instance.Play("fon");     
    }
    
    public static void StopFon()
    {        
        AudioManagerMenu.instance.Stop("fon");
    }

    public static void PlayFon()
    {
        AudioManagerMenu.instance.Play("fon");
    }

    public static void PlayButton()
    {
        if(ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("кнопки");
        }
        //AudioManagerMenu.instance.Play("кнопка");
    }
}