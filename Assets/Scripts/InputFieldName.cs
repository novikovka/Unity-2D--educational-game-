using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldName : MonoBehaviour
{
    [SerializeField] private Text PlayerName, InputText; //����� ������, ����� �����
    [SerializeField] private InputField inputField; //��� ����� ����
    [SerializeField] private string MyText; //���� ����������, ������� ������ ������

    public void SaveInputText() //�������� ��������� �����
    {
        MyText = InputText.text;
        ShowText();
    }

    public void ShowText()
    {
        PlayerName.text = "-��, " + MyText + ", � ��� ���? ���������! �� ��� ����������? F=mg, ��� ��� ������ ������ ���������?"; //������ ���������� �� ���� MyText
    }
}
