using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    
    public Light Light;
    
    



    void Start()
    {
        Light = GetComponent<Light>(); //its getting the component light 
        Light.intensity = 10f; // seting the insial intesity of the light 
    }

    void Update()
    {
       


        if (Input.GetKeyUp(KeyCode.Space)) // key to turn on/off the light
        {
            Light.enabled = !Light.enabled; // this is making sure that when the key is pressed the action happens 
           
        }


        Light.intensity -= Time.deltaTime * 0.33f; // gets the intesity of the light and decress it over time and the 0.33 is the speed it decresses at 
       

    }

   









}
