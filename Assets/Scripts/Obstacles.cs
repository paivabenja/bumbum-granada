using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Vector2 StartPos;
    public float playerSpeed;
    private float StartPlayerSpeed;
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] GameObject youWinText;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        StartPlayerSpeed = playerSpeed;

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("prefab");
            Instantiate(prefabs[Random.Range(0, 3)], new Vector2(transform.position.x + i * 4, transform.position.y), Quaternion.identity, transform);
        }
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
