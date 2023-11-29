using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic4 : MonoBehaviour
{
    public static void PlayButton()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("кнопки");
        }
    }
    
    public static void StopMusic()
    {
        AudioManagerMenu.instance.Stop("улица");
        AudioManagerMenu.instance.Stop("fon");
    }

}
