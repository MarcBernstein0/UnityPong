using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D _rigidBody;
    void Awake() 
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddStartingForce()
    {
        // Generate a random x direction
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        // Generate a random y direction, neg is up
        float y = Random.value < 0.5f ? Random.Range(-0.5f, -1.0f) : 
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidBody.AddForce(direction * this.speed);
        
    }
}
