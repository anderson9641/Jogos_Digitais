using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string cena;
    public GameObject painelOption;

    void Update()
    {
        
    }

    public void startGame(){
        SceneManager.LoadScene(cena);
    }

    public void quitGame(){
        //Editor Unity
        UnityEditor.EditorApplication.isPlaying = false;

        //Jogo compilado
        //Applicatio.Quit();

    }

    public void showPainel(){
        painelOption.SetActive(true);
    }

    public void backToMenu(){
        painelOption.SetActive(false);
    }
}
