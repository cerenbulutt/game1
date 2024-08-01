using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigid;
    [SerializeField] float timetoWait=5f;
    void Start()
    {
        render = GetComponent<MeshRenderer>(); 
        render.enabled = false;    
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }

    
    void Update()
    {
       if(Time.time > timetoWait)
       {
        render.enabled = true;
        rigid.useGravity = true;

       }
    }
}
