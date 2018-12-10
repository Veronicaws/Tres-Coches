using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CocheVerde : MonoBehaviour
{

    public float distanciaAvance = 1.5f;

    public int numeroPasosContador = 0;
    public int numeroPasosFinal = 30;

    public GameObject cocheMorado;
    public GameObject cocheNaranja;

    public bool llegadoFinal = false;

    public Text numeroPasosCocheVerde;
    public Text victoriaCocheVerde;


    // Update is called once per frame
    void Update()
    {

        bool botonAvanceCar = Input.GetKeyDown(KeyCode.H);

        if (numeroPasosContador >= numeroPasosFinal) {

            llegadoFinal = true;
        }

        if (botonAvanceCar && !llegadoFinal && !cocheMorado.GetComponent<CocheMorado>().llegadoFinal && !cocheNaranja.GetComponent<CocheNaranja>().llegadoFinal)
        {

            numeroPasosContador++;
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + distanciaAvance, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);

        }

        numeroPasosCocheVerde.text = ("Pasos Coche Verde: " + numeroPasosContador);

        if (llegadoFinal)
        {
            victoriaCocheVerde.text = ("Victoria de Coche Verde");
        }
    }
}