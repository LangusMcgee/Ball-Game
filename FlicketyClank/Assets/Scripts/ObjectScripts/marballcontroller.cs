using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class marballcontroller : MonoBehaviour
{
    Rigidbody rb;
    public Camera cam;
    public float force_amount = 250f;
    public float jump_force = 50000f;
    public bool is_jumping;
    private int top_speed = 15;
    public int teleports = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && is_jumping == false)
        {
            rb.AddForce(cam.transform.forward * force_amount * Time.deltaTime);
            capspeed();
        }
        if (Input.GetKey(KeyCode.S) && is_jumping == false)
        {
            rb.AddForce(-cam.transform.forward * force_amount * Time.deltaTime);
            capspeed();
        }
        if (Input.GetKey(KeyCode.D) && is_jumping == false)
        {
            rb.AddForce(cam.transform.right * force_amount * Time.deltaTime);
            capspeed();
        }
        if (Input.GetKey(KeyCode.A) && is_jumping == false)
        {
            rb.AddForce(-cam.transform.right * force_amount * Time.deltaTime);
            capspeed();
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
    void capspeed()
    {
        Vector2 tmpXZ = new Vector2(rb.velocity.x, rb.velocity.z);
        if (tmpXZ.magnitude > top_speed)
        {
            Debug.Log("top speed breached");
            tmpXZ = tmpXZ.normalized * top_speed;
            rb.velocity = new Vector3(tmpXZ.x, rb.velocity.y, tmpXZ.y);
        }
    }
}
