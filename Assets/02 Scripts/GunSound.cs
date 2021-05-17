using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSound : MonoBehaviour
{
    public AudioSource sound;
    public AudioSource soundMore;

    void Start()
    {
        StartCoroutine(F());
        StartCoroutine(G());
    }
    IEnumerator F()
    {
        sound.Play();
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(F());
    }
    IEnumerator G()
    {
        soundMore.Play();
        yield return new WaitForSeconds(1.30f);
        StartCoroutine(G());
    }
}
