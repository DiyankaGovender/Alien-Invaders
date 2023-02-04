using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destroyer : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {


            Debug.Log("Yee");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
           



        }
    }
}


