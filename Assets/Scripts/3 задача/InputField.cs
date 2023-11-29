
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    [SerializeField] public Text PravilnoText, InputText; //����� ������, ����� �����
    [SerializeField] private InputField inputField; //��� ����� ����
    [SerializeField] public static string MyText; //���� ����������, ������� ������ ������

    public static int door1 = 0;
    public static int Again = 0;

    public void SaveInputText()
    {
        MyText = InputText.text; //�������� ��������� �����
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
        PravilnoText.text = MyText; //������ ���������� �� ���� MyText
    }
    
    public static  void PlayDoors()
    {
        if (ButtonOff.Sounds == 1)
        {
            AudioManagerMenu.instance.Play("�����");
        }
    }

    public static void Door1()
    {
        door1 = 1;
    }

}
