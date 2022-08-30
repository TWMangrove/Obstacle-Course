using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweep : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] float sweepSpd = 1f;
    void Update()
    {
        if (Time.time % 6 < 3)
        {
            transform.Translate(0,0,0.01f*sweepSpd);
        }
        if (Time.time % 6 >= 3)
        {
            transform.Translate(0,0,-0.01f*sweepSpd);
        }
    }
}
