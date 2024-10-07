using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeColor : MonoBehaviour
{
    public MeshRenderer MyMesh;
    public Material objectMaterial;
    public Material colorMaterial;

    // Start is called before the first frame update
    void Start()
    {
        MyMesh.material = colorMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
