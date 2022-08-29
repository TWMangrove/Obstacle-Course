using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rBod;
    [SerializeField] float timeToWait = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rBod = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rBod.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rBod.useGravity = true;       
        }
    }
}
