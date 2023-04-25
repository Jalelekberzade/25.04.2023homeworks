using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject1 : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject.GetComponent<BoxCollider>());
        gameObject.tag = "changed";
        if (CompareTag("changed"))
        {
            gameObject.name = "changed";
            DestroyScriptInstance();
            
        }
    }

    void DestroyScriptInstance()
    {
        Destroy(this);
    }



    void Update()
    {
        
    }
}
