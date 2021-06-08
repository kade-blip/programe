using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private Light Light;
 
   
   


    void Start()
    {
        Light = GetComponent<Light>();
    }

   
    void Update()
    {
        

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Light.enabled = !Light.enabled;
        } 
      
    }
    
}
