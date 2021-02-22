using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    //public GameObject fps;

    public static bool GetIsActive()
    {
        if (instance == null)
        {
            instance = Instantiate(Resources.Load(nameOfPrefab)) as GameObject;
            DontDestroyOnLoad(instance);
            instance.SetActive(false);
        }
        return instance.activeInHierarchy;
    }

    private static string nameOfPrefab = "Canvas second";
    public static GameObject instance;
    public static void SetActiveFPS(bool value)
    {
        if (instance == null)
        {
            instance = Instantiate(Resources.Load(nameOfPrefab)) as GameObject;
            DontDestroyOnLoad(instance);
            instance.SetActive(false);
        }
        if (instance != null)
            instance.SetActive(value);
    }


}
