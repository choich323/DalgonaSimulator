using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    [SerializeField] private Text timer;

    public GameObject menu;

    public GameObject untilBrownUI;
    public GameObject bsPickupUI;
    public GameObject stirUI;
    public GameObject clearUI;

    public GameObject _burning;
    public GameObject _mixBar_1;
    public GameObject _mixBar_2;

    public Slider burning;
    public Slider mixBar_1;
    public Slider mixBar_2;

    float time;
    float _second;
    float _minute;
    public bool stopTImer = false;
    public bool stage2 = false;
    public int stage;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menu.activeSelf)
                menu.SetActive(false);
            else
                menu.SetActive(true);
        }
        if (menu.activeSelf)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        if(!stage2)
            BarOnoffUI();

        Timer();
    }

    void BarOnoffUI()
    {
        if (untilBrownUI.activeInHierarchy)
        {
            _mixBar_1.SetActive(true);
        }
        else if (bsPickupUI.activeInHierarchy)
        {
            _mixBar_1.SetActive(false);
        }

        if (stirUI.activeInHierarchy)
            _mixBar_2.SetActive(true);
        else if (clearUI.activeInHierarchy)
            _mixBar_2.SetActive(false);
    }

    void Timer()
    {
        if(!stopTImer)
          time += Time.deltaTime;

        _second = (int)(time % 60);
        _minute = (int)(time / 60 % 60);

        timer.text = string.Format("{0:00}:{1:00}", _minute, _second);
    }

    public void Mix(int count)
    {
        mixBar_1.value = count;
        mixBar_2.value = count;
    }

    public void Burning(int count)
    {
        burning.value = count;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Grip" + stage);
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
