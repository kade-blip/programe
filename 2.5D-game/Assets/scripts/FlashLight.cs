using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    
    public Light Light;
    bool isOn;
    private int State;
    
    void Start()
    {
        Light = GetComponent<Light>(); //its getting the component light 
        Light.intensity = 10f; // seting the insial intesity of the light
        State = 0;
    }

    void Update()
    {
        Cases();
        if (Input.GetKeyUp(KeyCode.Space) && isOn == true) // if space isnt pressed and light on
        {
            State = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isOn == true) // if space is pressed and light is on
        {
            State = 1;
        }

        else if (Input.GetKeyUp(KeyCode.Space) && isOn == false) // if space is pressed and light isnt on
        {
            State = 2;
        }
      
        else if (Input.GetKeyDown(KeyCode.Space) && isOn == false) // if space isnt pressed and light is off
        {
            State = 3;
            
        }
        if (isOn == true)
        {
            lightIntesityUpdate();
        }

        if(isOn == false)
        {
            lightIntesityStop();
        }






    }
    void Cases()
    {
        switch(State)
        {
            case 0:
                Light.enabled = true;
                isOn = true;
                
                Debug.Log("working11");
                break;
               
            case 1:
                Light.enabled = false;
                isOn = false;
                
                break;
            case 2:
                Light.enabled = false;
                isOn = false;
               
                break;
            case 3:
                Light.enabled = true;
                isOn = true;
                
                break;
        }
    }

   void lightIntesityUpdate()
    {
        Light.intensity -= Time.deltaTime * 0.33f; // gets the intesity of the light and decress it over time and the 0.33 is the speed it decresses at
    }

    void lightIntesityStop()
    {
        Light.intensity = Light.intensity;
    }







}
