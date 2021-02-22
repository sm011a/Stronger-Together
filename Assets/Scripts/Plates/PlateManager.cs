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
            portalTrigger.SetActive(true);
            portalParticle.SetActive(true);
            transform.Translate(0, -0.115f, 0);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        StartCoroutine(WaitActive());
    }
    IEnumerator WaitActive()
    {
        yield return new WaitForSeconds(2);
        transform.Translate(0, 0.072f, 0);
        portalTrigger.SetActive(false);
        portalParticle.SetActive(false);
    }
}