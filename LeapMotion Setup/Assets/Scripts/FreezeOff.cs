using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOff : MonoBehaviour
{
    Rigidbody rigid;


    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Palm")
        {

        }
    }
}
