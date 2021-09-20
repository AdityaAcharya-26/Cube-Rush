using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500;
    public float sideForce = 500;
    void Start()
    {
        rb.useGravity = true;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d") )
        {
            rb.AddForce(sideForce*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
     

        
    }
}
