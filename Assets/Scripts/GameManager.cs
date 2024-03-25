using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _compScore;

    public void PlayerScore()
    {
        _playerScore++;
        Debug.Log(_playerScore);
        
        this.ball.ResetPosition();
    }

    public void CompScore()
    {
        _compScore++;
        Debug.Log(_compScore);

        this.ball.ResetPosition();
    }
}
