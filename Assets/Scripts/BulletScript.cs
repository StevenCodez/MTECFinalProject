using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private Transform Bullet;
    private float HP = 3;
    private GameObject UFO;
    public Transform shotSpawn;

    //private Score PlayerScore;
    //private bool scoreflag;

    private bool HPflag;

    void Start()
    {
        Bullet = GetComponent<Transform>();
        UFO = GetComponent<GameObject>();
        //PlayerScore = GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(HP);

    }
    private void FixedUpdate()
    {
        Bullet.position += (Vector3.up * speed * Time.deltaTime); 
        
        

        if (Bullet.position.y >= 5)
            Destroy(gameObject);

        if (HP == 0)
        {

            //HPflag == true;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //scoreflag = false;
            Score.score += 100; 
        }

        if (collision.tag == "UFO")
        {

            //scoreflag = false;
            
            HP = -1;
            //PlayerScore.IncrementScore();
        }

        if (collision.tag == "UFO" && HPflag == true)
        {
            Destroy(gameObject);
        }

        
    }  
}
