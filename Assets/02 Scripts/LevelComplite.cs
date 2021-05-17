using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplite : MonoBehaviour
{
    public GameObject timer;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject MuzzelOne;
    public GameObject MuzzelTwo;
    public GameObject SoundOne;
    public GameObject SoundTwo;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        MuzzelOne.SetActive(false);
        MuzzelTwo.SetActive(false);

        SoundOne.SetActive(false);
        SoundTwo.SetActive(false);

        fadeIn.SetActive(true);
        timer.SetActive(true);
        Score.currentScore = 0;

        StartCoroutine(Muzz());
    }
    void Update()
    {
        if (Timer.theSeconds == 6)
        {
            StartCoroutine(T());
        }
    }
    IEnumerator Muzz()
    {
        yield return new WaitForSeconds(10);
        MuzzelOne.SetActive(true);
        MuzzelTwo.SetActive(true);
        SoundOne.SetActive(true);
        SoundTwo.SetActive(true);
    }
    IEnumerator T()

    {
        MuzzelOne.SetActive(false);
        MuzzelTwo.SetActive(false);
        SoundOne.SetActive(false);
        SoundTwo.SetActive(false);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        PlayerPrefs.SetInt("ScoreSaved", Score.internalScore);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
