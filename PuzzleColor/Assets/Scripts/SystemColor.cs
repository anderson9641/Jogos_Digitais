using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemColor : MonoBehaviour
{
    public Color[] cores;
    private Rigidbody rg;
    private string CurrentColor = "Branco";
    [SerializeField] GameObject sprite;
 
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("CuboAzul"))
        {
            Color cor = cores[1];
            sprite.GetComponent<Renderer>().material.color = cor;
            Destroy(other.gameObject);
            CurrentColor = "Azul";

        }else if (other.tag.Equals("CuboAmarelo"))
        {
            Color cor = cores[0];
            sprite.GetComponent<Renderer>().material.color = cor;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            CurrentColor = "Amarelo";

        }else if (other.tag.Equals("CuboVermelho"))
        {
            Color cor = cores[2];
            sprite.GetComponent<Renderer>().material.color = cor;
            Destroy(other.gameObject);
            CurrentColor = "Vermelha";
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

        }else if (other.collider.CompareTag("ParedeVermelha") && CurrentColor.Equals("Vermelha"))
        {
            Destroy(other.gameObject);
        }

    }

    
}
