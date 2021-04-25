using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProximoNivel : MonoBehaviour
{   
    public string proximoLevel;
    public void OnTriggerEnter(Collider other){
         if(other.tag.Equals("Player")){
             SceneManager.LoadScene(proximoLevel);
         }
     }
}
