using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {
    public GameObject objeto; 
    void OnCollisionEnter(Collision collision)
    {
        Destroy(objeto);
        Debug.Log("El objeto ha sido destruido");
    }
}
