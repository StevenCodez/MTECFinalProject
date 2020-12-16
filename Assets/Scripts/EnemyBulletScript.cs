using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float speed;
    private Transform EnemyBullet;

    public Transform shotSpawn;

    void Start()
    {
        EnemyBullet = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void FixedUpdate()
    {
        EnemyBullet.position += (Vector3.down * speed * Time.deltaTime);



        /*if (EnemyBullet.position.y >= -1000)
        {
            //Destroy(gameObject);
        }*/


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        //else if (other.tag == "Base")
        //Destroy 
    }
}
