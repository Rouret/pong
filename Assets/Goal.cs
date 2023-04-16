
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        GameManager.Instance.Score();
    }
}
