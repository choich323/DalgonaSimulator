using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class success : MonoBehaviour
{
    public Dalgona dalgona;
    public GameObject dalgonaObject;
    public GameObject needle;
    public GameObject cam;

    Renderer render;

    void Awake()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        if (dalgona.black == 50)
        {
            render.enabled = true;
            // 달고나와 바늘 오브젝트를 끄고
            // 카메라 조정
            cam.transform.position = new Vector3(0.298f, 1.567f, 0.107f);
            cam.transform.rotation = Quaternion.identity;
            dalgonaObject.SetActive(false);
            needle.SetActive(false);
            dalgona.board.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
