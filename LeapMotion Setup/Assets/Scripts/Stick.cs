using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject sugar_white;
    public GameObject sugar_white_mole;
    public GameObject sugar_brown_mole;
    public GameObject withBakingSoda;
    public GameObject sugar_brown_middle;
    public GameObject sugar_brown_high;
    public GameObject sugar_complete;
    public GameObject swtch;
    public int total_MixCount;
    int mixCount1 = 0;
    int mixCount2 = 0;
    int mixCount3 = 0;
    int mixCount4 = 0;
    float time1 = 0;
    float time2 = 0;
    float time3 = 0;

    void OnTriggerEnter(Collider other)
    {
        if (swtch.activeInHierarchy && sugar_white.activeInHierarchy && !sugar_white_mole.activeInHierarchy)
            MixCount(other, 6);
        else if (swtch.activeInHierarchy && sugar_white_mole.activeInHierarchy)
            MixCount(other, 12);
        else if (!swtch.activeInHierarchy && withBakingSoda.activeInHierarchy)
            MixCount(other, 17);
        else if (!swtch.activeInHierarchy && sugar_brown_middle.activeInHierarchy)
            MixCount(other, 22);
        else if (!swtch.activeInHierarchy && sugar_brown_high.activeInHierarchy)
            MixCount(other, 27);
    }

    void MixCount(Collider other, int value)
    {
        if (other.gameObject.tag == "B1" && mixCount1 < value)
            mixCount1++;
        else if (other.gameObject.tag == "B2" && mixCount2 < value)
            mixCount2++;
        else if (other.gameObject.tag == "B3" && mixCount3 < value)
            mixCount3++;
        else if (other.gameObject.tag == "B4" && mixCount4 < value)
            mixCount4++;
    }

    void Update()
    {
        Sum();
        SugarChangetoWhiteMole();
        SugarChangetoBrownMole();
        SugarRise();
        SugarChangeBrown_Middle();
        SugarChangeBrown_High();
        SugarChangeBrown_Complete();
    }

    void Sum()
    {
        total_MixCount = mixCount1 + mixCount2 + mixCount3 + mixCount4;
    }

    void SugarChangetoWhiteMole()
    {
        if (total_MixCount == 24 && swtch.activeInHierarchy && sugar_white.activeInHierarchy)
        {
            sugar_white_mole.SetActive(true);
        }
    }

    void SugarChangetoBrownMole()
    {
        if (total_MixCount == 48 && swtch.activeInHierarchy && sugar_white_mole.activeInHierarchy)
        {
            sugar_brown_mole.SetActive(true);
        }
    }

    void SugarRise()
    {
        if (withBakingSoda.activeInHierarchy)
        {
            time1 += Time.deltaTime;
            if (time1 > 7)
            {
                withBakingSoda.SetActive(false);
                sugar_brown_middle.SetActive(true);
            }
        }
        else if (sugar_brown_middle.activeInHierarchy)
        {
            time2 += Time.deltaTime;
            if(time2 > 6)
            {
                sugar_brown_middle.SetActive(false);
                sugar_brown_high.SetActive(true);
            }
        }
        else if (sugar_brown_high.activeInHierarchy)
        {
            time3 += Time.deltaTime;
            if(time3 > 6)
            {
                sugar_brown_high.SetActive(false);
                sugar_complete.SetActive(true);
            }
        }
    }

    void SugarChangeBrown_Middle()
    {
        if (withBakingSoda.activeInHierarchy)
        {
            if (!sugar_brown_middle.activeInHierarchy && total_MixCount == 68)
            {
                withBakingSoda.SetActive(false);
                sugar_brown_middle.SetActive(true);
            }
            else if (sugar_brown_middle.activeInHierarchy) // 실패했을 때
            {

            }
        }
    }

    void SugarChangeBrown_High()
    {
        if (sugar_brown_middle.activeInHierarchy)
        {
            if (!sugar_brown_high.activeInHierarchy && total_MixCount == 88)
            {
                sugar_brown_middle.SetActive(false);
                sugar_white_mole.SetActive(false);
                sugar_brown_mole.SetActive(false);
                sugar_brown_high.SetActive(true);
            }
            else if (sugar_brown_high.activeInHierarchy) // 실패했을 때
            {

            }
        }
    }

    void SugarChangeBrown_Complete()
    {
        if (sugar_brown_high.activeInHierarchy)
        {
            if (!sugar_complete.activeInHierarchy && total_MixCount == 108)
            {
                sugar_brown_high.SetActive(false);
                sugar_complete.SetActive(true);
            }
            else if (sugar_complete.activeInHierarchy) // 실패했을 때
            {

            }
        }
    }

}
