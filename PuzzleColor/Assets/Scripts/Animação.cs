
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
        if(Input.GetKey(KeyCode.W)){
            anim.SetInteger("transicao", -1);
        }else if(Input.GetKey(KeyCode.S)){
            anim.SetInteger("transicao", 1);
        }else if(Input.GetKey(KeyCode.A)){
            anim.SetInteger("transicao", -2);
        }else if(Input.GetKey(KeyCode.D)){
            anim.SetInteger("transicao", 2);
        }else{
            anim.SetInteger("transicao", 0);
        }
    }
}
