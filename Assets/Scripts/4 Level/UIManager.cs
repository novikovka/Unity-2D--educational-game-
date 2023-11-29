using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] public Text InputText; // текст ввода
    //[SerializeField] public Text TimeText;
    //[SerializeField] public int Time = 0;
    //public static int A = 0;

    [SerializeField] private InputField inputField; //сам инпут филд
    [SerializeField] public static int Speed; //сама переменная, которая хранит строку

    public void SaveSpeed()
    {
        Speed = int.Parse(InputText.text);

        //Time++;
        //TimeText.text = move.Time.ToString();
    }

    public void DeleteSpeed()
    {
        Speed = 0;
    }

    /*
    [SerializeField] public Text PravilnoText, InputText; //текст вывода, текст ввода
    [SerializeField] private InputField inputField; //сам инпут филд
    [SerializeField] public static string MyText; //сама переменная, которая хранит строку

    public void SaveInputText()
    {
        MyText = InputText.text; //сохраним введенный текст
        //ShowCatText();
        if (MyText == "50")
        {
            Pravilno();
        }

       

    }

    public void Pravilno()
    {
        PravilnoText.text = MyText; //подать информацию из поля MyText
    }
    */
}
