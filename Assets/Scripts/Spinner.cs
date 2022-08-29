using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpd = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,(0.5f * spinSpd),0f);
    }
}
