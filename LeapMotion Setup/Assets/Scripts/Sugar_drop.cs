using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sugar_drop : MonoBehaviour
{
    public GameObject sugar_white;
    public int sugarCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SugarCase")
        {
            sugarCount++;
        }
    }

    void FixedUpdate()
    {
        if (sugarCount == 5)
            sugar_white.SetActive(true);
    }
}
