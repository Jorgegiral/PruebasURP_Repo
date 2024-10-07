using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodosEjemplos : MonoBehaviour
{
    //Variables para ejemplo de m�todo con referencia
    public float carSpeed = 20;
    public float normalMode = 1;
    public float nitroMode = 5;
    public bool nitroEnabled = false;

    // Variables para ejemplo de m�todo con tipo de dato
    public int totalNumber;
    public int numberA;
    public int numberB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nitroEnabled)
        {
            CarAcceleration(nitroMode);
        }
        else
        {
            CarAcceleration(normalMode);
        }
    }

    // Ejemplo de M�todo (Acci�n) sin tipo de dato. Acci�n gen�rica
    // visibilidad + void + Nombre + () +  {}
    private void Movement()
    {
        // Aqu� se codea la representaci�n de la acci�n
    }

    //Ejemplo de m�todo con valor de referencia
    private void CarAcceleration(float speedMultiplier)
    {
        carSpeed = carSpeed * speedMultiplier;
    }

    // Ejemplo de m�todo con tipo de dato. Necesita devolver un dato del mismo tipo o el ordenador explota
    private int MultiplyAction()
    {
        totalNumber = numberA + numberB;
        return totalNumber;
    }
}
