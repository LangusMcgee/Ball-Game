using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class marballcontroller : MonoBehaviour
{
    Rigidbody rb;
    public Camera cam;
    public float torque_amount = 500;
    public float jump_force = 50000;
    public bool is_jumping;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddTorque(cam.transform.right * torque_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddTorque(-cam.transform.right * torque_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(cam.transform.forward * torque_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-cam.transform.forward * torque_amount * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && is_jumping == false)
        {
            is_jumping = true;
            rb.AddForce(Vector3.up * jump_force * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        is_jumping = false;
    }
}
