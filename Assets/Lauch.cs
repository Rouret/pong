using UnityEngine;
using Random = UnityEngine.Random;

public class Lauch : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private Vector3 lastVelocity;
    private Vector3 startPosition;
    
    public float speed = 5f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        LauchBall();
    }
    
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       var direction = Vector2.Reflect(lastVelocity.normalized, other.contacts[0].normal);
       rb.velocity = direction * speed;
       speed += 0.5f;
        
    }

    private void LauchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x, y) * speed;
    }

    public void Reset()
    {
        transform.position = startPosition;
        speed = 5f;
        LauchBall();
    }
}
