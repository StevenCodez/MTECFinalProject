using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoScript : MonoBehaviour
{
    public float speed;
    private float timestamp;
    private float timeBetweenShots = 0.5f;


    public GameObject shot;
    public Transform shotSpawn;

    




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += (Vector3.right * speed * Time.deltaTime);
        Debug.Log("speed" + speed);


        if (Time.time >= timestamp)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            timestamp = Time.time + timeBetweenShots;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Right")
        {

            speed = +1;
        }
        if (collision.tag == "Right2")
        {
            speed = -1;
        }


        
    }


}