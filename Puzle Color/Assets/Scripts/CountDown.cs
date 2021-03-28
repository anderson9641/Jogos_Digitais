using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text DisplayMinutos, DisplaySegundos;
    public float tempo = 120;
    private int minutos, segundos;
    void Start()
    {

    }

    void Update()
    {
        if (tempo > 0)
        {
            minutos = (int)(tempo / 60);
            segundos = (int)(tempo % 60);

            tempo -= Time.deltaTime;
            DisplayMinutos.text = minutos.ToString("F0");
            DisplaySegundos.text = segundos.ToString("F0");
        }
    }
}
