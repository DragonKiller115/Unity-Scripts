using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float DeltaRotation = 10;
    public float DeltaMovement = 10;
    private GameObject cubo;
    private GameObject plane;
    void Start()
    {

    }

    void FixedUpdate()
    {
        Entrada();
        Movement();

    }
    void Entrada()
    {
        if (Input.GetKey(KeyCode.R))
            transform.Rotate(new Vector3(0f, -DeltaRotation, 0f));
        else if (Input.GetKey(KeyCode.F))
            transform.Rotate(new Vector3(0f, DeltaRotation, 0f));
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