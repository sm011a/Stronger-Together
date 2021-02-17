using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesForMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Debug.Log("Exit App");
        Application.Quit();
    }
    public void RestartGame()
    {
        Debug.Log("Restarted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
