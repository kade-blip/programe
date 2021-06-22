using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batterStation : MonoBehaviour
{
   public FlashLight flashLightScript;
    public bool chargeStation = false;


     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FlashLight"))
        {
            chargeStation = true;
        }


    }
     void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FlashLight"))
        {
            chargeStation = false;
        }
    }
    void Update()
    {
         
       
        if (chargeStation == true)
        {
            flashLightScript.Light.intensity = 10; // checks to see if your in the charge station area and keeps intesity at 10 untill left 
        }
        if (chargeStation == false)
        {
            flashLightScript.Light.intensity = flashLightScript.Light.intensity; // checks if you are in the station area if its false then charge goes down
        }
           

        
    }
   
}
