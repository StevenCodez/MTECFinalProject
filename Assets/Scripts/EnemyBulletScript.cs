﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float speed;
    private Transform EnemyBullet;

    



    void Start()
    {
        EnemyBullet = GetComponent<Transform>();

    }

    
    void Update()
    {


    }
    private void FixedUpdate()
    {
        EnemyBullet.position += (Vector3.down * speed * Time.deltaTime);



       

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Score.score += 50;
        }


    }
}
