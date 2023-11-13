using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float lookSensitivity;
    public float minXLook;
    public float maxXLook;
    public Transform camanchor;
    public bool invertXRotation;
    private float curXRot;

    void LateUpdate() 
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.eulerAngles += Vector3.up * x * lookSensitivity;
    }
}
