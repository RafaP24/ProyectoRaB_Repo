using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Variables de referencia privada
    private float horInput; //Referencia al input horizontal del teclado
    private float verInput; //Referencia al input vertical del teclado

    [Header("General References")]
    public Rigidbody playerRB; //Almacén del Rigidbody del player. Me permite moverlo.
    public AudioSource playerAudio; //Referencia al reproductor de sonidos del player


    [Header("Movement Variables")]
    public float speed;

    [Header("Jump Varibales")]
    public float jumpForce;
    public bool isGrounded;

    [Header("Sound Library")]
    public AudioClip[] soundLibrary; //"Estantería" de sonidos del player 

    [Header("Respawn Configuration")]
    public GameObject respawnPoint; //ref al objeto que marca el punto de rtespawn (transform)
    public float fallLimit; //Valor en -y que al alcanzarlo se ejecutará el respawn



    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Almacenar de manera constante el input del teclado en los ejes X e Y
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
        Jump();
        if (transform.position.y < fallLimit) { Respawn(); }

    }


    private void FixedUpdate()
    {
        //Aquí se codea//llama a acciones que dependan de la física CONSTANTE
        //VelocityMove();
        
      ForceMove();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))

        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))

        { 
            playerAudio.PlayOneShot(soundLibrary[2]);
        }
            
       
    }


    void VelocityMove()
    {
        //motor que hace el movimiento basado en afectar al velocity que imita la capacidad de moverse
        playerRB.velocity = new Vector3(horInput * speed, playerRB.velocity.y, verInput * speed);
    }

    void ForceMove()
    {
        //Movimiento basado en aplicar fuerza de empuje en dos ejes: X/Z
        playerRB.AddForce(Vector3.right * horInput * speed);
        playerRB.AddForce(Vector3.forward * verInput * speed);
    }


    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            playerAudio.PlayOneShot(soundLibrary[0]);
            isGrounded = false;
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    void Respawn()


    //cambia la posición del player por la posicion del punto de respawn
    {

        playerAudio.PlayOneShot(soundLibrary[1]);
        transform.position = respawnPoint.transform.position;
    }
}
