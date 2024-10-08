using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Point System Parameters")]
    // Variables para definir los puntos del jugador
    public int currentPoints;
    public int winPoints;

    [Header("Respawn Parameters")]
    public Transform respawnPoint;
    public float respawnFallLimit;

    private void Update()
    {
        if (currentPoints < 0) { currentPoints = 0; }
        if (transform.position.y <= respawnFallLimit) { Respawn(); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            currentPoints += 1;
            other.gameObject.SetActive(false);
            // Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("PickDown"))
        {
            currentPoints -= 1;
            other.gameObject.SetActive(false);
            // Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) { Respawn(); }
    }
    void Respawn()
    {
        transform.position = respawnPoint.position;
    }
}
