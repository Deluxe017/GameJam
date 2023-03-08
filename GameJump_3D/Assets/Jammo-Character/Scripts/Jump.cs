using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float JumpSpeed;
    Rigidbody rb;
    private void Start()
    {
        rb.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey("space") && Ground.isGround)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpSpeed, 0);
            
        }
    }
}
