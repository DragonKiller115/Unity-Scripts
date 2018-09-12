using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restablecer : MonoBehaviour {

    private GameObject Cubito;
    #region Posicion_Predeterminada
    [Header("Posicion predeterminada")]
    public int X = 1;
    public int Y = 5;
    public int Z = 1;
    #endregion

    #region Escala_Predeterminada
    [Header("Escala predeterminada")]
    public int A = 1;
    public int B = 1;
    public int C = 1;
    #endregion

    #region Move config
    [Header("Move config")]
    public float DeltaMovement = 10;
    #endregion

    void Start ()
    {
        transform.position = new Vector3(X, Y, Z);
        transform.localScale = new Vector3(A, B, C);
    }
	
	
	void FixedUpdate ()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * DeltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * DeltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * DeltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * DeltaMovement * Time.deltaTime);
    }
}
