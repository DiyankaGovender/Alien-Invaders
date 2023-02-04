using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score_manager : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scorevalue;
    void Start()
    {
       scorevalue.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scorevalue.text = "score: "+ "" + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            score+= 100;
            Debug.Log(score);
        }
    }
}
