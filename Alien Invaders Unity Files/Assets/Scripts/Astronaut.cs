using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Astronaut : MonoBehaviour
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
            SceneManager.LoadScene(2);

        }

        if (collision.gameObject.tag == "Bullet")
        {

            Instantiate(enemyParticle, transform.position, Quaternion.identity);
            //collision.GetComponent<Character_Controller>().PlayerHealth += PlayerDamage;
            //Debug.Log(collision.GetComponent<Character_Controller>().PlayerHealth);
            Destroy(gameObject);
            SceneManager.LoadScene(2);

        }


    }

    public IEnumerator AstrnautWait()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("DEATH");
       
        
    }
}
