using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploScript : MonoBehaviour
{
    // Variables primitivas
    public int cantidadFrutas; // Variable Int = almacén de números enteros
    public float precioFrutas;
    public string nombreDependiente;
    public bool tiendaEstaAbierta;
    public int numeroConcreto = 4;
    public float altura = 1.80f;
    public string nombre = "Casimiro Ramirez";
    public bool esChico = true;

    // Variables complejas o compuestas
    public Vector3 posicion; //Vector3 = float x, float y, float z
    public Vector2 posicion2D; //Vector2 = float x, float y
    public Vector3 vector3Ejemplo = new Vector3(5.5f, 3.5f, -1.4f);

    // Variables de referencia
    public Transform miTransform;
    public Material miMaterial;
    public BoxCollider miCol;
    public Rigidbody miRigibody;
    public MeshRenderer miMalla;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
