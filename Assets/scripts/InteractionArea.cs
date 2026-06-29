﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public int score = 0;
    UIManager uiManag;

    void Awake() {
        uiManag = Object.FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter (Collider col) {
    if (col.gameObject.CompareTag ("Coleccionable")){
        score++;
        uiManag.UpdateScore(score);
        Debug.Log("Has recolectado " + score + " discos");
        Destroy(col.gameObject);

    if (score >= 5){
        uiManag.MostrarPantallaWin();
        Time.timeScale = 0;
        }
    }
    }
}
