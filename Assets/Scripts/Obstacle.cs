using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
  [SerializeField] float velocity;
  [SerializeField] float startX;

    void Start(){
      startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.left*velocity*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
      LimitLeft limitLeft = collider.GetComponent<LimitLeft>();
      Debug.Log("limitleft");
      Debug.Log(limitLeft);
      if (limitLeft){
        transform.position = new Vector2(startX, transform.position.y);
      }
    }
}
