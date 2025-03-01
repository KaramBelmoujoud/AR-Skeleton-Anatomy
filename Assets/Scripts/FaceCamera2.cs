using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera2 : MonoBehaviour
{
    Transform cam;
    Vector3 targetAngle = Vector3.zero;

    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
    }
}
