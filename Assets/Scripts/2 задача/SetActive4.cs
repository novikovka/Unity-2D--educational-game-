using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive4 : MonoBehaviour
{
    public void FixeUpdate()
    {
        if (Level2.q1 == 1)
        {
            gameObject.SetActive(true);
        }
    }

    public void FixeUpdate2()
    {
        if (Level2.q3 == 1)
        {
            gameObject.SetActive(true);
        }
    }
}
