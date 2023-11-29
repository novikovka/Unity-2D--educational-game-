using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAdd2 : MonoBehaviour
{

    public void FixeUpdate()
    {
        if (UIManager.Speed >= 400 && UIManager.Speed <= 800)
        {
            gameObject.SetActive(true);
        }

    }

}
