using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicMovement : MonoBehaviour
{
    Vector3 vectorEjemplo = new Vector3(3, 2, 5);
    // Start is called before the first frame update
    void Start()
    {
        MovementTransportation();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void MovementTranslation()
    {

    }

    void MovementTransportation()
    {
        transform.position = new Vector3(3, 2, 5);
    }
}
