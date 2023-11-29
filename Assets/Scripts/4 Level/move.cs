using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //public Text TimeText;
    [SerializeField] public Vector3 V3;
    //public int Time = 0;
    //public int speed;
    //public int a = 0;
    //public int speed = UIManager.Speed;
    //public static int x = UIManager.Speed;
    /*
    void Start()
    {
        V3 = this.transform.position;
        
    }
    */
    public void Update()
    {
        V3 = this.transform.position;
        //x = UIManager.Speed;
        //transform.Translate(Vector3.up * 6.0f * Time.deltaTime); //движение вверх на 1
        //transform.Translate(Vector3.right * Time.deltaTime); //движение вправо на 1
        //transform.Translate(Vector3.up * 6.0f * Time.deltaTime); //движение вверх на 6
        int speed = UIManager.Speed;
        transform.Translate(Vector3.right * speed * Time.deltaTime); //движение вверх со скоростью speed
        //a++;
        if (V3.x > 2200)
        {
            Delete();
            //Timer.timer = 0f;
            //Timer.distance = 0f;
            //speed = 0;


        }
        /*
        if(V3.X == 0)
        {
            speed = 0;
        }
        */
        //Time++;
        //TimeText.text = Time.ToString();
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.up * speed * Time.deltaTime); //движение вверх со скоростью speed при нажатии клавиши W
        //}
        /*
        if(a > 500)
        {
            speed = 0;
        }
        */

    }

    public void Delete()
    {
        V3 = V3 + new Vector3(-2200, 0, 0);
        this.transform.position = V3;

        //Time = 0;
    }
}

