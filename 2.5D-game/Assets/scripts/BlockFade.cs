using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFade : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FlashLight"))
        {
            Destroy(obj: gameObject);
            DestroyImmediate(gameObject);
        }
    }
    void Update()
    {
        
    }

}
