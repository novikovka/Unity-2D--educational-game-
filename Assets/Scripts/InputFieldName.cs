using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldName : MonoBehaviour
{
    [SerializeField] private Text PlayerName, InputText; //текст вывода, текст ввода
    [SerializeField] private InputField inputField; //сам инпут филд
    [SerializeField] private string MyText; //сама переменная, которая хранит строку

    public void SaveInputText() //сохраним введенный текст
    {
        MyText = InputText.text;
        ShowText();
    }

    public void ShowText()
    {
        PlayerName.text = "-Ой, " + MyText + ", а что это? Шпоргалка! Ты что списываешь? F=mg, это так сложно самому запомнить?"; //подать информацию из поля MyText
    }
}
