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
    SpaceTextScript spaceText;
    bool isStarted, manualStartEnabled, gameEnded;
    void Start()
    {
        isStarted = false;
        manualStartEnabled = true;
        gameEnded = false;
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        spaceText = FindObjectOfType<SpaceTextScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameEnded)
        {
            if (Input.GetKey(KeyCode.Space) && !isStarted && manualStartEnabled)
            {
                startJohnBall();
                manualStartEnabled = false;
                spaceText.hide();
                Debug.Log("hidden");
            }

            if (isStarted)
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
        if (!manualStartEnabled)
        {
            StartCoroutine(Waiter());
        }
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

    public void setManualStart(bool manualStartEnabled)
    {
        this.manualStartEnabled = manualStartEnabled;
    }

    public void setGameEnded(bool gameEnded)
    {
        this.gameEnded = gameEnded;
    }
}
