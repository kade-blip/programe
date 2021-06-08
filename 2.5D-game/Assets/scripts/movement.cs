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
    public bool onLadder;
    private float m_finalSpeed = 0f;
    public float m_movementSpeed = 12;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public LayerMask ladderMask;


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

        onLadder = Physics.CheckSphere(groundCheck.position, groundDistance, ladderMask);
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

        if (onLadder)
        {
            GetComponent<Rigidbody>().useGravity = false;
            movementVector = new Vector3(Input.GetAxis("Vertical"),0, 0);
            movementVector.y *= speed;

            Debug.Log("hehe on ladder poggie");
        }
        else
        {
            GetComponent<Rigidbody>().useGravity = true;

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
}
