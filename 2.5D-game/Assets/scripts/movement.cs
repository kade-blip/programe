using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5;
    private Vector3 movementVector;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2;
    public float jumpVelocity = 10;

    public bool onGround;
    private float m_finalSpeed = 0f;
    public float m_movementSpeed = 12;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_finalSpeed = m_movementSpeed;
    }

    void Start()
    {

    }
    
   
    void Update()
    {
        movementVector = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        movementVector *= speed;

        onGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        Debug.Log(onGround);

        rb.MovePosition(rb.position + movementVector * Time.deltaTime);

        if (Input.GetKeyDown (KeyCode.W) && onGround == true)
        {
            Debug.Log("Jump");
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Debug.Log("left");
        //    GetComponent<Rigidbody>().AddForce(new Vector3(-0.1f, 0, 0), ForceMode.Impulse);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("right");
        //    GetComponent<Rigidbody>().AddForce(new Vector3(0.1f, 0, 0), ForceMode.Impulse);
        //}


        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        

    }
}
