using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Pong");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
