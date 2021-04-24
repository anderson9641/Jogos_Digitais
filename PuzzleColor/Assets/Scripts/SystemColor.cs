using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemColor : MonoBehaviour
{
    public Color[] cores;
    private Rigidbody rg;
    public string CurrentColor = "Branco";
    [SerializeField] GameObject[] sprite;
 
    public void OnTriggerEnter(Collider other)
    {
        if (CurrentColor.Equals("Branco") && other.tag.Equals("CuboAzul"))
        {
            Color cor = cores[2];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            CurrentColor = "Azul";

        }else if (CurrentColor.Equals("Branco") && other.tag.Equals("CuboAmarelo"))
        {
            Color cor = cores[1];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            CurrentColor = "Amarelo";

        }else if (CurrentColor.Equals("Branco") && other.tag.Equals("CuboVermelho"))
        {
            Color cor = cores[3];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            CurrentColor = "Vermelho";
        }
        
        //  Quando for Azul

        if (CurrentColor.Equals("Azul") && other.tag.Equals("CuboAmarelo")
        || CurrentColor.Equals("Amarelo") && other.tag.Equals("CuboAzul"))
        {
            Color cor = cores[4];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            CurrentColor = "Verde";

        }else if (CurrentColor.Equals("Azul") && other.tag.Equals("CuboVermelho")
        || CurrentColor.Equals("Vermelho") && other.tag.Equals("CuboAzul"))
        {
            Color cor = cores[5];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            CurrentColor = "Violeta";
        }

        // QUando for Vermelho

        if (CurrentColor.Equals("Vermelho") && other.tag.Equals("CuboAmarelo")
        || CurrentColor.Equals("Amarelo") && other.tag.Equals("CuboVermelho"))
        {
            Color cor = cores[6];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            CurrentColor = "Laranja";

        }

        // Quando as cores secundarias 

        if (other.tag.Equals("CuboBranco"))
        {
            Color cor = cores[0];
            sprite[0].GetComponent<Renderer>().material.color = cor;
            sprite[1].GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            CurrentColor = "Branco";

        }
        if (other.tag.Equals("CuboBranco"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.tag.Equals("CuboAmarelo"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.tag.Equals("CuboAzul"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.tag.Equals("CuboVermelho"))
        {
            other.gameObject.SetActive(false);
        }

        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("ParedeAzul") && CurrentColor.Equals("Azul"))
        {
            Destroy(other.gameObject);

        }else if (other.collider.CompareTag("ParedeAmarela") && CurrentColor.Equals("Amarelo"))
        {
            
            Destroy(other.gameObject);

        }else if (other.collider.CompareTag("ParedeVermelha") && CurrentColor.Equals("Vermelho"))
        {
            Destroy(other.gameObject);
        }else if (other.collider.CompareTag("ParedeVerde") && CurrentColor.Equals("Verde"))
        {
            Destroy(other.gameObject);
        }else if (other.collider.CompareTag("ParedeLaranja") && CurrentColor.Equals("Laranja"))
        {
            Destroy(other.gameObject);
        }else if (other.collider.CompareTag("ParedeVioleta") && CurrentColor.Equals("Violeta"))
        {
            Destroy(other.gameObject);
        }

    }

    
}
