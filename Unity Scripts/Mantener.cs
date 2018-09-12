using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantener : MonoBehaviour {
    public GameObject objeto;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("El objeto ha colisionado");
    }
   
}
