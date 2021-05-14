using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 2;
    public float rotSpd = 2;
    public float rotSpdZ = 2;

    void Update()
    {
        transform.Rotate(rotSpd * Time.timeScale, rotateSpeed * Time.timeScale, rotSpdZ * Time.timeScale, Space.World);
    }
}
