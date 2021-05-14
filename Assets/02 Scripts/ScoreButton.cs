using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreButton : MonoBehaviour
{
    public GameObject st;
    public GameObject nd;
    public GameObject rd;
    public GameObject button;
    public GameObject buttonOne;
    public GameObject stBack;
    public GameObject ndBack;
    public GameObject rdBack;
    public GameObject buttonSmall;
    public GameObject buttonSmallBack;
    public AudioSource clickClose;
    public GameObject dark;

    void Start()
    {
        StartCoroutine(DarkRoutine());
    }
    IEnumerator DarkRoutine()
    {
        dark.SetActive(true);
        yield return new WaitForSeconds(3);
        dark.SetActive(false);
    }

        public void Score()
    {
        StartCoroutine(ScoreRoutine());
    }
    IEnumerator ScoreRoutine()
    {
        stBack.SetActive(false);
        ndBack.SetActive(false);
        rdBack.SetActive(false);
        st.SetActive(true);
        nd.SetActive(true);
        rd.SetActive(true);
        button.SetActive(false);
        buttonSmall.SetActive(true);
        clickClose.Play();
        yield return new WaitForSeconds(0.1f);
        buttonSmall.SetActive(false);
        buttonOne.SetActive(true);
    }
    public void ScoreBack()
    {
        StartCoroutine(ScoreBackRoutine());
    }
    IEnumerator ScoreBackRoutine()
    {
        st.SetActive(false);
        nd.SetActive(false);
        rd.SetActive(false);
        stBack.SetActive(true);
        ndBack.SetActive(true);
        rdBack.SetActive(true);
        buttonOne.SetActive(false);
        buttonSmallBack.SetActive(true);
        clickClose.Play();
        yield return new WaitForSeconds(0.1f);
        buttonSmallBack.SetActive(false);
        button.SetActive(true);
    }
}
