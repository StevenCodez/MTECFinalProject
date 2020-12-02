using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform player;
    public float speed = 50f ;
    private Rigidbody2D rb;
    public GameObject shot;

    public Transform shotSpawn;
    public float firerate;
    private float nextshot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Transform>();


    }
    // Update is called once per frame
    void Update()
    {
            float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 movedirection = new Vector3(xValue, rb.velocity.y, 0);
            rb.velocity = movedirection;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.position = Bullet.position;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            nextshot = Time.time + firerate;
        }
    }
}
