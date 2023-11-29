using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive5 : MonoBehaviour
{
    public void FixeUpdate()
    {
        if (Level2.q3 == 1)
        {
            gameObject.SetActive(true);
        }
    }
}
