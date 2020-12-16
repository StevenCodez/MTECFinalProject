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

    void Start()
    {
        Bullet = GetComponent<Transform>();
        UFO = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        

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
        }

        if (collision.tag == "UFO")
        {
            HP = -1;
            
        }

        if (HP == 0)
        {
            Destroy(collision.gameObject); 
            Destroy(gameObject);
        }

        //else if (other.tag == "Base")
        //Destroy 
    }  
}
