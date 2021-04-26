using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPointColor : MonoBehaviour
{
    public float contador;
    public float tempoLimite;
    private float posicao;
    private Vector3 posicaoinicial;

    Scene cenaAtual;

    [SerializeField] GameObject[] cubo;
    private void Start()
    {
        cenaAtual = SceneManager.GetActiveScene();
        posicaoinicial = transform.position;
          
    }

    void Update()
    {
        for (int x = 0; x < cubo.Length; x++)
        {
            if (cubo[x].activeInHierarchy == false)
            {
                contador += Time.deltaTime;
                if (contador >= tempoLimite)
                {
                    cubo[x].SetActive(true);
                    contador = 0;
                }
            }
        }
        posicao = transform.position.y;
        if(posicao <= -4){
            transform.position = posicaoinicial;
            //SceneManager.LoadScene(cenaAtual.name);
        }

        
    }
}
