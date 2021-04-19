using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    
    public Text textoTempo;
    int minutos;
    int segundos;
    public float tempoTotal;
    void Update()
    {
        tempoTotal -= Time.deltaTime;
        minutos = (int) (tempoTotal / 60);
        segundos = (int) (tempoTotal % 60);
        if(segundos < 10){
            textoTempo.text = "0" + minutos.ToString("F0") + " : "+ "0" + segundos.ToString("F0");
        }else{
            textoTempo.text = "0" + minutos.ToString("F0") + " : " + segundos.ToString("F0");
        }
        if(minutos <= 0 && segundos <= 0){
            textoTempo.text = " Game Over ";
        }
        
        

    }
}
