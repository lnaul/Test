using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public GameObject yes;
    public GameObject yesBack;
    public GameObject no;
    public GameObject noBack;
    public GameObject sure;
    public GameObject sureBack;
    public GameObject quitButton;
    public GameObject quitButtonBack;
    public GameObject buttonSmall;
    public GameObject buttonSmallBack;
    public AudioSource clickClose;
    public AudioSource clickSound;
    public GameObject fadeOut;
    public GameObject yesSmall;

    public void QuitButtonOpen()
    {
        StartCoroutine(QBORoutine());
    }
    IEnumerator QBORoutine()
    {
        yes.SetActive(true);
        yesBack.SetActive(false);
        no.SetActive(true);
        noBack.SetActive(false);
        sure.SetActive(true);
        sureBack.SetActive(false);
        quitButton.SetActive(false);
        buttonSmall.SetActive(true);
        clickClose.Play();
        yield return new WaitForSeconds(0.1f);
        buttonSmall.SetActive(false);
        quitButtonBack.SetActive(true);
    }
    public void QuitButtonBack()
    {
        StartCoroutine(QBBRoutine());
    }
    IEnumerator QBBRoutine()
    {
        yes.SetActive(false);
        yesBack.SetActive(true);
        no.SetActive(false);
        noBack.SetActive(true);
        sure.SetActive(false);
        sureBack.SetActive(true);
        quitButtonBack.SetActive(false);
        quitButton.SetActive(true);
        buttonSmallBack.SetActive(true);
        clickClose.Play();
        yield return new WaitForSeconds(0.1f);
        buttonSmallBack.SetActive(false);
    }
    public void QuitGame()
    {
        StartCoroutine(QuitGameRoutine());
    }
    IEnumerator QuitGameRoutine()
    {
        yes.SetActive(false);
        yesSmall.SetActive(true);
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        Application.Quit();
    }
}
