using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaControlador : MonoBehaviour
{
    public Animator animator;
    

    private void Awake()
    {
        animator.SetBool("Abrir",false);
    }

    public void AbrirCerrarPuerta()
    {
        bool Estado_Puerta = animator.GetBool("Abrir");

        if (Estado_Puerta == true){
            animator.SetBool("Abrir",false );
        }

        if (Estado_Puerta == false)
        {
            animator.SetBool("Abrir",true);
        }
    }

}
