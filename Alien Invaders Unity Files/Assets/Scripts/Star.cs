using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int PlayerDamage = 1;
    public GameObject enemyParticle;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Instantiate(enemyParticle, transform.position, Quaternion.identity);
            collision.GetComponent<Character_Controller>().PlayerHealth += PlayerDamage;
            Debug.Log(collision.GetComponent<Character_Controller>().PlayerHealth);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Bullet")
        {

            Instantiate(enemyParticle, transform.position, Quaternion.identity);
            collision.GetComponent<Character_Controller>().PlayerHealth += PlayerDamage;
            Debug.Log(collision.GetComponent<Character_Controller>().PlayerHealth);
            Destroy(gameObject);
        }
    }
}
