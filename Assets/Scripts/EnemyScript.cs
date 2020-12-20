using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;

   
    void Start()
    {

    }

    
    void Update()
    {



        transform.position += (Vector3.left * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Right")
        {

            speed = +1;
        }
        if(collision.tag == "Left")
        {
            speed = -1;
        }
    }



  
}
