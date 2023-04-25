using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        gameObject.name = "Empty";
        gameObject.transform.parent = collision.transform;

    }
}
