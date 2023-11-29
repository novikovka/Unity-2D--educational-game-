
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDelete : MonoBehaviour
{
    public static int NumberInputField = 1;
    public void FixeUpdate()
    {
        if (InputField.MyText == "800" && NumberInputField == 1)
        {
            gameObject.SetActive(false);
            NumberInputField = 2;
        }

        if (InputField2.MyText == "113" && NumberInputField == 2)
        {
            gameObject.SetActive(false);
        }
    }

}
