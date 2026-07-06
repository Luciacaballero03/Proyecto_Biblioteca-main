using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManag;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        uiManag = Object.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (uiManag.panelInicio.activeSelf){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1;
                uiManag.panelInicio.SetActive(false);
                uiManag.txt_Temporizador.gameObject.SetActive(true);
                uiManag.txt_Score.gameObject.SetActive(true);
                uiManag.panelTemporizador.SetActive(true);
                uiManag.panelScore.SetActive(true);
            }
            return;
        }
            timer -= Time.deltaTime;
            uiManag.UpdateTimer(timer);

             if (timer <= 0){
                timer = 0;
                uiManag.MostrarPantallaGameOver();
                Time.timeScale = 0;
            }

            if (Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                timer = 0;
        }

    }
}