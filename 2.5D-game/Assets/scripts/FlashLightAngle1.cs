using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightAngle1 : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask layerMask;

   

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
        {
            Vector3 normal = (raycastHit.point- transform.position).normalized; //* this makes it so instead of going all over it goes strat to the mouse

            //transform.position = raycastHit.point;
            transform.rotation = Quaternion.FromToRotation(Vector3.forward, normal); 
        }
    }

}    