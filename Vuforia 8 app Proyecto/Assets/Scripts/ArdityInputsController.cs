using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArdityInputsController : MonoBehaviour
{
    public string mensaje;
    //public PuertoController puerto;

    void Update()
    {
        
        //int valor = int.Parse(puerto.datos);
        if(GameMaster.instance.jugador != null)
        {
            /*
            if (valor < 450)
            {
                GameMaster.instance.jugador.GetComponent<PlayerController>().girarDerecha();
            }
            else if(valor < 550)
            {
                
            }
            else
            {
                GameMaster.instance.jugador.GetComponent<PlayerController>().girarIzquierda();
            }*/
            if(Input.GetKey(KeyCode.A))
            {
                GameMaster.instance.jugador.GetComponent<PlayerController>().girarDerecha();
            }
            if (Input.GetKey(KeyCode.D))
            {
                GameMaster.instance.jugador.GetComponent<PlayerController>().girarIzquierda();
            }
        }
    }

    void OnConnectionEvent(bool success)
    {

    }
}
