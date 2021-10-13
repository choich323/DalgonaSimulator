using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick_Mix : MonoBehaviour
{
    public GameObject sugar_brown;
    public GameObject sugar_white;
    int mixCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stick")
        {
            mixCount++;
        }
    }

    void FixedUpdate()
    {
        if (mixCount == 5)
        {
            sugar_white.SetActive(false);
            sugar_brown.SetActive(true);
        }
    }
}
