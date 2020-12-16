using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private Transform Bullet;
    //private float HP = 3;
    
    public Transform shotSpawn;

    //Score not working
    /*private Score PlayerScore;
    public Text ScoreText;*/
   
    //private bool HPflag;

    void Start()
    {
        Bullet = GetComponent<Transform>();
        //UFO = GetComponent<GameObject>();
        //PlayerScore = GetComponent<Score>();
    }

    
    void Update()
    {
        //Debug.Log(HP);

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
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
            //Score.score += 100;
            //PlayerScore.IncrementScore();
        }

        if (collision.tag == "UFO")
        {

            
            Destroy(gameObject);
            //HP = -1;
            //PlayerScore.IncrementScore();
        }

        /*if (collision.tag == "UFO" && HPflag == true)
        {
            Destroy(gameObject);
        }*/

        
    }  
}
