using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPointColor : MonoBehaviour
{
    public float contador;
    public float tempoLimite;

    [SerializeField] GameObject[] cubo;


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

        
    }
}
