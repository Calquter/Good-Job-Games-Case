using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaxBehaviour : MonoBehaviour
{

    [SerializeField] private float _growSpeed;

    private bool _isTriggered;
    public bool isDone;

    private void GrowUp()
    {
        if (!_isTriggered)
            return;

        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), _growSpeed * Time.deltaTime);
    }

    private void LateUpdate()
    {
        GrowUp();
    }

    private void OnMouseEnter()
    {
        _isTriggered = true;
    }
}
