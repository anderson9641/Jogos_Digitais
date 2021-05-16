using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePause : MonoBehaviour
{
    public GameObject telaDePause;

    public GameObject scriptTemporizador;
    void Update()
    {
                
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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
    public void exitToMenu()
    {
        
        SceneManager.LoadScene("Menu");

    }
    public void restartLevel()
    {
        Scene cena = SceneManager.GetActiveScene();
        exitToGame();
        SceneManager.LoadScene(cena.name);
    }

    public void exitToGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        telaDePause.SetActive(false);
    }
}
