using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //how to pickup and opject
    public GameObject ui;
    bool canCollect;

    public bool collectOnEnter;

    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(collectOnEnter)
            {
                getCollected();
            }
            else
            {
                //this makes the player able to actually pick things up--
                ui.SetActive(true);
                canCollect = true;
            }


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ui.SetActive(false);
            canCollect = false;
        }
    }

    private void Update()
    {
        if (canCollect && Input.GetKeyDown(KeyCode.E))
        {
            getCollected();
        }
    }

    public void getCollected()
    {
        //todo play sound and get somethin cool or lame, we'll see when we get there
        collectSound.Play();
        ui.SetActive(false);
        Destroy(gameObject);
    }
}
