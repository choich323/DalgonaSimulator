using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject obj;
    Rigidbody rigid;
    Vector3 pos;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        pos = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reset")
        {
            if (obj.tag == "Sugar")
            {
                obj.transform.position = new Vector3(-0.6289f, 1.433f, 0.191f);
                obj.transform.rotation = Quaternion.identity;
            }
            else if (obj.tag == "BakingSoda")
            {
                obj.transform.position = new Vector3(-0.955f, 1.433f, 0.23f);
                obj.transform.rotation = Quaternion.Euler(0, -38.612f, 0);
            }
            else if (obj.tag == "MixStick")
            {
                obj.transform.position = new Vector3(-0.7522f, 1.381f, 0.1645f);
                obj.transform.rotation = Quaternion.Euler(90, 90, 0);
            }

            rigid.velocity = Vector3.zero;
            rigid.angularVelocity = Vector3.zero;
        }
    }
}
