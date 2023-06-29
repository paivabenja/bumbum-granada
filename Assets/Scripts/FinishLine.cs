using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Obstacles obstacles;
    [SerializeField] GameObject youWinText;
    private Vector2 startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            obstacles.move(obstacles.StartPos);
            obstacles.playerSpeed = 0;
            transform.position = startpos;
            youWinText.SetActive(true);
        }
    }
}
