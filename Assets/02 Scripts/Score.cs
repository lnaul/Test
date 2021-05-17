using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreBox;
    public static int currentScore;
    public static int internalScore;

    void Update()
    {
        internalScore = currentScore;
        if (internalScore >= 10)
        {
            scoreBox.GetComponent<Text>().text = "0" + internalScore + "";
        }
        else
        {
            scoreBox.GetComponent<Text>().text = "00" + internalScore + "";
        }
    }
}
