using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPointColor : MonoBehaviour
{
    public float contador;
    public float tempoLimite;

    [SerializeField] GameObject cubo;
    public GameObject cuboAmarelo;
    public GameObject cuboBranco;
    
    void Update()
    {
        
        if(cubo.activeInHierarchy == false){
            contador += Time.deltaTime;
            if(contador >= tempoLimite){
                cubo.SetActive(true);
                contador = 0;
            }
        }
        if(cuboAmarelo.activeInHierarchy == false){
            contador += Time.deltaTime;
            if(contador >= tempoLimite){
                cuboAmarelo.SetActive(true);
                contador = 0;
            }
        }
        if(cuboBranco.activeInHierarchy == false){
            contador += Time.deltaTime;
            if(contador >= tempoLimite){
                cuboBranco.SetActive(true);
                contador = 0;
            }
        }
    }
}
