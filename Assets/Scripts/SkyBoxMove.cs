using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxMove : MonoBehaviour
{
    public float rotateSpeed = 0.5f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);  
    }
}
