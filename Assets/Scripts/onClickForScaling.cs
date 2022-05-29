using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class onClickForScaling : MonoBehaviour
{
    void Update()
    {

    }

    void OnMouseDown()
    {
        CSharpscaling.ScaleTransform = this.transform;
    }
}