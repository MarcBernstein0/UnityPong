using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Ball ball;
    public Text playerScoreText;
    public Text compScoreText;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape pressed");
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    /*
    *   Bring down Pause Menu 
    *   Unfreeze the game
    *   Set Pause Var to false   
    */
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        // Can use this to set slowmotion effects or pause the game
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void RestartGame()
    {
        GameIsPaused = false;
        Score.compScore = 0;
        Score.playerScore = 0;


        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        this.playerScoreText.text = Score.playerScore.ToString();
        this.compScoreText.text = Score.playerScore.ToString();
        this.ball.ResetPosition();
        StartCoroutine(this.ball.DelayStart(1));
    }

    public void Quit() 
    {
        Application.Quit();
    }

    /*
    *   Bring up Pause Menu 
    *   Freeze the game
    *   Set Pause Var to true   
    */
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        // Can use this to set slowmotion effects or pause the game
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
