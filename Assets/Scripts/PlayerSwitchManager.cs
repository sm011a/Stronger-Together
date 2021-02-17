using UnityEngine;

public class PlayerSwitchManager : MonoBehaviour
{
    public GameObject playerFirst; //Определение 1 игрока
    public GameObject playerSecond;//Определение 2 игрока

    private bool switcher = true;

    private void Update()
    {
        SwitchPlayer();
    }

    private void Awake()
    {
        AwakeSwitchPlayer();
    }

    private void AwakeSwitchPlayer() // Изначальная возможность управление 1м играком
    {
        if (switcher)
        {
            playerFirst.GetComponent<PlayerController>().enabled = false;
            playerSecond.GetComponent<PlayerController>().enabled = true;
            switcher = false;
        }
    }

    private void SwitchPlayer() // Для переключения между игроками путём отключения скриптов
    {
        if (switcher && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            playerFirst.GetComponent<PlayerController>().enabled = false;
            playerSecond.GetComponent<PlayerController>().enabled = true;
            switcher = false;
        }
        else if(switcher == false && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            playerFirst.GetComponent<PlayerController>().enabled = true;
            playerSecond.GetComponent<PlayerController>().enabled = false;
            switcher = true;
        }
    }
}
