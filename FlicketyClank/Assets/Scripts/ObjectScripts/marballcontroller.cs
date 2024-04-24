using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class marballcontroller : MonoBehaviour
{
    Rigidbody rb;
    public Camera cam;
    public float torque_amount = 500f;
    public float jump_force = 50000f;
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
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(cam.transform.right * torque_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-cam.transform.right * torque_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(cam.transform.forward * torque_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-cam.transform.forward * torque_amount * Time.deltaTime);
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
