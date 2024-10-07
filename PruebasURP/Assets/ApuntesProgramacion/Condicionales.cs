using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int carSpeed; // Variable para indicar la velocidad del coche ficticio
    public int minSpeed; // Variable para determinar vel mínima
    public int maxSpeed; // Variable para determinar vel máxima
    public bool goodDriving;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(carSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (carSpeed > maxSpeed)
        {
            Debug.Log("Te estás pasando de velocidad...");
            goodDriving = false;
        }
        else if (carSpeed < minSpeed)
        {
            Debug.Log("Vas por debajo de la velocidad correcta...");
            goodDriving = false;
        }
        else
        {
            Debug.Log("Conduces de puta madre!...");
            goodDriving = true;
        }
    }
}
