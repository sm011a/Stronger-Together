using System.Collections;
using UnityEngine;

public class PortalManagerRed : MonoBehaviour
{
    public GameObject player;
    public GameObject otherPlayer;
    public GameObject switchManager;

    private AudioSource audioSource;
    public AudioClip discordLeaveSound;

    public bool playerDone = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player red"))
        {
            playerDone = true;
            otherPlayer.GetComponent<PlayerController>().enabled = true;
            Destroy(switchManager);
            audioSource.PlayOneShot(discordLeaveSound);
            Destroy(player);
        }
    }
}
