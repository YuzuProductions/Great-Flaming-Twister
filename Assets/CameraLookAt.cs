using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    public float offset = 10f;
    private Vector3 initialTransform;
    void Start()
    {
        initialTransform = transform.position;
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            transform.LookAt(target);
            if ((transform.position - target.position).magnitude >= offset)
            {
                transform.position -= ((Vector3.one) * speed * Time.deltaTime);
            }

        }
    }

    public void CameraLookAtSet(Transform targetTransform)
    {
        target = targetTransform;
        transform.position = initialTransform;
    }
}
