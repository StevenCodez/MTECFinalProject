using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform player;
    public float speed = 50f ;
    private Rigidbody2D rb;
    public GameObject shot;

    private float timestamp;
    private float timeBetweenShots = 0.3f;

    public Transform shotSpawn;

    public AudioSource shoot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        

    }

    void Update()
    {
            float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 movedirection = new Vector3(xValue, rb.velocity.y, 0);
        rb.velocity = movedirection;

        


        if (Time.time >= timestamp && Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            timestamp = Time.time + timeBetweenShots;
            shoot.Play();
        }

       
    }
}
