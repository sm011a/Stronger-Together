using UnityEngine;

public class FPSButton : MonoBehaviour
{
    // public bool isActive;
    public GameObject image;

    public void SetActive()
    {
        var value = !FPS.GetIsActive();
        // FPS.instance.SetActive(value);
        FPS.SetActiveFPS(value);
        image.SetActive(value);
    }

    private void OnEnable()
    {
        var value = FPS.GetIsActive();
        image.SetActive(value);
    }
}
