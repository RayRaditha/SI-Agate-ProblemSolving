using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text scoretext;
    public ScoreValue score;
    
    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.GetCurrentScore().ToString();
    }
}
