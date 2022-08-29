using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweep : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Time.time % 6 < 3)
        {
            transform.Translate(0,0,0.01f);
        }
        if (Time.time % 6 >= 3)
        {
            transform.Translate(0,0,-0.01f);
        }
    }
}
