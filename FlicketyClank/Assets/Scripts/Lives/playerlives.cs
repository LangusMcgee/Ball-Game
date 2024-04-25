using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class playerlives : MonoBehaviour
{
    public int health = 3;

    public CollectableRings collectableRings;
    public GameObject gameOverScreen;
    public GameObject RespawnPoint;
    public Rigidbody rb;

    public bool gameOver;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DamageZone")
        {
            Debug.Log("damage player");

            health--;
            collectableRings.rings -= 2;
            rb.isKinematic = true;
            gameObject.transform.position = RespawnPoint.transform.position;
            rb.isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (collectableRings.rings >= 5)
        {
            health++;
            collectableRings.rings = 0;
        }
        if (health <= 0)
        {
            gameOverScreen.SetActive(true);
            Thread.Sleep(50);
            Destroy(gameObject);
        }
    }
}
