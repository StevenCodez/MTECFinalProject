using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour

{
    public static float score = 0;

    public TextMeshPro scoreText;

    void Start()
    {
        
    }
    void Update()
    {
        //score++;
        scoreText.text = "Score: " + score;
    }
}

