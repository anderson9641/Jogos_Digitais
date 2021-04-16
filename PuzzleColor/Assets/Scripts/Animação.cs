
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animação : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            anim.SetInteger("transicao", -1);
        }else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            anim.SetInteger("transicao", 1);
        }else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            anim.SetInteger("transicao", -2);
        }else if(Input.GetKey(KeyCode.D ) || Input.GetKey(KeyCode.RightArrow)){
            anim.SetInteger("transicao", 2);
        }else{
            anim.SetInteger("transicao", 0);
        }
    }
}
