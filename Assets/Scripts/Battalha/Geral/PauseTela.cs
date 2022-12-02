using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PauseTela : MonoBehaviour
{
    private bool EstaPausado;
    public GameObject Painel;

    void Start()
    {
        Time.timeScale = 1f;
        EstaPausado = true;
        Painel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();
    }

    public void Pause(){

        if (EstaPausado)
        {
            EstaPausado = false;
            Time.timeScale = 0f;
            Painel.SetActive(true);
        }
        else
        {
            EstaPausado = true;
            Time.timeScale = 1f;
            Painel.SetActive(false);
        }
    }
}
