using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalgona : MonoBehaviour
{
    public GameObject cam;
    public GameObject touchDalgonaUI;

    public bool isTouch;
    SphereCollider sphere;

    void Awake()
    {
        sphere = GetComponent<SphereCollider>();
    }

    void Update()
    {
        SphereOff();
    }

    void SphereOff()
    {
        if (touchDalgonaUI.activeInHierarchy)
            sphere.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finger" && !sphere.enabled)
        {
            isTouch = true;
            touchDalgonaUI.SetActive(false);
            cam.transform.position = new Vector3(0, 0, 0);
            cam.transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}
