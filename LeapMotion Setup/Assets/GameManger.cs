using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public GameObject bakingsoda;
    public int middleMixCount;
    public int totalMixCount;
    public Text totalMixText;
    public Text mixCount;

    void Awake()
    {
        totalMixText.text = "/ " + middleMixCount.ToString();
    }

    public void Mix(int count)
    {
        mixCount.text = count.ToString();
        if (bakingsoda.activeInHierarchy)
            totalMixText.text = " / " + totalMixCount.ToString();
    }

}
