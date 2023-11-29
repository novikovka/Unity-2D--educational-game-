
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    [SerializeField] public Text PravilnoText, InputText; //текст вывода, текст ввода
    [SerializeField] private InputField inputField; //сам инпут филд
    [SerializeField] public static string MyText; //сама переменная, которая хранит строку

    public static int door1 = 0;
    public static int Again = 0;

    public void SaveInputText()
    {
        MyText = InputText.text; //сохраним введенный текст
        //ShowCatText();
        if (MyText == "800")
        {
            Pravilno();
            PlayDoors();
            Door1();
            Again = 1;
        }        
    }

    public void Pravilno()
    {
        PravilnoText.text = MyText; //подать информацию из поля MyText
    }
    
    public static  void PlayDoors()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("двери");
        }
    }

    public static void Door1()
    {
        door1 = 1;
    }

}
