using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float health = 100f;

    
    
	// Update is called once per frame
	void Update () {
        Debug.Log(health.ToString());
        if (health <= 0.00f)
        {
            Destroy(gameObject); 
        }

    }

}
