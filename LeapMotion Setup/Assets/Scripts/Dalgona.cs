using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalgona : MonoBehaviour
{
    public GameObject cam;
    public GameObject touchDalgonaUI;
    public GameObject press;
    public GameObject frame;
    public GameObject star;
    public GameObject board;
    public GameObject needle;

    public bool isTouch;
    public int black; // ¹Ù´Ã·Î Âñ¸° °÷ÀÇ ¼ö
    SphereCollider sphere;
    Animator anim;

    float x; float z;

    void Awake()
    {
        sphere = GetComponent<SphereCollider>();
        anim = GetComponent<Animator>();
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
        if(other.gameObject.tag == "Finger" && !sphere.enabled && !isTouch)
        {
            x = star.transform.position.x;
            z = star.transform.position.z;
            isTouch = true;
            touchDalgonaUI.SetActive(false);
            anim.SetBool("isTouch", true);
            board.GetComponent<MeshRenderer>().enabled = false;
            cam.transform.position = new Vector3(0.3f, 1.8f, 0.3f);
            cam.transform.rotation = Quaternion.Euler(80, 0, 0);
            press.SetActive(false);
            frame.SetActive(false);
            needle.SetActive(true);
        }
    }
}
