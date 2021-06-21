using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightAngle1 : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask layerMask;
    public float rotatX;
    public float rotatY;
    

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
        {
            Vector3 normal = (raycastHit.point- transform.position).normalized; //* this makes it so instead of going all over it goes strat to the mouse

            rotatY += Input.GetAxis("Mouse X"); // the lines bellow this are attempts to clamp the rotatoins of the flash light 
            rotatX += Input.GetAxis("Mouse Y");
            rotatY = Mathf.Clamp(rotatY, -0f, 0f);
            rotatX = Mathf.Clamp(rotatX, -0f, 0f);
            transform.rotation = Quaternion.FromToRotation(Vector3.forward, normal); 
        }
    }

}    