using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // variables change movement speed 
    [SerializeField] float yValue = 0;
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {      
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();              
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!;");
        Debug.Log("Move your player with WASD or arrow keys.");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform .Translate(xValue,yValue,zValue);  
    }

}
