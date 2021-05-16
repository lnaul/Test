using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timerDisplay01;
    public bool isIakingTime = false;
    public int theSeconds = 59;
    public GameObject script;

    void Update()
    {
        if (isIakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }
    IEnumerator SubtractSecond()
    {
        isIakingTime = true;
        theSeconds -= 1;

        if (theSeconds <= 9)
        {
            timerDisplay01.GetComponent<Text>().text = "|0" + theSeconds + "|";
        }
        else
        {
            timerDisplay01.GetComponent<Text>().text = "|" + theSeconds + "|";
        }
        yield return new WaitForSeconds(1);
        if (theSeconds == 0)
        {
            timerDisplay01.GetComponent<Text>().text = "|00|";
            script.SetActive(false);
        }
        isIakingTime = false;
    }
}
