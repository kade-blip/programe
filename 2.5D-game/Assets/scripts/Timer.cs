using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text textBox;
    public float timeControle;
    public bool stopTime = false;
    void Start()
    {
        timeControle = 0f;
    }

    
    void Update()
    {
        if (stopTime == false)
        {
            timeControle += Time.deltaTime;
        }
       
        timeControle = Mathf.Round(timeControle * 100f) / 100f;
        textBox.text = "Time" + timeControle;
         
        
    }
}
