
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y + 12.5f >= ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
