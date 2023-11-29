using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField2 : MonoBehaviour
{
    [SerializeField] public Text PravilnoText, InputText; //текст вывода, текст ввода
    [SerializeField] private InputField inputField; //сам инпут филд
    [SerializeField] public static string MyText; //сама переменная, которая хранит строку
    public static int Again2 = 0;

    public void SaveInputText()
    {
        if(InputField.door1 == 1)
        {
            MyText = InputText.text; //сохраним введенный текст
                                     //ShowCatText();

            if (MyText == "113")
            {
                Pravilno();
                PlayDoors();
                Again2 = 1;
            }
        }        
    }

    public void Pravilno()
    {
        PravilnoText.text = MyText; //подать информацию из поля MyText
    }
    
    public static void PlayDoors()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("двери");

        }
    }

}
