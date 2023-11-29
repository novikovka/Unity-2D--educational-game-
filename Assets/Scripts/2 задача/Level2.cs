using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    public static int q1 = 0; //вопрос1
    public static int q2 = 0; //вопрос2
    public static int q3 = 0; //вопрос3
    public static int q4 = 0; //вопрос4

    public  static void Q1()
    {
        q1 = 1;
    }
    
    public static  void Q2()
    {
        if(q1 == 1)
        {
            q2 = 1;
        }     
    }
    
    public static void Q3()
    {
        q3 = 1;
    }
    
    public static void Q4()
    {
        if (q3 == 1)
        {
            q4 = 1;
        }
    }
}
