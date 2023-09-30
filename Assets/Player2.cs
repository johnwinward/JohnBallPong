using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb2D;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
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

        if (Input.GetKey(KeyCode.Alpha6))
        {
            sr.color = Color.blue;
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            sr.color = Color.red;
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            sr.color = Color.green;
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            sr.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            sr.color = Color.magenta;
        }

    }
}
