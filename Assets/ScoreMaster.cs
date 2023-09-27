using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMaster : MonoBehaviour
{
    public static int leftScore, rightScore;
    Text leftText, rightText;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Reset()
    {
        leftScore = 0;
        rightScore = 0;
    }

    public static void updateScore(string player)
    {
        if (player.Equals("left")) leftScore++;
        else if(player.Equals("right")) rightScore++;
    }
}
