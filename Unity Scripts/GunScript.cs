using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float range = 0f;
    public float delay = 0.72f;
    public int i;
    public Transform barrel;
    public ParticleSystem Extinguidizante;

    void Start()
    {

        Extinguidizante.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Extinguidizante.Play(); 
        }
        if (Input.GetButtonUp("Fire1"))
        {
           Extinguidizante.Stop();
        }
        if (Input.GetButton("Fire1"))
        {
            StartCoroutine("Delay");
        }

    }

    //
    IEnumerator Fire()
    {
        RaycastHit hit;
        Ray ray = new Ray(barrel.position, transform.forward);


        if (Physics.Raycast(ray, out hit, range))
        {
            if (hit.collider.tag == "Enemy")
            {
                Enemy enemy = hit.collider.GetComponent<Enemy>();
                enemy.health -= .25f;
            }

        }
        Debug.DrawRay(barrel.position, transform.forward * range, Color.red);
        yield return null;
    }

    //
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        StartCoroutine("Fire");
    }



}



