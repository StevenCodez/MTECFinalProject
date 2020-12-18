using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootsound : MonoBehaviour
{
    public AudioSource shoot;


    void Start()
    {
        
    }

    // Update is called once per frame
    public void Shootingsound()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot.Play();
        }   
    }      
}
