using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;
    
    public GameObject ball;
    public GameObject player;

    public void Score()
    {
        ball.GetComponent<Lauch>().Reset();
        player.GetComponent<PlayerMouvement>().Reset();
    }
    
    void Start()
    {
        Instance = this;
    }

}
