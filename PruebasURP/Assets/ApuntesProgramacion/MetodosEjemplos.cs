using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodosEjemplos : MonoBehaviour
{
    //Variables para ejemplo de método con referencia
    public float carSpeed = 20;
    public float normalMode = 1;
    public float nitroMode = 5;
    public bool nitroEnabled = false;

    // Variables para ejemplo de método con tipo de dato
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

    // Ejemplo de Método (Acción) sin tipo de dato. Acción genérica
    // visibilidad + void + Nombre + () +  {}
    private void Movement()
    {
        // Aquí se codea la representación de la acción
    }

    //Ejemplo de método con valor de referencia
    private void CarAcceleration(float speedMultiplier)
    {
        carSpeed = carSpeed * speedMultiplier;
    }

    // Ejemplo de método con tipo de dato. Necesita devolver un dato del mismo tipo o el ordenador explota
    private int MultiplyAction()
    {
        totalNumber = numberA + numberB;
        return totalNumber;
    }
}
