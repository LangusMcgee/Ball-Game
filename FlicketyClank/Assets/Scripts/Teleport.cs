using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 TargetPosition;
    public marballcontroller player;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.rigidbody.isKinematic = true;
            other.gameObject.transform.position = TargetPosition;
            other.rigidbody.isKinematic = false;
            player.teleports++;
            Debug.Log("Player Entered TP");
        }
    }
}
