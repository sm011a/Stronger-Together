using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Dropdown dropdown; // Определение dropdown со сцены

    public void CheckDropdownQuality() // Функция которая меняет настройки графики
    {
        QualitySettings.SetQualityLevel(dropdown.value, true);
    }
}
