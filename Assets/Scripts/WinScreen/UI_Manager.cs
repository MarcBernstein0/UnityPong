using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("Restart game pressed");
        SceneManager.LoadScene("Pong");
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame pressed");
        Application.Quit();
    }
}
