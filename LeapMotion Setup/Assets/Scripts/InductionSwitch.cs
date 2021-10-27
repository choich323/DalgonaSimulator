using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InductionSwitch : MonoBehaviour
{
    public GameObject swi;
    public GameObject burned;
    public GameObject white;
    public GameObject white_mole;
    public GameObject brown_mole;

    bool isOn = false;
    bool swtchReady = true;
    float burningCount; // 실패 판단
    float swtchDelay;
    public float rate;
    
    void Update()
    {
        Burned();
        swtchDelay += Time.deltaTime;
        swtchReady = rate < swtchDelay;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finger" && swtchReady)
        {
            if (!isOn)
            {
                swi.SetActive(true);
                isOn = true;
                swtchDelay = 0;
            }
            else
            {
                swi.SetActive(false);
                isOn = false;
                swtchDelay = 0;
            }
        }
    }

    void Burned()
    {
        burningCount += Time.deltaTime;
        if(burningCount > 40)
        {

        }
    }
}
