using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOff : MonoBehaviour
{
    public static int Music = 1;
    public static int Sounds = 1;

    public static void MusicOff()
    {
        Music = 0;
    }

    public static void SoundsOff()
    {
        Sounds = 0;
    }

    public static void MusicOn()
    {
        if(Music == 0)
        {
            Music = 1;
        }
    }

    public static void SoundsOn()
    {
        if (Sounds == 0)
        {
            Sounds = 1;
        }
    }
}
