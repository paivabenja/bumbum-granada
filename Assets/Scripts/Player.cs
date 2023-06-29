using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpHeight;
    public Vector3 StartPos;
    public Rigidbody2D PlayerRB;
    public float GroundLevel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        StartPos = transform.position;
        GroundLevel = transform.position.y + 0.1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                if (transform.position.y < GroundLevel)
                {
                    PlayerRB.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
                }
            }
        }

        // if (transform.position.y == GroundLevel)
        // {
        //     transform.rotation = new Quaternion(0, 0, 0, 0);
        // }

        // transform.position = new Vector3(
    }

    private void OnCollisionEnter2D()
    {
        transform.position = StartPos;
    }
}
