using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpaceTextScript : MonoBehaviour
{
    TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hide()
    {
        text.text = string.Empty;
    }

    public void show()
    {
        text.text = "Press SPACE to start.";
    }
}
