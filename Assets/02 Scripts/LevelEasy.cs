using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEasy : MonoBehaviour
{
    public GameObject AstOne;
    public GameObject AstTwo;
    public GameObject AstThree;
    public GameObject JetOne;
    public GameObject JetTwo;
    public GameObject JetThree;

    void Start()
    {
        AstOne.SetActive(false);
        AstTwo.SetActive(false);
        AstThree.SetActive(false);
        JetOne.SetActive(false);
        JetTwo.SetActive(false);
        JetThree.SetActive(false);

        StartCoroutine(Easy());   
    }
    IEnumerator Easy()
    {
        AstOne.SetActive(true);
        yield return new WaitForSeconds(1);
        JetOne.SetActive(true);
        yield return new WaitForSeconds(1);
        AstTwo.SetActive(true);
        yield return new WaitForSeconds(1);
        JetTwo.SetActive(true);
        yield return new WaitForSeconds(1);
        AstThree.SetActive(true);
        yield return new WaitForSeconds(1);
        JetThree.SetActive(true);
        yield return new WaitForSeconds(1);
    }

    void Update()
    {
        
    }
}
