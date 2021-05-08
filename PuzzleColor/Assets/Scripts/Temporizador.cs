using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{

    public Text textoTempo;
    public Text textoScore;
    private int scoreGanho;
    int minutos;
    int segundos;
    public float tempoTotal;
    private float tempoGasto;
    public string proximoLevel;
    
    private void Start()
    {
        tempoGasto = tempoTotal;
        if (proximoLevel == "Level-2")
        {
            PlayerPrefs.SetInt("score", 0);
        }
        else
        {            
            scoreGanho = PlayerPrefs.GetInt("score");
            textoScore.text = scoreGanho.ToString("F0");
        }

    }
    void Update()
    {

        tempoGasto -= Time.deltaTime;
        minutos = (int)(tempoGasto / 60);
        segundos = (int)(tempoGasto % 60);
        if (segundos < 10)
        {
            textoTempo.text = "0" + minutos.ToString("F0") + " : " + "0" + segundos.ToString("F0");
        }
        else
        {
            textoTempo.text = "0" + minutos.ToString("F0") + " : " + segundos.ToString("F0");
        }
        if (minutos <= 0 && segundos <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            scoreGanho = scoreGanho + ((int)tempoGasto);
            PlayerPrefs.SetInt("score", scoreGanho);
            textoScore.text = scoreGanho.ToString("F0");
            SceneManager.LoadScene(proximoLevel);
        }
    }

}
