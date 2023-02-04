using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Character_Controller : MonoBehaviour
{
    public int PlayerHealth; 
    public float distance;

    private Vector2 Playerposition;
    public float KeyDistance;

    public float speed;

    public float minDistance;
    public float maxDistance;


    public GameObject bullet;
    Vector2 bulletposition;
    public float bulletFireRate;
    float nextBulletFire =0f;

    public Button firebutton;

    public TextMeshProUGUI health;

    public AudioSource shootingsound;


    private void Start()
    {
        health.GetComponent<TextMeshProUGUI>();
    }

    void Update()

    {
        //Player Health UI
        health.text = PlayerHealth.ToString();

        //Player Health
         if(PlayerHealth <=0)
        {
            SceneManager.LoadScene(2);
        }

         if(PlayerHealth >= 5)
        {
            PlayerHealth = 5;
        }


        //Player TouchScreen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began )
            {
                if (touch.position.x < Screen.width / 2 && transform.position.x > -distance)
                    this.transform.position = new Vector2(transform.position.x - distance, transform.position.y);

                if (touch.position.x > Screen.width / 2 && transform.position.x < distance)
                    this.transform.position = new Vector2(transform.position.x + distance, transform.position.y);
            }
        }







        //Player Input Keyboard
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minDistance)
        {
            Playerposition = new Vector2(transform.position.x - KeyDistance, transform.position.y);
            transform.position = Playerposition;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxDistance)
        {
            Playerposition = new Vector2(transform.position.x + KeyDistance, transform.position.y);
            transform.position = Playerposition;
        }


        //Bullet Fire KEYBOARD
        if (Input.GetKey(KeyCode.UpArrow) && Time.time > nextBulletFire)
        {
            nextBulletFire = Time.time + bulletFireRate;
            fireBullet();
        }

        //Bullet Fire TOUCH
      

    }

    public void fireBullet()
    {
        shootingsound.Play();
        bulletposition = transform.position;
        Instantiate(bullet, bulletposition, Quaternion.identity);

    }
}
