using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Rigidbody Rb;
    public float movespeed = 10f;
    private float xInput;
    private float zInput;
    void Awake()
    {
        Rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //Good for handling inputs and animations
        ProcessInputs();

        
    }
    private void FixedUpdate()
    {
        //Movement
        Move();
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        Rb.AddForce(new Vector3(xInput, 0f, zInput) * movespeed);
    }
}
