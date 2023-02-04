using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int PlayerDamage =1;

    public float EnemySpeed;
    public GameObject enemyParticle;
    public GameObject boomParticle;

    private Camera_Shake shake;
 


    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Camera_Shake>();
    }

   
    void Update()
    {
        transform.Translate(Vector2.down * EnemySpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           
            shake.camerashake();
            Instantiate(enemyParticle, transform.position, Quaternion.identity);
            Instantiate(boomParticle, transform.position, Quaternion.identity);
            collision.GetComponent<Character_Controller>().PlayerHealth -= PlayerDamage;
            Debug.Log(collision.GetComponent<Character_Controller>().PlayerHealth);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Bullet")
        {

            
            shake.camerashake();
            Instantiate(enemyParticle, transform.position, Quaternion.identity);
            Instantiate(boomParticle, transform.position, Quaternion.identity);
            Debug.Log("Yikes");
            Destroy(gameObject);
        }
    }
}
