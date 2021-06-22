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
            timeControle += Time.deltaTime * 0.9f; // only accurate in the build not the inspectore but does get to a speed that is 0.1 sec fasterd
        }


        timeControle = Mathf.Round(timeControle * 100f) / 100f;
        textBox.text = "" + timeControle;

    }
     void FixedUpdate()
    {
        
    }
}
