using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
