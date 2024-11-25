using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public int points; //Variable que almacena los puntos del jugador
    public int winPoints; //Define la cantidad de puntos necesarios para pasar de nivel
    public GameObject winGoal; //Referencia al objeto que representa la meta
    public int puntosTotales;
    public TMP_Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (points >= winPoints)
        {
            winGoal.SetActive(true);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            points = points + 1;
            other.gameObject.SetActive(false); //Apaga el objeto con el que he chocado
            //Destroy(other.gameObject);
        }

        pointsText.text = "Feathers = " + points.ToString();

        if (other.gameObject.CompareTag("Final"))
        {
            if (points >= winPoints)
            {
                SceneManager.LoadScene("GoodEnding");
            }
            else
            {
                SceneManager.LoadScene("BadEnding");
            }
        }
    }
    


}
