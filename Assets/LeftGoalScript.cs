using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGoalScript : MonoBehaviour
{
    JohnBall johnball;
    ScoreMaster scoreMaster;
    // Start is called before the first frame update
    void Start()
    {
        johnball = FindObjectOfType<JohnBall>();
        scoreMaster = FindObjectOfType<ScoreMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreMaster.updateScore("right");
        johnball.resetJohnBall();
    }
}
