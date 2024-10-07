using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operaciones : MonoBehaviour
{
    public int a = 11;
    public int b = 2;
    public int c;

    public string nombre = "Jorge";
    public string saludo = "Hola que tal";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a + b); //Esto es una suma
        Debug.Log(a - b); //Esto es una resta
        Debug.Log(a * b); //Esto es una multiplicación
        Debug.Log(a / b); //División
        Debug.Log(a % b); //Resto
        Debug.Log(++a); //+1
        Debug.Log(--a); //-1
        c = a + b;
        Debug.Log(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
