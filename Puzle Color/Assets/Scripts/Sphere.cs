using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Color[] cores;
    private Rigidbody rg;
    public float velo = 20f;
    private string CurrentColor = "Branco";
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moviment = new Vector3(h, 0, v);
        moviment.Normalize();
        rg.AddForce(moviment * velo);



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("CuboAzul"))
        {
            Color cor = cores[1];
            GetComponent<Renderer>().material.color = cor;
            Destroy(other.gameObject);
            CurrentColor = "Azul";

        }else if (other.tag.Equals("CuboVerde"))
        {
            Color cor = cores[0];
            GetComponent<Renderer>().material.color = cor;
            Destroy(other.gameObject);
            CurrentColor = "Verde";

        }else if (other.tag.Equals("CuboVermelho"))
        {
            Color cor = cores[2];
            GetComponent<Renderer>().material.color = cor;
            Destroy(other.gameObject);
            CurrentColor = "Vermelha";
        }

        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("ParedeAzul") && CurrentColor.Equals("Azul"))
        {
            Destroy(other.gameObject);

        }else if (other.collider.CompareTag("ParedeVerde") && CurrentColor.Equals("Verde"))
        {
            Destroy(other.gameObject);

        }else if (other.collider.CompareTag("ParedeVermelha") && CurrentColor.Equals("Vermelha"))
        {
            Destroy(other.gameObject);
        } 
        
    }
}
