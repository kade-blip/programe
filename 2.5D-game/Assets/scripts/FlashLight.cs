using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    
    private Light Light;
    public float maxIntensity;
    public float minIntensity;
    public float intesityAmount;



    void Start()
    {
        Light = GetComponent<Light>(); //its getting the component light 
        
    }

    void Update()
    {
       


        if (Input.GetKeyUp(KeyCode.Space)) // key to turn on/off the light
        {
            Light.enabled = !Light.enabled; // this is making sure that when the key is pressed the action happens 
           
        }


        float brightness = Mathf.Clamp(10, minIntensity, maxIntensity);
        Light.intensity = brightness * maxIntensity;

        while (Light.enabled == true)
        {
            maxIntensity -= minIntensity;
            Debug.Log("working");
        }


    }

    //*private void fixedUpdate()
    //{
        //float brightness = Mathf.Clamp(10, minIntensity, maxIntensity);
        //Light.intensity = brightness * maxIntensity;
       
        //while(Light.enabled == true)
        //{
          //  maxIntensity -= minIntensity;
        //    Debug.Log("working");
      //  }
       
       

        
    //}









}
