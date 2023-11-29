using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive2 : MonoBehaviour
{  
    public void FixeUpdate() //активирует "молодец" после первого вопроса
    {       
        if (Level2.q1 == 1 && Level2.q2 == 1)
        {
            gameObject.SetActive(true);            
        }
    }

}