using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // occurs whenever a collision takes place
    // other is object collided with 
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
