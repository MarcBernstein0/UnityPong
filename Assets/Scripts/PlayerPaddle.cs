using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            // Move up
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
           // Move down
            _direction = Vector2.down;
        } else {
            // Don't move
            _direction = Vector2.zero;
        }
    }

    // Frame-rate independent message for physics calculations
    void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }

}
