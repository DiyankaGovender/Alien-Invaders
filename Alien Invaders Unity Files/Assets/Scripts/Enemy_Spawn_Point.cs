using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn_Point : MonoBehaviour
{

    public int number;
    // public GameObject enemy;

    public GameObject sun1;
    public GameObject moon2;
    public GameObject earth3;
    public GameObject venus4;
    public GameObject uranus5;
    public GameObject neptune6;
    public GameObject pluto7;
    public GameObject jupiter8;
    public GameObject mars9;
    public GameObject mercury10;
    public GameObject star;
    public GameObject astronaut;

    void Start()
    {
        number = Random.Range(0, 16);

        if(number == 0)
        {
            Instantiate(sun1, transform.position, Quaternion.identity);
        }

        if (number == 1)
        {
            Instantiate(sun1, transform.position, Quaternion.identity);
        }


        if (number == 2)
        {
            Instantiate(moon2, transform.position, Quaternion.identity);
        }

        if (number == 3)
        {
            Instantiate(earth3, transform.position, Quaternion.identity);
        }

        if (number == 4)
        {
            Instantiate(venus4, transform.position, Quaternion.identity);
        }

        if (number == 5)
        {
            Instantiate(uranus5, transform.position, Quaternion.identity);
        }

        if (number == 6)
        {
            Instantiate(neptune6, transform.position, Quaternion.identity);
        }

        if (number == 7)
        {
            Instantiate(pluto7, transform.position, Quaternion.identity);
        }

        if (number == 8)
        {
            Instantiate(jupiter8, transform.position, Quaternion.identity);
        }


        if (number == 9)
        {
            Instantiate(mars9, transform.position, Quaternion.identity);
        }

        if(number == 10)
        {
            Instantiate(mercury10, transform.position, Quaternion.identity);
        }

       


        if (number == 11 )
        {
            Instantiate(star, transform.position, Quaternion.identity);
       
        }


        if (number == 12 )
        {
            Instantiate(star, transform.position, Quaternion.identity);
         
        }


        if ( number == 13)
        {
            Instantiate(astronaut, transform.position, Quaternion.identity);
           
        }


        if (number == 14)
        {
            Instantiate(astronaut, transform.position, Quaternion.identity);
            
        }

        if (number == 15)
        {
            Instantiate(venus4, transform.position, Quaternion.identity);
            
        }

        if (number == 16)
        {
            Instantiate(mars9, transform.position, Quaternion.identity);
            
        }

        











        //Instantiate(enemy, transform.position, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
