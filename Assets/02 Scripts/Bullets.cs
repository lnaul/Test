using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public Transform bulletPoolTr;
    int currentBulletIndex = 0;
    Vector3 startingAngle, startingPosition;


    void FixedUpdate()
    {

        Vector3 newPos = startingAngle + startingPosition;
        transform.LookAt(newPos);
        Rigidbody bulletRB = bulletPoolTr.GetChild(currentBulletIndex).GetComponent<Rigidbody>();
        bulletRB.gameObject.SetActive(true);
        bulletRB.position = transform.position + Vector3.forward;
        bulletRB.velocity = Vector3.zero;
        bulletRB.AddForce(Vector3.forward * 10, ForceMode.Impulse);

        StartCoroutine(D());
    }
    IEnumerator D()
    {
        yield return new WaitForSeconds(5);
        currentBulletIndex++;
        if (currentBulletIndex >= bulletPoolTr.childCount)
        {
            currentBulletIndex = 0;
        }
       // if (Input.GetMouseButton(0);
    }
}
