using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batteryhealth : MonoBehaviour
{

    public Slider meterSlider;
    public FlashLight fl;
    public void UpdateMeter(float value)
    {
        meterSlider.value = value;
    }

     void Update()
    {
        meterSlider.value = fl.Light.intensity; // changes the health bar to the value of the flashlihght intesity 
        
    }

}
