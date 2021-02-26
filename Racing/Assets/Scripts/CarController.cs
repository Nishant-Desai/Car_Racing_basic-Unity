using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float moveInput;
    private float turnInput;
    private bool isgrounded;

    private float currentspeed=0;
    public float forwardspeed = 100;
    public float reversespeed;
    public float turnspeed;
    public float airDrag;
    public float groundDrag;

    public LayerMask groundlayer;

    public Rigidbody sphereRb;
    //public Vector3 pos;
    //private float currentspeed;
    //private float lerpspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        sphereRb.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");
        turnInput = Input.GetAxisRaw("Horizontal");

        //moveInput += moveInput > 0 ? forwardspeed : reversespeed;
        if (Input.GetKey(KeyCode.W))
        {
            moveInput += currentspeed;
            if (currentspeed<forwardspeed)
            {
                currentspeed += (20 * Time.deltaTime);
            }
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //moveInput -= reversespeed;
            moveInput += (-currentspeed);
            if (currentspeed<reversespeed)
            {
                currentspeed += (10 * Time.deltaTime);
            }
        }

        // NOTE: CHECK FOR HOW TO MAKE THE CURRENT SPEED TO 0 WHEN CAR IS STOPPED!!!!!
        if (sphereRb.velocity.magnitude==0)
        {
            currentspeed = 0;
            //moveInput = 0;
        }

        transform.position = sphereRb.transform.position;

        float newRotation = turnInput * turnspeed * Time.deltaTime*Input.GetAxisRaw("Vertical");
        transform.Rotate(0, newRotation, 0, Space.World);
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A)))
        {
            while(currentspeed>70)
            {
                currentspeed -= (5 * Time.deltaTime);
            }
        }

        RaycastHit hit;
        isgrounded = Physics.Raycast(transform.position, -transform.up, out hit, 1f, groundlayer);

        transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        if (isgrounded)
        {
            sphereRb.drag = groundDrag;
        }
        else
        {
            sphereRb.drag = airDrag;
        }
    }

    private void FixedUpdate()
    {
        /*if(Input.GetKey(KeyCode.W))
        {
            currentspeed = Mathf.Lerp(currentspeed, forwardspeed, lerpspeed);
        }
        else
        {
            currentspeed = Mathf.Lerp(currentspeed, 0f, lerpspeed);
        }*/
        if (isgrounded)
        {
            sphereRb.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
        }
        else
        {
            sphereRb.AddForce(transform.up * -10);
        }
        
    }
}
