using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        if (ButtonOff.Music == 1)
        {
            AudioManagerMenu.instance.Play("fon");


        }
        //AudioManager.instance.Play("вороны");
    }
    

    public void PlayButton()
    {
        if(ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("кнопки");

        }
    }

    public static void StopMusic()
    {
        AudioManagerMenu.instance.Stop("fon");
        AudioManagerMenu.instance.Stop("кнопки");

    }

}

