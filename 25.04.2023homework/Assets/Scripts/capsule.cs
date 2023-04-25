using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponentInChildren<Renderer>().enabled = false;
        
    }
    void OnTriggerExit(Collider other)
    {
        gameObject.GetComponentInChildren<Renderer>().enabled = true;
        gameObject.tag = "Entered";
    }
}
