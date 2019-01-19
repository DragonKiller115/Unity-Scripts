using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalizer : MonoBehaviour
{
    private bool finalizer = false;
    private bool comprobation = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Press method for stop the count.
        Press();
        //Comprobation for count execution.
        if(!comprobation)
        {
            comprobation = true;
            StartCoroutine(Count());           
        }
    }

    void Press()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Debug.Log("Method stoped<Count>");
            finalizer = true;
        }
    }
    IEnumerator Count()
    {
        if(!finalizer)
        {
            for(int i = 1; i != 0; i++)
            {
                Debug.Log("Segundos: " + i + "s");
                yield return new WaitForSeconds(1f);
                //Comprobation for break the count
                if(finalizer)
                {break;}
            }
        } 
    }
}
