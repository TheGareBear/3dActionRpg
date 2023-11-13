using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float lookSensitivity;
    public float minXLook;
    public float maxXLook;
    public Transform camAnchor;
    public bool invertXRotation;
    private float curXRot;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // called at the end of each frame
    void LateUpdate() 
    {
        // get mouse x and y inputs
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        // rotate player horizontally
        transform.eulerAngles += Vector3.up * x * lookSensitivity;
        
        // camera rotation vertically
        if (invertXRotation)
            curXRot += y * lookSensitivity;
        else
            curXRot -= y * lookSensitivity;

        curXRot = Mathf.Clamp(curXRot, minXLook, maxXLook);

        Vector3 clampedAngle = camAnchor.eulerAngles;
        clampedAngle.x =curXRot;
        camAnchor.eulerAngles = clampedAngle;
    }
}
