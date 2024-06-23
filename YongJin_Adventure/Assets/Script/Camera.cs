using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3
        (target.position.x, target.position.y,
        transform.position.z);

        transform.position = Vector3.Lerp
        (transform.position,
        targetPosition, smoothing * Time.deltaTime);
    }
}
