using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic4 : MonoBehaviour
{
    public static void PlayButton()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("������");
        }
    }
    
    public static void StopMusic()
    {
        AudioManagerMenu.instance.Stop("�����");
        AudioManagerMenu.instance.Stop("fon");
    }

}
