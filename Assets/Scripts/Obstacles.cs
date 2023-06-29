using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Vector2 StartPos;
    public float playerSpeed;
    private float StartPlayerSpeed;
    [SerializeField] GameObject youWinText;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        StartPlayerSpeed = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * -playerSpeed);
    }

    public void move(Vector2 pos)
    {
        transform.position = pos;
    }

    public void restart()
    {
        move(StartPos);
        playerSpeed = StartPlayerSpeed;
        youWinText.SetActive(false);
    }
}
