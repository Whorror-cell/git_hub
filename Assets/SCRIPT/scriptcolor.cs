using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if
          (Input.GetKeyDown(KeyCode.Y)) //aqui asignamos la letra que tenemos que pulsar.
        {
            GetComponent<Renderer>().material.color = Color.cyan; //aqui el color que nos va a mostrar.
        }
        if
           (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if
           (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        //para ver cualquiera de los colores, deberá estar en play.
        //acuerdate de guardar tanto en visual como en unity antes de darle a play.
    }
}