using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic3 : MonoBehaviour
{
    public static void PlayButton()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("������");
        }
    }
    public static void PlayDoors()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("�����");
        }
    }

    public static void PlayStreet()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("�����");
        }
    }

    public static void StopStreet()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Stop("�����");
        }
    }

    public static void StopMusic()
    {
        AudioManagerMenu.instance.Stop("�����");
        AudioManagerMenu.instance.Stop("fon");
    }

}