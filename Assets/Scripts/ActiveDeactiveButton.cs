using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveDeactiveButton : MonoBehaviour
{
    public GameObject panal;

    public void SwitchActive()
    {
        panal.SetActive(!panal.activeSelf);

        if(panal.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else if (panal.activeSelf == false)
        {
            Time.timeScale = 1;
        }
    }

}
