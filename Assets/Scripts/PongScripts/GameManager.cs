using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text playerScoreText;
    public Text compScoreText;
    public int scoreLimit = 3;
    private int _playerScore;
    private int _compScore;

    public void PlayerScore()
    {
        Debug.Log(_playerScore);
        _playerScore++;

        if (_playerScore == scoreLimit) {
            Debug.Log("Player Wins");
        }

        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void CompScore()
    {
        _compScore++;

        if (_compScore == scoreLimit) {
            Debug.Log("CPU Wins");
        }

        this.compScoreText.text = _compScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
