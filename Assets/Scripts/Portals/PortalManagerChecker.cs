using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalManagerChecker : MonoBehaviour
{
    public GameObject redPortal;
    public GameObject bluePortal;

    private PortalManagerRed redPortalScript;
    private PortalManagerBlue bluePortalScript;

    private void Start()
    {
        redPortalScript = redPortal.GetComponent<PortalManagerRed>();
        bluePortalScript = bluePortal.GetComponent<PortalManagerBlue>();
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
