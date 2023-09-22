using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class JohnBall : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    bool isColliding;
    void Start()
    {
        isColliding = false;
        rb = GetComponent<Rigidbody2D>();
        if(Random.value > 0.5f)
        {
            rb.velocity = new Vector2(10.0f, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(-10.0f, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x < 10.0f && rb.velocity.x > -10.0f)
        {
            if(rb.velocity.x > 0.0f)
            {
                rb.velocity = new Vector2(10.0f, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-10.0f, rb.velocity.y);
            }

            //float newXVector = Mathf.Sqrt(100.0f - (rb.velocity.y * rb.velocity.y));
            //rb.velocity = new Vector2(newXVector, rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isColliding = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
    }
}
