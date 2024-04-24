using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRings : MonoBehaviour
{
    public int rings;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ring")
        {
            Debug.Log("ring collected");
            rings++;
            other.gameObject.SetActive(false);
        }
    }
}
