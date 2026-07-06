using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
     public TextMeshProUGUI txt_Score; 
     public TextMeshProUGUI txt_Temporizador;
     public GameObject panelWin;
     public GameObject panelGameOver;
     public GameObject panelTemporizador;
     public GameObject panelScore;
     public GameObject panelInicio;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTimer(0);
        txt_Temporizador.gameObject.SetActive(false);
        txt_Score.gameObject.SetActive(false);
        panelTemporizador.SetActive(false);
        panelScore.SetActive(false);
        panelWin.SetActive(false);
        panelGameOver.SetActive(false);
    }

    public void UpdateScore (int score) {
        txt_Score.text = "Score: " + score;
        }

    public void UpdateTimer (float timer) {
    if (timer < 0)
        {
            timer = 0;
        }
        txt_Temporizador.text = timer.ToString("F2");
    } 

    public void MostrarPantallaWin(){
        panelWin.SetActive(true);
        txt_Temporizador.gameObject.SetActive(false);
        txt_Score.gameObject.SetActive(false);
        panelTemporizador.SetActive(false);
        panelScore.SetActive(false);
    }

    public void MostrarPantallaGameOver(){
        panelGameOver.SetActive(true);
        txt_Temporizador.gameObject.SetActive(false);
        txt_Score.gameObject.SetActive(false);
        panelTemporizador.SetActive(false);
        panelScore.SetActive(false);
    }
}