using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;

public class JohnBall : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    AudioSource audioSource;
    bool isStarted, manualStartEnabled;
    void Start()
    {
        isStarted = false;
        manualStartEnabled = true;
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !isStarted && manualStartEnabled)
        {
            startJohnBall();
            manualStartEnabled = false;
        }

        if(isStarted)
        {
            if (rb.velocity.x < 10.0f && rb.velocity.x > -10.0f)
            {
                if (rb.velocity.x > 0.0f)
                {
                    rb.velocity = new Vector2(10.0f, rb.velocity.y);
                }
                else
                {
                    rb.velocity = new Vector2(-10.0f, rb.velocity.y);
                }
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
    }

    public void resetJohnBall()
    {
        isStarted = false;
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1.0f);
        startJohnBall();
    }

    private void startJohnBall()
    {
        if (Random.value > 0.5f)
        {
            rb.velocity = new Vector2(10.0f, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(-10.0f, 0.0f);
        }
        isStarted = true;
    }
}
