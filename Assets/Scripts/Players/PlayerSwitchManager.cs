using UnityEngine;

public class PlayerSwitchManager : MonoBehaviour
{
    public GameObject playerRed;//Определение синего игрока
    public GameObject playerBlue; //Определение красного игрока

    private PlayerController playerControllerRed;
    private PlayerController playerControllerBlue;


    public GameObject redPortal; //Определение красного портала
    public GameObject bluePortal;//Определение синего портала

    private PortalManagerRed redPortalScript;
    private PortalManagerBlue bluePortalScript;

    private bool switcher = true;

    private void Start()
    {
        playerControllerRed = playerBlue.GetComponent<PlayerController>();
        playerControllerBlue = playerRed.GetComponent<PlayerController>();

        redPortalScript = redPortal.GetComponent<PortalManagerRed>();
        bluePortalScript = bluePortal.GetComponent<PortalManagerBlue>();
        StartSwitchPlayer();
    }

    private void Update()
    {
        if (switcher && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            playerControllerRed.enabled = false;
            playerControllerBlue.enabled = true;
            switcher = false;
        }
        else if (switcher == false && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            playerControllerRed.enabled = true;
            playerControllerBlue.enabled = false;
            switcher = true;
        }
    }

    private void StartSwitchPlayer() // Изначальная возможность управление 1м играком
    {
        playerControllerBlue.enabled = false;
    }

}