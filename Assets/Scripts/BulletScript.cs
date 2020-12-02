using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private Transform Bullet;

    public Transform shotSpawn;

    void Start()
    {
        Bullet = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void FixedUpdate()
    {
        Bullet.position += (Vector3.up * speed * Time.deltaTime); 
        
        

        if (Bullet.position.y >= 10)
            Destroy(gameObject);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        //else if (other.tag == "Base")
            //Destroy 
    }  
}
