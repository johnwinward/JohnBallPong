using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2D.velocity = new Vector2(0.0f, 10.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2D.velocity = new Vector2(0.0f, -10.0f);
        }
        else
        {
            rb2D.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
