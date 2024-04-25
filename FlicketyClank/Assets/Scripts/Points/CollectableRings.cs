using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CollectableRings : MonoBehaviour
{
    public int rings;
    public GameObject gameWinScreen;
    public Rigidbody rb;

    private void Update()
    {
        if(rings <= 0)
        {
            rings = 0;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ring")
        {
            Debug.Log("ring collected");
            rings++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Win")
        {
            gameWinScreen.SetActive(true);
            other.gameObject.SetActive(false);
            Thread.Sleep(50);
            rb.isKinematic = true;
        }
    }
}
