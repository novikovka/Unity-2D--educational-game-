using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public float distance;
    [SerializeField] private Text TimeText;
    [SerializeField] private Text DistanceText;

    void Start()
    {
        timer = 0;
        distance = 0;
        //TimeText.text = "Time: " + timer;

    }
    /*
    public void ChargeIt()
    {
        timer += Time.deltaTime * 5;
    }
    */

    public void Update()
    {

        TimeText.text = " * " + Mathf.Round(timer);
        timer += Time.deltaTime;

        DistanceText.text = "  " + Mathf.Round(distance) + " = ";
        distance = timer * UIManager.Speed;

        /*
        if (move.V3.x > 1000)
        {
            
            timer = 0;
            distance = 0;


        }
        */


    }
}