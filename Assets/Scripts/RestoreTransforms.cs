using System.Collections.Generic;
using UnityEngine;

public class RestoreTransforms : MonoBehaviour
{
    private List<Transform> _transforms = new List<Transform>();
    private List<Vector3> _positions = new List<Vector3>();
    private List<Quaternion> _rotations = new List<Quaternion>();
    private List<Vector3> _scale = new List<Vector3>();

    private void Awake()
    {
        var allTransforms = GetComponentsInChildren<Transform>();
        foreach (var t in allTransforms)
        {
            _transforms.Add(t);
            _positions.Add(t.position);
            _rotations.Add(t.localRotation);
            _scale.Add(t.localScale);
        }
    }

    private void OnEnable()
    {
        for (int i = 0; i < _transforms.Count; ++i)
        {
            _transforms[i].position = _positions[i];
            _transforms[i].localRotation = _rotations[i];
            _transforms[i].localScale = _scale[i];
        }
        GetComponent<RestoreTransforms>().enabled = false;
    }
}