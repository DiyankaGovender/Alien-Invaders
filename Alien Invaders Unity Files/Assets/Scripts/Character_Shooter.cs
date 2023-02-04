using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Shooter : MonoBehaviour
{
    public float velocityY = 5f;
    public float velocityX = 0f;
    public Rigidbody2D rigidbod;
    void Start()
    {
        rigidbod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbod.velocity = new Vector2(velocityX, velocityY);
    }
}
