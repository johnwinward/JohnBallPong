using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMaster : MonoBehaviour
{
    public int leftScore, rightScore;
    WinTextScript winTextScript;
    SpaceTextScript spaceText;
    bool allowGameReset;

    // Start is called before the first frame update
    void Start()
    {
        winTextScript = FindObjectOfType<WinTextScript>();
        spaceText = FindObjectOfType<SpaceTextScript>();
        allowGameReset = false;
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if(allowGameReset && Input.GetKey(KeyCode.R)) {
            Reset();
            winTextScript.Reset();
            allowGameReset = false;
            FindObjectOfType<JohnBall>().setGameEnded(false);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Reset()
    {
        spaceText.show();
        leftScore = 0;
        rightScore = 0;
    }

    public void updateScore(string player)
    {
        JohnBall johnBall = FindObjectOfType<JohnBall>();

        if (player.Equals("left")) leftScore++;
        else if(player.Equals("right")) rightScore++;

        if(leftScore >= 5)
        {
            winTextScript.setWinner('l');
            allowGameReset=true;
            johnBall.setManualStart(true);
            johnBall.resetJohnBall();
            johnBall.setGameEnded(true);
        }
        else if(rightScore >= 5)
        {
            winTextScript.setWinner('r');
            allowGameReset=true;
            johnBall.setManualStart(true);
            johnBall.resetJohnBall();
            johnBall.setGameEnded(true);
        }
    }
}
