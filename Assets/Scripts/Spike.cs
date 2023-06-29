using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Transform Obstacles;
    public Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = Obstacles.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("chocaste culiado");
        if (collision.gameObject.tag == "Cube")
        {
            Obstacles.position = StartPos;
        }
    }
}
