using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouvement : MonoBehaviour
{
    private Vector2 move;
    private Rigidbody2D rb;
    public float speed = 7f;
    
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }
    
    void Update()
    {
        rb.velocity = new Vector2(move.x * speed, move.y * speed);
    }
    
    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    public void Reset()
    {
        transform.position = startPosition;
    }
}
