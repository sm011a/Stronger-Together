using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalManager : MonoBehaviour
{
    public GameObject player;

    public bool playerDone = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other)
        {
            playerDone = true;
            Destroy(player);
        }
    }
}
