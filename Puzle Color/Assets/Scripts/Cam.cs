using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject target;
    public float xOffSet, yOffSet, zOffSet, mouseX, mouseY;


    void Update()
    {
        transform.position = target.transform.position + new Vector3(xOffSet, yOffSet, zOffSet);
        transform.LookAt(target.transform.position);

       // mouseX += Input.GetAxis("Mouse X");
       // mouseY -= Input.GetAxis("Mouse Y");

       // transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}