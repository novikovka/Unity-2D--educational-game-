using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public static void StopVoroni()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("вороны");
    }

    public static void PlayKotel()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("котел");
    }
    public static void StopKotel()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("котел");
    }

    public static void PlayKot()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("кот");
    }
    public static void StopKot()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("кот");
    }

    public static void PlayVzriv()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("взрыв");
    }
    public static void StopVzriv()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("взрыв");
    }

    public static void PlayFon()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("fon");
    }
    public static void StopFon()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("fon");
    }


    public static void PlayButton()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("кнопки");
    }

    public static void StopMusic()
    {
        AudioManagerMenu.instance.Stop("вороны");
        AudioManagerMenu.instance.Stop("котел");
        AudioManagerMenu.instance.Stop("кот");
        AudioManagerMenu.instance.Stop("взрыв");
        AudioManagerMenu.instance.Stop("fon");
    }




}
