using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWin : MonoBehaviour
{
    void Start()
    {
        hide();
    }
    // Start is called before the first frame update
    public void show()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    public void hide()
    {
        transform.position = new Vector3(-1000, 0, 0);
    }
}
