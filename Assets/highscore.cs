using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    [SerializeField] Text printHighscore;
   
    void Update()
    {
        printHighscore.text = $"HighScore:{Movement.highscore}"; 
    }
}
