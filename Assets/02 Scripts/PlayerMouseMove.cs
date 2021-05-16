using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMove : MonoBehaviour
{
    public float xRot;
    public float yRot;
    //public float xRotCurrent;
    //public float yRotCurrent;
    public GameObject player;
    public GameObject PlaerObject;
    public float sensitivity = 10f;
    //public float smooth = 0.1f
    //public float curVelX;
    //public float curVelY;

    void Update()
    {
        MouseMove();
    }
    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X") * sensitivity;
        yRot += Input.GetAxis("Mouse Y") * sensitivity;
        yRot = Mathf.Clamp(yRot, -20, 30);
        xRot = Mathf.Clamp(xRot, -45, 45);

        //xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref curVelX, smooth);
        //yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref curVelY, smooth);

        player.transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
        PlaerObject.transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
    }
}
