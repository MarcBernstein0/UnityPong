using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    // private Text winScreenText = Score.winner;
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
