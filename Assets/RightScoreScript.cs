using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RightScoreScript : MonoBehaviour
{
    TMP_Text text;
    ScoreMaster scoreMaster;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        scoreMaster = FindObjectOfType<ScoreMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = scoreMaster.rightScore.ToString();
    }
}
