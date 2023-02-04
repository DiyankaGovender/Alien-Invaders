using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject[] enemyPattern;

    private float TimeBetweenspawn;
    
    public float startTime;
    public float decreaseTimeBetweenSpawn;
    public float minTime = 0.75f;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (TimeBetweenspawn <= 0)
        {
            int rand = Random.Range(0, enemyPattern.Length);

            Instantiate(enemyPattern[rand], transform.position, Quaternion.identity);
            TimeBetweenspawn = startTime;

            if (startTime > minTime)
            {
                startTime -= decreaseTimeBetweenSpawn;

            }
            

        }

        else
        {
            TimeBetweenspawn -= Time.deltaTime;
        }
    }
}
