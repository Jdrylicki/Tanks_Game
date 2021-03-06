﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardSpeed = 2f;
    public float rotationSpeed = 90f;
    float xMovement, zMovement;

    void Start()
    {
            
    }

    void Update()
    {
        

    }
    // Update is called once per frame
    //"Fixed"Update works better with unity and physics
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            Move(1);
        if (Input.GetKey("s"))
            Move(-1);
        if (Input.GetKey("d"))
            Turn(1);
        if (Input.GetKey("a"))
            Turn(-1);

    }


    void Move(int dir)
    {
        Vector3 movement = transform.forward * dir * forwardSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void Turn(int dir)
    {
        float turn = dir * rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
