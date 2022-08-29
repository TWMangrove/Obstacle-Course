using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int currentScore = -1;
    private void OnCollisionEnter(Collision other) 
    {
        currentScore += 1;
        if (currentScore == 1){Debug.Log("You've bumped into something.");}
        if (currentScore > 1){Debug.Log("You've bumped into something " + currentScore + " times.");}    
    }
}
