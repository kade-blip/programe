using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public Timer tt;
    public float timestoper;
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timestoper = tt.timeControle;
            tt.timeControle = timestoper;
            tt.stopTime = true;
            Debug.Log("heheh");
        }
    }


}
