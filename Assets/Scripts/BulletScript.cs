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

    //Score not working
    /*private Score PlayerScore;
    public Text ScoreText;*/
    private float HP = 3;
    public bool HPflag;

    void Start()
    {
        Bullet = GetComponent<Transform>();
        //UFO = GetComponent<GameObject>();
        //PlayerScore = GetComponent<Score>();
    }

    
    void Update()
    {
        //Debug.Log("HP" + HP);

    }
    private void FixedUpdate()
    {
        Bullet.position += (Vector3.up * speed * Time.deltaTime); 
        
        

        if (Bullet.position.y >= 5)
            Destroy(gameObject);
        
        if(HP== 0)
        {
            HPflag = true;
        }
        

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

            if (collision.GetComponent<UfoScript>() != null)
            {
                collision.GetComponent<UfoScript>().HP -= 1;

            }


            //ScriptthehasHp.Hp -= 1;
            //Destroy(collision.gameObject);//This kills the UFO
            Destroy(gameObject);
            //HP = HP -1;
            //PlayerScore.IncrementScore();
        }

        /*if (collision.tag == "UFO" && HPflag == true)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }*/
    }  
}
