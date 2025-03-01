using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

   
    void Start()
    {
        PrintInstructions();
    }

   
    void Update()
    {
       MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        

    }
    void MovePlayer()
    {
        float xValue= Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue= Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
