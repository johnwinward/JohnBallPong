using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class JohnBall : MonoBehaviour
{
    // Start is called before the first frame update

    bool isMovingRight;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if(Random.value > 0.5f)
        {
            rb.velocity = new Vector2(10.0f, 0.0f);
            isMovingRight = true;
        }
        else
        {
            rb.velocity = new Vector2(-10.0f, 0.0f);
            isMovingRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (isMovingRight)
        {
            rb.velocity = new Vector2(-10.0f, 0.0f);
            isMovingRight = false;
        }
        else
        {
            rb.velocity = new Vector2(10.0f, 0.0f);
            isMovingRight = true;
        }
        
    }
}
