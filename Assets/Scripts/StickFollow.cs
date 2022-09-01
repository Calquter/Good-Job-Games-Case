using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickFollow : MonoBehaviour
{
    private Camera _cam;
    Vector3 pos;

    private void Start()
    {
        _cam = Camera.main;
    }
    void LateUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        pos = Input.mousePosition;
        pos.z = 1f;
        transform.position = _cam.ScreenToWorldPoint(pos);
    }
}
