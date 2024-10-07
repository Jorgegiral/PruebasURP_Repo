using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Variables para definir los puntos del jugador
    public int currentPoints;
    public int winPoints;

    private void Update()
    {
        if (currentPoints < 0) { currentPoints = 0; }
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
}
