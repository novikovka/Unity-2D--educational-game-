using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] public Text InputText; // ����� �����
    //[SerializeField] public Text TimeText;
    //[SerializeField] public int Time = 0;
    //public static int A = 0;

    [SerializeField] private InputField inputField; //��� ����� ����
    [SerializeField] public static int Speed; //���� ����������, ������� ������ ������

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
    [SerializeField] public Text PravilnoText, InputText; //����� ������, ����� �����
    [SerializeField] private InputField inputField; //��� ����� ����
    [SerializeField] public static string MyText; //���� ����������, ������� ������ ������

    public void SaveInputText()
    {
        MyText = InputText.text; //�������� ��������� �����
        //ShowCatText();
        if (MyText == "50")
        {
            Pravilno();
        }

       

    }

    public void Pravilno()
    {
        PravilnoText.text = MyText; //������ ���������� �� ���� MyText
    }
    */
}
