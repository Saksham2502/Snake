using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   [SerializeField] Text printScore;
       
    void Update()
    {
        printScore.text = $"Score:{Movement.count}";   
    }
}
