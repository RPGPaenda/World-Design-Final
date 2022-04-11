using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    //how to make a teleporter/spawn point
    public Transform spawnPoint;
    public GameObject ui;
    bool canTeleport;
    Transform transformToTeleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ui.SetActive(true);
            canTeleport = true;
            transformToTeleport = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ui.SetActive(false);
            canTeleport = false;
            transformToTeleport = null;
        }
    }

    private void Update()
    {
        if(canTeleport && Input.GetKeyDown(KeyCode.E))
        {
            transformToTeleport.position = spawnPoint.position;
        }
    }
}
