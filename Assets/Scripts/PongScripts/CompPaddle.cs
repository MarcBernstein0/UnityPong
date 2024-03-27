using UnityEngine;

// Tracks the position of the ball
public class CompPaddle : Paddle
{
    // Now the editor will see this value, can set it in the editor
    public Rigidbody2D ball;
    void FixedUpdate() 
    {
        // ball is now moving TOWARDS the paddle
        if (this.ball.velocity.x > 0.0f) {
            if (this.ball.velocity.y > this.transform.position.y) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.velocity.y < this.transform.position.y) {
                // could have done else, but don't want the paddle to move if the ball is 
                // same y as the paddle
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        } else {
            if (this.transform.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
