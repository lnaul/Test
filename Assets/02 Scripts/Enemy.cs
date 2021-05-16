using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject exp;

    void OnTriggerEnter()
    {
        Score.currentScore += 1;
        exp.SetActive(true);
        enemy.SetActive(false);
    }
}
