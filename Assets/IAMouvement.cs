using UnityEngine;

public class IAMouvement : MonoBehaviour
{
    
    public GameObject ball;
    private Rigidbody2D rb;
    public float speed = 7f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (ball.transform.position.x > 0)
        {
            rb.velocity = new Vector2(0, ball.transform.position.y - transform.position.y) * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
