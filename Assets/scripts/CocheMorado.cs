using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocheMorado : MonoBehaviour
{

    public float distanciaAvance = 1.5f;

    public GameObject cocheNaranja;
    public GameObject cocheVerde;

    public int numeroPasosContador = 0;
    public int numeroPasosFinal = 30;

    public bool llegadoFinal = false;

    public Text numeroPasosCocheMorado;
    public Text victoriaCocheMorado;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool botonAvanceCar = Input.GetKeyDown(KeyCode.L);

        if (numeroPasosContador >= numeroPasosFinal) {

            llegadoFinal = true;
        }

        if (botonAvanceCar && !llegadoFinal && !cocheVerde.GetComponent<CocheVerde>().llegadoFinal && !cocheNaranja.GetComponent<CocheNaranja>().llegadoFinal)
        {

            numeroPasosContador++;
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + distanciaAvance, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);

        }

        numeroPasosCocheMorado.text = ("Pasos Coche Morado: " + numeroPasosContador);

        if (llegadoFinal)
        {
            victoriaCocheMorado.text = "Victoria del Coche Morado";
        }

    }

}