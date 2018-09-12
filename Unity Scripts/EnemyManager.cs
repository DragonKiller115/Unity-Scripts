using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public GameObject Fuego1;
    public GameObject Fuego2;
    public int ifuego1;
    public int ifuego2;

    float Time =1.5f;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("1"))
        {
            Instantiate(Fuego1);
        }
        if (Input.GetKeyDown("2"))
        {
            Instantiate(Fuego2);
        }
    }
}
