﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{

    private Rigidbody body;
    public float speed;
    public float rotationSpeed;
    private float InputX, InputY;
    private List<GameObject> conches;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputY = Input.GetAxis("Vertical");
        body.velocity = (transform.forward * InputY) * speed * Time.fixedDeltaTime;
        transform.Rotate((transform.up * InputX) * rotationSpeed * Time.fixedDeltaTime);
    }

    public void AddConch(GameObject conch) {

    }
}