using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFade : MonoBehaviour
{
   public FlashLight flashLightScript;


     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FlashLight"))
        {
         
            flashLightScript.Light.intensity = 10;
          
            Debug.Log("work");
        }
        
    }
    void Update()
    {
        
    }

}
