
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectAdd : MonoBehaviour
{
    public static int NumberInputField = 1;
    public void FixeUpdateDoors()
    {
        if (InputField.MyText == "800"  && NumberInputField == 1)
        {
            gameObject.SetActive(true);
           NumberInputField = 2;
        }
        if (InputField2.MyText == "113" && NumberInputField == 2)
        {
            gameObject.SetActive(true);
        }
    }

    public void FixeUpdate1()
    {
        if(InputField.Again == 0)
        {
            gameObject.SetActive(true);
        }
    }

    public void FixeUpdate2()
    {
        if (InputField2.Again2 == 0 && InputField.door1 == 1)
        {
            gameObject.SetActive(true);
        }
    }

    public void FixeUpdate() //сначала открой деревянную дверь
    {
        if (InputField.door1 == 0)
        {
            gameObject.SetActive(true);
        }
    }

}
