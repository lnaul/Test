using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static int score;
   
    public GameObject scoreTextFirst;

    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        score = PlayerPrefs.GetInt("ScoreSaved");

        if (score <= 9)
        {
            scoreTextFirst.GetComponent<Text>().text = "#00" + score + "#";
            //PlayerPrefs.Save();
        }
        else
        {
            scoreTextFirst.GetComponent<Text>().text = "#0" + score + "#";
            //PlayerPrefs.Save();
        }    
    }
}
