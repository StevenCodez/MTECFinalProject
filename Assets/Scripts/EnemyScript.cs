using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    private Transform enemyHolder;

    

    //private OppBarrier OpponentBarrier;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        //OpponentBarrier = GetComponent<OppBarrier>();
        //Debug.Log("speed" + speed);
        enemyHolder = GetComponent < Transform > ();

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += (Vector3.right * speed * Time.deltaTime);
        Debug.Log("speed" + speed);
      
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Left" || collision.tag == "Right")
        {

            speed = -1;
        }

    }



    /*
    void MoveEnemy()
    {
        enemyHolder.position += Vector3.right * speed * Time.deltaTime;

        foreach (Transform enemy in enemyHolder)
        {

            if (enemy.position.x < -10.5 || enemy.position.x > 10.5)
            {
                speed = -speed;
                //enemyHolder.position += Vector3.down * 0.5f
                return;
            }
        }

        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);

        }

       
    }*/
}
