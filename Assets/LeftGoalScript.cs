using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGoalScript : MonoBehaviour
{
    JohnBall johnball;
    // Start is called before the first frame update
    void Start()
    {
        johnball = FindObjectOfType<JohnBall>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreMaster.updateScore("right");
        johnball.resetJohnBall();
    }
}
