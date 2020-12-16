﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform player;
    public float speed = 50f ;
    private Rigidbody2D rb;
    public GameObject shot;

    private float timestamp;
    private float timeBetweenShots = 0.5f;

    public Transform shotSpawn;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //player = GetComponent<Transform>();
        

    }
    // Update is called once per frame
    void Update()
    {
            float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 movedirection = new Vector3(xValue, rb.velocity.y, 0);
        rb.velocity = movedirection;

        


        if (Time.time >= timestamp && Input.GetKeyDown(KeyCode.Space))
        {
            //transform.position = Bullet.position;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            timestamp = Time.time + timeBetweenShots;

        }

       
    }
}
