﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    

    

 
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += (Vector3.right * speed * Time.deltaTime);
        Debug.Log("speed" + speed);
      
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Right")
        {

            speed = -1;
        }
        if(collision.tag == "Left")
        {
            speed = +1;
        }
    }



  
}
