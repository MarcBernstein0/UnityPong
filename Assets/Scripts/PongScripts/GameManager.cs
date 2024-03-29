using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text playerScoreText;
    public Text compScoreText;
    public int scoreLimit = 3;

    public void PlayerScore()
    {
        Debug.Log(Score.playerScore);
        Score.playerScore++;

        if (Score.playerScore == scoreLimit)
        {
            Score.winner = "PLAYER";
            SwitchToWinScreen();
        }

        this.playerScoreText.text = Score.playerScore.ToString();
        ResetRound();
    }

    public void CompScore()
    {
        Score.compScore++;

        if (Score.compScore == scoreLimit)
        {
            Score.winner = "CPU";
            SwitchToWinScreen();
        }

        this.compScoreText.text = Score.compScore.ToString();
        ResetRound();
    }

    private void SwitchToWinScreen() {
        SceneManager.LoadScene("WinScreen");
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
