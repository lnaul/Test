using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject easyOpen;
    public GameObject normalOpen;
    public GameObject hardOpen;
    public GameObject easyClose;
    public GameObject normalClose;
    public GameObject hardClose;
    public GameObject playOpen;
    public GameObject playClose;
    public GameObject playSmall;
    public AudioSource clickSound;
    public AudioSource clickOpenSound;
    public AudioSource clickCloseSound;
    public GameObject fadeOut;
    public GameObject easyOpenSmall;
    public GameObject normalOpenSmall;
    public GameObject hardOpenSmall;


    public void PlayOpen()
    {
        StartCoroutine(PORoutine());
    }
    IEnumerator PORoutine()
    {
        easyOpen.SetActive(true);
        normalOpen.SetActive(true);
        hardOpen.SetActive(true);
        easyClose.SetActive(false);
        normalClose.SetActive(false);
        hardClose.SetActive(false);
        playOpen.SetActive(false);
        playSmall.SetActive(true);
        clickCloseSound.Play();
        yield return new WaitForSeconds(0.1f);
        playSmall.SetActive(false);
        playClose.SetActive(true);
    }
    public void PlayClose()
    {
        StartCoroutine(PCRoutine());
    }
    IEnumerator PCRoutine()
    {
        easyOpen.SetActive(false);
        normalOpen.SetActive(false);
        hardOpen.SetActive(false);
        easyClose.SetActive(true);
        normalClose.SetActive(true);
        hardClose.SetActive(true);
        playClose.SetActive(false);
        playSmall.SetActive(true);
        clickCloseSound.Play();
        yield return new WaitForSeconds(0.1f);
        playSmall.SetActive(false);
        playOpen.SetActive(true);
    }
    public void EasyGame()
    {
        StartCoroutine(EasyGameRoutine());
    }
    IEnumerator EasyGameRoutine()
    {
        easyOpen.SetActive(false);
        easyOpenSmall.SetActive(true);
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
    public void NormalGame()
    {
        StartCoroutine(NormalGameRoutine());
    }
    IEnumerator NormalGameRoutine()
    {
        normalOpen.SetActive(false);
        normalOpenSmall.SetActive(true);
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
    public void HardGame()
    {
        StartCoroutine(HardGameRoutine());
    }
    IEnumerator HardGameRoutine()
    {
        hardOpen.SetActive(false);
        hardOpenSmall.SetActive(true);
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
