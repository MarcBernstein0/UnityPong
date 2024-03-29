using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text winScreenText;
    void Awake()
    {
        winScreenText.text += " " + Score.winner;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Pong");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
