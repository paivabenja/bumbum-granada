using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public AudioClip soundClip;
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
                    AudioSource.PlayClipAtPoint(soundClip, transform.position);
                }
            }
        }
    }

    private void OnCollisionEnter2D()
    {
        transform.position = StartPos;
    }
}
