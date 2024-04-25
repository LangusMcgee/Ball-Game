using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject TargetPosition;
    public marballcontroller player;
    public playerlives respawn;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.rigidbody.isKinematic = true;
            other.gameObject.transform.position = TargetPosition.transform.position;
            respawn.RespawnPoint.transform.position = TargetPosition.transform.position;
            other.rigidbody.isKinematic = false;
            player.teleports++;
            Debug.Log("Player Entered TP");
        }
    }
}
