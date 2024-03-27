using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    // making attributes public in the editor allows them to 
    // appear in the editor
    public float speed = 10.0f;

    private void Awake()
    {
        // On gameObj that this script is attached too, 
        // will look for Rigidbody2D comp and return it
        _rigidbody = GetComponent<Rigidbody2D>();

    }
}
