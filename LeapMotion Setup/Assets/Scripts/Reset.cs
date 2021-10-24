using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{

    Rigidbody rigid;

    void Awake()
    {

        rigid = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reset")
        {
            rigid.velocity = Vector3.zero;
            rigid.angularDrag = 0f;
            rigid.angularVelocity = Vector3.zero;
        }
    }
}
