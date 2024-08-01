using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) // bir yere çarptığında
    {
        if(other.gameObject.tag=="Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag= "Hit";
        }
        

    }
}
