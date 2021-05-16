using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{

    public Text textoTempo;
    public Text textoScore;
    public Text textoScoreFinal;
    public Text scoreLevel;

    public GameObject telaGameOver;
    public GameObject telaLevelUp;

    private int scoreGanho;
    int minutos;
    int segundos;
    public float passa = 0f;

    public float tempoTotal;
    private float tempoGasto;
    public string proximoLevel;

    private void Start()
    {
        Time.timeScale = 1;
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
            textoScoreFinal.text = scoreGanho.ToString("F0");
            SceneManager.LoadScene("Menu");
        }


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            int tempoLevel = ((int)tempoGasto);
            scoreGanho = scoreGanho + tempoLevel;
            scoreLevel.text = tempoLevel.ToString("F0");
            Cursor.lockState = CursorLockMode.None;
            telaLevelUp.SetActive(true);
            PlayerPrefs.SetInt("score", scoreGanho);
            textoScore.text = scoreGanho.ToString("F0");
            Time.timeScale = 0;

        }
    }

    public void levelUp()
    {
        telaLevelUp.SetActive(false);
        SceneManager.LoadScene(proximoLevel);

    }

    public void gameOver(){

    }
}
