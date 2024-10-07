using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject respawnPoint; //Ref al objeto del que se toma la posición al respawnear
    public Rigidbody playerRb; //Ref al Rigibody del objeto player

    public float speed;
    public float jumpForce;
    public float respawnLimit = -20;
    float inputX;
    float inputY;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        //Ejemplo de tp
        //transform.position = new Vector3(3, 0.5f, -2);
        isGrounded = true; //Al inicio del juego el personaje puede saltar
    }

    // Update is called once per frame
    void Update()
    {
        InputUpdating();
        Movement();
        Respawn();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void Movement()
    {
        transform.Translate(Vector3.right * speed *inputX * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * inputY * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded ==true)
        {
            isGrounded = false;
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void Respawn()
    {
        if (transform.position.y < respawnLimit)
        {
            transform.position = respawnPoint.transform.position;
        }
    }

    void InputUpdating()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }
}
