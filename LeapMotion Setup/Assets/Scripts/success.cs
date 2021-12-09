using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class success : MonoBehaviour
{
    public GameManger manager;
    public Dalgona dalgona;
    public GameObject dalgonaObject;
    public GameObject needle;
    public GameObject cam;
    public GameObject BbogiUI;
    public GameObject SuccessUI;
    public GameObject caution;

    Renderer render;

    void Awake()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        if(dalgona.black == 1)
        {
            BbogiUI.SetActive(false);
        }
        if (dalgona.black == 50)
        {
            render.enabled = true;
            // 달고나와 바늘 오브젝트를 끄고
            // 카메라 조정
            cam.transform.position = new Vector3(0.298f, 1.567f, 0.107f);
            cam.transform.rotation = Quaternion.identity;
            dalgonaObject.SetActive(false);
            needle.SetActive(false);
            caution.SetActive(false);
            dalgona.board.GetComponent<MeshRenderer>().enabled = true; // 보드 그래픽 활성화
            SuccessUI.SetActive(true); // 성공 UI
            manager.stopTImer = true; // 시간 멈추기
        }
    }
}
