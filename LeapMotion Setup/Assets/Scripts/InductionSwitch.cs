using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InductionSwitch : MonoBehaviour
{
    public GameObject swi;
    bool isOn = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finger")
        {
            if (!isOn)
            {
                swi.SetActive(true);
                isOn = true;
            }
            else
            {
                swi.SetActive(false);
                isOn = false;
            }
        }
    }
}
