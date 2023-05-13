using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> obstacleList;

    [SerializeField]
    float timeCounter;

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter > 1)
        {
            timeCounter = 0;
            Instantiate(obstacleList[Random.Range(0, 1)]);
        }
    }
}
