using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public static void StopVoroni()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("������");
    }

    public static void PlayKotel()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("�����");
    }
    public static void StopKotel()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("�����");
    }

    public static void PlayKot()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("���");
    }
    public static void StopKot()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("���");
    }

    public static void PlayVzriv()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Play("�����");
    }
    public static void StopVzriv()
    {
        if (ButtonOff.Sounds == 1)
            AudioManagerMenu.instance.Stop("�����");
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
            AudioManagerMenu.instance.Play("������");
    }

    public static void StopMusic()
    {
        AudioManagerMenu.instance.Stop("������");
        AudioManagerMenu.instance.Stop("�����");
        AudioManagerMenu.instance.Stop("���");
        AudioManagerMenu.instance.Stop("�����");
        AudioManagerMenu.instance.Stop("fon");
    }




}
