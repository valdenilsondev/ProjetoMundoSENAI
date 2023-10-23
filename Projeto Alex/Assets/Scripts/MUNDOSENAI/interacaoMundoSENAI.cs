using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoMundoSENAI : MonoBehaviour
{
   
    private bool isVerificarToque;
    private bool isPainel;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (isVerificarToque)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isPainel = !isPainel;
            }
        }

        if(isPainel){
            print("Toquei No objeto");
            isPainel = false;
        }
    }

     private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}
