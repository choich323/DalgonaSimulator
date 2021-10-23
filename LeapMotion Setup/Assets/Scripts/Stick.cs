using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject sugar_brown;
    public GameObject sugar_white;
    public int total_MixCount;
    int mixCount1 = 0;
    int mixCount2 = 0;
    int mixCount3 = 0;
    int mixCount4 = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "B1")
            mixCount1++;
        else if (other.gameObject.tag == "B2")
            mixCount2++;
        else if (other.gameObject.tag == "B3")
            mixCount3++;
        else if (other.gameObject.tag == "B4")
            mixCount4++;
    }

    void FixedUpdate()
    {
        Sum();
        SugarChange();
    }

    void Sum()
    {
        total_MixCount = mixCount1 + mixCount2 + mixCount3 + mixCount4;
    }

    void SugarChange()
    {
        if (mixCount1 >= 5 && mixCount2 >= 5 && mixCount3 >= 5 && mixCount4 >= 5 && total_MixCount >= 25)
        {
            sugar_white.SetActive(false);
            sugar_brown.SetActive(true);
            total_MixCount = 0;
        }
    }
}
