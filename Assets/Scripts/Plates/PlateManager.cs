using System.Collections;
using UnityEngine;

public class PlateManager : MonoBehaviour
{
    public GameObject player;
    public GameObject portalTrigger;
    public GameObject portalParticle;

    private void OnCollisionEnter(Collision collision)
    {
        if (player)
        {
            StartCoroutine(WaitActive());
        }
    }
    
    IEnumerator WaitActive()
    {
        portalTrigger.SetActive(true);
        portalParticle.SetActive(true);
        yield return new WaitForSeconds(2);
        portalTrigger.SetActive(false);
        portalParticle.SetActive(false);
    }
}