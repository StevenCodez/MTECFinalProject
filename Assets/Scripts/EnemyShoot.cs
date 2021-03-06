﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject shot;  //this is just like enemy script except allowing individual sprites to shoot. (Not for UFo)
    public Transform shotSpawn;

    private float timestampF;
    private float timestamp;
    private float timeBetweenShots = 2;

    void Start()
    {
        
    }

    
    void Update()
    {
        timestampF = Random.Range(1.5f, 8f);
        timestamp = Mathf.Round(timestampF * 100f) / 100f;


        if (timestamp == 1.5)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            timestamp = Time.time + timeBetweenShots;

        }

    }
}
