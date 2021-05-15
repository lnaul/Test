using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMove : MonoBehaviour
{
    public float mainSpeed = 1f; //regular speed
    //float shiftAdd = 250.0f; //multiplied by how long shift is held.  Basically running
    //float maxShift = 1000.0f; //Maximum speed when holdin gshift
    public float camSens = 0.1f; //How sensitive it with mouse
    public Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    public float totalRun = 1.0f;                                                        // private float totalRun = 1.0f;

    void Update()
    {
        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
    }
}
