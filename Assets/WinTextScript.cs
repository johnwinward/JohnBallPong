using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinTextScript : MonoBehaviour
{
    TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setWinner(char winner)
    {
        if (winner == 'l')
        {
            text.text = "Left Player Wins!";
        }
        else if(winner == 'r')
        {
            text.text = "Right Player Wins!";
        }

        text.text += "\r\nPress R to play again.";
    }

    public void Reset()
    {
        text.text = string.Empty;
    }
}
