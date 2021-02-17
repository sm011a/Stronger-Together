using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalManagerChecker : MonoBehaviour
{
    public GameObject redPortal;
    public GameObject bluePortal;

    private PortalManager redPortalScript;
    private PortalManager bluePortalScript;

    private void Start()
    {
        redPortalScript = redPortal.GetComponent<PortalManager>();
        bluePortalScript = bluePortal.GetComponent<PortalManager>();
    }

    private void FixedUpdate()
    {
        if (redPortalScript.playerDone && bluePortalScript.playerDone)
        {
            Debug.Log("All Done, Lets Go");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
