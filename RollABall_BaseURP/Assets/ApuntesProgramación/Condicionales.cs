using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{

    public int CarSpeed;
    public int minSpeed = 20;
    public int maxSpeed = 120;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RadarDeVelocidad();
        AnularVelocidadNegativa();
    }


    void RadarDeVelocidad()

    {
        //definición de condicional
        if (CarSpeed > maxSpeed)
        {
            Debug.Log("Te estás pasando de velocidad!");
        }
        else if (CarSpeed < minSpeed)
        {
            Debug.Log("Vas demasiado lento, aprieta el acelerador");
        }
        else
        {
            Debug.Log(CarSpeed < minSpeed);
        }
    }



    void AnularVelocidadNegativa()
    {
        if (CarSpeed < 0) { CarSpeed = 0; }
    }

}
