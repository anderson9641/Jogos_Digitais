using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject painelTutorial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void starGame(){
        SceneManager.LoadScene("Level-1");
    }

    public void quitGame(){
        UnityEditor.EditorApplication.isPlaying = false;

        //Jogo Compilado
        //Application.Quit();
    }

    public void showTutorial(){
        painelTutorial.SetActive(true);
    }
    public void backToMenu(){
        painelTutorial.SetActive(false);
    }
}
