using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocheNaranja : MonoBehaviour
{

    public float distanciaAvance = 1.5f;

    public GameObject cocheMorado;
    public GameObject cocheVerde;

    public int numeroPasosContador = 0;
    public int numeroPasosFinal = 30;

    public bool llegadoFinal = false;

    public Text numeroPasosCocheNaranja;
    public Text victoriaCocheNaranja;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool botonAvanceCar = Input.GetKeyDown(KeyCode.A);

        //bool botonUpCar = Input.GetKeyDown(KeyCode.U);
       // bool botonDownCar = Input.GetKeyDown(KeyCode.M);


        if (numeroPasosContador >= numeroPasosFinal)
        {

            llegadoFinal = true;

        }

        if (botonAvanceCar && !llegadoFinal && !cocheMorado.GetComponent<CocheMorado>().llegadoFinal && !cocheVerde.GetComponent<CocheVerde>().llegadoFinal)
        {

            numeroPasosContador++;
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + distanciaAvance, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);

        }

        //if (botonUpCar && !llegadoFinal && !car1.GetComponent<Car1>().llegadoFinal && !car3.GetComponent<Car3>().llegadoFinal)
        //{

        //    numeroPasosContador++;
        //    GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + distanciaAvance, GetComponent<Transform>().position.z);

        //}

        //if (botonDownCar && !llegadoFinal && !car1.GetComponent<Car1>().llegadoFinal && !car3.GetComponent<Car3>().llegadoFinal)
        //{

        //    numeroPasosContador++;
        //    GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y - distanciaAvance, GetComponent<Transform>().position.z);

        //}

        numeroPasosCocheNaranja.text = ("Pasos Coche Naranja: " + numeroPasosContador);

        if (llegadoFinal) { victoriaCocheNaranja.text = "Victoria del Coche Naranja"; }

    }

    //private void OnTriggerEnter(Collider other)
    //{

    //    if (other.tag == "Meta")
    //    {
    //        llegadoFinal = true;
    //    }

    //}

}