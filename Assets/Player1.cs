using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W)){
            rb2D.velocity = new Vector2(0.0f, 10.0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb2D.velocity = new Vector2(0.0f, -10.0f);
        }
        else
        {
            rb2D.velocity = new Vector2(0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            sr.color = Color.red;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            sr.color = Color.blue;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            sr.color = Color.green;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            sr.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            sr.color = Color.magenta;
        }
    }
}
