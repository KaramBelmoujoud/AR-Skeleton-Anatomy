using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera3 : MonoBehaviour
{
    Transform cam;
    Vector3 targetAngle = Vector3.zero;
    public int n;

    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        targetAngle.y = 0;
        targetAngle.x = 90;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
    }
}
