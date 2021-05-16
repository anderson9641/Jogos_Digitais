using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inteface : MonoBehaviour
{
    //  ------------Temporizador  ------------
    public float tempoTotal;
    private float tempoGasto;
    public Text textoTempo;
    int minutos;
    int segundos;
    //  -------------- Pontuação --------
    private int scoreGanho;
    public Text scoreLevel;
    public Text textoScore;
    public Text textoScoreFinal;

    //  ------------- Telas e Leveis -------------
    public string proximoLevel;
    private bool levelEnd;
    public GameObject telaDePause;
    public GameObject telaGameOver;
    public GameObject telaLevelUp;
    void Start()
    {
        Scene cenaAtual = SceneManager.GetActiveScene();
        levelEnd = false;
        Time.timeScale = 1;
        tempoGasto = tempoTotal;
        if (cenaAtual.name == "Level-1")
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
        timeview();

        if (Input.GetKeyDown(KeyCode.Escape) && levelEnd == false)
        {
            pauseGame();
        }
    }

    void timeview(){
        tempoGasto -= Time.deltaTime;
        minutos = (int)(tempoGasto / 60);
        segundos = (int)(tempoGasto % 60);
        if (segundos < 10 && segundos > 0)
        {
            textoTempo.text = "0" + minutos.ToString("F0") + " : " + "0" + segundos.ToString("F0");
        }
        else if(segundos > 0)
        {
            textoTempo.text = "0" + minutos.ToString("F0") + " : " + segundos.ToString("F0");
        }
        if (minutos <= 0 && segundos <= 0)
        {
            gameOver();
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
            levelEnd = true;

        }
    }

    public void levelUp()
    {
        telaLevelUp.SetActive(false);
        SceneManager.LoadScene(proximoLevel);

    }

    public void gameOver(){
        textoScoreFinal.text = scoreGanho.ToString("F0");
        Cursor.lockState = CursorLockMode.None;
        telaLevelUp.SetActive(false);
        telaGameOver.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void exitToMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Menu");

    }

    public void exitToGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        telaDePause.SetActive(false);
    }

    public void restartLevel()
    {
        Scene cena = SceneManager.GetActiveScene();
        exitToGame();
        SceneManager.LoadScene(cena.name);
    }

    void pauseGame(){
        if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                telaDePause.SetActive(true);
                Cursor.lockState = CursorLockMode.None;

            }
            else
            {
                exitToGame();
            }
    }
    
}
