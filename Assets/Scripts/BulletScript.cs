using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private Transform Bullet;
    
    
    public Transform shotSpawn;

    public Color color;

    



    void Start()
    {
        Bullet = GetComponent<Transform>();
        
    }

    
    
    private void FixedUpdate()
    {
        Bullet.position += (Vector3.up * speed * Time.deltaTime); 
        
        

        if (Bullet.position.y >= 5)
            Destroy(gameObject);
        
        
        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy"){
            Score.score += 100;
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
            
            //PlayerScore.IncrementScore();
        }


        if (collision.tag == "UFO")
        {
            Score.score += 300;
            if (collision.GetComponent<UfoScript>() != null)
            {
                collision.GetComponent<UfoScript>().HP -= 1;

            }



            Destroy(gameObject);


        }
    }  
}
