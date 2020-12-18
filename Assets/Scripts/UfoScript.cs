using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoScript : MonoBehaviour
{
    public float speed;
    private float timestampF;
    private float timestamp;
    private float timeBetweenShots = 2;
    


    public GameObject shot;
    public Transform shotSpawn;
    public int HP = 3;
     // make a Health variable
    




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            Destroy(gameObject);
        }

        transform.position += (Vector3.left * speed * Time.deltaTime);
        

        timestampF = Random.Range(1.5f, 2f);
        timestamp = Mathf.Round(timestampF * 100f) / 100f;
        
        
        if (timestamp == 1.5)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            timestamp = Time.time + timeBetweenShots;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Right")
        {

            speed = -4;
        }
        if (collision.tag == "Right2")
        {
            speed = 4;
        }


        
    }


}