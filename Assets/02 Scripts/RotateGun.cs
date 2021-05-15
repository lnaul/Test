using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    public GameObject gun;
    public float RotateSpeed = 20;

    void FixedUpdate()
    {
        RotateGunLR();
    }
    void RotateGunLR()
    {
        //float AngleRotate = Time.deltaTime * RotateSpeed * Input.GetAxis("GunMove");
        float AngleRotate = Time.deltaTime * RotateSpeed * Input.GetAxis("Mouse X");
        //float AngleRotateY = Time.deltaTime * RotateSpeed * Input.GetAxis("GunMoveY");
        float AngleRotateY = Time.deltaTime * RotateSpeed * Input.GetAxis("Mouse Y");
        gun.transform.Rotate(AngleRotateY, 0, AngleRotate);

    }
}
