using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostoncollide : MonoBehaviour
{
    // Start is called before the first frame update
    public float forceval = 10000f;
    void Start()
    {
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * forceval * Time.deltaTime);
        Debug.Log("Trigger Entered");
        //other.Addforce(-cam.transform.forward * torque_amount * Time.deltaTime);
    }
}
